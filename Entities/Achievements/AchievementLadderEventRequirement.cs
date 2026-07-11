namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Per-achievement snapshot of an achievement ladder event — what was required and
    /// what the user actually produced within the ladder period.
    /// </summary>
    /// <remarks>
    /// One row per achievement of the evaluated level, including unmet ones — a demotion
    /// event carries the exact shortfall ("completed 2 of 3 required weeks, produced 41 of
    /// the 100 target"). Met/unmet is derivable (<see cref="AchievementRequirementSnapshot.CompletedCount"/>
    /// vs <see cref="AchievementRequirementSnapshot.RequiredCount"/>). In
    /// <see cref="AchievementLadderMode.Points"/> mode required count is zero (achievements
    /// contribute points instead of being required); in
    /// <see cref="AchievementLadderMode.Requirements"/> mode <see cref="PointsAwarded"/> is zero.
    /// </remarks>
    public sealed class AchievementLadderEventRequirement : AchievementRequirementSnapshot
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementLadderEventRequirement()
        {
        }

        /// <summary>
        /// Gets or sets event id.
        /// </summary>
        public int EventId { get; set; }

        /// <summary>
        /// Gets or sets the points the achievement contributed to the period score.
        /// Zero in <see cref="AchievementLadderMode.Requirements"/> mode.
        /// </summary>
        public int PointsAwarded { get; set; }

        /// <summary>
        /// Gets or sets event.
        /// </summary>
        public AchievementLadderEvent Event { get; set; }
    }
}
