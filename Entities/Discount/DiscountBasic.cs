#nullable enable

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount entity.
    /// </summary>
    public sealed class DiscountBasic : DiscountTargeted
    {
        /// <summary>
        /// Gets or set value.
        /// </summary>
        public decimal Value { get; set; }
    }
}
