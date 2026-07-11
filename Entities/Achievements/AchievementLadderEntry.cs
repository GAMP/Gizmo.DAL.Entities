namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// An achievement's participation in a ladder — what completing it is worth there.
    /// </summary>
    /// <remarks>
    /// The point award lives on this link, not on the achievement: the achievement defines
    /// the deed, the entry defines its value in this ladder's score.
    /// </remarks>
    public sealed class AchievementLadderEntry : ModifiableByOperatorBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementLadderEntry()
        {
        }

        /// <summary>
        /// Gets or sets ladder id.
        /// </summary>
        public int LadderId { get; set; }

        /// <summary>
        /// Gets or sets achievement id.
        /// </summary>
        public int AchievementId { get; set; }

        /// <summary>
        /// Gets or sets points awarded per completion towards the ladder score.
        /// </summary>
        public int Points { get; set; }

        /// <summary>
        /// Gets or sets if the entry contributes to scoring.
        /// Disabled entries keep their configuration but award nothing.
        /// </summary>
        public bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets ladder.
        /// </summary>
        public AchievementLadder Ladder { get; set; }

        /// <summary>
        /// Gets or sets achievement.
        /// </summary>
        public Achievement Achievement { get; set; }
    }
}
