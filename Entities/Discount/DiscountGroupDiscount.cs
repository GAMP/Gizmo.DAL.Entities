namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount group entity.
    /// </summary>
    public sealed class DiscountGroupDiscount
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public DiscountGroupDiscount()
        {
        }

        /// <summary>
        /// Gets or sets discount group id.
        /// </summary>
        public int DiscountGroupId { get; set; }

        /// <summary>
        /// Gets or sets discount id.
        /// </summary>
        public int DiscountId { get; set; }

        /// <summary>
        /// Gets or sets discount.
        /// </summary>
        public Discount Discount { get; set; }

        /// <summary>
        /// Gets or sets discount group.
        /// </summary>
        public DiscountGroup DiscountGroup {get; set;}
    }
}
