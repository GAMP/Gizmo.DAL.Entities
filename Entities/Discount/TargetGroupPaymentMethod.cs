using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Payment method target group.
    /// </summary>
    public sealed class TargetGroupPaymentMethod : TargetGroup
    {
        /// <summary>
        /// Creates a new instance of <see cref="TargetGroupPaymentMethod"/> class.
        /// </summary>
        public TargetGroupPaymentMethod() : base()
        {
            PaymentMethods = new HashSet<TargetPaymentMethod>();
        }

        /// <summary>
        /// Gets or sets payment methods.
        /// </summary>
        public ISet<TargetPaymentMethod> PaymentMethods { get; private set; }
    }
}
