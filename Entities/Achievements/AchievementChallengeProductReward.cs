namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Achievement challenge reward granting a product.
    /// </summary>
    public sealed class AchievementChallengeProductReward : AchievementChallengeReward
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementChallengeProductReward()
        {
        }

        /// <summary>
        /// Gets or sets rewarded product id.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the rewarded quantity.
        /// </summary>
        public int Quantity { get; set; } = 1;

        /// <summary>
        /// Gets or sets rewarded product.
        /// </summary>
        public ProductBase Product { get; set; }
    }
}
