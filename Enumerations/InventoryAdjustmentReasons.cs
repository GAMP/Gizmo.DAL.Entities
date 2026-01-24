namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Inventory adjustment reasons enumeration.
    /// </summary>
    public enum InventoryAdjustmentReasons
    {
        /// <summary>
        /// Product expired.
        /// </summary>
        Expired = -1,

        /// <summary>
        /// Product packaging is damaged.
        /// </summary>
        Damaged = -2,

        /// <summary>
        /// Product is damaged.
        /// </summary>
        DamagedItem = -3,

        /// <summary>
        /// Product is lost.
        /// </summary>
        Lost = -4,

        /// <summary>
        /// Product is not in demand.
        /// </summary>
        NotInDemand = -5,

        /// <summary>
        /// Force major circumstances.
        /// </summary>
        ForceMajor = -6,
    }
}
