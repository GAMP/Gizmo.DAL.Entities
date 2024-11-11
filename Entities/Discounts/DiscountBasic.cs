#nullable enable

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount entity.
    /// </summary>
    public sealed class DiscountBasic : Discount
    {
        /// <summary>
        /// Apply type, basically at what level discount is applied (order or order line)
        /// </summary>
        public DiscountApplyType ApplyType { get; set; }

        /// <summary>
        /// Gets or sets type.
        /// </summary>
        public DiscountValueType Type { get; set; }

        /// <summary>
        /// Gets or set value.
        /// </summary>
        /// <remarks>
        /// The value will be percentage or monetary discount base on Discount value type.
        /// </remarks>
        public decimal? Value { get; set; }
    }
}
