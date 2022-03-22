using GizmoDALV2.Entities;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Fiscal receipt entity.
    /// </summary>
    public class FiscalReceipt
    {
        /// <summary>
        /// Gets or sets associated invoice id.
        /// </summary>
        public int InvoiceId
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets receipt status.
        /// </summary>
        public int Status
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets document id.
        /// </summary>
        public int DocumentId
        {
            get;set;
        }

        /// <summary>
        /// Gets or sets signature.
        /// </summary>
        public string Signature
        {
            get;set;
        }

        #region VIRTUAL PROPERTIES

        /// <summary>
        /// Gets or sets associated invocie.
        /// </summary>
        public virtual Invoice Invoice
        {
            get;
            set;
        }


        #endregion
    }
}
