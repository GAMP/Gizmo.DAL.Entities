using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount target bill profile.
    /// </summary>
    public sealed class TargetGroupBillProfile : TargetGroup
    {
        /// <summary>
        /// Gets targeted bill profiles.
        /// </summary>
        public ISet<TargetBillProfile> BilliProfiles { get; set; }
    }
}
