namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount bonus entity.
    /// </summary>
    public sealed class DiscountBonus : Discount
    {
        /// <summary>
        /// Gets or sets bonus value.
        /// </summary>
        public int Value { get; set; }
    }
}
