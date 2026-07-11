namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// A single custom signal parameter value of an achievement.
    /// </summary>
    /// <remarks>
    /// Keys and values follow the parameter metadata declared by the achievement's signal
    /// provider; validation happens at configuration time against that metadata. Values are
    /// stored as strings and interpreted only by the providing signal.
    /// </remarks>
    public sealed class AchievementParameter : CreatedByOperatorBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementParameter()
        {
        }

        /// <summary>
        /// Gets or sets achievement id.
        /// </summary>
        public int AchievementId { get; set; }

        /// <summary>
        /// Gets or sets parameter key (e.g. <c>game.wins</c>).
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets parameter value.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets achievement.
        /// </summary>
        public Achievement Achievement { get; set; }
    }
}
