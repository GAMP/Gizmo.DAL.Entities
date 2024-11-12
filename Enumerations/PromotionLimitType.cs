namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Promotion limit types.
    /// </summary>
    public enum PromotionLimitType
    {
        /// <summary>
        /// Total limit.
        /// </summary>
        Total = 0,

        /// <summary>
        /// Per user limit.
        /// </summary>
        PerUser = 1,

        /// <summary>
        /// Daily limit.
        /// </summary>
        Daily = 2,

        /// <summary>
        /// Weekly limit.
        /// </summary>
        Weekly = 3,
    }
}
