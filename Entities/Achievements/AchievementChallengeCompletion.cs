using System;
using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// A user's completion of an achievement challenge.
    /// </summary>
    /// <remarks>
    /// One row per completion occurrence — at most one exists per user, challenge and
    /// <see cref="Occurrence"/>, which makes re-evaluation idempotent. Completion and grant
    /// are separate states: <see cref="CompletedTime"/> is written by the evaluator, while
    /// grant state lives on the reward children
    /// (<see cref="AchievementChallengeCompletionReward.Status"/>) — each reward is
    /// fulfilled independently; completed-but-not-granted is a visible, retryable state.
    /// Requirement and reward children are self-contained snapshots of the terms at
    /// completion time, never resolved from live configuration. Kept forever.
    /// </remarks>
    public sealed class AchievementChallengeCompletion : EntityBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementChallengeCompletion()
        {
            Requirements = new HashSet<AchievementChallengeCompletionRequirement>();
            Rewards = new HashSet<AchievementChallengeCompletionReward>();
        }

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets challenge id.
        /// </summary>
        public int ChallengeId { get; set; }

        /// <summary>
        /// Gets or sets the one-based completion occurrence index for repeatable challenges.
        /// </summary>
        public int Occurrence { get; set; }

        /// <summary>
        /// Gets or sets the one-based global finisher number across all users of the
        /// challenge — always populated ("finisher #7"). The unique index over challenge
        /// and this value makes the slot claimable exactly once, which is how the global
        /// completion pool is enforced under concurrency: when the pool is exhausted no
        /// completion row is written at all.
        /// </summary>
        public int GlobalOccurrence { get; set; }

        /// <summary>
        /// Gets or sets the UTC time the challenge requirements were satisfied.
        /// Grant state is tracked per reward row — rewards of one completion may be
        /// fulfilled at different times by different operators.
        /// </summary>
        public DateTime CompletedTime { get; set; }

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public UserMember User { get; set; }

        /// <summary>
        /// Gets or sets challenge.
        /// </summary>
        public AchievementChallenge Challenge { get; set; }

        /// <summary>
        /// Gets the per-requirement snapshot rows of the terms at completion time.
        /// </summary>
        public ISet<AchievementChallengeCompletionRequirement> Requirements { get; set; }

        /// <summary>
        /// Gets the snapshot rows of the rewards granted.
        /// </summary>
        public ISet<AchievementChallengeCompletionReward> Rewards { get; set; }
    }
}
