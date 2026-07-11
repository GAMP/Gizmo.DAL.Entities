namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Achievement filter counting only activity settled with the specified payment method.
    /// </summary>
    public sealed class AchievementPaymentMethodFilter : AchievementFilter
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementPaymentMethodFilter()
        {
        }

        /// <summary>
        /// Gets or sets payment method id.
        /// </summary>
        public int PaymentMethodId { get; set; }

        /// <summary>
        /// Gets or sets payment method.
        /// </summary>
        public PaymentMethod PaymentMethod { get; set; }
    }
}
