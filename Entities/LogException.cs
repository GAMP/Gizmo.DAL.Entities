using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Log exception entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class LogException : EntityBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public LogException()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets exception data.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public byte[] ExceptionData { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets log message.
        /// </summary>
        public virtual Log Message
        {
            get;
            set;
        }

        #endregion
    }
}