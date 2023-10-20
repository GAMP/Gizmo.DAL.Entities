using ProtoBuf;

using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Premission entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class UserPermission : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserPermission()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets permission type.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(255)]
        [ProtoMember(1)]
        public string Type
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets permission value.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(255)]
        [ProtoMember(2)]
        public string Value
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
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
        public virtual User User
        {
            get;
            set;
        }

        #endregion
    }
}