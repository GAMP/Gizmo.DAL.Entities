using ProtoBuf;
using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Refund deposit entity.
    /// </summary>
    [Serializable()]
    [ProtoContract()]
    public class RefundDepositPayment : Refund
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
        /// Gets or sets fiscal receipt status.
        /// </summary>
        [ProtoMember(2)]
        public int FiscalReceiptStatus
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets (optional) fiscal receipt id.
        /// </summary>
        [ProtoMember(3)]
        public int? FiscalReceiptId
        {
            get;set;
        }   

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets deposit payment.
        /// </summary>
        public virtual DepositPayment DepositPayment
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
