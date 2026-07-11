namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Achievement challenge reward crediting time to the user's balance.
    /// </summary>
    public sealed class AchievementChallengeTimeReward : AchievementChallengeReward
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementChallengeTimeReward()
        {
        }

        /// <summary>
        /// Gets or sets the credited time amount in seconds.
        /// </summary>
        public int Seconds { get; set; }
    }
}
