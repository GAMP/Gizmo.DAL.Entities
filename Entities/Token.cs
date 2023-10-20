using ProtoBuf;

using SharedLib;

using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Token entity.
    /// </summary>
    [DataContract()]
    [ProtoContract()]
    [Serializable()]
    public class Token : ModifiableByUserCreatedByUserBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Token() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int? UserId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets token value.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        [MaxLength(32)]
        public string Value
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user confirmation code.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        [MaxLength(6)]
        public string ConfirmationCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets token type.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public TokenType Type
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets token status.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public TokenStatus Status
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets optional expiration time.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public DateTime? Expires
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

        #endregion
    }
}