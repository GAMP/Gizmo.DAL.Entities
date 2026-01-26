using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// License reservation types.
    /// </summary>
    [Flags]
    public enum LicenseReservationType
    {
        /// <summary>
        /// First available.
        /// </summary>
        FirstAvailable = 0,

        /// <summary>
        /// One from each.
        /// </summary>
        OneFromEach = 1,
    }
}
