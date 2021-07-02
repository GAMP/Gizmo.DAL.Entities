namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Host device relation entity.
    /// </summary>
    public class DeviceHost : GizmoDALV2.Entities.ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public DeviceHost() : base()
        { } 

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets host id.
        /// </summary>
        public int HostId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets device id.
        /// </summary>
        public int DeviceId
        {
            get; set;
        } 

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets device.
        /// </summary>
        public virtual Device Device
        {
            get; protected set;
        }

        /// <summary>
        /// Gets host.
        /// </summary>
        public virtual GizmoDALV2.Entities.Host Host
        {
            get; protected set;
        } 

        #endregion
    }
}
