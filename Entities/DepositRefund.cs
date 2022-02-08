using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Deposit refund entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class DepositRefund : GizmoDALV2.Entities.EntityWithShift
    {
        /// <summary>
        /// Gets or sets deposit transaction id.
        /// </summary>
        public int DepositTransactionId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets payment id.
        /// </summary>
        public int PaymentId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets amount.
        /// </summary>
        public decimal Amount
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets refund method id.
        /// </summary>
        public int RefundMethodId
        {
            get; set;
        }
    }
}
