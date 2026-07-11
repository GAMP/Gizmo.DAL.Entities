using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Achievement ladder entity — maps accumulated achievement score to user group levels.
    /// </summary>
    /// <remarks>
    /// One ladder may be enabled at a time (application enforced). Progress accumulates
    /// within the current calendar <see cref="Period"/>: users are promoted immediately
    /// when a higher level becomes satisfied (up only), and settle to whatever the
    /// completed period earned at the period boundary — the only place demotion happens.
    /// <see cref="Mode"/> selects how levels are satisfied: accumulated points against
    /// level thresholds, or per-level required achievements. Period boundaries and
    /// evaluation clocks resolve through the operation's time zone configuration; the
    /// ladder stores no time zone of its own.
    /// </remarks>
    public sealed class AchievementLadder : ModifiableByOperatorBase, IDeletable
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementLadder()
        {
            Levels = new HashSet<AchievementLadderLevel>();
            Achievements = new HashSet<AchievementLadderEntry>();
        }

        /// <summary>
        /// Gets or sets the calendar period progress accumulates within.
        /// <see cref="CalendarPeriod.Week"/> through <see cref="CalendarPeriod.Year"/>.
        /// </summary>
        public CalendarPeriod Period { get; set; }

        /// <summary>
        /// Gets or sets the scoring mode.
        /// <see cref="AchievementLadderMode.Points"/> uses <see cref="Achievements"/> entries
        /// and level thresholds; <see cref="AchievementLadderMode.Requirements"/> uses each
        /// level's required achievements.
        /// </summary>
        public AchievementLadderMode Mode { get; set; }

        /// <summary>
        /// Gets or sets option flags.
        /// </summary>
        public AchievementLadderOptionType Options { get; set; }

        /// <summary>
        /// Gets or sets if the ladder is enabled.
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <inheritdoc/>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets ladder levels — ordered score thresholds mapping to user groups.
        /// </summary>
        public ISet<AchievementLadderLevel> Levels { get; set; }

        /// <summary>
        /// Gets achievements participating in the ladder with their point awards.
        /// Used in <see cref="AchievementLadderMode.Points"/> mode.
        /// </summary>
        public ISet<AchievementLadderEntry> Achievements { get; set; }
    }
}
