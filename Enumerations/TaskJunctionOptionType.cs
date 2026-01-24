using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Task junction options.
    /// </summary>
    [Flags()]
    public enum TaskJunctionOptionType
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Delete destination.
        /// </summary>
        DeleteDestination = 1,
    }
}
