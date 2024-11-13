namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount branch entity.
    /// </summary>
    public sealed class DiscountBranch : IBranchedEntity
    {
        /// <summary>
        /// Discount id.
        /// </summary>
        public int DiscountId { get; set; }

        /// <summary>
        /// Branch Id.
        /// </summary>
        public int BranchId { get; set; }

        /// <summary>
        /// Gets discount.
        /// </summary>
        public Discount Discount { get; set; }

        /// <summary>
        /// Indicates that Discount is enabled for the Branch.
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets branch.
        /// </summary>
        public Branch Branch { get; private set; }
    }
}
