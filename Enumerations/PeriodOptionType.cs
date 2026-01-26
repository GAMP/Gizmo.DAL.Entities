using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Period options.
    /// </summary>
    [Flags()]
    public enum PeriodOptionType
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Has day time range.
        /// </summary>
        HasDayTimeRange = 1,

        /// <summary>
        /// Has date range.
        /// </summary>
        HasDateRange = 2,
    }
}
