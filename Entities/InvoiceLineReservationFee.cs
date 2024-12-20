namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Invoice line reservation fee entity.
    /// </summary>
    public sealed class InvoiceLineReservationFee : InvoiceLine, IOrderLineReference
    {
        /// <inheritdoc/>
        public int OrderLineId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets reservation id.
        /// </summary>
        public int ReservationId { get; set; }

        /// <summary>
        /// Gets or sets fee type.
        /// </summary>
        public FeeType Type { get; set; }

        /// <summary>
        /// Gets or sets fee value.
        /// </summary>
        public decimal Fee { get; set; }

        /// <summary>
        /// Gets or sets order line.
        /// </summary>
        public ProductOLReservationFee OrderLine
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets reservation.
        /// </summary>
        public Reservation Reservation 
        { 
            get; 
            set;
        }
    }
}
