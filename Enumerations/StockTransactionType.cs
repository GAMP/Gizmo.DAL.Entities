namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Stock transaction type.
    /// </summary>
    public enum StockTransactionType
    {
        /// <summary>
        /// Add.
        /// </summary>
        Add = 0,

        /// <summary>
        /// Remove.
        /// </summary>
        Remove = 1,

        /// <summary>
        /// Sale.
        /// </summary>
        Sale = 2,

        /// <summary>
        /// Set.
        /// </summary>
        Set = 3,

        /// <summary>
        /// Return.
        /// </summary>
        Return = 4,
    }
}
