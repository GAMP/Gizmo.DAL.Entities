using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// User group price base class.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class UserGroupPriceBase : PriceBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance of user group price base.
        /// </summary>
        public UserGroupPriceBase() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets user group id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int UserGroupId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets user group.
        /// </summary>
        public virtual UserGroup UserGroup
        {
            get;
            set;
        }

        #endregion
    }
}