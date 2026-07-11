namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Snapshot of points granted by an achievement challenge completion.
    /// </summary>
    public sealed class AchievementChallengeCompletionPointsReward : AchievementChallengeCompletionReward
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementChallengeCompletionPointsReward()
        {
        }

        /// <summary>
        /// Gets or sets the granted points amount.
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Gets or sets the points transaction the grant produced.
        /// Null while the grant is pending.
        /// </summary>
        public int? PointTransactionId { get; set; }

        /// <summary>
        /// Gets or sets points transaction.
        /// </summary>
        public PointTransaction PointTransaction { get; set; }
    }
}
