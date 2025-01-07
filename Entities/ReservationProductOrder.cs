namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Reservation order entity.
    /// </summary>
    public sealed class ReservationProductOrder : CreatedByOperatorBase
    {
        /// <summary>
        /// Gets or sets order id.
        /// </summary>
        public int ProductOrderId { get; set; }

        /// <summary>
        /// Gets or sets reservation id.
        /// </summary>
        public int ReservationId { get; set; }

        /// <summary>
        /// Gets or sets reservation.
        /// </summary>
        public Reservation Reservation { get; set; }

        /// <summary>
        /// Gets or sets product order.
        /// </summary>
        public ProductOrder ProductOrder { get; set; }
    }
}
