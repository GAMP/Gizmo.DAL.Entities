using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
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