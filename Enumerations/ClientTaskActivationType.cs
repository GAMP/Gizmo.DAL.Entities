using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Client task activation types.
    /// </summary>
    [Flags()]
    public enum ClientTaskActivationType
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Startup.
        /// </summary>
        Startup = 1,

        /// <summary>
        /// Shut down.
        /// </summary>
        Shutdown = 2,

        /// <summary>
        /// Login.
        /// </summary>
        Login = 4,

        /// <summary>
        /// Logout.
        /// </summary>
        Logout = 8,
    }
}
