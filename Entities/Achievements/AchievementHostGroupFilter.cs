namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Achievement filter counting only activity on hosts of the specified host group.
    /// </summary>
    public sealed class AchievementHostGroupFilter : AchievementFilter
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementHostGroupFilter()
        {
        }

        /// <summary>
        /// Gets or sets host group id.
        /// </summary>
        public int HostGroupId { get; set; }

        /// <summary>
        /// Gets or sets host group.
        /// </summary>
        public HostGroup HostGroup { get; set; }
    }
}
