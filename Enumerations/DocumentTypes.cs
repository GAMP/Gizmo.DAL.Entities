namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Predefined document types for the system.
    /// </summary>
    public enum DocumentTypes
    {
        /// <summary>
        /// Delivery note.
        /// </summary>
        DeliveryNote = -1,

        /// <summary>
        /// Dispatch note.
        /// </summary>
        DispatchNote = -2,

        /// <summary>
        /// Stock take report.
        /// </summary>
        StockTakeReport = -3,

        /// <summary>
        /// Write off report.
        /// </summary>
        WriteOffReport = -4,

        /// <summary>
        /// Consignment note.
        /// </summary>
        ConsignmentNote = -5,

        /// <summary>
        /// Invoice.
        /// </summary>
        Invoice = -6,

        /// <summary>
        /// Work order.
        /// </summary>
        WorkOrder = -7,
    }
}
