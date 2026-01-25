namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Invoice status.
    /// </summary>
    public enum InvoiceStatus
    {
        /// <summary>
        /// Unpaid.
        /// </summary>
        Unpaid = 0,

        /// <summary>
        /// Partially paid.
        /// </summary>
        PartiallyPaid = 1,

        /// <summary>
        /// Paid.
        /// </summary>
        Paid = 2,
    }
}
