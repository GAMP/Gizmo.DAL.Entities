namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// What triggered an achievement ladder level transition.
    /// </summary>
    public enum AchievementLadderEventTrigger
    {
        /// <summary>
        /// Live evaluation after a scoring event (promotions only).
        /// </summary>
        Live = 0,

        /// <summary>
        /// Period boundary settle — the authoritative evaluation of the completed period.
        /// </summary>
        Settle = 1,

        /// <summary>
        /// Operator-initiated re-evaluation.
        /// </summary>
        Operator = 2,
    }
}
