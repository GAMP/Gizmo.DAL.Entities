namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Promotion branch entity.
    /// </summary>
    public sealed class PromotionBranch : IBranchedEntity
    {
        /// <summary>
        /// Promotion id.
        /// </summary>
        public int PromotionId { get; set; }

        /// <summary>
        /// Branch Id.
        /// </summary>
        public int BranchId { get; set; }

        /// <summary>
        /// Gets promotion.
        /// </summary>
        public Promotion Promotion { get; set; }

        /// <summary>
        /// Indicates that Promotion is enabled for the Branch.
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets branch.
        /// </summary>
        public Branch Branch { get; private set; }
    }
}
