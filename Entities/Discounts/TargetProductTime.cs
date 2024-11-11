namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount target product time - product time.
    /// </summary>
    public sealed class TargetProductTime : Target
    {
        /// <summary>
        /// Gets or sets product time id.
        /// </summary>
        public int ProductTimeId { get; set; }

        /// <summary>
        /// Gets or sets target group product time id.
        /// </summary>
        public int TargetGroupProductTimeId { get; set; }

        /// <summary>
        /// Gets targeted product time.
        /// </summary>
        public ProductTime ProductTime { get; set; }

        /// <summary>
        /// Gets or sets target group product time.
        /// </summary>
        public TargetGroupProductTime TargetGroupProductTime { get; set; }
    }
}
