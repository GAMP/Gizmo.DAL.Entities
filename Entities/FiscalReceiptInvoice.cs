namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Fiscal receipt invoice relation entity.
    /// </summary>
    public class FiscalReceiptInvoice
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public FiscalReceiptInvoice() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets invoice id.
        /// </summary>
        public int InvoiceId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES
        
        /// <summary>
        /// Gets or sets invoice.
        /// </summary>
        public virtual GizmoDALV2.Entities.Invoice Invoice
        {
            get;
            set;
        } 

        #endregion
    }
}
