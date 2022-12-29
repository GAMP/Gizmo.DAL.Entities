using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// Void base class.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public abstract class Void : EntityWithShift
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Void() : base()
        { }
        #endregion
    }
}