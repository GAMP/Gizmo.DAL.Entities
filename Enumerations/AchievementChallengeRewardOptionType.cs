using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Achievement challenge reward option flags.
    /// </summary>
    /// <remarks>
    /// Fulfillment mode is derived from the reward type by default: digital rewards
    /// (points, time) grant automatically at completion, product rewards await operator
    /// fulfillment. Flags override the derived default per reward.
    /// </remarks>
    [Flags]
    public enum AchievementChallengeRewardOptionType
    {
        /// <summary>
        /// No options set.
        /// </summary>
        None = 0,

        /// <summary>
        /// Force manual (operator) fulfillment for a reward that would otherwise grant
        /// automatically — the reward waits in the pending claims list like a physical
        /// prize. Redundant on product rewards, which always require fulfillment.
        /// </summary>
        ForceClaim = 1,
    }
}
