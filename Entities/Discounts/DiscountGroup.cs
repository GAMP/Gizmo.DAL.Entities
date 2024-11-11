using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount group entity.
    /// </summary>
    public sealed class DiscountGroup : ModifiableByOperatorBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public DiscountGroup() 
        {
            Discounts = new HashSet<DiscountGroupDiscount>();
        }

        /// <summary>
        /// Gets or sets discount group name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets discounts.
        /// </summary>
        public ISet<DiscountGroupDiscount> Discounts { get; private set; }
    }
}
