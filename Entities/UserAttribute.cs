using ProtoBuf;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// User attribute entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class UserAttribute : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserAttribute() : base()
        { }
        #endregion

        #region PROPERIES

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int UserId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets attribute id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int AttributeId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets attribute value.
        /// </summary>
        [StringLength(255)]
        [DataMember()]
        [ProtoMember(3)]
        public string Value
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public virtual User User
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets attribute.
        /// </summary>
        public virtual Attribute Attribute
        {
            get; set;
        }

        #endregion
    }
}