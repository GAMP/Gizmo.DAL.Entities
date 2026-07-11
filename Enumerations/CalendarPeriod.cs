namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Calendar period used by achievement configuration.
    /// </summary>
    /// <remarks>
    /// Periods are half-open local-calendar intervals (e.g. a month is
    /// [1st 00:00, 1st of next month 00:00) in the operation's time zone).
    /// Achievement ranges use <see cref="Day"/> through <see cref="Month"/>;
    /// ladder periods use <see cref="Week"/> through <see cref="Year"/> —
    /// an achievement's range must not exceed its ladder's period (application enforced).
    /// </remarks>
    public enum CalendarPeriod
    {
        /// <summary>
        /// Calendar day.
        /// </summary>
        Day = 0,

        /// <summary>
        /// Calendar week (ISO, Monday start).
        /// </summary>
        Week = 1,

        /// <summary>
        /// Calendar month.
        /// </summary>
        Month = 2,

        /// <summary>
        /// Calendar quarter.
        /// </summary>
        Quarter = 3,

        /// <summary>
        /// Calendar year.
        /// </summary>
        Year = 4,
    }
}
