namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Reservation payment status.
    /// </summary>
    public enum ReservationPaymentStatus
    {
        /// <summary>
        /// No order or payment is required—user can use the reservation “as is.”
        /// </summary>
        NotRequired = 0,        

        /// <summary>
        /// Pre-payment threshold has NOT been reached yet.
        /// </summary>
        NotSatisfied = 1,

        /// <summary>
        /// Threshold reached but the reservation is not fully paid yet.
        /// </summary>
        PartiallySatisfied = 2,

        /// <summary>
        /// Pre-payment threshold has been reached and reservation is fully paid.
        /// </summary>
        Satisfied = 3
    }
}
