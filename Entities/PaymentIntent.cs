#nullable enable

using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Payment intent base entity. 
    /// </summary>
    public class PaymentIntent : ModifiableByUserCreatedByUserBase, IReplicatable, IBranchedOptionalEntity
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public PaymentIntent() : base()
        {
            Guid = Guid.NewGuid();
        }
        #endregion

        #region FIELDS
        [NonSerialized()]
        private Branch? _branch;
        [NonSerialized()]
        private Payment? _payment;
        [NonSerialized()]
        private int? _paymentId;
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets target user id.
        /// </summary>
        public int UserId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets payment method id.
        /// </summary>
        public int PaymentMethodId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets payment intent amount.
        /// </summary>
        public decimal Amount
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets intent state.
        /// </summary>
        public PaymentIntentState State
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets transaction id.
        /// </summary>
        public string? TransactionId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets transaction time.
        /// </summary>
        public DateTime? TransactionTime
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets unique id.
        /// </summary>
        public Guid Guid
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets payment intent provider.
        /// </summary>
        public Guid Provider
        {
            get; set;
        }

        /// <inheritdoc/>
        public int? BranchId
        {
            get;
            set;
        }

        /// <summary>
        /// Payment URL.
        /// </summary>
        public string? PaymentUrl
        {
            get; set;
        }

        /// <summary>
        /// Intent expiration.
        /// </summary>
        public int? Expiration { get; set; }

        /// <summary>
        /// Gets or sets intent expiration date/time.
        /// </summary>
        public DateTime? ExpireAt
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets payment id.
        /// </summary>
        public int? PaymentId
        {
            get { return _paymentId; }
            set { _paymentId = value; }
        }

        /// <summary>
        /// Gets or sets disable receipt printing.
        /// </summary>
        public bool DisableReceiptPrinting { get; set; }

        /// <summary>
        /// Companion id.
        /// </summary>
        /// <remarks>
        /// This value identifies the companion id that payment intent was created on.
        /// </remarks>
        public int? CompanionId
        {
            get; set;
        }

        /// <summary>
        /// Device number.
        /// </summary>
        /// <remarks>
        /// This value indicates the terminal device number that payment intent was created on.
        /// </remarks>
        public int? TerminalNumber
        {
            get; set;
        }

        /// <summary>
        /// Register id.
        /// </summary>
        /// <remarks>
        /// The register the intent was created on. Pinned at creation for operator initiated intents so the
        /// processing pass can attribute the resulting payment/invoice to the same register without re-deriving
        /// it from the operator's current context. Null for user initiated (self service) intents.
        /// </remarks>
        public int? RegisterId
        {
            get; set;
        }

        /// <summary>
        /// Shift id.
        /// </summary>
        /// <remarks>
        /// The operator shift active on <see cref="RegisterId"/> at creation time, if any. Null for user initiated
        /// intents and for operators without an active shift.
        /// </remarks>
        public int? ShiftId
        {
            get; set;
        }

        /// <summary>
        /// Qr display device number.
        /// </summary>
        /// <remarks>
        /// The customer display that showed the payment qr code, pinned so the processing pass clears the device it
        /// was actually shown on rather than whichever one the register points at by then. Null when no qr code was
        /// displayed, which is every intent except a synchronous payment provider one.
        /// </remarks>
        public int? QrDisplayNumber
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

#nullable disable

        /// <summary>
        /// Gets or set target user.
        /// </summary>
        public virtual UserMember User
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets payment method.
        /// </summary>
        public virtual PaymentMethod PaymentMethod
        {
            get; set;
        }

#nullable enable

        /// <inheritdoc/>
        public Branch? Branch
        {
            get { return _branch; }
            set { _branch = value; }
        }

        /// <summary>
        /// Gets payment.
        /// </summary>
        public virtual Payment? Payment
        {
            get { return _payment; }
            set { _payment = value; }
        }

        /// <summary>
        /// Gets or set companion.
        /// </summary>
        public Companion? Companion
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register.
        /// </summary>
        public Register? Register
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets shift.
        /// </summary>
        public Shift? Shift
        {
            get; set;
        }

        #endregion
    }
}
