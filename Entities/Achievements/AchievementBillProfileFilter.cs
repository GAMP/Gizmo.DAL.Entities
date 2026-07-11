namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Achievement filter counting only activity billed under the specified bill profile.
    /// </summary>
    public sealed class AchievementBillProfileFilter : AchievementFilter
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementBillProfileFilter()
        {
        }

        /// <summary>
        /// Gets or sets bill profile id.
        /// </summary>
        public int BillProfileId { get; set; }

        /// <summary>
        /// Gets or sets bill profile.
        /// </summary>
        public BillProfile BillProfile { get; set; }
    }
}
