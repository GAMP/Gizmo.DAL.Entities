namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Interface implemented by object supporting display order.
    /// </summary>
    public interface IDisplayOrder
    {
        /// <summary>
        /// Gets or sets display order.
        /// </summary>
        int DisplayOrder
        {
            get; set;
        }
    }
}
