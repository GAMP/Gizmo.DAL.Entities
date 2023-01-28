using ProtoBuf;
using SharedLib;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Log entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class Log : EntityBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Log()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets time.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public DateTime Time { get; set; }

        /// <summary>
        /// Gets or sets host number.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int? HostNumber { get; set; }

        /// <summary>
        /// Gets or sets host name.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        [StringLength(45)]
        public string Hostname { get; set; }

        /// <summary>
        /// Gets or sets module type.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public ModuleEnum ModuleType { get; set; }

        /// <summary>
        /// Gets or sets module version.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public string ModuleVersion { get; set; }

        /// <summary>
        /// Gets or sets category.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public LogCategories Category { get; set; }

        /// <summary>
        /// Gets or sets message type.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public EventTypes MessageType { get; set; }

        /// <summary>
        /// Gets or sets message.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        [StringLength(65536)]
        public string Message { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets log exception.
        /// </summary>
        [DataMember()]
        [ProtoMember(9)]
        public virtual LogException Exception { get; set; }

        #endregion
    }
}