using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Base class where entity can be created by operator and modified by user.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class ModifiableByUserBase : CreatedByOperatorBase, IModifiableByUser
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ModifiableByUserBase()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets modified by id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int? ModifiedById
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets last modified time.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public DateTime? ModifiedTime
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or set modified by user.
        /// </summary>
        public virtual User ModifiedBy
        {
            get; set;
        }

        #endregion
    }
}