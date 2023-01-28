using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Base class for value entities.
    /// </summary>
    /// <typeparam name="TValue">Value Type.</typeparam>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public abstract class ValueBase<TValue> : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ValueBase() : base()
        { }
        #endregion

        #region PROPERTIES
        /// <summary>
        /// Gets or sets value.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public virtual TValue Value
        {
            get; set;
        }
        #endregion
    }
}