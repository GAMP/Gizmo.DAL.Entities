namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Product Branch relationship.
    /// </summary>
    public class ProductBranch : IBranchedEntity
    {
        /// <summary>
        /// Product Id.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Branch Id.
        /// </summary>
        public int BranchId { get; set; }

        /// <summary>
        /// Indicates that Product is enabled for the Branch.
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Product.
        /// </summary>
        public virtual ProductBase Product { get; protected set; }

        /// <summary>
        /// Branch.
        /// </summary>
        public virtual Branch Branch { get; protected set; }

    }
}
