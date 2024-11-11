namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Promotion discount entity.
    /// </summary>
    /// <remarks>
    /// Promotion that targets single discount.
    /// </remarks>
    public sealed class PromotionDiscount : Promotion
    {
        /// <summary>
        /// Gets or sets discount id.
        /// </summary>
        public int DiscountId { get; set; }

        /// <summary>
        /// Gets or sets discount.
        /// </summary>
        public Discount Discount { get; set; }
    }
}
