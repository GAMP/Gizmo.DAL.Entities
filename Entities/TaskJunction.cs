using ProtoBuf;

using SharedLib;

using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Task junction entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class TaskJunction : TaskBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public TaskJunction()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets junction source directory.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [Required()]
        [StringLength(255)]
        public string SourceDirectory
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets junction destination directory.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        [Required()]
        [StringLength(255)]
        public string DestinationDirectory
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets options.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public TaskJunctionOptionType Options
        {
            get;
            set;
        }

        #endregion
    }
}