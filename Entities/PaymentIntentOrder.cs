namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Order payment intent.
    /// </summary>
    public class PaymentIntentOrder : PaymentIntent
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public PaymentIntentOrder() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets product order id.
        /// </summary>
        public int ProductOrderId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets invoice payment id.
        /// </summary>
        public int? InvoicePaymentId
        {
            get;set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets associated product order.
        /// </summary>
        public virtual ProductOrder ProductOrder
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets associated invoice payment.
        /// </summary>
        public virtual InvoicePayment InvoicePayment
        {
            get;set;
        }

        #endregion
    }
}
