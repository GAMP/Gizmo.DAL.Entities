namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Payment intent invoice - invoice.
    /// </summary>
    public sealed class IntentInvoice : ModifiableByUserCreatedByUserBase
    {
        /// <summary>
        /// Payment intent order id.
        /// </summary>
        public int PaymentIntentOrderId { get; set; }

        /// <summary>
        /// Gets invoice id.
        /// </summary>
        public int InvoiceId { get; set; }

        /// <summary>
        /// Invoice payment amount.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Invoice payment id.
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
        /// Gets associated invoice.
        /// </summary>
        public Invoice Invoice { get; set; }

        /// <summary>
        /// Gets or sets associated invoice payment.
        /// </summary>
        public InvoicePayment InvoicePayment
        {
            get; set;
        }
    }
}
