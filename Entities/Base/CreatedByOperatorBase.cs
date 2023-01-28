using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Base class where entity is created by operator.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class CreatedByOperatorBase : CreatedByBase<UserOperator>, ICreatedByOperator
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public CreatedByOperatorBase()
            : base()
        { }
        #endregion
    }
}