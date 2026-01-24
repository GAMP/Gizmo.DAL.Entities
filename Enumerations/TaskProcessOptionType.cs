using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Task process options.
    /// </summary>
    [Flags()]
    public enum TaskProcessOptionType
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,
        /// <summary>
        /// Wait.
        /// </summary>
        Wait = 1,
        /// <summary>
        /// No window.
        /// </summary>
        NoWindow = 2,
    }
}
