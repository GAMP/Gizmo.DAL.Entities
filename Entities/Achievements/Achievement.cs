using System;
using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Achievement entity — a completable objective over an achievement signal.
    /// </summary>
    /// <remarks>
    /// Reads as "accumulate <see cref="Value"/> of the signal within one calendar
    /// <see cref="Range"/>" (e.g. 5 visits in a week). <see cref="SignalGuid"/> is a soft
    /// reference to the providing signal — signals are code, not rows, so integrity is
    /// enforced at configuration time (guid must resolve in the signal registry) and at
    /// evaluation time (unresolvable guid = orphaned achievement, never scored as zero).
    /// </remarks>
    public sealed class Achievement : ModifiableByOperatorBase, IDisable, IDeletable
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Achievement()
        {
            Filters = new HashSet<AchievementFilter>();
            Parameters = new HashSet<AchievementParameter>();
        }

        /// <summary>
        /// Gets or sets achievement name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets optional customer-facing description shown alongside the achievement
        /// in level requirement checklists.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the identity of the signal this achievement measures.
        /// </summary>
        public Guid SignalGuid { get; set; }

        /// <summary>
        /// Gets or sets the calendar range one completion is evaluated within.
        /// </summary>
        public CalendarPeriod Range { get; set; }

        /// <summary>
        /// Gets or sets the target signal value to accumulate within one range,
        /// in the signal's native unit.
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of completions within one range instance.
        /// 1 (default) means binary — a range is either completed or not; higher values
        /// award proportionally up to the cap.
        /// </summary>
        public int MaxCompletionsPerRange { get; set; } = 1;

        /// <summary>
        /// Gets or sets option flags.
        /// </summary>
        public AchievementOptionType Options { get; set; }

        /// <summary>
        /// Gets or sets if the achievement is disabled.
        /// A disabled achievement is inert everywhere: no new completions are evaluated and
        /// it drops out of ladder scoring and level requirement sets (a level is judged on
        /// its remaining requirements). Existing completions and event history remain.
        /// Challenge requirements are the deliberate exception — they never drop out
        /// (that would instantly grant prizes) and are judged on already-recorded
        /// completions, so a disabled achievement only gates users who have not yet
        /// satisfied that requirement.
        /// </summary>
        public bool IsDisabled { get; set; }

        /// <inheritdoc/>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Gets id filter values restricting counted activity (hosts, host groups, apps etc.).
        /// </summary>
        public ISet<AchievementFilter> Filters { get; set; }

        /// <summary>
        /// Gets custom signal parameter values, validated against the signal's declared
        /// parameter metadata.
        /// </summary>
        public ISet<AchievementParameter> Parameters { get; set; }
    }
}
