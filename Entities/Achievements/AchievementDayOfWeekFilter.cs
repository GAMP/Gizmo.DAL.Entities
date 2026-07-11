using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Achievement filter counting only activity within a day-anchored window.
    /// </summary>
    /// <remarks>
    /// A row is a day of week, optionally narrowed to a time-of-day window. A null window
    /// means the entire day; both bounds are required together (application validated). A
    /// window whose start is later than its end extends past midnight into the next calendar
    /// day and is still attributed to <see cref="Day"/> — "(Friday, 22:00–06:00)" is Friday
    /// night including Saturday's early hours. Multiple rows may share a day to express
    /// multiple windows within it. Rows combine as ANY-of and are evaluated in the
    /// operation's configured time zone.
    /// </remarks>
    public sealed class AchievementDayOfWeekFilter : AchievementFilter
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementDayOfWeekFilter()
        {
        }

        /// <summary>
        /// Gets or sets the day of week the window is anchored to.
        /// </summary>
        public DayOfWeek Day { get; set; }

        /// <summary>
        /// Gets or sets optional window start time of day.
        /// </summary>
        public TimeOnly? DayTimeFrom { get; set; }

        /// <summary>
        /// Gets or sets optional window end time of day.
        /// </summary>
        public TimeOnly? DayTimeTo { get; set; }
    }
}
