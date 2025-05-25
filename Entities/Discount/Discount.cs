#nullable enable

using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount base entity.
    /// </summary>
    public sealed class Discount : ModifiableByOperatorBase , IDeletable , IDisable
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Discount()
        {
            Branches = new HashSet<DiscountBranch>();
            TargetGroups = new HashSet<TargetGroup>();
            Period = new DiscountPeriod();
        }

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets description.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Apply type, basically at what level discount is applied (order or order line)
        /// </summary>
        public DiscountApplyType ApplyType { get; set; }

        /// <summary>
        /// Gets or sets calculation type.
        /// </summary>
        public DiscountCalculationType CalculationType { get; set; }

        /// <summary>
        /// Gets or sets discount reward type.
        /// </summary>
        public DiscountRewardType RewardType { get; set; }

        /// <summary>
        /// Target group requirement.
        /// </summary>
        public TargetGroupRequirement Requirement { get; set; }

        /// <summary>
        /// Gets or set value.
        /// </summary>
        public decimal Value { get; set; }

        /// <inheritdoc/>
        public bool IsDisabled { get; set; }

        /// <inheritdoc/>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets discount period.
        /// </summary>
        public DiscountPeriod Period { get; set; }

        /// <summary>
        /// Gets target groups.
        /// </summary>
        public ISet<TargetGroup> TargetGroups { get; private set; }

        /// <summary>
        /// Gets or sets discount branches.
        /// </summary>
        public ISet<DiscountBranch> Branches { get; private set; } 
    }
}
