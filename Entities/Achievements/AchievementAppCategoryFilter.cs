namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Achievement filter counting only activity in applications of the specified category.
    /// </summary>
    public sealed class AchievementAppCategoryFilter : AchievementFilter
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementAppCategoryFilter()
        {
        }

        /// <summary>
        /// Gets or sets app category id.
        /// </summary>
        public int AppCategoryId { get; set; }

        /// <summary>
        /// Gets or sets app category.
        /// </summary>
        public AppCategory AppCategory { get; set; }
    }
}
