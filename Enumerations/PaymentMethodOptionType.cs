using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Payment method options.
    /// </summary>
    [Flags()]
    public enum PaymentMethodOptionType
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Indicates that method is non-fiscal and does not require a receipt.
        /// </summary>
        NonFiscal = 1,

        /// <summary>
        /// Indicates that method is used in fiscal printer as credit card.
        /// </summary>
        IsCreditCard = 2
    }
}
