using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Personal file options.
    /// </summary>
    [Flags()]
    public enum PersonalUserFileOptionType
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Cleanup.
        /// </summary>
        CleanUp = 1,

        /// <summary>
        /// Store.
        /// </summary>
        Store = 2,

        /// <summary>
        /// Include sub directories.
        /// </summary>
        IncludeSubDirectories = 4,
    }
}
