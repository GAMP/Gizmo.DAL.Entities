namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// An achievement required to complete an achievement challenge.
    /// </summary>
    /// <remarks>
    /// The requirement is met when the achievement has been completed at least
    /// <see cref="RequiredCount"/> times within the challenge window. A requirement whose
    /// achievement is disabled stays in force and is judged on already recorded completions —
    /// it never drops out of the set (see <see cref="Achievement.IsDisabled"/>).
    /// </remarks>
    public sealed class AchievementChallengeRequirement : ModifiableByOperatorBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementChallengeRequirement()
        {
        }

        /// <summary>
        /// Gets or sets challenge id.
        /// </summary>
        public int ChallengeId { get; set; }

        /// <summary>
        /// Gets or sets achievement id.
        /// </summary>
        public int AchievementId { get; set; }

        /// <summary>
        /// Gets or sets the number of completions required within the challenge window.
        /// </summary>
        public int RequiredCount { get; set; } = 1;

        /// <summary>
        /// Gets or sets challenge.
        /// </summary>
        public AchievementChallenge Challenge { get; set; }

        /// <summary>
        /// Gets or sets achievement.
        /// </summary>
        public Achievement Achievement { get; set; }
    }
}
