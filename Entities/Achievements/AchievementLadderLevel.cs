using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// A single level of an achievement ladder mapping to a user group.
    /// </summary>
    /// <remarks>
    /// <see cref="Rank"/> orders levels in both scoring modes; a user's level is the highest
    /// rank they satisfy — via <see cref="Threshold"/> in points mode (thresholds must be
    /// strictly increasing by rank, application validated) or via <see cref="Requirements"/>
    /// in requirements mode (no cumulative-set rule; highest satisfied wins). The user group
    /// carries the level's benefits (discount group etc.); ladder groups should differ only
    /// by intended level perks — the evaluator moves users between them.
    /// </remarks>
    public sealed class AchievementLadderLevel : ModifiableByOperatorBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementLadderLevel()
        {
            Requirements = new HashSet<AchievementLadderRequirement>();
        }

        /// <summary>
        /// Gets or sets ladder id.
        /// </summary>
        public int LadderId { get; set; }

        /// <summary>
        /// Gets or sets the level order within the ladder — higher rank is a higher level.
        /// </summary>
        public int Rank { get; set; }

        /// <summary>
        /// Gets or sets the score required to reach this level.
        /// Used in <see cref="AchievementLadderMode.Points"/> mode only.
        /// </summary>
        public int Threshold { get; set; }

        /// <summary>
        /// Gets or sets the user group users at this level belong to.
        /// </summary>
        public int UserGroupId { get; set; }

        /// <summary>
        /// Gets or sets optional customer-facing level description (marketing copy for the
        /// level's perks). The user group's description is operational and is not shown to
        /// end users.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets optional badge image id. Badge SVGs following the theming convention
        /// (currentColor / theme variables) inherit the client's standardized rank-keyed
        /// accent colors; no color is stored per level.
        /// </summary>
        public int? ImageId { get; set; }

        /// <summary>
        /// Gets or sets ladder.
        /// </summary>
        public AchievementLadder Ladder { get; set; }

        /// <summary>
        /// Gets or sets user group.
        /// </summary>
        public UserGroup UserGroup { get; set; }

        /// <summary>
        /// Gets or sets badge image.
        /// </summary>
        public FileImage Image { get; set; }

        /// <summary>
        /// Gets the achievements required to reach this level.
        /// Used in <see cref="AchievementLadderMode.Requirements"/> mode.
        /// </summary>
        public ISet<AchievementLadderRequirement> Requirements { get; set; }
    }
}
