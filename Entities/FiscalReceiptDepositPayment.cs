namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Fiscal receipt deposit payment relation entity.
    /// </summary>
    public class FiscalReceiptDepositPayment : FiscalReceiptBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public FiscalReceiptDepositPayment() : base()
        { } 
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets deposit payment id.
        /// </summary>
        public int DepositPaymentId
        {
            get; set;
        } 

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets deposit payment.
        /// </summary>
        public GizmoDALV2.Entities.DepositPayment DepositPayment
        {
            get;
            set;
        } 

        #endregion
    }
}
