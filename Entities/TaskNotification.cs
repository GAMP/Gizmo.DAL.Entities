using ProtoBuf;
using SharedLib;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// Task notification entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class TaskNotification : TaskBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public TaskNotification()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets notification title.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [Required()]
        [StringLength(255)]
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets notification message.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        [Required()]
        [StringLength(65536)]
        public string Message
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets notification options.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public TaskNotificationOptionType NotificationOptions
        {
            get; set;
        }

        #endregion
    }
}