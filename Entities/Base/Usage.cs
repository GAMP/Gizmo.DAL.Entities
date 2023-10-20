using ProtoBuf;

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Usage base class entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class Usage : EntityBase, IModifiable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Usage() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets usage session id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int UsageSessionId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int UserId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets total seconds.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public double Seconds
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets modified time.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public DateTime? ModifiedTime
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets created time.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public DateTime CreatedTime
        {
            get; set;
        }

        #endregion

        #region UNMAPPED PROPERTIES

        /// <summary>
        /// Indicates that when entity is saved creation time shouldnt be set automatically.
        /// </summary>
        [NotMapped()]
        public bool IgnoreCreatedUpdate
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates that when entity is saved update time and user shouldnt be set automatically.
        /// </summary>
        [NotMapped()]
        public bool IgnoreUpdatedUpdate { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets bill session.
        /// </summary>
        public virtual UsageSession UsageSession
        {
            get; set;
        }

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