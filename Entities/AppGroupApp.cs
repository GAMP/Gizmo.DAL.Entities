using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// App group entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class AppGroupApp
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AppGroupApp() : base()
        {
        }
        #endregion

        #region PROPERTIES
        /// <summary>
        /// Gets or sets app id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int AppId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets app group id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int AppGroupId
        {
            get; set;
        }
        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets app.
        /// </summary>
        public virtual App App
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets app group.
        /// </summary>
        public virtual AppGroup AppGroup
        {
            get; set;
        }
        #endregion
    }
}