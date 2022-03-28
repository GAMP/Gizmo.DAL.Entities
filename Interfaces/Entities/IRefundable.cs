using SharedLib;

namespace GizmoDALV2
{
    /// <summary>
    /// Represents an entity that can be refunded.
    /// </summary>
    public interface IRefundable
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets total refunded amount.
        /// </summary>
        decimal RefundedAmount
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets refund status.
        /// </summary>
        RefundStatus RefundStatus
        {
            get; set;
        }

        #endregion
    }
}
