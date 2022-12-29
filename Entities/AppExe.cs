using ProtoBuf;
using SharedLib;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// App exe entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class AppExe : ModifiableByOperatorBase, IReplicatable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AppExe()
            : base()
        {
            Guid = Guid.NewGuid();
            AppExeCdImages = new HashSet<AppExeCdImage>();
            Tasks = new HashSet<AppExeTask>();
            PersonalFiles = new HashSet<AppExePersonalFile>();
            Deployments = new HashSet<AppExeDeployment>();
            Licenses = new HashSet<AppExeLicense>();
            AppStats = new HashSet<AppStat>();
            MaxUsers = new HashSet<AppExeMaxUser>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets accessible.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public bool Accessible
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets caption.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        [StringLength(255)]
        public string Caption
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        [StringLength(255)]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets items guid.
        /// <remarks>
        /// This property is required to globaly identify the object.
        /// In case of exporting or importing applications it gives us ability to have unique objects.
        /// </remarks>
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        [Required()]
        public Guid Guid
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets applications modes.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public ApplicationModes Modes
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or Sets path to the executable file.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        [Required()]
        [StringLength(255)]
        public string ExecutablePath
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or Sets executables working directory.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        [StringLength(255)]
        public string WorkingDirectory
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or Sets executables arguments.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        [StringLength(255)]
        public string Arguments
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or Sets the runmode of the executable.
        /// </summary>
        [DataMember()]
        [ProtoMember(9)]
        public RunMode RunMode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets license reservation type.
        /// </summary>
        [DataMember()]
        [ProtoMember(10)]
        public LicenseReservationType ReservationType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets executable options.
        /// </summary>
        [DataMember()]
        [ProtoMember(11)]
        public ExecutableOptionType Options
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets display order.
        /// </summary>
        [DataMember()]
        [ProtoMember(12)]
        public int DisplayOrder
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets application id.
        /// </summary>
        [DataMember()]
        [ProtoMember(13)]
        [Required()]
        public int AppId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets default deployment profile.
        /// </summary>
        [DataMember()]
        [ProtoMember(14)]
        public int? DefaultDeploymentId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets image.
        /// </summary>
        [ProtoMember(24)]
        public virtual AppExeImage Image
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets application.
        /// </summary>
        [ProtoMember(23, AsReference = true)]
        public virtual App App
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets defualt deployment profile.
        /// </summary>        
        [ProtoMember(22, AsReference = true)]
        public virtual Deployment DefaultDeployment
        {
            get;
            set;
        }

        /// <summary>
        /// Gets stats.
        /// </summary>
        [ProtoMember(15)]
        public virtual ISet<AppStat> AppStats
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets virtual cd images.
        /// </summary>
        [ProtoMember(16)]
        public virtual ISet<AppExeCdImage> AppExeCdImages
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets tasks.
        /// </summary>
        [ProtoMember(17)]
        public virtual ISet<AppExeTask> Tasks
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets personal user files.
        /// </summary>
        [ProtoMember(18)]
        public virtual ISet<AppExePersonalFile> PersonalFiles
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets deployment profiles.
        /// </summary>
        [ProtoMember(19)]
        public virtual ISet<AppExeDeployment> Deployments
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets license profiles.
        /// </summary>
        [ProtoMember(20)]
        public virtual ISet<AppExeLicense> Licenses
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets app mode max users.
        /// </summary>
        [ProtoMember(21)]
        public virtual ISet<AppExeMaxUser> MaxUsers
        {
            get;
            protected set;
        }

        #endregion
    }
}