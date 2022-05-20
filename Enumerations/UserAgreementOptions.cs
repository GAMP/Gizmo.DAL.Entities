using System;

namespace Gizmo.DAL
{
    /// <summary>
    /// User agreement options.
    /// </summary>
    [Flags]
    public enum UserAgreementOptions
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,
        /// <summary>
        /// Agreement can be rejected.
        /// </summary>
        Rejectable = 1,
    }
}
