namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// HDMI Device entity.
    /// </summary>
    public class DeviceHdmi : Device
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public DeviceHdmi() : base()
        {
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets unique id.
        /// </summary>
        public string UniqueId
        {
            get; set;
        }

        #endregion
    }
}
