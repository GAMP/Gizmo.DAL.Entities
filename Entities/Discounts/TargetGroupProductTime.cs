using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount target product time entity.
    /// </summary>
    public sealed class TargetGroupProductTime : TargetGroup
    {
        /// <summary>
        /// Gets targeted product times.
        /// </summary>
        public ISet<TargetProductTime> ProductTimes { get; set; }
    }
}
