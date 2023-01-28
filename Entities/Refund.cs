using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Refund base entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public abstract class Refund : EntityWithShift
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Refund() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets payment id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int? PaymentId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets amount.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public decimal Amount
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets deposit transaction id.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public virtual int? DepositTransactionId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets point transaction id.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public virtual int? PointTransactionId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets refund payment method id.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int RefundMethodId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets payment.
        /// </summary>
        public virtual Payment Payment
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets deposit transactions.
        /// </summary>
        public virtual DepositTransaction DepositTransaction
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets point transaction id.
        /// </summary>
        public virtual PointTransaction PointTransaction
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets refund payment method.
        /// </summary>
        public virtual PaymentMethod RefundMethod
        {
            get; set;
        }

        #endregion
    }
}