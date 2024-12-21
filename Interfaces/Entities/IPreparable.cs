using System;

namespace Gizmo.DAL
{
    /// <summary>
    /// Represents an entry that can be marked as prepared.
    /// </summary>
    public interface IPreparable
    {
        /// <summary>
        /// Gets or sets preparation status.
        /// </summary>
        public OrderPrepareStatus PrepareStatus { get; set; }

        /// <summary>
        /// Gets or sets prepared quantity.
        /// </summary>
        public decimal PreparedQuantity { get; set; }

        /// <summary>
        /// Gets or sets entry preparation time.
        /// </summary>
        public DateTime? PrepareTime { get; set; }
    }
}
