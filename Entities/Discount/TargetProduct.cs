namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount target product-product entity.
    /// </summary>
    public sealed class TargetProduct : Target
    {
        /// <summary>
        /// Gets or sets target group product id.
        /// </summary>
        public int TargetGroupProductId { get; set; }

        /// <summary>
        /// Gets or sets product id.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets target group product.
        /// </summary>
        public TargetGroupProduct TargetGroupProduct { get; set; }

        /// <summary>
        /// Gets targeted product.
        /// </summary>
        public ProductBaseExtended Product { get; set; }
    }
}
