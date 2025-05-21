namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount target product group - product group.
    /// </summary>
    public sealed class TargetProductGroup : Target
    {
        /// <summary>
        /// Gets or sets target group product group id.
        /// </summary>
        public int TargetGroupProductGroupId { get; set; }

        /// <summary>
        /// Gets or sets product group id.
        /// </summary>
        public int ProductGroupId { get; set; }

        /// <summary>
        /// Gets target group product.
        /// </summary>
        public TargetGroupProductGroup TargetGroupProductGroup { get; set; }

        /// <summary>
        /// Gets or sets product group.
        /// </summary>
        public ProductGroup ProductGroup { get; set; }
    }
}
