namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Base achievement challenge reward entity — what a challenge grants per completion.
    /// </summary>
    /// <remarks>
    /// Mapped table-per-type: the concrete subtype defines the reward's configuration.
    /// A challenge may hold multiple rewards of different types — all are granted together
    /// per completion occurrence.
    /// </remarks>
    public abstract class AchievementChallengeReward : ModifiableByOperatorBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        protected AchievementChallengeReward()
        {
        }

        /// <summary>
        /// Gets or sets challenge id.
        /// </summary>
        public int ChallengeId { get; set; }

        /// <summary>
        /// Gets or sets option flags.
        /// </summary>
        public AchievementChallengeRewardOptionType Options { get; set; }

        /// <summary>
        /// Gets or sets challenge.
        /// </summary>
        public AchievementChallenge Challenge { get; set; }
    }
}
