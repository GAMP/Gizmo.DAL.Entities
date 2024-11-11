using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount target product entity.
    /// </summary>
    public sealed class TargetGroupProduct : TargetGroup
    {
        /// <summary>
        /// Gets targeted products.
        /// </summary>
        public ISet<TargetProduct> Products { get; set; }
    }
}
