using System;
using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// A user's level transition on an achievement ladder.
    /// </summary>
    /// <remarks>
    /// Written by the evaluation engine for transitions only — settle confirmations that
    /// keep the user at their level produce no event ("held Gold for six periods" is
    /// derivable from the gaps). Events are self-contained snapshots: values that live
    /// configuration could later change (ranks, requirement numbers) are copied in, never
    /// resolved from config at read time. Kept forever. Manual operator group moves outside
    /// the ladder are recorded by the general user audit, not here.
    /// </remarks>
    public sealed class AchievementLadderEvent : EntityBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementLadderEvent()
        {
            Requirements = new HashSet<AchievementLadderEventRequirement>();
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
        /// Gets or sets the user group the user moved from.
        /// </summary>
        public int FromUserGroupId { get; set; }

        /// <summary>
        /// Gets or sets the user group the user moved to.
        /// </summary>
        public int ToUserGroupId { get; set; }

        /// <summary>
        /// Gets or sets the ladder rank the user moved from, as it was at event time.
        /// Denormalized — levels can be restructured or deleted after the fact.
        /// </summary>
        public int FromRank { get; set; }

        /// <summary>
        /// Gets or sets the ladder rank the user moved to, as it was at event time.
        /// </summary>
        public int ToRank { get; set; }

        /// <summary>
        /// Gets or sets what triggered the transition.
        /// Direction is derivable from the ranks.
        /// </summary>
        public AchievementLadderEventTrigger Trigger { get; set; }

        /// <summary>
        /// Gets or sets the UTC start of the ladder period whose activity caused the
        /// transition — the completed period for settles, the current period for live
        /// promotions.
        /// </summary>
        public DateTime PeriodStart { get; set; }

        /// <summary>
        /// Gets or sets the user's period score at event time.
        /// Used in <see cref="AchievementLadderMode.Points"/> mode; null in requirements mode.
        /// </summary>
        public int? Score { get; set; }

        /// <summary>
        /// Gets or sets the UTC event time.
        /// </summary>
        public DateTime CreatedTime { get; set; }

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public UserMember User { get; set; }

        /// <summary>
        /// Gets or sets ladder.
        /// </summary>
        public AchievementLadder Ladder { get; set; }

        /// <summary>
        /// Gets or sets the user group moved from.
        /// </summary>
        public UserGroup FromUserGroup { get; set; }

        /// <summary>
        /// Gets or sets the user group moved to.
        /// </summary>
        public UserGroup ToUserGroup { get; set; }

        /// <summary>
        /// Gets the per-achievement snapshot rows explaining the transition.
        /// </summary>
        public ISet<AchievementLadderEventRequirement> Requirements { get; set; }
    }
}
