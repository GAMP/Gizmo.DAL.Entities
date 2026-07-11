using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// A user's completion record of an achievement within one range instance.
    /// </summary>
    /// <remarks>
    /// At most one row exists per user, achievement and range instance;
    /// <see cref="Quantity"/> counts completions within the instance (capped by the
    /// achievement's max completions per range). Rows are a rebuildable cache of the
    /// underlying signal facts: the live evaluation path writes them as thresholds are
    /// crossed, and the period-boundary settle recomputes them from facts as the
    /// authoritative pass. Because a rebuild may delete and re-insert rows, nothing may
    /// hold a foreign key to this table — consumers (ladder scoring, challenge evaluation,
    /// event snapshots) read it by the natural key (user, achievement, range start) and
    /// copy any values they need to keep.
    /// </remarks>
    public sealed class AchievementCompletion : EntityBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementCompletion()
        {
        }

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets achievement id.
        /// </summary>
        public int AchievementId { get; set; }

        /// <summary>
        /// Gets or sets the UTC start of the range instance the completion belongs to.
        /// Identifies the instance together with the achievement's range length.
        /// </summary>
        public DateTime RangeStart { get; set; }

        /// <summary>
        /// Gets or sets the UTC time the range instance's first completion was earned — the
        /// moment the target value was first crossed. The row is an accumulator: later
        /// completions within the same instance increment <see cref="Quantity"/> without
        /// changing this value.
        /// </summary>
        public DateTime CompletedTime { get; set; }

        /// <summary>
        /// Gets or sets the number of completions earned within the range instance.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public UserMember User { get; set; }

        /// <summary>
        /// Gets or sets achievement.
        /// </summary>
        public Achievement Achievement { get; set; }
    }
}
