namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// HDMI Device entity.
    /// </summary>
    public class HdmiDevice : Device
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public HdmiDevice() : base()
        {
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets unique serial number.
        /// </summary>
        public string SerialNumber
        {
            get; set;
        }

        #endregion
    }
}
