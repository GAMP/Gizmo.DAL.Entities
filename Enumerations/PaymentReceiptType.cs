namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Payment receipt type.
    /// </summary>
    /// <remarks>
    /// Used to represent different types of payment receipts.
    /// </remarks>
    public enum PaymentReceiptType
    {
        /// <summary>
        /// Indicates payment.
        /// </summary>
        Payment = 0,

        /// <summary>
        /// Indicates refund.
        /// </summary>
        Refund = 1,
    }
}
