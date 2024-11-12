namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount target base entity.
    /// </summary>
    public abstract class Target : CreatedByOperatorBase
    {
        /// <summary>
        /// Gets or sets discount target group id.
        /// </summary>
        public int TargetGroupId { get; set; }

        /// <summary>
        /// Gets discount target group.
        /// </summary>
        public TargetGroup TargetGroup { get; protected set; }
    }
}
