namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Promotion code status.
    /// </summary>
    public enum PromotionCodeStatus
    {
        /// <summary>
        /// Promotion code was not used.
        /// </summary>
        Unused = 0,
        
        /// <summary>
        /// Promotion code is used.
        /// </summary>
        Used = 1,

        /// <summary>
        /// Promotion code is depleted.
        /// </summary>
        Depleted = 2,

        /// <summary>
        /// Revoked.
        /// </summary>
        Revoked = 3,
    }
}
