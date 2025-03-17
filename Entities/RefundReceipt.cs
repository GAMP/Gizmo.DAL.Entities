#nullable enable

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Refund receipt entity.
    /// </summary>
    public sealed class RefundReceipt : EntityWithShift
    {
        /// <summary>
        /// Gets or sets RRN (Retrieval Reference Number). 
        /// </summary>
        public string? RRN
        {
            get; init;
        }

        /// <summary>
        /// Gets or sets refund.
        /// </summary>
        public Refund Refund
        {
            get; set;
        } = null!;
    }
}
