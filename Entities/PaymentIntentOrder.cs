namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Order payment intent.
    /// </summary>
    public class PaymentIntentOrder : PaymentIntent
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public PaymentIntentOrder() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets product order id.
        /// </summary>
        public int ProductOrderId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets associated product order.
        /// </summary>
        public virtual GizmoDALV2.Entities.ProductOrder ProductOrder
        {
            get; set;
        }

        #endregion
    }
}
