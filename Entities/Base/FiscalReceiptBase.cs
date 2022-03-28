namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Fiscal receipt relation base.
    /// </summary>
    public abstract class FiscalReceiptBase : GizmoDALV2.Entities.EntityWithShift
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public FiscalReceiptBase() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets fiscal receipt id.
        /// </summary>
        public int FiscalReceiptId
        {
            get; set;
        }
        
        #endregion

        #region NAVIGATION PROPERTIES
        
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
