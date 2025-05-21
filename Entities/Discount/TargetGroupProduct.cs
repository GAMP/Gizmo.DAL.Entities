using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Discount target product entity.
    /// </summary>
    public sealed class TargetGroupProduct : TargetGroup
    {
        /// <summary>
        /// Creates a new instance of <see cref="TargetGroupProduct"/> class.
        /// </summary>
        public TargetGroupProduct() : base()
        {
            Products = new HashSet<TargetProduct>();
        }

        /// <summary>
        /// Gets targeted products.
        /// </summary>
        public ISet<TargetProduct> Products { get; set; }
    }
}
