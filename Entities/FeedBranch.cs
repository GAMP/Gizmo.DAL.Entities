namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Feed Branch relationship.
    /// </summary>
    public class FeedBranch : IBranchedEntity
    {
        /// <summary>
        /// AppExe Id.
        /// </summary>
        public int FeedId { get; set; }

        /// <summary>
        /// Branch Id.
        /// </summary>
        public int BranchId { get; set; }

        /// <summary>
        /// AppExe.
        /// </summary>
        public Feed Feed { get; set; }

        /// <summary>
        /// Indicates that Feed is enabled for the Branch.
        /// </summary>
        public bool IsEnabled { get; protected set; }

        /// <summary>
        /// Branch.
        /// </summary>
        public Branch Branch { get; protected set; }
    }
}
