using Gizmo.DAL.Entities;
using ProtoBuf;
using SharedLib;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// Deposit payment entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class DepositPayment : ModifiableByWithRequiredUserMemberBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public DepositPayment() : base()
        {
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets deposit transaction id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int DepositTransactionId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets payment id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int PaymentId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets shift id.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int? ShiftId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register id.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int? RegisterId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets refunded amount.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public decimal RefundedAmount
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets refund status.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public RefundStatus RefundStatus
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets fiscal receipt status.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public int FiscalReceiptStatus
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets (optional) fiscal receipt id.
        /// </summary>
        [DataMember()]
        [ProtoMember(9)]
        public int? FiscalReceiptId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if deposit payment is voided.
        /// </summary>
        [DataMember()]
        [ProtoMember(10)]
        public bool IsVoided
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets payment.
        /// </summary>
        [ProtoMember(3)]
        public virtual Payment Payment
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets deposit transaction.
        /// </summary>
        public virtual DepositTransaction DepositTransaction
        {
            get; set;
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

        /// <summary>
        /// Gets or sets voids.
        /// </summary>
        public virtual ISet<VoidDepositPayment> Voids
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets (optional) fiscal receipt.
        /// </summary>
        public virtual FiscalReceipt FiscalReceipt
        {
            get; set;
        }

        #endregion
    }
}