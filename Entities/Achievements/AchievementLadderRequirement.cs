namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// An achievement required to reach an achievement ladder level.
    /// </summary>
    /// <remarks>
    /// Used in <see cref="AchievementLadderMode.Requirements"/> mode: a level is satisfied
    /// when every requirement's achievement has been completed at least
    /// <see cref="RequiredCount"/> times within the ladder period.
    /// </remarks>
    public sealed class AchievementLadderRequirement : ModifiableByOperatorBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementLadderRequirement()
        {
        }

        /// <summary>
        /// Gets or sets ladder level id.
        /// </summary>
        public int LevelId { get; set; }

        /// <summary>
        /// Gets or sets achievement id.
        /// </summary>
        public int AchievementId { get; set; }

        /// <summary>
        /// Gets or sets the number of completions required within the ladder period.
        /// </summary>
        public int RequiredCount { get; set; } = 1;

        /// <summary>
        /// Gets or sets ladder level.
        /// </summary>
        public AchievementLadderLevel Level { get; set; }

        /// <summary>
        /// Gets or sets achievement.
        /// </summary>
        public Achievement Achievement { get; set; }
    }
}
