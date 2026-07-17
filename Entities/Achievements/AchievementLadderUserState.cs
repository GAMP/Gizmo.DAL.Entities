using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Per-user evaluation state of an achievement ladder.
    /// </summary>
    /// <remarks>
    /// Tracks which period was last settled for the user so the settle knows whether the
    /// previous period still needs authoritative evaluation. Keyed per ladder so future
    /// scoped ladders need no schema change. Identified by its composite key
    /// (UserId, LadderId) — one row per user per ladder, nothing references it, so it
    /// carries no surrogate id (link-table convention).
    /// </remarks>
    public sealed class AchievementLadderUserState
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementLadderUserState()
        {
        }

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets ladder id.
        /// </summary>
        public int LadderId { get; set; }

        /// <summary>
        /// Gets or sets the UTC start of the last period settled for the user.
        /// </summary>
        public DateTime LastSettledPeriodStart { get; set; }

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public UserMember User { get; set; }

        /// <summary>
        /// Gets or sets ladder.
        /// </summary>
        public AchievementLadder Ladder { get; set; }
    }
}
