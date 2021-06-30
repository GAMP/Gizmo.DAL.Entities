using GizmoDALV2.Entities;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Device entity.
    /// </summary>
    public class Device : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Device() : base()
        { }
        #endregion

        #region PROPERTIES
        /// <summary>
        /// Gets or set device name.
        /// </summary>
        public string Name
        {
            get; set;
        }
        #endregion
    }
}
