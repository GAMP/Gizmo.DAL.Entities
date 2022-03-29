namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Invoice fiscal receipt relation type.
    /// </summary>
    public class InvoiceFiscalReceipt : GizmoDALV2.Entities.EntityWithShift
    {
        #region PROPERTIES
        
        /// <summary>
        /// Gets or sets invoice id.
        /// </summary>
        public int InvoiceId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets fiscal receipt id.
        /// </summary>
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
