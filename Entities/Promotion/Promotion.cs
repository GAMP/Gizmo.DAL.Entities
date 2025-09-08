#nullable enable

using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Promotion entity.
    /// </summary>
    public abstract class Promotion : ModifiableByOperatorBase , IDeletable , IDisable
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Promotion() 
        {
            Limits = new HashSet<PromotionLimit>();
            Codes = new HashSet<PromotionCode>();
            Branches = new HashSet<PromotionBranch>();
        }

        /// <summary>
        /// Gets or sets promotion name.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets promotion description.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets promotion code type.
        /// </summary>
        public PromotionCodeType CodeType { get; set; }

        /// <inheritdoc/>
        public bool IsDeleted { get; set; }

        /// <inheritdoc/>
        public bool IsDisabled { get; set; }

        /// <summary>
        /// Gets or sets promotion period.
        /// </summary>
        public PromotionPeriod Period { get; set; } = null!;

        /// <summary>
        /// Gets promotion codes.
        /// </summary>
        public ISet<PromotionCode> Codes { get; private set; }

        /// <summary>
        /// Gest use limits.
        /// </summary>
        public ISet<PromotionLimit> Limits { get; private set; }

        /// <summary>
        /// Gets or sets promotion branches.
        /// </summary>
        public ISet<PromotionBranch> Branches { get; private set; }

    }
}
