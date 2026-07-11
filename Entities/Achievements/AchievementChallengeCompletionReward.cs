using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Base snapshot of a reward granted by an achievement challenge completion.
    /// </summary>
    /// <remarks>
    /// Mapped table-per-type: the concrete subtype records what was actually granted.
    /// Rows are created pending when the completion is recorded (the terms) and stamped
    /// when processed (<see cref="Status"/>, <see cref="ProcessedTime"/>, processor, ledger
    /// reference) — each reward is processed independently, possibly at different times by
    /// different operators.
    /// Snapshots capture the resolved grant outcome, not the reward configuration — a
    /// future formula-based reward (e.g. a random product) resolves at the grant stamp.
    /// Later edits to the challenge's reward configuration never rewrite what a user received.
    /// </remarks>
    public abstract class AchievementChallengeCompletionReward : EntityBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        protected AchievementChallengeCompletionReward()
        {
        }

        /// <summary>
        /// Gets or sets completion id.
        /// </summary>
        public int CompletionId { get; set; }

        /// <summary>
        /// Gets or sets the reward grant status.
        /// Set at completion time from the reward's nature and configuration (product
        /// rewards and <see cref="AchievementChallengeRewardOptionType.ForceClaim"/> await
        /// claim, the rest grant automatically) — later configuration edits never change
        /// how an existing row is treated.
        /// </summary>
        public AchievementChallengeRewardStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the UTC time the reward reached its terminal status
        /// (granted or declined); null while pending or awaiting claim.
        /// </summary>
        public DateTime? ProcessedTime { get; set; }

        /// <summary>
        /// Gets or sets the operator that granted or declined the reward.
        /// Null for system acts (automatic grants) and user declines, and while the
        /// reward is unprocessed — set by the operator-facing fulfillment flow.
        /// </summary>
        public int? ProcessedById { get; set; }

        /// <summary>
        /// Gets or sets completion.
        /// </summary>
        public AchievementChallengeCompletion Completion { get; set; }

        /// <summary>
        /// Gets or sets the processing operator.
        /// </summary>
        public UserOperator ProcessedBy { get; set; }
    }
}
