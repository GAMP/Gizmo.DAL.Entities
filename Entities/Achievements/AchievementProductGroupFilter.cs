namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Achievement filter counting only activity involving products of the specified product group.
    /// </summary>
    public sealed class AchievementProductGroupFilter : AchievementFilter
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementProductGroupFilter()
        {
        }

        /// <summary>
        /// Gets or sets product group id.
        /// </summary>
        public int ProductGroupId { get; set; }

        /// <summary>
        /// Gets or sets product group.
        /// </summary>
        public ProductGroup ProductGroup { get; set; }
    }
}
