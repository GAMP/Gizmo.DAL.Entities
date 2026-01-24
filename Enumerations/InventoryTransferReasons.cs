namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Inventory transfer reasons enumeration.
    /// </summary>
    public enum InventoryTransferReasons
    {
        /// <summary>
        /// Product is in demand.
        /// </summary>
        InDemand = -1,

        /// <summary>
        /// Product is not in demand.
        /// </summary>
        NotInDemand = -2,

        /// <summary>
        /// For adjustment purposes.
        /// </summary>
        /// <remarks>
        /// Used in cases where inventory is being transferred for adjustment, such as correcting stock levels or addressing discrepancies.
        /// </remarks>
        ForAdjustment = -3,
    }
}
