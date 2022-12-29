using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// Modifable with required user base class.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class ModifiableByWithRequiredUserMemberBase : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ModifiableByWithRequiredUserMemberBase()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int UserId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public virtual UserMember User
        {
            get; set;
        }

        #endregion
    }
}