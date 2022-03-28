using ProtoBuf;
using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Refund deposit payment entity.
    /// </summary>
    [Serializable()]
    [ProtoContract()]
    public class RefundDepositPayment : GizmoDALV2.Entities.Refund
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets deposit payment id.
        /// </summary>
        [ProtoMember(1)]
        public int DepositPaymentId
        {
            get; set;
        }

        /// <inheritdoc/>
        /// <remarks>
        /// The record pointed by this value will be to the transaction that withdrew the amount from deposits.
        /// </remarks>
        [ProtoMember(2)]
        public override int? DepositTransactionId { get => base.DepositTransactionId; set => base.DepositTransactionId = value; }

        /// <summary>
        /// Points transaction id.
        /// </summary>
        /// <remarks>
        /// This value should never be set since we never refund deposit payment with points.
        /// </remarks>
        [ProtoMember(3)]
        public override int? PointTransactionId { get => base.PointTransactionId; set => base.PointTransactionId = value; }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets deposit payment.
        /// </summary>
        public virtual GizmoDALV2.Entities.DepositPayment DepositPayment
        {
            get;set;
        }

        #endregion
    }
}
