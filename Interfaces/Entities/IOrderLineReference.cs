namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Interface for entities referencing order line.
    /// </summary>
    public interface IOrderLineReference
    {
        #region PROPERTIES

        /// <summary>
        /// Gets or sets order line id.
        /// </summary>
        int OrderLineId { get; set; }

        #endregion
    }
}
