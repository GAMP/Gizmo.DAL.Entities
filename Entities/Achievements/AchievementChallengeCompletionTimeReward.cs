namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Snapshot of time credited by an achievement challenge completion.
    /// </summary>
    public sealed class AchievementChallengeCompletionTimeReward : AchievementChallengeCompletionReward
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementChallengeCompletionTimeReward()
        {
        }

        /// <summary>
        /// Gets or sets the credited time amount in seconds.
        /// </summary>
        public int Seconds { get; set; }
    }
}
