namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount value type.
    /// </summary>
    public enum DiscountCalculationType
    {
        /// <summary>
        /// Percentage discount.
        /// </summary>
        Percentage = 0,

        /// <summary>
        /// Fixed discount.
        /// </summary>
        Fixed = 1,
    
        // Fixed Price PerItem ?
        // Fixed discount total, total discount value irrelevant of items in order line ?
        // Fixed Price Total ?,
    }
}
