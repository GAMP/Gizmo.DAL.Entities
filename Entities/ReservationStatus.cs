namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Reservation status.
    /// </summary>
    public enum ReservationStatus
    {
        /// <summary>
        /// Reservation is waiting.
        /// </summary>
        Waiting = 0,

        /// <summary>
        /// Active status.
        /// </summary>
        Active = 2,

        /// <summary>
        /// Reservation is canceled by operator.
        /// </summary>
        Canceled = 1,

        /// <summary>
        /// Expired.
        /// </summary>
        Expired = 3,

        /// <summary>
        /// Completed.
        /// </summary>
        Completed = 4,

        /// <summary>
        /// Released.
        /// </summary>
        Released = 5,

        /// <summary>
        /// Moved.
        /// </summary>
        Moved = 6,
    }
}
