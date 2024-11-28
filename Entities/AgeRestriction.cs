namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Age restriction.
    /// </summary>
    public abstract class AgeRestriction : CreatedByOperatorBase
    {
        /// <summary>
        /// Age from.
        /// </summary>
        public int AgeFrom { get; init; }

        /// <summary>
        /// Age to.
        /// </summary>
        public int AgeTo { get; init; }

        /// <summary>
        /// Day minute from.
        /// </summary>
        public int? DayMinuteFrom { get; set; }

        /// <summary>
        /// Day minute to.
        /// </summary>
        public int? DayMinuteTo { get; set; }
    }
}
