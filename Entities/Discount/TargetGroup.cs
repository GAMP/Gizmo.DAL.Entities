namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount target base entity.
    /// </summary>
    public abstract class TargetGroup : ModifiableByOperatorBase
    { 
        /// <summary>
        /// Gets or sets discount id.
        /// </summary>
        public int DiscountId { get; set; }

        /// <summary>
        /// Target everything based on target type.
        /// For example if enabled for DiscountTargetProduct group then all product groups will be included.
        /// </summary>
        public bool IncludeAll { get; set; }   
      
        /// <summary>
        /// Source list requirements.
        /// </summary>
        public TargetRequirement Requirement { get; set; }

        /// <summary>
        /// Requirement value. for example at least 3 items or at least 50 euro.
        /// </summary>
        public decimal? Value { get; set; }

        /// <summary>
        /// Gets discount.
        /// </summary>
        public DiscountTargeted Discount { get; private set; }
    }
}
