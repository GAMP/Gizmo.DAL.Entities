namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Base achievement filter entity — restricts which activity counts towards an achievement.
    /// </summary>
    /// <remarks>
    /// Mapped table-per-type: one row per filtered value, the concrete subtype determines
    /// what is filtered. Same-value duplicates within one achievement are application
    /// validated — the achievement id and the filtered value live in different tables,
    /// so no composite database unique constraint can express it. Values of the same subtype combine as ANY-of, different
    /// subtypes must all hold — matching signal query semantics. Delete behavior of subtype
    /// foreign keys should restrict rather than cascade: silently removing the last value of
    /// an ANY-of set would invert the filter's meaning from "only these" to "everywhere".
    /// </remarks>
    public abstract class AchievementFilter : CreatedByOperatorBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        protected AchievementFilter()
        {
        }

        /// <summary>
        /// Gets or sets achievement id.
        /// </summary>
        public int AchievementId { get; set; }

        /// <summary>
        /// Gets or sets achievement.
        /// </summary>
        public Achievement Achievement { get; set; }
    }
}
