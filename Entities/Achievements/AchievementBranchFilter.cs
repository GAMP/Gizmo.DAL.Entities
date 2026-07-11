namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Achievement filter counting only activity attributed to the specified branch.
    /// </summary>
    public sealed class AchievementBranchFilter : AchievementFilter
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementBranchFilter()
        {
        }

        /// <summary>
        /// Gets or sets branch id.
        /// </summary>
        public int BranchId { get; set; }

        /// <summary>
        /// Gets or sets branch.
        /// </summary>
        public Branch Branch { get; set; }
    }
}
