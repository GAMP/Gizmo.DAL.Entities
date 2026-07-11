namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Achievement filter counting only activity involving the specified product.
    /// </summary>
    public sealed class AchievementProductFilter : AchievementFilter
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementProductFilter()
        {
        }

        /// <summary>
        /// Gets or sets product id.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets product.
        /// </summary>
        public ProductBase Product { get; set; }
    }
}
