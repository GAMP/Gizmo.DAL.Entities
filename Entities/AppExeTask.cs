using ProtoBuf;
using SharedLib;
using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Executable task entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class AppExeTask : ModifiableByOperatorBase, IEnabled
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AppExeTask()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets activation type.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public ExecutableTaskActivationType Activation
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
        /// Gets or sets executable id.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int AppExeId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets task id.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int TaskBaseId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets executable.
        /// </summary>
        public virtual AppExe AppExe
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets task.
        /// </summary>
        [ProtoMember(6, AsReference = true)]
        public virtual TaskBase TaskBase
        {
            get;
            set;
        }

        #endregion
    }
}