namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Per-achievement snapshot of an achievement challenge completion — what was required
    /// and what the user actually produced within the challenge window.
    /// </summary>
    /// <remarks>
    /// One row per challenge requirement; all rows are met by definition — a completion only
    /// exists once every requirement passed. The snapshot preserves the terms the prize was
    /// granted under against later configuration edits.
    /// </remarks>
    public sealed class AchievementChallengeCompletionRequirement : AchievementRequirementSnapshot
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementChallengeCompletionRequirement()
        {
        }

        /// <summary>
        /// Gets or sets completion id.
        /// </summary>
        public int CompletionId { get; set; }

        /// <summary>
        /// Gets or sets completion.
        /// </summary>
        public AchievementChallengeCompletion Completion { get; set; }
    }
}
