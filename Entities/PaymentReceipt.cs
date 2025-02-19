#nullable enable

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Payment receipt entity.
    /// </summary>
    public sealed class PaymentReceipt : EntityWithShift
    {
        /// <summary>
        /// Gets or sets RRN (Retrieval Reference Number). 
        /// </summary>
        public string? RRN
        {
            get;init;
        }

        /// <summary>
        /// Gets or sets payment.
        /// </summary>
        public Payment Payment
        {
            get; set;
        } = null!;
    }
}
