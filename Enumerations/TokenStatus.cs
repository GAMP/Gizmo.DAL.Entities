namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Token status enumeration.
    /// </summary>
    public enum TokenStatus
    {
        /// <summary>
        /// Token unused.
        /// </summary>
        Unused = 0,
        /// <summary>
        /// Token used.
        /// </summary>
        Used = 1,
        /// <summary>
        /// Token revoked.
        /// </summary>
        Revoked = 2,
    }
}
