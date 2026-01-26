#nullable enable

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using ProtoBuf;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Payment entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class Payment : ModifiableByWithRequiredUserMemberBase, IDeletable, IRefundable, IVoidable, IBranchedOptionalEntity
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new payment instance.
        /// </summary>
        public Payment() : base()
        {
            Receipts = new HashSet<PaymentReceipt>();
        }
        #endregion

        #region FIELDS
        [NonSerialized()]
        private Branch? _branch;
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets payment method id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int PaymentMethodId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets amount.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public decimal Amount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets received amount.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public decimal AmountReceived
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if deleted.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public bool IsDeleted
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if voided.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public bool IsVoided
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets transaction id.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public int? DepositTransactionId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets loyalty transaction id.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public int? PointTransactionId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets shift id.
        /// </summary>
        [DataMember()]
        [ProtoMember(9)]
        public int? ShiftId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register id.
        /// </summary>
        [DataMember()]
        [ProtoMember(10)]
        public int? RegisterId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets refunded amount.
        /// </summary>
        [DataMember()]
        [ProtoMember(11)]
        public decimal RefundedAmount
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets refund status.
        /// </summary>
        [DataMember()]
        [ProtoMember(12)]
        public RefundStatus RefundStatus
        {
            get; set;
        }

        /// <inheritdoc/>
        public int? BranchId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets balance transaction for this payment.
        /// </summary>
        public virtual DepositTransaction DepositTransaction
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets loyalty transaction for this payment.
        /// </summary>
        public virtual PointTransaction PointTransaction
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets payment method.
        /// </summary>
        public virtual PaymentMethod PaymentMethod
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets shift.
        /// </summary>
        public virtual Shift Shift
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register.
        /// </summary>
        public virtual Register Register
        {
            get; set;
        }

        /// <inheritdoc/>
        public Branch? Branch
        {
            get { return _branch; }
            set { _branch = value; }
        }

        /// <summary>
        /// Gets associated receipts.
        /// </summary>
        [ProtoIgnore()]
        public ISet<PaymentReceipt> Receipts
        {
            get; set;
        }

        #endregion
    }
}
