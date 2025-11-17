#nullable enable

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Payment receipt entity.
    /// </summary>
    public sealed class PaymentReceipt : EntityWithShift
    {
        /// <summary>
        /// Payment id.
        /// </summary>
        public int PaymentId { get; set; }

        /// <summary>
        /// Gets or sets receipt type.
        /// </summary>
        public PaymentReceiptType Type { get; set; }

        /// <summary>
        /// Gets or sets RRN (Retrieval Reference Number). 
        /// </summary>
        public string? RRN
        {
            get; init;
        }

        /// <summary>
        /// Fiscal receipt companion id.
        /// </summary>
        /// <remarks>
        /// This value identifies the companion the receipt was printed on.
        /// </remarks>
        public int? CompanionId
        {
            get; set;
        }

        /// <summary>
        /// Device number.
        /// </summary>
        /// <remarks>
        /// This value indicates the terminal device number that payment was accepted on.
        /// </remarks>
        public int? TerminalNumber
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets payment.
        /// </summary>
        public Payment Payment
        {
            get; set;
        } = null!;

        /// <summary>
        /// Gets or set companion.
        /// </summary>
        public Companion? Companion
        {
            get; set;
        }
    }
}
