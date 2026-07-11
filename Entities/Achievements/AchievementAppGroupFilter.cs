namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Achievement filter counting only activity in applications of the specified app group.
    /// </summary>
    public sealed class AchievementAppGroupFilter : AchievementFilter
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementAppGroupFilter()
        {
        }

        /// <summary>
        /// Gets or sets app group id.
        /// </summary>
        public int AppGroupId { get; set; }

        /// <summary>
        /// Gets or sets app group.
        /// </summary>
        public AppGroup AppGroup { get; set; }
    }
}
