using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Application module type scope enumeration.
    /// </summary>
    [Flags()]
    public enum ModuleScopes
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Client.
        /// </summary>
        Client = 1,

        /// <summary>
        /// Server.
        /// </summary>
        Server = 2,

        /// <summary>
        /// Manager.
        /// </summary>
        Manager = 4,

        /// <summary>
        /// Global.
        /// </summary>
        Global = Client | Server | Manager,
    }
}
