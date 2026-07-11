using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Achievement option flags.
    /// </summary>
    [Flags]
    public enum AchievementOptionType
    {
        /// <summary>
        /// No options set.
        /// </summary>
        None = 0,

        /// <summary>
        /// The achievement is not displayed to end users in client interfaces.
        /// Presentation only — a hidden achievement still evaluates, completes and
        /// appears in ladder events; operator interfaces always show it.
        /// </summary>
        Hidden = 1,
    }
}
