using System;
using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Achievement challenge entity — complete the required achievements, receive the rewards.
    /// </summary>
    /// <remarks>
    /// Evaluation is purely event driven: when an achievement completion is recorded the
    /// challenges requiring that achievement are re-tested — grants are monotonic and
    /// irreversible, so no period settle exists. Requirements count achievement completions
    /// within the challenge window (<see cref="StartTime"/>/<see cref="EndTime"/>, both
    /// optional). Occurrences satisfied = the minimum over requirements of
    /// completions ÷ required count (floor), capped by <see cref="MaxCompletions"/>;
    /// each occurrence is granted once (unique per user, challenge and occurrence).
    /// </remarks>
    public sealed class AchievementChallenge : ModifiableByOperatorBase, IDisable, IDeletable
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AchievementChallenge()
        {
            Requirements = new HashSet<AchievementChallengeRequirement>();
            Rewards = new HashSet<AchievementChallengeReward>();
        }

        /// <summary>
        /// Gets or sets challenge name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets optional customer-facing description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets optional UTC start of the challenge window.
        /// Null means the window opens at challenge creation.
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets optional UTC end of the challenge window.
        /// Null means the challenge is evergreen.
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of completions per user within the window.
        /// Null means unlimited — a recurring reward the user earns every time the
        /// requirements are met again.
        /// </summary>
        public int? MaxCompletions { get; set; } = 1;

        /// <summary>
        /// Gets or sets the total completion pool across all users — "first N finishers"
        /// scarcity campaigns. Null means uncapped. Slots are consumed per completion, not
        /// per winner; combine with a per-user max of one for "N distinct winners".
        /// </summary>
        public int? GlobalMaxCompletions { get; set; }

        /// <summary>
        /// Gets or sets option flags.
        /// </summary>
        public AchievementChallengeOptionType Options { get; set; }

        /// <summary>
        /// Gets or sets if the challenge is disabled.
        /// A disabled challenge is not evaluated and no new completions are granted;
        /// existing completions and their rewards remain.
        /// </summary>
        public bool IsDisabled { get; set; }

        /// <summary>
        /// Gets or sets optional badge image id.
        /// </summary>
        public int? ImageId { get; set; }

        /// <inheritdoc/>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets or sets badge image.
        /// </summary>
        public FileImage Image { get; set; }

        /// <summary>
        /// Gets the achievements required to complete the challenge.
        /// </summary>
        public ISet<AchievementChallengeRequirement> Requirements { get; set; }

        /// <summary>
        /// Gets the rewards granted per completion.
        /// </summary>
        public ISet<AchievementChallengeReward> Rewards { get; set; }
    }
}
