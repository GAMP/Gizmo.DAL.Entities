using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// News entity options.
    /// </summary>
    [Flags()]
    public enum NewsOptions
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,
        /// <summary>
        /// Custom template.
        /// </summary>
        CustomTemplate = 1,
    }
}
