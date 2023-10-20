using ProtoBuf;

using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Base class where entity is created by user.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class CreatedByUserBase : CreatedByBase<User>, ICreatedByUser
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public CreatedByUserBase() : base()
        { }
        #endregion
    }
}