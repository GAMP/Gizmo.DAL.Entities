namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Deposit payment intent.
    /// </summary>
    public class PaymentIntentDeposit : PaymentIntent
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public PaymentIntentDeposit() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets deposit payment id.
        /// </summary>
        public int? DepositPaymentId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets associated deposit payment.
        /// </summary>
        public virtual DepositPayment DepositPayment
        {
            get; set;
        }

        #endregion
    }
}
