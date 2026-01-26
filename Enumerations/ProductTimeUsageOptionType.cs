using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Product time usage options.
    /// </summary>
    [Flags()]
    public enum ProductTimeUsageOptionType
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Maximum usage.
        /// </summary>
        HasMaximumUsage = 1,

        /// <summary>
        /// Maximum daily usage.
        /// </summary>
        HasMaximumDailyUsage = 2,

        /// <summary>
        /// Reservation.
        /// </summary>
        /// <remarks>
        /// Indicates that product can be used for reservations.
        /// </remarks>
        Reservation = 4,
    }
}
