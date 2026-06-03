#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Gizmo.DAL
{
    /// <summary>
    /// Period entity extensions.
    /// </summary>
    public static class PeriodExtensions
    {
        /// <summary>
        /// Checks if passes period. All period fields (StartDate/EndDate and day-time seconds) are interpreted as branch-local wall-clock.
        /// </summary>
        /// <param name="period">Period.</param>
        /// <param name="branchLocalNow">Current time in the branch's local time zone.</param>
        /// <returns>Result</returns>
        public static PassPeriodResult PassPeriod(this DAL.Entities.ProductTimePeriod? period, DateTime branchLocalNow)
        {
            if (period == null)
                return PassPeriodResult.Success;

            var times = (period.Days ?? Enumerable.Empty<DAL.Entities.ProductTimePeriodDay>())
                .ToDictionary(
                d => d.Day,
                d => (IReadOnlyList<DayTimeRange>)[.. d.Times.Select(t => new DayTimeRange(t.StartSecond, t.EndSecond))]);
            return PassPeriod(period.Options, branchLocalNow, period.StartDate, period.EndDate, times);
        }

        /// <summary>
        /// Checks if passes period. All period fields (StartDate/EndDate and day-time seconds) are interpreted as branch-local wall-clock.
        /// </summary>
        /// <param name="period">Period.</param>
        /// <param name="branchLocalNow">Current time in the branch's local time zone.</param>
        /// <returns>Result</returns>
        public static PassPeriodResult PassPeriod(this DAL.Entities.ProductPeriod? period, DateTime branchLocalNow)
        {
            if (period == null)
                return PassPeriodResult.Success;

            var times = (period.Days ?? Enumerable.Empty<DAL.Entities.ProductPeriodDay>())
                .ToDictionary(
                d => d.Day,
                d => (IReadOnlyList<DayTimeRange>)[.. d.Times.Select(t => new DayTimeRange(t.StartSecond, t.EndSecond))]);
            return PassPeriod(period.Options, branchLocalNow, period.StartDate, period.EndDate, times);
        }

        static PassPeriodResult PassPeriod(DAL.Entities.PeriodOptionType options,
            DateTime branchLocalNow,
            DateTime? periodStart,
            DateTime? periodEnd,
            IReadOnlyDictionary<DayOfWeek, IReadOnlyList<DayTimeRange>>? dayTimeRanges = null)
        {
            // Date range check — branch-local wall-clock.
            if (options.HasFlag(Entities.PeriodOptionType.HasDateRange))
            {
                if ((periodStart.HasValue && branchLocalNow < periodStart.Value) ||
                    (periodEnd.HasValue && branchLocalNow > periodEnd.Value))
                {
                    return PassPeriodResult.Date;
                }
            }

            // Day-of-week / time-of-day check — branch-local wall-clock.
            if (options.HasFlag(Entities.PeriodOptionType.HasDayTimeRange))
            {
                var secondOfDay = branchLocalNow.TimeOfDay.TotalSeconds;

                if (dayTimeRanges == null ||
                    !dayTimeRanges.TryGetValue(branchLocalNow.DayOfWeek, out var dayWindows) ||
                    dayWindows == null ||
                    !dayWindows.Any(w => w.StartSecond <= secondOfDay && secondOfDay <= w.EndSecond))
                {
                    return PassPeriodResult.DateTime;
                }
            }

            return PassPeriodResult.Success;
        }

        readonly struct DayTimeRange
        {
            public DayTimeRange(double startSecond, double endSecond)
            {
                StartSecond = startSecond;
                EndSecond = endSecond;
            }
            public double StartSecond { get; }
            public double EndSecond { get; }
        }

        /// <summary>
        /// Period pass result.
        /// </summary>
        public enum PassPeriodResult
        {
            /// <summary>
            /// Success.
            /// </summary>
            Success,
            /// <summary>
            /// Date range mismatch.
            /// </summary>
            Date,
            /// <summary>
            /// Day time range mismatch.
            /// </summary>
            DateTime,
        }
    }
}
