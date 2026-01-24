namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Schedule type.
    /// </summary>
    public enum ScheduleType
    {
        /// <summary>
        /// Daily schedule.
        /// </summary>
        Daily = 0,

        /// <summary>
        /// Weekly schedule.
        /// </summary>
        Weekly = 1,
        
        /// <summary>
        /// Monthly schedule.
        /// </summary>
        Monthly = 2,
        
        /// <summary>
        /// Yearly schedule.
        /// </summary>
        Yearly = 3,
        
        /// <summary>
        /// One time schedule.
        /// </summary>
        OneTime = 4
    }
}
