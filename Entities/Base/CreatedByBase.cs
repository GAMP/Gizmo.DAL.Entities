using ProtoBuf;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Created by base calss.
    /// </summary>
    /// <typeparam name="TCreated">Created type.</typeparam>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public abstract class CreatedByBase<TCreated> : EntityBase, ICreatedBy
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new created by instance.
        /// </summary>
        public CreatedByBase() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets created by id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int? CreatedById
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets created time.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public DateTime CreatedTime
        {
            get; set;
        }

        /// <summary>
        /// Indicates that when entity is saved creation time shouldnt be set automatically.
        /// </summary>
        [NotMapped()]
        public bool IgnoreCreatedUpdate
        {
            get; set;
        }

        /// <summary>
        /// Indicates that when entity is saved update time and user shouldnt be set automatically.
        /// </summary>
        [NotMapped()]
        public bool IgnoreUpdatedUpdate
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets created by.
        /// </summary>
        public virtual TCreated CreatedBy
        {
            get; set;
        }

        #endregion
    }
}