namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Payment intent order - order.
    /// </summary>
    public sealed class IntentOrder : ModifiableByUserCreatedByUserBase
    {
        /// <summary>
        /// Payment intent order id.
        /// </summary>
        public int PaymentIntentOrderId { get; set; }

        /// <summary>
        /// Gets order id.
        /// </summary>
        public int ProductOrderId { get; set; }

        /// <summary>
        /// Order payment amount.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets invoice payment id.
        /// </summary>
        public int? InvoicePaymentId
        {
            get; set;
        }

        /// <summary>
        /// Gets payment intent order.
        /// </summary>
        public PaymentIntentOrder PaymentIntentOrder { get; set; }

        /// <summary>
        /// Gets product order.
        /// </summary>
        public ProductOrder ProductOrder { get; set; }

        /// <summary>
        /// Gets or sets associated invoice payment.
        /// </summary>
        public InvoicePayment InvoicePayment
        {
            get; set;
        }
    }
}
