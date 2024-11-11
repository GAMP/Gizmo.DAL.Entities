namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount target bill profile - billing profile.
    /// </summary>
    public sealed class TargetBillProfile : Target
    {
        /// <summary>
        /// Gets or sets bill profile id.
        /// </summary>
        public int BillProfileId { get; set; }

        /// <summary>
        /// Gets bill profile group id.
        /// </summary>
        public int TargetGroupBillProfileId { get; set; }

        /// <summary>
        /// Gets or sets bill profile.
        /// </summary>
        public BillProfile BillProfile { get; set; }

        /// <summary>
        /// Gets billing profile target group.
        /// </summary>
        public TargetGroupBillProfile TargetGroupBillProfile { get; private set; }
    }
}
