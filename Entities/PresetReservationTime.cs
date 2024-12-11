using SharedLib;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Preset reservation range entity.
    /// </summary>
    public sealed class PresetReservationTime : ValueBase<int> , IDisplayOrder
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public PresetReservationTime():base() { }

        /// <summary>
        /// Gets or sets display order.
        /// </summary>
        public int DisplayOrder
        {
            get; set;
        }
    }
}
