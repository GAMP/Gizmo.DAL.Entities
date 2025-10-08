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
        /// Checks if passes period.
        /// </summary>
        /// <param name="period">Period.</param>
        /// <param name="dateTime">Current date/time.</param>
        /// <returns>Result</returns>
        public static PassPeriodResult PassPeriod(this DAL.Entities.ProductTimePeriod period, DateTime dateTime)
        {
            var times = (period.Days ?? Enumerable.Empty<DAL.Entities.ProductTimePeriodDay>())
                .ToDictionary(
                d => d.Day,
                d => (IReadOnlyList<DayTimeRange>)[.. d.Times.Select(t => new DayTimeRange(t.StartSecond, t.EndSecond))]);
            return PassPeriod(period.Options, dateTime, period.StartDate, period.EndDate, times);
        }

        /// <summary>
        /// Checks if passes period.
        /// </summary>
        /// <param name="period">Period.</param>
        /// <param name="dateTime">Current date/time.</param>
        /// <returns>Result</returns>
        public static PassPeriodResult PassPeriod(this DAL.Entities.ProductPeriod period, DateTime dateTime)
        {
            var times = (period.Days ?? Enumerable.Empty<DAL.Entities.ProductPeriodDay>())
                .ToDictionary(
                d => d.Day,
                d => (IReadOnlyList<DayTimeRange>)[.. d.Times.Select(t => new DayTimeRange(t.StartSecond, t.EndSecond))]);
            return PassPeriod(period.Options, dateTime, period.StartDate, period.EndDate, times);
        }

        static PassPeriodResult PassPeriod(SharedLib.PeriodOptionType options,
            DateTime now,
            DateTime? periodStart,
            DateTime? periodEnd,
            IReadOnlyDictionary<DayOfWeek, IReadOnlyList<DayTimeRange>>? dayTimeRanges = null)
        {
            // Date range check
            if (options.HasFlag(SharedLib.PeriodOptionType.HasDateRange))
            {
                // Must be within [periodStart, periodEnd], when those bounds are present.
                if ((periodStart.HasValue && now < periodStart.Value) ||
                    (periodEnd.HasValue && now > periodEnd.Value))
                {
                    return PassPeriodResult.Date;
                }
            }

            // Day-of-week / time-of-day check
            if (options.HasFlag(SharedLib.PeriodOptionType.HasDayTimeRange))
            {
                var secondOfDay = now.TimeOfDay.TotalSeconds;

                if (dayTimeRanges == null ||
                    !dayTimeRanges.TryGetValue(now.DayOfWeek, out var dayWindows) ||
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
