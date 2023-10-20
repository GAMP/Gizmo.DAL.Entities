using ProtoBuf;

using SharedLib;

using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Invoice payment entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class InvoicePayment : ModifiableByWithRequiredUserMemberBase, IRefundable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public InvoicePayment() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets payment id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int PaymentId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets invoice id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int InvoiceId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets amount taken from the referenced payment.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public decimal Amount
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets shift id.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int? ShiftId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register id.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public int? RegisterId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets refunded amount.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public decimal RefundedAmount
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets refund status.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public RefundStatus RefundStatus
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets payment.
        /// </summary>
        [ProtoMember(4)]
        public virtual Payment Payment
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets invoice.
        /// </summary>
        public virtual Invoice Invoice
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

        #endregion
    }
}