using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Modified by base class.
    /// </summary>
    /// <typeparam name="TCreated">Created type.</typeparam>
    /// <typeparam name="TModified">Modified type.</typeparam>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public abstract class ModifiedByBase<TCreated, TModified> : CreatedByBase<TCreated>, IModifiedBy
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ModifiedByBase() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets modifier id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int? ModifiedById
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets modified time.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public DateTime? ModifiedTime
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Get or sets modified by.
        /// </summary>
        public virtual TModified ModifiedBy
        {
            get; set;
        }

        #endregion
    }
}