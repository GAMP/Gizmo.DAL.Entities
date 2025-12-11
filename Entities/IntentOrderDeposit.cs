#nullable enable

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Payment intent order deposit.
    /// </summary>
    public sealed class IntentOrderDeposit : ModifiableByUserCreatedByUserBase
    {
        /// <summary>
        /// Payment intent order id.
        /// </summary>
        public int PaymentIntentOrderId { get; set; }

        /// <summary>
        /// User id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets deposit amount.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets deposit payment id.
        /// </summary>
        public int? DepositPaymentId { get; set; }

        /// <summary>
        /// Gets payment intent order.
        /// </summary>
        public PaymentIntentOrder PaymentIntentOrder { get; set; } = null!;

        /// <summary>
        /// Gets payment intent user.
        /// </summary>
        public UserMember User { get; set; } = null!;

        /// <summary>
        /// Deposit payment.
        /// </summary>
        public DepositPayment? DepositPayment { get; set; } = null;
    }
}
