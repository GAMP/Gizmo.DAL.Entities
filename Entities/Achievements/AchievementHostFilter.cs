namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Achievement filter counting only activity on the specified host.
    /// </summary>
    public sealed class AchievementHostFilter : AchievementFilter
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementHostFilter()
        {
        }

        /// <summary>
        /// Gets or sets host id.
        /// </summary>
        public int HostId { get; set; }

        /// <summary>
        /// Gets or sets host.
        /// </summary>
        public Host Host { get; set; }
    }
}
