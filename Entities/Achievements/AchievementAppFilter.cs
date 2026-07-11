namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Achievement filter counting only activity in the specified application.
    /// </summary>
    public sealed class AchievementAppFilter : AchievementFilter
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementAppFilter()
        {
        }

        /// <summary>
        /// Gets or sets application id.
        /// </summary>
        public int AppId { get; set; }

        /// <summary>
        /// Gets or sets application.
        /// </summary>
        public App App { get; set; }
    }
}
