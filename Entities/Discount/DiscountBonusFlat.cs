namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount bonus flat entity.
    /// </summary>
    public sealed class DiscountBonusFlat : Discount
    {
        /// <summary>
        /// Gets or sets bonus value.
        /// </summary>
        public int Value { get; set; }
    }
}
