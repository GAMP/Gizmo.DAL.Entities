namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// News Branch relationship.
    /// </summary>
    public class NewsBranch : IBranchedEntity
    {
        /// <summary>
        /// News Id.
        /// </summary>
        public int NewsId { get; set; }

        /// <summary>
        /// Branch Id.
        /// </summary>
        public int BranchId { get; set; }

        /// <summary>
        /// AppExe.
        /// </summary>
        public News News { get; set; }

        /// <summary>
        /// Indicates that News is enabled for the Branch.
        /// </summary>
        public bool IsEnabled { get; protected set; }

        /// <summary>
        /// Branch.
        /// </summary>
        public Branch Branch { get; protected set; }
    }
}
