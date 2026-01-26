using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Deployment options.
    /// </summary>
    [Flags()]
    public enum DeployOptionType : int
    {
        /// <summary>
        /// Default option.
        /// </summary>
        None = 0,

        /// <summary>
        /// Marks deployment as ignored from cleanup procedures.
        /// </summary>
        IgnoreCleanup = 1,

        /// <summary>
        /// Indicates that deployment should be done only on repair procedures.
        /// </summary>
        RepairOnly = 2,

        /// <summary>
        /// Indicates direct access to the deployment source.
        /// </summary>
        DirectAccess = 4,

        /// <summary>
        /// Indicates mirroring of destination directory.
        /// </summary>
        Mirror = 8,

        /// <summary>
        /// Indicates inclusion of sub directories.
        /// </summary>
        IncludeSubDirectories = 16,
    }
}
