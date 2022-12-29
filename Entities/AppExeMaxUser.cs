using ProtoBuf;
using SharedLib;
using System;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// App exe max user entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class AppExeMaxUser : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AppExeMaxUser()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets app exe id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int AppExeId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets mode.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public ApplicationModes Mode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets maximum users.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int? MaxUsers
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets app exe.
        /// </summary>
        public virtual AppExe AppExe
        {
            get;
            set;
        }

        #endregion
    }
}