using ProtoBuf;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Invoice fiscal receipt relation type.
    /// </summary>
    [ProtoContract()]
    public class InvoiceFiscalReceipt : GizmoDALV2.Entities.EntityWithShift
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets invoice id.
        /// </summary>
        [ProtoMember(1)]
        public int InvoiceId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets fiscal receipt id.
        /// </summary>
        [ProtoMember(2)]
        public int FiscalReceiptId
        {
            get; set;
        }

        #endregion

        #region NAVIGATIONAL PROPERTIES

        /// <summary>
        /// Gets or sets invoice.
        /// </summary>
        public virtual GizmoDALV2.Entities.Invoice Invoice
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets fiscal receipt.
        /// </summary>
        public virtual FiscalReceipt FiscalReceipt
        {
            get; set;
        }

        #endregion
    }
}
