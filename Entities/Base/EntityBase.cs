using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Base entity class.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class EntityBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new entity instance.
        /// </summary>
        public EntityBase()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets primary id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public virtual int Id
        {
            get;
            set;
        }

        #endregion
    }
}