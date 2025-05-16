#nullable enable

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Product order discount.
    /// </summary>
    public sealed class ProductOrderDiscount : EntityWithShift
    {
        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets product order id.
        /// </summary>
        public int ProductOrderId { get; set; }

        /// <summary>
        /// Gets or sets product order line id.
        /// </summary>
        public int? ProductOrderLineId { get; set; }

        /// <summary>
        /// Gets or sets promotion id.
        /// </summary>
        public int? PromotionId { get; set; }

        /// <summary>
        /// Gets or sets promotion code.
        /// </summary>
        public int? PromotionCodeId { get; set; }

        /// <summary>
        /// Gets or sets discount id.
        /// </summary>
        public int DiscountId { get; set; }

        /// <summary>
        /// Gets or sets discount name.
        /// </summary>
        public string DiscountName { get; set; } = null!;

        /// <summary>
        /// Gets or sets discount value type.
        /// </summary>
        public DiscountCalculationType CalculationType { get; set; }

        /// <summary>
        /// Gets or sets discount apply type.
        /// </summary>
        public DiscountApplyType ApplyType { get; set; }

        /// <summary>
        /// Gets or sets discount value.
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// Gets or sets discount amount.
        /// </summary>
        public decimal DiscountAmount { get; set; }

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public UserMember? User { get; set; }

        /// <summary>
        /// Gets or sets product order.
        /// </summary>
        public ProductOrder? ProductOrder
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets product order line.
        /// </summary>
        public ProductOL? ProductOrderLine { get; set; }

        /// <summary>
        /// Gets or sets promotion.
        /// </summary>
        public Promotion? Promotion { get; set; }

        /// <summary>
        /// Gets or sets promotion code.
        /// </summary>
        public PromotionCode? PromotionCode { get; set; }

        /// <summary>
        /// Gets or sets discount.
        /// </summary>
        public Discount? Discount { get; set; }
    }
}
