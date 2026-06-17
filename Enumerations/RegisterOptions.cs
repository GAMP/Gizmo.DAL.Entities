using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Register options.
    /// </summary>
    [Flags()]
    public enum RegisterOptions
    {
        /// <summary>
        /// None option.
        /// </summary>
        None,

        /// <summary>
        /// Indicates default branch register.
        /// </summary>
        Default = 1,

        /// <summary>
        /// Indicates global default branch register.
        /// </summary>
        GlobalDefault = 2,
    }
}
