namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// AppExe Branch relationship.
    /// </summary>
    public class AppExeBranch : IBranchedEntity
    {
        /// <summary>
        /// AppExe Id.
        /// </summary>
        public int AppExeId { get; set; }

        /// <summary>
        /// Branch Id.
        /// </summary>
        public int BranchId { get; set; }

        /// <summary>
        /// AppExe.
        /// </summary>
        public AppExe AppExe { get; set; }

        /// <summary>
        /// Indicates that AppExe is enabled for the Branch.
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Branch.
        /// </summary>
        public Branch Branch { get; protected set; }
    }
}
