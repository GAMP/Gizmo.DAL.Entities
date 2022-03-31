using ProtoBuf;
using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Refund deposit entity.
    /// </summary>
    [Serializable()]
    [ProtoContract()]
    public class RefundDepositPayment : GizmoDALV2.Entities.Refund
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public RefundDepositPayment() : base()
        { } 
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets deposit payment id.
        /// </summary>
        [ProtoMember(1)]
        public int? DepositPaymentId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets (optional) fiscal receipt id.
        /// </summary>
        [ProtoMember(2)]
        public int? FiscalReceiptId
        {
            get;set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets deposit payment.
        /// </summary>
        public virtual GizmoDALV2.Entities.DepositPayment DepositPayment
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets (optional) fiscal receipt.
        /// </summary>
        public virtual FiscalReceipt FiscalReceipt
        {
            get;set;
        }

        #endregion
    }
}
