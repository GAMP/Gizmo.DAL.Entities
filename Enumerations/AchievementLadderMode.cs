namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Scoring mode of an achievement ladder.
    /// </summary>
    public enum AchievementLadderMode
    {
        /// <summary>
        /// Levels are reached by accumulating points: ladder entries award points per
        /// achievement completion, levels are score thresholds.
        /// </summary>
        Points = 0,

        /// <summary>
        /// Levels are reached by completing their required achievements: each level lists
        /// the achievements (and completion counts) it demands, the highest satisfied
        /// level wins.
        /// </summary>
        Requirements = 1,
    }
}
