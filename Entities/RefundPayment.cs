#nullable enable

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Refund payment entity.
    /// </summary>
    public sealed class RefundPayment : Refund
    {
        /// <summary>
        /// Gets or sets fiscal receipt status.
        /// </summary>
        public int FiscalReceiptStatus
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets (optional) fiscal receipt id.
        /// </summary>
        public int? FiscalReceiptId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets (optional) fiscal receipt.
        /// </summary>
        public FiscalReceipt? FiscalReceipt
        {
            get; set;
        }
    }
}
