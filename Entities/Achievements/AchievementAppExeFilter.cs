namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Achievement filter counting only activity in the specified application executable.
    /// </summary>
    public sealed class AchievementAppExeFilter : AchievementFilter
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementAppExeFilter()
        {
        }

        /// <summary>
        /// Gets or sets application executable id.
        /// </summary>
        public int AppExeId { get; set; }

        /// <summary>
        /// Gets or sets application executable.
        /// </summary>
        public AppExe AppExe { get; set; }
    }
}
