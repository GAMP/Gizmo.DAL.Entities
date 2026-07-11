namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Base per-achievement requirement snapshot — what was required and what the user
    /// actually produced, copied at the time the owning record was written.
    /// </summary>
    /// <remarks>
    /// Mapped table-per-type: the concrete subtype carries the owning record's foreign key
    /// and defines the evaluation window the values were measured over.
    /// Snapshots are self-contained — values live configuration could later change are
    /// copied in, never resolved from config at read time. <see cref="ActualValue"/> sums
    /// one achievement's signal production over its own range instances within the owning
    /// window — rows are never aggregated across achievements.
    /// </remarks>
    public abstract class AchievementRequirementSnapshot : EntityBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        protected AchievementRequirementSnapshot()
        {
        }

        /// <summary>
        /// Gets or sets achievement id.
        /// </summary>
        public int AchievementId { get; set; }

        /// <summary>
        /// Gets or sets the completions demanded at snapshot time.
        /// </summary>
        public int RequiredCount { get; set; }

        /// <summary>
        /// Gets or sets the completions the user produced within the owning window.
        /// </summary>
        public int CompletedCount { get; set; }

        /// <summary>
        /// Gets or sets the achievement's target value at snapshot time, in the signal's
        /// native unit, per range instance.
        /// </summary>
        public decimal TargetValue { get; set; }

        /// <summary>
        /// Gets or sets the signal value the user produced across the achievement's range
        /// instances within the owning window, in the signal's native unit.
        /// </summary>
        public decimal ActualValue { get; set; }

        /// <summary>
        /// Gets or sets achievement.
        /// </summary>
        public Achievement Achievement { get; set; }
    }
}
