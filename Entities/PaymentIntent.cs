#nullable enable

using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Payment intent base entity. 
    /// </summary>
    public abstract class PaymentIntent : ModifiableByUserCreatedByUserBase, IReplicatable, IBranchedOptionalEntity
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

        #endregion
    }
}
