namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Achievement challenge reward depositing points to the user's points balance.
    /// </summary>
    public sealed class AchievementChallengePointsReward : AchievementChallengeReward
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementChallengePointsReward()
        {
        }

        /// <summary>
        /// Gets or sets the points amount.
        /// </summary>
        public int Amount { get; set; }
    }
}
