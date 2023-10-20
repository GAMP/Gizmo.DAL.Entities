using ProtoBuf;

using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// App exe cd image entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class AppExeCdImage : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AppExeCdImage()
            : base()
        {
            Guid = Guid.NewGuid();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets cd image.
        /// </summary>
        [DataMember()]
        [StringLength(255)]
        [ProtoMember(1)]
        public string Path
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets mounting options.
        /// </summary>
        [DataMember()]
        [StringLength(255)]
        [ProtoMember(2)]
        public string MountOptions
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets device id.
        /// </summary>
        [DataMember()]
        [StringLength(3)]
        [ProtoMember(3)]
        public string DeviceId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or Sets the cehck exit code value.
        /// <remarks >
        /// When this set Mount() call will check the mounter process exit code when it exits.
        /// </remarks>
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public bool CheckExitCode
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
        [ProtoMember(5)]
        public Guid Guid
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets executable id.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public int AppExeId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets executable.
        /// </summary>
        public virtual AppExe AppExe { get; set; }

        #endregion
    }
}