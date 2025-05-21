#nullable enable

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Represents a target associated with a specific payment method.
    /// </summary>
    public sealed class TargetPaymentMethod : Target
    {
        /// <summary>
        /// Gets or sets target group payment method id.
        /// </summary>
        public int TargetGroupPaymentMethodId { get; set; }

        /// <summary>
        /// Gets or sets payment method id.
        /// </summary>
        public int MethodId { get; set; }

        /// <summary>
        /// Gets or sets target group payment method.
        /// </summary>
        public TargetGroupPaymentMethod TargetGroupPaymentMethod { get; set; } = null!;

        /// <summary>
        /// Gets or sets payment method.
        /// </summary>
        public PaymentMethod PaymentMethod { get; set; } = null!;
    }
}
