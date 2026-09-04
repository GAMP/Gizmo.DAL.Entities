namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Snapshot of a product granted by an achievement challenge completion.
    /// </summary>
    /// <remarks>
    /// One row is one unit: a reward configured for five colas mints five rows, so every unit
    /// is claimed and stocked on its own.
    /// </remarks>
    public sealed class AchievementChallengeCompletionProductReward : AchievementChallengeCompletionReward
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementChallengeCompletionProductReward()
        {
        }

        /// <summary>
        /// Gets or sets granted product id.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the granted quantity — one, since a row is a single unit.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the invoice the grant produced (zero-total prize invoice —
        /// carries the stock movement and fiscal handling).
        /// Null while the grant is pending.
        /// </summary>
        public int? InvoiceId { get; set; }

        /// <summary>
        /// Gets or sets granted product.
        /// </summary>
        public ProductBase Product { get; set; }

        /// <summary>
        /// Gets or sets grant invoice.
        /// </summary>
        public Invoice Invoice { get; set; }
    }
}
