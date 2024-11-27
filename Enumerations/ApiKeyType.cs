namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Api key type.
    /// </summary>
    public enum ApiKeyType
    {
        /// <summary>
        /// Unrestricted.
        /// </summary>
        /// <remarks>
        /// Such api key will have all permissions by default.
        /// </remarks>
        Unrestricted = 0,

        /// <summary>
        /// Restricted.
        /// </summary>
        /// <remarks>
        /// Such api key will have only permissions explicitly granted.
        /// </remarks>
        Restricted = 1
    }
}
