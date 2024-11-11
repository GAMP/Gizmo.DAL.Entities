using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Promotion entity.
    /// </summary>
    public abstract class Promotion : ModifiableByOperatorBase
    {
        //max use. total maximum uses per promo code
        //max use per user. total maximum times an single customer can use promo code.

        /// <summary>
        /// Gets promotion codes.
        /// </summary>
        public ISet<PromotionCode> Codes { get; set; }

        /// <summary>
        /// Gets or sets promotion period.
        /// </summary>
        public PromotionPeriod Period { get; set; }
    }
}
