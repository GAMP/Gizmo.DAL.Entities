using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount target product time entity.
    /// </summary>
    public sealed class TargetGroupProductTime : TargetGroup
    {
        /// <summary>
        /// Creates a new instance of <see cref="TargetGroupProductTime"/> class.
        /// </summary>
        public TargetGroupProductTime() : base()
        {
            ProductTimes = new HashSet<TargetProductTime>();
        }

        /// <summary>
        /// Gets targeted product times.
        /// </summary>
        public ISet<TargetProductTime> ProductTimes { get; set; }
    }
}
