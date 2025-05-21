using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount target bill profile.
    /// </summary>
    public sealed class TargetGroupBillProfile : TargetGroup
    {
        /// <summary>
        /// Creates a new instance of <see cref="TargetGroupBillProfile"/> class.
        /// </summary>
        public TargetGroupBillProfile() : base()
        {
            BillProfiles = new HashSet<TargetBillProfile>();
        }

        /// <summary>
        /// Gets targeted bill profiles.
        /// </summary>
        public ISet<TargetBillProfile> BillProfiles { get; set; }
    }
}
