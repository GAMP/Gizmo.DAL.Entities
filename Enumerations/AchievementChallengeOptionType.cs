using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Achievement challenge option flags.
    /// </summary>
    [Flags]
    public enum AchievementChallengeOptionType
    {
        /// <summary>
        /// No options set.
        /// </summary>
        None = 0,

        /// <summary>
        /// The challenge is not displayed to end users in client interfaces.
        /// Presentation only — a hidden challenge still evaluates and grants.
        /// </summary>
        Hidden = 1,
    }
}
