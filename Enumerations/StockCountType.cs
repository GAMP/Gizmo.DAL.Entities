namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Stock count type.
    /// </summary>
    public enum StockCountType
    {
        /// <summary>
        /// Interval stock count, used for regular stock counts.
        /// </summary>
        Interval = 0,
        /// <summary>
        /// Shift open stock count, used to open a shift.
        /// </summary>
        ShiftOpen = 1,
        /// <summary>
        /// Shift close stock count, used to close a shift.
        /// </summary>
        ShiftClose = 2,
    }
}
