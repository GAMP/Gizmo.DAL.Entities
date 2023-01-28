using ProtoBuf;
using SharedLib;
using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Client task entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class ClientTask : ModifiableByOperatorBase, IEnabled
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ClientTask()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets system task activation type.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public ClientTaskActivationType Activation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets order.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int UseOrder
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if enabled.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public bool IsEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets task id.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int TaskBaseId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets task.
        /// </summary>
        public virtual TaskBase TaskBase
        {
            get;
            set;
        }

        #endregion
    }
}