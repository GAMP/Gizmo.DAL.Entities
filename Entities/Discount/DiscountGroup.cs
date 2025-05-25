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
            UserGroups = new HashSet<UserGroup>();
        }

        /// <summary>
        /// Gets or sets discount group name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets associated discounts.
        /// </summary>
        public ISet<DiscountGroupDiscount> Discounts { get; set; }

        /// <summary>
        /// Gets associated user groups.
        /// </summary>
        public ISet<UserGroup> UserGroups { get; private set; }
    }
}
