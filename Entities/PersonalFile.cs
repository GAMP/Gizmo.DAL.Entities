using ProtoBuf;
using SharedLib;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Personal file entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class PersonalFile : FileListEntityBase, IReplicatable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public PersonalFile()
            : base()
        {
            AppExes = new HashSet<AppExePersonalFile>();
            Guid = Guid.NewGuid();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(255)]
        [ProtoMember(1)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets caption.
        /// </summary>
        [DataMember()]
        [StringLength(255)]
        [ProtoMember(2)]
        public string Caption
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [StringLength(255)]
        [ProtoMember(3)]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets accessible.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public bool Accessible
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the source path.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(255)]
        [ProtoMember(5)]
        public string Source
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets activation type.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public PersonalFileActivationType Activation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets deactivation type.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public PersonalFileDeactivationType Deactivation
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets quota.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public int MaxQuota
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets compression level.
        /// </summary>
        [DataMember()]
        [ProtoMember(9)]
        public int CompressionLevel
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets items guid.
        /// <remarks>This property is required to globaly identify the object. In case of exporting or importing applications it gives us ability to have unique objects.</remarks>
        /// </summary>
        [DataMember()]
        [Required()]
        [ProtoMember(10)]
        public Guid Guid
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets type.
        /// </summary>
        [DataMember()]
        [ProtoMember(11)]
        public PersonalUserFileType Type
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets options.
        /// </summary>
        [DataMember()]
        [ProtoMember(12)]
        public PersonalUserFileOptionType Options
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets executables.
        /// </summary>
        public virtual ISet<AppExePersonalFile> AppExes
        {
            get;
            protected set;
        }

        #endregion
    }
}