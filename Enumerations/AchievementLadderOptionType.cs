using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Achievement ladder option flags.
    /// </summary>
    [Flags]
    public enum AchievementLadderOptionType
    {
        /// <summary>
        /// No options set.
        /// </summary>
        None = 0,

        /// <summary>
        /// Promotions are applied only at the period boundary settle instead of instantly —
        /// "earn this season, enjoy next season": a period's activity decides the level held
        /// through the following period. The settle is direction-neutral by design, so this
        /// flag merely disables the live promotion trigger; no separate evaluation mode
        /// exists. Opt-in — instant promotion is the engagement default.
        /// </summary>
        PromoteOnSettleOnly = 1,
    }
}
