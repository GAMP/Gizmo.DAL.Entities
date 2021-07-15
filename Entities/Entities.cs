using CoreLib;
using CyClone;
using Gizmo.DAL.Entities;
using ProtoBuf;
using SharedLib;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    #region APPCATEGORY
    /// <summary>
    /// App category entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class AppCategory : ModifiableByOperatorBase, IReplicatable
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates a new instance of the category.
        /// </summary>
        public AppCategory()
            : base()
        {
            Guid = Guid.NewGuid();
            Children = new HashSet<AppCategory>();
            Apps = new HashSet<App>();
        }

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [Required()]
        [StringLength(45)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets items guid.
        /// <remarks>This property is required to globaly identify the object. In case of exporting or importing applications it gives us ability to have unique objects.</remarks>
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        [Required()]
        public Guid Guid
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets parent id.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int? ParentId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets parent.
        /// </summary>
        public virtual AppCategory Parent
        {
            get;
            set;
        }

        /// <summary>
        /// Gets child categories.
        /// </summary>
        public virtual ISet<AppCategory> Children
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets applications.
        /// </summary>
        public virtual ISet<App> Apps
        {
            get;
            protected set;
        }

        #endregion
    }
    #endregion

    #region APP
    /// <summary>
    /// App entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class App : ModifiableByOperatorBase, IReplicatable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public App()
            : base()
        {
            Guid = Guid.NewGuid();
            AppGroups = new HashSet<AppGroupApp>();
            AppExes = new HashSet<AppExe>();
            AppLinks = new HashSet<AppLink>();
            AppStats = new HashSet<AppStat>();
            AppRatings = new HashSet<AppRating>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or Sets application title.
        /// </summary>
        [Required()]
        [ProtoMember(1)]
        [DataMember()]
        [StringLength(255)]
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or Sets application description.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or Sets application version.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        [StringLength(45)]
        public string Version
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or Sets applications genre.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int AppCategoryId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or Sets applications developer.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int? DeveloperId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or Sets applications publisher.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public int? PublisherId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets applications age rating.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public int AgeRating
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or Sets applications release date.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public DateTime? ReleaseDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or Sets application halt on error value.
        /// </summary>
        [DataMember()]
        [ProtoMember(9)]
        public AppOptionType Options
        {
            get;
            set;
        }

        /// <summary>
        /// Gets age rating type.
        /// </summary>
        [DataMember()]
        [ProtoIgnore()]
        public AgeRatingType AgeRatingType
        {
            get
            {
                if (AgeRating > 0)
                {
                    return AgeRatingType.Manual;
                }
                else if (AgeRating < 0 & AgeRating >= -20)
                {
                    return AgeRatingType.PEGI;
                }
                else if (AgeRating < -20 & AgeRating >= -40)
                {
                    return AgeRatingType.ESRB;
                }
                return AgeRatingType.None;
            }
        }

        /// <summary>
        /// Gets or sets items guid.
        /// <remarks>This property is required to globaly identify the object. In case of exporting or importing applications it gives us ability to have unique objects.</remarks>
        /// </summary>
        [DataMember()]
        [ProtoMember(10)]
        [Required()]
        public Guid Guid
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets default executable id.
        /// </summary>
        [DataMember()]
        [ProtoMember(20)]
        public int? DefaultExecutableId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets box art image binary data.
        /// </summary>
        [DataMember()]
        [ProtoMember(11)]
        public virtual AppImage Image
        {
            get;
            set;
        }

        /// <summary>
        /// Gets application category.
        /// </summary>
        [ProtoMember(12)]
        public virtual AppCategory AppCategory
        {
            get;
            set;
        }

        /// <summary>
        /// Gets developer.
        /// </summary>
        [ProtoMember(13)]
        public virtual AppEnterprise Developer
        {
            get;
            set;
        }

        /// <summary>
        /// Gets publisher.
        /// </summary>
        [ProtoMember(14)]
        public virtual AppEnterprise Publisher
        {
            get;
            set;
        }

        /// <summary>
        /// Gets executables.
        /// </summary>
        [ProtoMember(15)]
        public virtual ISet<AppExe> AppExes
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets links.
        /// </summary>
        [ProtoMember(16)]
        public virtual ISet<AppLink> AppLinks
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets app groups of app.
        /// </summary>
        [ProtoMember(17)]
        public virtual ISet<AppGroupApp> AppGroups
        {
            get; protected set;
        }

        /// <summary>
        /// Gets ratings.
        /// </summary>
        [ProtoMember(18)]
        public virtual ISet<AppRating> AppRatings
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets stats.
        /// </summary>
        [ProtoMember(19)]
        public virtual ISet<AppStat> AppStats
        {
            get;
            protected set;
        }

        #endregion
    }
    #endregion

    #region APPSTAT
    /// <summary>
    /// App stat entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class AppStat : EntityBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AppStat()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets total span.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public double Span { get; set; }

        /// <summary>
        /// Gets or sets start time.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets application id.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int AppId { get; set; }

        /// <summary>
        /// Gets or sets executable id.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int AppExeId { get; set; }

        /// <summary>
        /// Gets or sets host id.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int HostId { get; set; }

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public int UserId { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets application.
        /// </summary>
        public virtual App App
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets executable.
        /// </summary>
        public virtual AppExe AppExe
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets host.
        /// </summary>
        public virtual HostComputer Host
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public virtual UserMember User
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region APPRATING
    /// <summary>
    /// App rating entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class AppRating
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AppRating()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets value.
        /// </summary>
        [DataMember()]
        public int Value { get; set; }

        /// <summary>
        /// Gets or sets last vote time.
        /// </summary>
        [DataMember()]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets application id.
        /// </summary>
        [DataMember()]
        public int AppId { get; set; }

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        public int UserId { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets application.
        /// </summary>
        public virtual App App { get; set; }

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public virtual UserMember User { get; set; }

        #endregion
    }
    #endregion

    #region APPLINK
    /// <summary>
    /// App link entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class AppLink : ModifiableByOperatorBase, IReplicatable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AppLink()
            : base()
        {
            Guid = Guid.NewGuid();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets caption.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
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
        [ProtoMember(2)]
        [StringLength(255)]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets url.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        [Required()]
        [StringLength(255)]
        public string Url
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets display order.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int DisplayOrder
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets items guid.
        /// <remarks>This property is required to globaly identify the object. In case of exporting or importing applications it gives us ability to have unique objects.</remarks>
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        [Required()]
        public Guid Guid
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets application id.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public int AppId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets application.
        /// </summary>
        public virtual App App
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region APPIMAGE
    /// <summary>
    /// App image entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class AppImage : ImageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AppImage()
            : base()
        { }
        #endregion

        #region NAVIGATION PROPERTIES
        /// <summary>
        /// Gets or sets app.
        /// </summary>
        public virtual App App
        {
            get;
            set;
        }
        #endregion
    }
    #endregion

    #region APPEXE
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
    #endregion

    #region APPEXEMAXUSER
    /// <summary>
    /// App exe max user entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class AppExeMaxUser : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AppExeMaxUser()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets app exe id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int AppExeId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets mode.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public ApplicationModes Mode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets maximum users.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int? MaxUsers
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets app exe.
        /// </summary>
        public virtual AppExe AppExe
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region APPEXEIMAGE
    /// <summary>
    /// App exe image.
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class AppExeImage : ImageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AppExeImage()
            : base()
        { }
        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets app exe.
        /// </summary>
        public virtual AppExe AppExe
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region APPEXECDIMAGE
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
    #endregion

    #region APPEXETASK
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
    #endregion

    #region APPEXELICENSE
    /// <summary>
    /// Relation between executable and license profile.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class AppExeLicense : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AppExeLicense()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets executable id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int AppExeId { get; set; }

        /// <summary>
        /// Gets or sets license profile id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int LicenseId { get; set; }

        /// <summary>
        /// Gets or sets order.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int UseOrder { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets executable.
        /// </summary>
        public virtual AppExe AppExe { get; set; }

        /// <summary>
        /// Gets or sets license profile.
        /// </summary>
        [ProtoMember(4, AsReference = true)]
        public virtual License License { get; set; }

        #endregion
    }
    #endregion

    #region APPEXEPERSONALFILE
    /// <summary>
    /// Relation between executable and personal user file.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class AppExePersonalFile : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AppExePersonalFile()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets executable id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int AppExeId { get; set; }

        /// <summary>
        /// Gets or sets personal user file id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int PersonalFileId { get; set; }

        /// <summary>
        /// Gets or sets order.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int UseOrder { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets executable.
        /// </summary>
        public virtual AppExe AppExe { get; set; }

        /// <summary>
        /// Gets or sets personal user file.
        /// </summary>
        [ProtoMember(4, AsReference = true)]
        public virtual PersonalFile PersonalFile { get; set; }

        #endregion
    }
    #endregion

    #region APPEXEDEPLOYMENT
    /// <summary>
    /// Relation between executable and deployment profile.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class AppExeDeployment : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AppExeDeployment()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets executable id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int AppExeId { get; set; }

        /// <summary>
        /// Gets or sets deployment profile id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int DeploymentId { get; set; }

        /// <summary>
        /// Gets or sets order.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int UseOrder { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets executable.
        /// </summary>
        public virtual AppExe AppExe { get; set; }

        /// <summary>
        /// Gets or sets deployment profile.
        /// </summary>
        [ProtoMember(4, AsReference = true)]
        public virtual Deployment Deployment { get; set; }

        #endregion
    }
    #endregion

    #region APPENTERPRISE
    /// <summary>
    /// App enterprise entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class AppEnterprise : ModifiableByOperatorBase, IReplicatable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AppEnterprise()
            : base()
        {
            Guid = Guid.NewGuid();
            PublishedApps = new HashSet<App>();
            DevelopedApps = new HashSet<App>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets enterprise name.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [Required()]
        [StringLength(255)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets items guid.
        /// <remarks>This property is required to globaly identify the object. In case of exporting or importing applications it gives us ability to have unique objects.</remarks>
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        [Required()]
        public Guid Guid
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets developed applications collection.
        /// </summary>
        public virtual ISet<App> DevelopedApps
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets published applications collection.
        /// </summary>
        public virtual ISet<App> PublishedApps
        {
            get;
            protected set;
        }

        #endregion
    }
    #endregion

    #region APPGROUP
    /// <summary>
    /// App group entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class AppGroup : ModifiableByOperatorBase, IReplicatable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AppGroup()
            : base()
        {
            Guid = Guid.NewGuid();
            Apps = new HashSet<AppGroupApp>();
            HostGroups = new HashSet<HostGroup>();
            UserGroups = new HashSet<UserGroup>();
            TimeOffers = new HashSet<ProductTime>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets profile name.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [Required()]
        [StringLength(45)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets item guid.
        /// </summary>
        [Required()]
        [ProtoMember(2)]
        [DataMember()]
        public Guid Guid
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets beloning applications.
        /// </summary>
        [ProtoMember(3)]
        public virtual ISet<AppGroupApp> Apps
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets host groups that this profile belong to.
        /// </summary>
        [ProtoMember(4)]
        public virtual ISet<HostGroup> HostGroups
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets user groups that this profile belong to.
        /// </summary>
        [ProtoMember(5)]
        public virtual ISet<UserGroup> UserGroups
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets time offers.
        /// </summary>
        [ProtoMember(6)]
        public virtual ISet<ProductTime> TimeOffers
        {
            get;
            protected set;
        }

        #endregion
    }
    #endregion

    #region APPGROUPAPP
    /// <summary>
    /// App group entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class AppGroupApp
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AppGroupApp() : base()
        {
        }
        #endregion

        #region PROPERTIES
        /// <summary>
        /// Gets or sets app id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int AppId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets app group id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int AppGroupId
        {
            get; set;
        }
        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets app.
        /// </summary>
        public virtual App App
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets app group.
        /// </summary>
        public virtual AppGroup AppGroup
        {
            get; set;
        }
        #endregion
    }
    #endregion

    #region SECURITYPROFILE
    /// <summary>
    /// Security profile entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class SecurityProfile : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public SecurityProfile()
            : base()
        {
            Restrictions = new HashSet<SecurityProfileRestriction>();
            Policies = new HashSet<SecurityProfilePolicy>();
            HostGroups = new HashSet<HostGroup>();
            UserGroups = new HashSet<UserGroup>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets profile name.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [Required()]
        [StringLength(45)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets disabled drives.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int DisabledDrives
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets restrictions.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public virtual ISet<SecurityProfileRestriction> Restrictions
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets policies.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public virtual ISet<SecurityProfilePolicy> Policies
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets host groups.
        /// </summary>
        public virtual ISet<HostGroup> HostGroups
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets user groups.
        /// </summary>
        public virtual ISet<UserGroup> UserGroups
        {
            get;
            protected set;
        }

        #endregion
    }
    #endregion

    #region SECURITYPROFILERESTRICTION
    /// <summary>
    /// Base restriction class.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class SecurityProfileRestriction : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public SecurityProfileRestriction()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets restriction parameter.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [Required()]
        [StringLength(255)]
        public string Parameter
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets restriction type.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public RestrictionType Type
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets security profile id.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int SecurityProfileId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets security profile.
        /// </summary>
        public virtual SecurityProfile SecurityProfile
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region SECURITYPROFILEPOLICY
    /// <summary>
    /// Security profile policy entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class SecurityProfilePolicy : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public SecurityProfilePolicy()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets policy type.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public SecurityPolicyType Type
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets security profile id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int SecurityProfileId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets security profile.
        /// </summary>
        public virtual SecurityProfile SecurityProfile
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region SETTING
    /// <summary>
    /// Setting entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public partial class Setting : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Setting()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets setting name.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [Required()]
        [StringLength(45)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets setting value.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets setting group.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        [StringLength(45)]
        public string GroupName { get; set; }

        #endregion
    }
    #endregion

    #region NEWS
    /// <summary>
    /// News entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class News : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public News()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets feed title.
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
        /// Gets or sets feed data.
        /// <remarks>
        /// Data can be set to plain text or html.
        /// </remarks>
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public string Data
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets start date.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public DateTime? StartDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets end date.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public DateTime? EndDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets external url string.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        [StringLength(255)]
        public string Url
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets media url string.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        [StringLength(255)]
        public string MediaUrl
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region FEED
    /// <summary>
    /// Feed entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class Feed : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Feed()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets feed title.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [Required()]
        [StringLength(45)]
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets maximum results.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int Maximum
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets feed url.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        [Required()]
        [StringLength(255)]
        public string Url
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region MAPPING
    /// <summary>
    /// Mapping entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class Mapping : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Mapping()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets volume label.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [StringLength(45)]
        public string Label
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets source.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        [StringLength(255)]
        public string Source
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets mount point.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        [StringLength(255)]
        public string MountPoint
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets type.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int Type
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets size.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int Size
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets username.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        [StringLength(45)]
        public string Username
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets password.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        [StringLength(45)]
        public string Password
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets options.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public MappingFlags Options
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region VARIABLE
    /// <summary>
    /// Variable entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class Variable : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Variable()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets variable name.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [StringLength(255)]
        [Required()]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets variable value.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        [StringLength(65535)]
        [Required()]
        public string Value
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets module scope.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        [Required()]
        public ModuleScopes Scope
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets order.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        [Required()]
        public int UseOrder
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region PLUGINLIBRARY
    /// <summary>
    /// Plugin libarary entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class PluginLibrary : ModifiableByOperatorBase, IEnabled
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public PluginLibrary()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets plugin library file name.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [Required()]
        [StringLength(255)]
        public string FileName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets configuration scope.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public ModuleScopes Scope
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if library is enabled and should be loaded into process.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public bool IsEnabled
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region DEPLOYMENT
    /// <summary>
    /// Deployment entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class Deployment : FileListEntityBase, IReplicatable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Deployment()
            : base()
        {
            Guid = Guid.NewGuid();
            Dependencies = new HashSet<DeploymentDeployment>();
            Dependent = new HashSet<DeploymentDeployment>();
            DependentAppExes = new HashSet<AppExeDeployment>();
            DefaultedAppExes = new HashSet<AppExe>();
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
        /// Gets or sets registry string.
        /// </summary>
        [DataMember()]
        [StringLength(16777215)]
        [ProtoMember(2)]
        public string RegistryString
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets source.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(255)]
        [ProtoMember(3)]
        public string Source
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets destination.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(255)]
        [ProtoMember(4)]
        public string Destination
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
        /// Gets or sets comparison level.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public FileInfoLevel ComparisonLevel
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets options.
        /// </summary>
        [DataMember()]
        [Required()]
        [ProtoMember(7)]
        public DeployOptionType Options
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets dependencies.
        /// </summary>
        public virtual ISet<DeploymentDeployment> Dependencies
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets dependent.
        /// </summary>
        public virtual ISet<DeploymentDeployment> Dependent
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets dependent executables.
        /// </summary>
        public virtual ISet<AppExeDeployment> DependentAppExes
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets defaulted executables.
        /// </summary>
        public virtual ISet<AppExe> DefaultedAppExes
        {
            get;
            protected set;
        }

        #endregion
    }
    #endregion

    #region DEPLOYMENTDEPLOYMENT
    /// <summary>
    /// Deployment deployment entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class DeploymentDeployment : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public DeploymentDeployment()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets parent id.
        /// </summary>
        [DataMember()]
        public int ParentId { get; set; }

        /// <summary>
        /// Gets or sets child id.
        /// </summary>
        [DataMember()]
        public int ChildId { get; set; }

        /// <summary>
        /// Gets or sets order.
        /// </summary>
        [DataMember()]
        public int UseOrder { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets parent.
        /// </summary>
        public virtual Deployment Parent { get; set; }

        /// <summary>
        /// Gets or sets child.
        /// </summary>
        public virtual Deployment Child { get; set; }

        #endregion
    }
    #endregion

    #region PERSONALFILE
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
    #endregion

    #region LICENSE
    /// <summary>
    /// Application license entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class License : ModifiableByOperatorBase, IReplicatable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public License()
            : base()
        {
            Guid = Guid.NewGuid();
            LicenseKeys = new HashSet<LicenseKey>();
            AppExes = new HashSet<AppExeLicense>();
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
        /// Gets or sets items guid.
        /// <remarks>This property is required to globaly identify the object. 
        /// In case of exporting or importing applications it gives us ability to have unique objects.</remarks>
        /// </summary>
        [DataMember()]
        [Required()]
        [ProtoMember(2)]
        public Guid Guid
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets plugin type name.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(255)]
        [ProtoMember(3)]
        public string Plugin
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets plugin assembly.
        /// </summary>        
        [DataMember()]
        [Required()]
        [StringLength(255)]
        [ProtoMember(4)]
        public string Assembly
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets settings.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public byte[] Settings
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets executables.
        /// </summary>
        public virtual ISet<AppExeLicense> AppExes
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets licenses.
        /// </summary>
        public virtual ISet<LicenseKey> LicenseKeys
        {
            get;
            protected set;
        }

        #endregion
    }
    #endregion

    #region LICENSEKEY
    /// <summary>
    /// Application license key entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class LicenseKey : ModifiableByOperatorBase, IReplicatable, IEnabled
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public LicenseKey()
            : base()
        {
            Guid = Guid.NewGuid();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets profile id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int LicenseId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets items guid.
        /// <remarks>This property is required to globaly identify the object. 
        /// In case of exporting or importing applications it gives us ability to have unique objects.
        /// </remarks>
        /// </summary>
        [Required()]
        [DataMember()]
        [ProtoMember(2)]
        public Guid Guid
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets comment.
        /// </summary>
        [DataMember()]
        [StringLength(255)]
        [ProtoMember(3)]
        public string Comment
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if license key is enabled.
        /// <remarks>
        /// When disabled license key is not used within license reservation.
        /// </remarks>
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public bool IsEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets value.
        /// </summary>
        [IgnoreDataMember()]
        [Required()]
        [ProtoMember(5)]
        public byte[] Value
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets license.
        /// </summary>
        public virtual License License
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region LOG
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
    #endregion

    #region LOGEXCEPTION
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
    #endregion

    #region CLIENTTASK
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
    #endregion

    #region USERGROUP
    /// <summary>
    /// User group entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class UserGroup : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserGroup()
            : base()
        {
            Users = new HashSet<UserMember>();
            ProductPrices = new HashSet<ProductUserPrice>();
            DissalowedProducts = new HashSet<ProductUserDisallowed>();
            DissalowedHostGroups = new HashSet<UserGroupHostDisallowed>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [Required()]
        [StringLength(45)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        [StringLength(255)]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets app profile id.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int? AppGroupId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets security profile id.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int? SecurityProfileId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets bill profile id.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int? BillProfileId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets required user info.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public UserInfoTypes RequiredUserInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets ovverides.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public GroupOverrides Overrides
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets options.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public UserGroupOptionType Options
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets credit limit options.
        /// </summary>
        [DataMember()]
        [ProtoMember(9)]
        public CreditLimitOptionType CreditLimitOptions
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if user group allows negative balance.
        /// </summary>
        [DataMember()]
        [ProtoMember(10)]
        public bool IsNegativeBalanceAllowed
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets credit limit.
        /// </summary>
        [DataMember()]
        [ProtoMember(11)]
        public decimal CreditLimit
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets time point award options.
        /// </summary>
        [DataMember()]
        [ProtoMember(12)]
        public TimePointAwardOptionType PointsAwardOptions
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets points money ratio. 
        /// </summary>
        [DataMember()]
        [ProtoMember(13)]
        public decimal PointsMoneyRatio
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets points time multiplier.
        /// </summary>
        [DataMember()]
        [ProtoMember(14)]
        public int PointsTimeRatio
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets amount of points to award.
        /// </summary>
        [DataMember()]
        [ProtoMember(15)]
        public int? Points
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if user group is default for new users.
        /// </summary>
        [DataMember()]
        [ProtoMember(16)]
        public bool IsDefault
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if age rating is enabled for the group.
        /// </summary>
        [DataMember()]
        [ProtoMember(17)]
        public bool IsAgeRatingEnabled
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user billing option.
        /// </summary>
        [DataMember()]
        [ProtoMember(19)]
        public BillingOption BillingOptions
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user group priority.
        /// </summary>
        [DataMember()]
        [ProtoMember(20)]
        public int WaitingLinePriority
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if waiting line priority enabled.
        /// </summary>
        [DataMember()]
        [ProtoMember(21)]
        public bool IsWaitingLinePriorityEnabled
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets app profile.
        /// </summary>
        public virtual AppGroup AppGroup
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets security profile.
        /// </summary>
        public virtual SecurityProfile SecurityProfile
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets bill profile.
        /// </summary>
        public virtual BillProfile BillProfile
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets users.
        /// </summary>
        public virtual ISet<UserMember> Users { get; protected set; }

        /// <summary>
        /// Gets product prices.
        /// </summary>
        public virtual ISet<ProductUserPrice> ProductPrices { get; protected set; }

        /// <summary>
        /// Gets or sets dissalowed products.
        /// </summary>
        public virtual ISet<ProductUserDisallowed> DissalowedProducts { get; protected set; }

        /// <summary>
        /// Gets dissalowed host groups.
        /// </summary>
        [ProtoMember(18)]
        public virtual ISet<UserGroupHostDisallowed> DissalowedHostGroups { get; protected set; }

        #endregion
    }
    #endregion

    #region USERGROUPHOSTDISALLOWED
    /// <summary>
    /// User group host disallowed entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class UserGroupHostDisallowed : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserGroupHostDisallowed() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets user group.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int UserGroupId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets host group.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int HostGroupId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets disallowed value.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public bool IsDisallowed
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets user group.
        /// </summary>
        public virtual UserGroup UserGroup
        {
            get; set;
        }

        /// <summary>
        /// Gets host group.
        /// </summary>
        public virtual HostGroup HostGroup
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region USERCREDENTIAL
    /// <summary>
    /// User credential entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    public partial class UserCredential : ModifiableByUserBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserCredential()
            : base()
        {
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets password.
        /// </summary>
        public byte[] Password { get; set; }

        /// <summary>
        /// Gets or sets salt.
        /// </summary>
        public byte[] Salt { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public virtual User User { get; set; }

        #endregion
    }
    #endregion

    #region USER
    /// <summary>
    /// User base entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class User : ModifiableByUserBase,
        IDeletable,
        IDisable,
        IReplicatable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public User()
            : base()
        {
            Guid = Guid.NewGuid();
            Permissions = new HashSet<UserPermission>();
            CreatedUserSessions = new HashSet<UserSession>();
            CreatedUserSessionChanges = new HashSet<UserSessionChange>();
            Attributes = new HashSet<UserAttribute>();
            Tokens = new HashSet<Token>();
            Verifications = new HashSet<Verification>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets first name.
        /// </summary>
        [DataMember()]
        [StringLength(45)]
        [ProtoMember(1)]
        public string FirstName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets last name.
        /// </summary>
        [DataMember()]
        [StringLength(45)]
        [ProtoMember(2)]
        public string LastName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets birth date.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public DateTime? BirthDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets address.
        /// </summary>
        [DataMember()]
        [StringLength(255)]
        [ProtoMember(4)]
        public string Address
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets city.
        /// </summary>
        [DataMember()]
        [StringLength(45)]
        [ProtoMember(5)]
        public string City
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets country.
        /// </summary>
        [DataMember()]
        [StringLength(45)]
        [ProtoMember(6)]
        public string Country
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets post code.
        /// </summary>
        [DataMember()]
        [StringLength(20)]
        [ProtoMember(7)]
        public string PostCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets phone number.
        /// </summary>
        [DataMember()]
        [StringLength(20)]
        [ProtoMember(8)]
        public string Phone
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets mobile phone number.
        /// </summary>
        [DataMember()]
        [StringLength(20)]
        [ProtoMember(9)]
        public string MobilePhone
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets sex.
        /// </summary>
        [DataMember()]
        [ProtoMember(10)]
        public Sex Sex
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if user is deleted.
        /// </summary>
        [DataMember()]
        [ProtoMember(11)]
        public bool IsDeleted
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if user is enabled.
        /// </summary>
        [DataMember()]
        [ProtoMember(12)]
        public bool IsDisabled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets item guid.
        /// </summary>
        [Required()]
        [DataMember()]
        [ProtoMember(13)]
        public Guid Guid
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets SmartCard UID.
        /// </summary>
        [DataMember()]
        [StringLength(255)]
        [ProtoMember(14)]
        public string SmartCardUID
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets identification number.
        /// </summary>
        [DataMember()]
        [StringLength(255)]
        [ProtoMember(15)]
        public string Identification
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets user credentials.
        /// </summary>
        public virtual UserCredential UserCredential
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets user picture.
        /// </summary>
        public virtual UserPicture UserPicture
        {
            get;
            set;
        }

        /// <summary>
        /// Gets user claims.
        /// </summary>
        [ProtoMember(16)]
        public virtual ISet<UserPermission> Permissions
        {
            get;
            protected set;
        }

        /// <summary>
        /// Get or sets user attributes.
        /// </summary>
        [ProtoMember(17)]
        public virtual ISet<UserAttribute> Attributes
        {
            get; protected set;
        }

        /// <summary>
        /// Gets or sets created user sessions.
        /// </summary>
        public virtual ISet<UserSession> CreatedUserSessions
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets created user session changes.
        /// </summary>
        public virtual ISet<UserSessionChange> CreatedUserSessionChanges
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets user tokens.
        /// </summary>
        public virtual ISet<Token> Tokens
        {
            get; protected set;
        }

        /// <summary>
        /// Gets or sets verifications.
        /// </summary>
        public virtual ISet<Verification> Verifications
        {
            get; protected set;
        }


        #endregion
    }
    #endregion

    #region USEROPERATOR

    /// <summary>
    /// User operator entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class UserOperator : User,
        IUserNameEmail
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserOperator()
            : base()
        {
            CreatedPayments = new HashSet<Payment>();
            ModifiedPayments = new HashSet<Payment>();
            CreatedDeposits = new HashSet<DepositTransaction>();
            ModifiedDeposits = new HashSet<DepositTransaction>();
            CreatedOrders = new HashSet<ProductOrder>();
            ModifiedOrders = new HashSet<ProductOrder>();
            Shifts = new HashSet<Shift>();
            RegisterTransactions = new HashSet<RegisterTransaction>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets username.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(30)]
        [ProtoMember(1)]
        public virtual string Username { get; set; }

        /// <summary>
        /// Gets or sets email.
        /// </summary>
        [DataMember()]
        [StringLength(254)]
        [ProtoMember(2)]
        public virtual string Email { get; set; }

        /// <summary>
        /// Gets or sets shift options.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public ShiftOption ShiftOptions
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets created payments.
        /// </summary>
        public virtual ISet<Payment> CreatedPayments { get; protected set; }

        /// <summary>
        /// Gets modified payments.
        /// </summary>
        public virtual ISet<Payment> ModifiedPayments { get; protected set; }

        /// <summary>
        /// Gets created deposits.
        /// </summary>
        public virtual ISet<DepositTransaction> CreatedDeposits { get; protected set; }

        /// <summary>
        /// Gets modified deposits.
        /// </summary>
        public virtual ISet<DepositTransaction> ModifiedDeposits { get; protected set; }

        /// <summary>
        /// Gets created orders.
        /// </summary>
        public virtual ISet<ProductOrder> CreatedOrders { get; protected set; }

        /// <summary>
        /// Gets modified orders.
        /// </summary>
        public virtual ISet<ProductOrder> ModifiedOrders { get; protected set; }

        /// <summary>
        /// Gets or sets opeator shifts.
        /// </summary>
        public virtual ISet<Shift> Shifts
        {
            get; protected set;
        }

        /// <summary>
        /// Gets register transactions.
        /// </summary>
        public virtual ISet<RegisterTransaction> RegisterTransactions
        {
            get; protected set;
        }

        #endregion
    }

    #endregion

    #region USERMEMBER
    /// <summary>
    /// User member entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class UserMember : User,
        IUserNameEmail
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserMember()
            : base()
        {
            UserSessions = new HashSet<UserSession>();
            UserSessionsChanges = new HashSet<UserSessionChange>();

            AppRatings = new HashSet<AppRating>();
            AppStats = new HashSet<AppStat>();
            Payments = new HashSet<Payment>();
            Deposits = new HashSet<DepositTransaction>();
            LoayalityPoints = new HashSet<PointTransaction>();

            ProductOrders = new HashSet<ProductOrder>();
            ProductOrdersLines = new HashSet<ProductOL>();

            Invoices = new HashSet<Invoice>();
            InvoicePayments = new HashSet<InvoicePayment>();
            DepositPayments = new HashSet<DepositPayment>();
            InvoiceLines = new HashSet<InvoiceLine>();

            UsageSessions = new HashSet<UsageSession>();
            Usage = new HashSet<Usage>();
            Notes = new HashSet<UserNote>();

            AssetTransactions = new HashSet<AssetTransaction>();

            Reservations = new HashSet<Reservation>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets username.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(30)]
        [ProtoMember(1)]
        public virtual string Username { get; set; }

        /// <summary>
        /// Gets or sets email.
        /// </summary>
        [DataMember()]
        [StringLength(254)]
        [ProtoMember(2)]
        public virtual string Email { get; set; }

        /// <summary>
        /// Gets or sets users group id.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int UserGroupId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if user allowed to have negative balance.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public bool? IsNegativeBalanceAllowed
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if personal info is requested.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public bool IsPersonalInfoRequested
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets billing options.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public BillingOption? BillingOptions
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user re-enable date-time.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public DateTime? EnableDate
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets disabled date-time.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public DateTime? DisabledDate
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets user credit limit.
        /// </summary>
        public virtual UserCreditLimit UserCreditLimit
        {
            get;
            set;
        }

        /// <summary>
        /// Gets user group.
        /// </summary>
        public virtual UserGroup UserGroup
        {
            get;
            set;
        }

        /// <summary>
        /// Gets user sessions.
        /// </summary>
        public virtual ISet<UserSession> UserSessions
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets session changes.
        /// </summary>
        public virtual ISet<UserSessionChange> UserSessionsChanges
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets app ratings.
        /// </summary>
        public virtual ISet<AppRating> AppRatings
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets app stats.
        /// </summary>
        public virtual ISet<AppStat> AppStats
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets payments.
        /// </summary>
        public virtual ISet<Payment> Payments
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets deposits.
        /// </summary>
        public virtual ISet<DepositTransaction> Deposits
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets loyality points.
        /// </summary>
        public virtual ISet<PointTransaction> LoayalityPoints
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets user orders.
        /// </summary>
        public virtual ISet<ProductOL> ProductOrdersLines
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets product orders.
        /// </summary>
        public virtual ISet<ProductOrder> ProductOrders
        {
            get; protected set;
        }

        /// <summary>
        /// Gets invoice lines.
        /// </summary>
        public virtual ISet<InvoiceLine> InvoiceLines
        {
            get; protected set;
        }

        /// <summary>
        /// Gets invoices.
        /// </summary>
        public virtual ISet<Invoice> Invoices
        {
            get; protected set;
        }

        /// <summary>
        /// Gets invoice payments.
        /// </summary>
        public virtual ISet<InvoicePayment> InvoicePayments
        {
            get; protected set;
        }

        /// <summary>
        /// Gets deposit payments.
        /// </summary>
        public virtual ISet<DepositPayment> DepositPayments
        {
            get; protected set;
        }

        /// <summary>
        /// Gets bill sessions.
        /// </summary>
        public virtual ISet<UsageSession> UsageSessions
        {
            get; protected set;
        }

        /// <summary>
        /// Gets or sets usage.
        /// </summary>
        public virtual ISet<Usage> Usage
        {
            get; protected set;
        }

        /// <summary>
        /// Get or sets user notes.
        /// </summary>
        public virtual ISet<UserNote> Notes
        {
            get; set;
        }

        /// <summary>
        /// Gets asset transactions.
        /// </summary>
        public virtual ISet<AssetTransaction> AssetTransactions
        {
            get; protected set;
        }

        /// <summary>
        /// Gets reservations.
        /// </summary>
        public virtual ISet<Reservation> Reservations
        {
            get; protected set;
        }

        #endregion
    }
    #endregion       

    #region USERGUEST
    /// <summary>
    /// User guest entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class UserGuest : UserMember
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserGuest()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets account is joint.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public bool IsJoined
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if guest user is reserved.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public bool IsReserved
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets reserved host id.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int? ReservedHostId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets reserved slot.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int? ReservedSlot
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets reserved host
        /// </summary>
        public virtual Host ReservedHost
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region USERPERMISSION
    /// <summary>
    /// Premission entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class UserPermission : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserPermission()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets permission type.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(255)]
        [ProtoMember(1)]
        public string Type
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets permission value.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(255)]
        [ProtoMember(2)]
        public string Value
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int UserId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public virtual User User
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region USERCREDITLIMIT
    /// <summary>
    /// User credit limit entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class UserCreditLimit : ModifiableByOperatorBase, IEnabled
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserCreditLimit() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets credit limit.
        /// </summary>
        [DataMember()]
        public decimal CreditLimit
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if credit limit is enabled.
        /// </summary>
        [DataMember()]
        public bool IsEnabled
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public virtual UserMember User
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region USERPICTURE
    /// <summary>
    /// User picture entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class UserPicture : ModifiableByUserCreatedByUserBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserPicture()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets picture data.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public byte[] Picture
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets user.
        /// </summary>
        public virtual User User
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region USERSESSION
    /// <summary>
    /// User session entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public partial class UserSession : CreatedByUserBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserSession()
        {
            UserSessionChanges = new HashSet<UserSessionChange>();
            Usage = new HashSet<UsageUserSession>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int UserId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets host Id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int HostId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets session state.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public SessionState State
        {
            get;
            set;
        }

        /// <summary>
        /// Gets total span.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public double Span
        {
            get;
            set;
        }

        /// <summary>
        /// Gets amount of seconds billed in session active span.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public double BilledSpan
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets session last pend time.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public DateTime? PendTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets pend span.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public double PendSpan
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets session end time.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public DateTime? EndTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets session slot.
        /// </summary>
        [DataMember()]
        [ProtoMember(10)]
        public int Slot
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets total pend span.
        /// </summary>
        [DataMember()]
        [ProtoMember(11)]
        public double PendSpanTotal
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets pause span.
        /// </summary>
        [DataMember()]
        [ProtoMember(12)]
        public double PauseSpan
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets total pause span.
        /// </summary>
        [DataMember()]
        [ProtoMember(13)]
        public double PauseSpanTotal
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets host.
        /// </summary>
        public virtual Host Host
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public virtual UserMember User
        {
            get;
            set;
        }

        /// <summary>
        /// Gets user session states.
        /// </summary>
        [ProtoMember(9)]
        public virtual ISet<UserSessionChange> UserSessionChanges
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets usage.
        /// </summary>
        public virtual ISet<UsageUserSession> Usage
        {
            get;
            protected set;
        }

        #endregion
    }
    #endregion

    #region USERSESSIONCHANGE
    /// <summary>
    /// User session change entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class UserSessionChange : CreatedByUserBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserSessionChange()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets user session id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int UserSessionId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int UserId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets host id.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int HostId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets state.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public SessionState State
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets session span.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public double Span
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets session slot.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public int Slot
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets user session.
        /// </summary>
        public virtual UserSession UserSession
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets host.
        /// </summary>
        public virtual Host Host
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public virtual UserMember User
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region HOST
    /// <summary>
    /// Host entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class Host : ModifiableByOperatorBase, IDeletable , IReplicatable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Host()
            : base()
        {
            UserSessions = new HashSet<UserSession>();
            UserSessionsChanges = new HashSet<UserSessionChange>();
            Layouts = new HashSet<HostLayoutGroupLayout>();
            ReservedGuests = new HashSet<UserGuest>();
            ProductOrders = new HashSet<ProductOrder>();
            Devices = new HashSet<DeviceHost>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets host number.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int Number { get; set; }

        /// <summary>
        /// Gets or sets host name.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(45)]
        [ProtoMember(2)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets host group.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int? HostGroupId { get; set; }

        /// <summary>
        /// Gets or sets host state.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public HostState State { get; set; }

        /// <summary>
        /// Gets or sets icon id.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int? IconId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if host is deleted.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public bool IsDeleted
        {
            get; set;
        }

        /// <inheritdoc/>
        public Guid Guid
        {
            get;set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets icon.
        /// </summary>
        public virtual Icon Icon { get; set; }

        /// <summary>
        /// Gets or sets host group.
        /// </summary>
        public virtual HostGroup HostGroup { get; set; }

        /// <summary>
        /// Gets user sessions.
        /// </summary>
        public virtual ISet<UserSession> UserSessions { get; protected set; }

        /// <summary>
        /// Gets user sessions log.
        /// </summary>
        public virtual ISet<UserSessionChange> UserSessionsChanges { get; protected set; }

        /// <summary>
        /// Gets host layouts.
        /// </summary>
        public virtual ISet<HostLayoutGroupLayout> Layouts { get; protected set; }

        /// <summary>
        /// Gets reserved guest users.
        /// </summary>
        public virtual ISet<UserGuest> ReservedGuests
        {
            get; protected set;
        }

        /// <summary>
        /// Gets or sets product orders.
        /// </summary>
        public virtual ISet<ProductOrder> ProductOrders
        {
            get; protected set;
        }

        /// <summary>
        /// Gets associated devices.
        /// </summary>
        public virtual ISet<DeviceHost> Devices
        {
            get; protected set;
        }

        #endregion
    }
    #endregion

    #region HOSTCOMPUTER
    /// <summary>
    /// Host computer entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class HostComputer : Host
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public HostComputer()
            : base()
        {
            AppStats = new HashSet<AppStat>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets hostname.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(255)]
        [ProtoMember(1)]
        public string Hostname { get; set; }

        /// <summary>
        /// Gets or sets mac address.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(255)]
        [ProtoMember(2)]
        public string MACAddress { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets application stats.
        /// </summary>
        public virtual ISet<AppStat> AppStats { get; protected set; }

        #endregion
    }
    #endregion

    #region HOSTENDPOINT
    /// <summary>
    /// Host endpoint entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class HostEndpoint : Host
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public HostEndpoint()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets maximum users.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int MaximumUsers
        {
            get;
            set;
        }

        #endregion
    }
    #endregion    

    #region HOSTGROUP
    /// <summary>
    /// Host group entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class HostGroup : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public HostGroup()
            : base()
        {
            Hosts = new HashSet<Host>();
            DisallowedTimeOffers = new HashSet<ProductTimeHostDisallowed>();
            DisallowedUserGroups = new HashSet<UserGroupHostDisallowed>();
            UserBillProfiles = new HashSet<HostGroupUserBillProfile>();
            WaitingLineEntries = new HashSet<HostGroupWaitingLineEntry>();
            HiddenProducts = new HashSet<ProductHostHidden>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [Required()]
        [StringLength(45)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets skin name.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        [StringLength(255)]
        public string SkinName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if shell is enabled.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public HostGroupOptionType Options
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets app profile id.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int? AppGroupId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets security profile id.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int? SecurityProfileId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets default guest group id.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public int? DefaultGuestGroupId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets waiting line.
        /// </summary>
        public virtual HostGroupWaitingLine WaitingLine
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets default guest group.
        /// </summary>
        public virtual UserGroup DefaultGuestGroup
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets app profile.
        /// </summary>
        public virtual AppGroup AppGroup
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets security profile.
        /// </summary>
        public virtual SecurityProfile SecurityProfile
        {
            get;
            set;
        }

        /// <summary>
        /// Gets hosts in this host group.
        /// </summary>
        public virtual ISet<Host> Hosts { get; protected set; }

        /// <summary>
        /// Gets or sets disallowed offers for this host group.
        /// </summary>
        public virtual ISet<ProductTimeHostDisallowed> DisallowedTimeOffers { get; protected set; }

        /// <summary>
        /// Gets or sets dissalowed user groups.
        /// </summary>
        public virtual ISet<UserGroupHostDisallowed> DisallowedUserGroups { get; protected set; }

        /// <summary>
        /// Gets user group bill profiles.
        /// </summary>
        [ProtoMember(100)]
        public virtual ISet<HostGroupUserBillProfile> UserBillProfiles { get; protected set; }

        /// <summary>
        /// Gets or sets dissalowed user groups.
        /// </summary>
        public virtual ISet<ProductHostHidden> HiddenProducts { get; protected set; }

        /// <summary>
        /// Gets waiting line entries for this host group.
        /// </summary>
        public virtual ISet<HostGroupWaitingLineEntry> WaitingLineEntries
        {
            get; protected set;
        }

        #endregion
    }
    #endregion

    #region TASKSCRIPT
    /// <summary>
    /// Task Script entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class TaskScript : TaskBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public TaskScript()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets script type.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public ScriptTypes ScriptType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets data.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        [Required()]
        [StringLength(65535)]
        public string Data
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets process options.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public TaskProcessOptionType ProcessOptions
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region TASKPROCESS
    /// <summary>
    /// Task process entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class TaskProcess : TaskBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public TaskProcess()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets process file name.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [Required()]
        [StringLength(255)]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets arguments.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        [StringLength(255)]
        public string Arguments { get; set; }

        /// <summary>
        /// Gets or sets working directory.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        [StringLength(255)]
        public string WorkingDirectory { get; set; }

        /// <summary>
        /// Gets or sets user name.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        [StringLength(45)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets password.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        [StringLength(45)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets options.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public TaskProcessOptionType ProcessOptions
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region TASKNOTIFICATION
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
    #endregion

    #region TASKJUNCTION
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
    #endregion

    #region HOSTLAYOUTGROUP
    /// <summary>
    /// Host layout group entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class HostLayoutGroup : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public HostLayoutGroup()
            : base()
        {
            Layouts = new HashSet<HostLayoutGroupLayout>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(45)]
        [ProtoMember(1)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets display order.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int DisplayOrder
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets layout group image.
        /// </summary>
        public virtual HostLayoutGroupImage Image
        {
            get;
            set;
        }

        /// <summary>
        /// Gets layouts.
        /// </summary>
        [ProtoMember(3)]
        public virtual ISet<HostLayoutGroupLayout> Layouts
        {
            get;
            protected set;
        }

        #endregion
    }
    #endregion

    #region HOSTLAYOUTGROUPLAYOUT
    /// <summary>
    /// Host layout entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class HostLayoutGroupLayout : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public HostLayoutGroupLayout()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets x position.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int X
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets y postion.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int Y
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets width.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int Width
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets height.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int Height
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if host layout is hidden.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public bool IsHidden
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets layout group id.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public int HostLayoutGroupId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets host id.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public int HostId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets layout group.
        /// </summary>
        public virtual HostLayoutGroup HostLayoutGroup
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets host.
        /// </summary>
        public virtual Host Host
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region HOSTLAYOUTGROUPIMAGE
    /// <summary>
    /// Host layout group image entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class HostLayoutGroupImage : ImageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public HostLayoutGroupImage()
            : base()
        { }
        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets layout group.
        /// </summary>
        public virtual HostLayoutGroup HostLayoutGroup
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region ICON
    /// <summary>
    /// Icon entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class Icon : ImageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Icon()
            : base()
        { }
        #endregion
    }
    #endregion

    #region ATTRIBUTE
    /// <summary>
    /// Attribute entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class Attribute : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Attribute() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets attribute name.
        /// </summary>
        [Required()]
        [StringLength(45)]
        [DataMember()]
        [ProtoMember(1)]
        public string Name
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets friendly name.
        /// </summary>
        [StringLength(45)]
        [DataMember()]
        [ProtoMember(2)]
        public string FriendlyName
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region USERATTRIBUTE
    /// <summary>
    /// User attribute entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class UserAttribute : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserAttribute() : base()
        { }
        #endregion

        #region PROPERIES

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int UserId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets attribute id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int AttributeId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets attribute value.
        /// </summary>
        [StringLength(255)]
        [DataMember()]
        [ProtoMember(3)]
        public string Value
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public virtual User User
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets attribute.
        /// </summary>
        public virtual Attribute Attribute
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region BILLING

    #region MONETARYUNIT
    /// <summary>
    /// Monetary unit entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class MonetaryUnit : ModifiableByOperatorBase, IDeletable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public MonetaryUnit() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [DataMember()]
        [Required()]
        [ProtoMember(1)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets value.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public decimal Value
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets display order.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int DisplayOrder
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if entity is deleted.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public bool IsDeleted
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region PAYMENTMETHOD
    /// <summary>
    /// Payment method entity.
    /// </summary>
    [Serializable()]
    [DataContract]
    [ProtoContract()]
    public class PaymentMethod : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new payment method instance.
        /// </summary>
        public PaymentMethod() : base()
        {
            Payments = new HashSet<Payment>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets name.
        /// </summary>
        [DataMember()]
        [Required()]
        [StringLength(45)]
        [ProtoMember(1)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets description.
        /// </summary>
        [DataMember()]
        [StringLength(255)]
        [ProtoMember(2)]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets surcharge.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public decimal Surcharge
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets display order.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int DisplayOrder
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if payment method is enabled.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public bool IsEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets options.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public PaymentMethodOptionType Options
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if payment method can be used by client.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public bool IsClient
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if payment method can be used by manager.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public bool IsManager
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if payment method can be used by web portal.
        /// </summary>
        [DataMember()]
        [ProtoMember(9)]
        public bool IsPortal
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if payment method can be used by web portal.
        /// </summary>
        [DataMember()]
        [ProtoMember(10)]
        public bool IsDeleted
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets payments done with this method.
        /// </summary>
        public virtual ISet<Payment> Payments { get; protected set; }

        #endregion
    }
    #endregion

    #region TAX
    /// <summary>
    /// Tax entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class Tax : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Tax() : base()
        {
            Products = new HashSet<ProductTax>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Tax name.
        /// </summary>
        [StringLength(45)]
        [Required()]
        [DataMember()]
        [ProtoMember(1)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Tax value.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public decimal Value
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets use order.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int UseOrder
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets products using this tax.
        /// </summary>
        public virtual ISet<ProductTax> Products
        {
            get;
            protected set;
        }

        #endregion
    }
    #endregion

    #region PRODUCTGROUP
    /// <summary>
    /// Product group entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class ProductGroup : ModifiableByOperatorBase,
        IReplicatable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance of product group.
        /// </summary>
        public ProductGroup()
            : base()
        {
            Guid = Guid.NewGuid();
            ChildGroups = new HashSet<ProductGroup>();
            Products = new HashSet<ProductBase>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [StringLength(45)]
        [DataMember()]
        [ProtoMember(1)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets parent id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int? ParentId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets display order.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int DisplayOrder
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets sort options.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public ProductSortOptionType SortOption
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets entity guid.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public Guid Guid
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets parent.
        /// </summary>
        public virtual ProductGroup Parent
        {
            get;
            set;
        }

        /// <summary>
        /// Gets child groups.
        /// </summary>
        public virtual ISet<ProductGroup> ChildGroups
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets products.
        /// </summary>
        public virtual ISet<ProductBase> Products
        {
            get;
            protected set;
        }

        #endregion
    }
    #endregion

    #region PRODUCTPERIOD
    /// <summary>
    /// Product period entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class ProductPeriod : PeriodDate
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductPeriod() : base()
        {
            Days = new HashSet<ProductPeriodDay>();
        }
        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets product time.
        /// </summary>
        public virtual ProductBase Product
        {
            get;
            set;
        }

        /// <summary>
        /// Gets days of week.
        /// </summary>
        [ProtoMember(1)]
        public virtual ISet<ProductPeriodDay> Days
        {
            get;
            protected set;
        }

        #endregion
    }
    #endregion

    #region PRODUCTPERIODDAY
    /// <summary>
    /// Product period day entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class ProductPeriodDay : PeriodDay
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductPeriodDay() : base()
        {
            Times = new HashSet<ProductPeriodDayTime>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets period id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int ProductPeriodId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets period.
        /// </summary>
        public ProductPeriod Period
        {
            get;
            set;
        }

        /// <summary>
        /// Gets period day times.
        /// </summary>
        [ProtoMember(2)]
        public virtual ISet<ProductPeriodDayTime> Times
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region PRODUCTPERIODDAYTIME
    /// <summary>
    /// Product perido day time entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class ProductPeriodDayTime : PeriodDayTime
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductPeriodDayTime() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets time offer period day id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int PeriodDayId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets time period day.
        /// </summary>
        public virtual ProductPeriodDay Day
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region PRODUCTTIMEPERIOD
    /// <summary>
    /// Product time period entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class ProductTimePeriod : PeriodDate
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductTimePeriod() : base()
        {
            Days = new HashSet<ProductTimePeriodDay>();
        }
        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets product time.
        /// </summary>
        public virtual ProductTime ProductTime
        {
            get; set;
        }

        /// <summary>
        /// Gets days of week.
        /// </summary>
        [ProtoMember(1)]
        public ISet<ProductTimePeriodDay> Days
        {
            get; protected set;
        }

        #endregion
    }
    #endregion

    #region PRODUCTTIMEPERIODDAY
    /// <summary>
    /// Product time period day.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class ProductTimePeriodDay : PeriodDay
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductTimePeriodDay() : base()
        {
            Times = new HashSet<ProductTimePeriodDayTime>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets period id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int ProductTimePeriodId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets period.
        /// </summary>
        public virtual ProductTimePeriod Period
        {
            get; set;
        }

        /// <summary>
        /// Gets or set day times.
        /// </summary>
        [ProtoMember(2)]
        public virtual ISet<ProductTimePeriodDayTime> Times
        {
            get; protected set;
        }

        #endregion
    }
    #endregion

    #region PRODUCTTIMEPERIODDAYTIME
    /// <summary>
    /// Product time period day time.
    /// </summary>
    [DataContract()]
    [Serializable()]
    public class ProductTimePeriodDayTime : PeriodDayTime
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductTimePeriodDayTime() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets period day id.
        /// </summary>
        [DataMember()]
        public int PeriodDayId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets time period day.
        /// </summary>
        public virtual ProductTimePeriodDay Day
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region PRODUCT
    /// <summary>
    /// Product entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class Product : ProductBaseExtended
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Product()
            : base()
        {
        }
        #endregion
    }
    #endregion

    #region PRODUCTTAX
    /// <summary>
    /// Product tax entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class ProductTax : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductTax() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets product id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int ProductId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets tax id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int TaxId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets use order.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int UseOrder
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if tax is enabled.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public bool IsEnabled { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets product.
        /// </summary>
        public virtual ProductBase Product
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets tax.
        /// </summary>
        public virtual Tax Tax
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region PRODUCTUSERPRICE
    /// <summary>
    /// Product user price entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class ProductUserPrice : UserGroupPriceBase, IEnabled
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new product user price instance.
        /// </summary>
        public ProductUserPrice()
            : base()
        {
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets product id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int ProductId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if product user price is enabled.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public bool IsEnabled
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets product.
        /// </summary>
        public virtual ProductBase Product
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region PRODUCTUSERDISALLOWED
    /// <summary>
    /// Product user disallowed enttiy.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class ProductUserDisallowed : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new product user disallowed instance.
        /// </summary>
        public ProductUserDisallowed() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets user group.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int UserGroupId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets product.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int ProductId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets disallowed value.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public bool IsDisallowed
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets product.
        /// </summary>
        public virtual ProductBase Product
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user group.
        /// </summary>
        public virtual UserGroup UserGroup
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region PRODUCTHOSTHIDDEN
    /// <summary>
    /// Product host hidden entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class ProductHostHidden : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductHostHidden() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets host group id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int HostGroupId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets product id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int ProductId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets hidden value.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public bool IsHidden
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets host group.
        /// </summary>
        public virtual HostGroup HostGroup
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets product.
        /// </summary>
        public virtual ProductBase Product
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region PRODCUTIMAGE
    /// <summary>
    /// Product image entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class ProductImage : ImageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new product image instance.
        /// </summary>
        public ProductImage() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets product id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int ProductId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets product.
        /// </summary>
        public virtual ProductBase Product
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region PRODUCTTIME
    /// <summary>
    /// Product time entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class ProductTime : ProductBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductTime()
            : base()
        {
            DisallowedHostsGroup = new HashSet<ProductTimeHostDisallowed>();
            OrderLines = new HashSet<ProductOLTime>();
            InvoiceLines = new HashSet<InvoiceLineTime>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets minutes.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int Minutes
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets weekday maximum minutes.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        [Range(1, 7200)]
        public int? WeekDayMaxMinutes
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets weekend maximum minutes.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        [Range(1, 2880)]
        public int? WeekEndMaxMinutes
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets app profile id.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int? AppGroupId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets expire after days.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int ExpiresAfter
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets expiration options.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public ProductTimeExpirationOptionType ExpirationOptions
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets expire from options.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public ExpireFromOptionType ExpireFromOptions
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets usage options.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public ProductTimeUsageOptionType UsageOptions
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets use order.
        /// </summary>
        [DataMember()]
        [ProtoMember(9)]
        public int UseOrder
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets expire after type.
        /// </summary>
        [DataMember()]
        [ProtoMember(12)]
        public ExpireAfterType ExpireAfterType
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets expire at day time minute.
        /// </summary>
        [DataMember()]
        [ProtoMember(13)]
        public int ExpireAtDayTimeMinute
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets use period.
        /// </summary>
        [ProtoMember(10)]
        public virtual ProductTimePeriod UsePeriod
        {
            get; set;
        }

        /// <summary>
        /// Gets disallowed host groups.
        /// </summary>
        [ProtoMember(11)]
        public virtual ISet<ProductTimeHostDisallowed> DisallowedHostsGroup
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets AppProfile.
        /// </summary>
        public virtual AppGroup AppGroup
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets order lines.
        /// </summary>
        public virtual ISet<ProductOLTime> OrderLines
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets invoice lines.
        /// </summary>
        public virtual ISet<InvoiceLineTime> InvoiceLines
        {
            get;
            protected set;
        }

        #endregion
    }
    #endregion

    #region PRODUCTTIMEHOSTDISALLOWED
    /// <summary>
    /// Product time host disallowed entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class ProductTimeHostDisallowed : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductTimeHostDisallowed() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets host group id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int HostGroupId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets product time id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int ProductTimeId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets disallowed value.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public bool IsDisallowed
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets host group.
        /// </summary>
        public virtual HostGroup HostGroup
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets product time.
        /// </summary>
        public virtual ProductTime ProductTime
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region PRODUCTBUNDLE
    /// <summary>
    /// Product bundle entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class ProductBundle : ProductBaseExtended
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductBundle()
            : base()
        {
            BundledProducts = new HashSet<BundleProduct>();
            UserPrices = new HashSet<ProductBundleUserPrice>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets bundle stock options.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public BundleStockOptionType BundleStockOptions
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets bundled products.
        /// </summary>
        [ProtoMember(2)]
        public virtual ISet<BundleProduct> BundledProducts
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets user group prices.
        /// </summary>
        [ProtoMember(3)]
        public virtual ISet<ProductBundleUserPrice> UserPrices
        {
            get; protected set;
        }

        #endregion
    }
    #endregion

    #region PRODUCTBUNDLEUSERPRICE
    /// <summary>
    /// Product Bundle user price.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class ProductBundleUserPrice : UserGroupPriceBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductBundleUserPrice() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets product bundle product id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int ProductBundleId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets product bundle.
        /// </summary>
        public virtual ProductBundle ProductBundle
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region BUNDLEPRODUCT
    /// <summary>
    /// Bundle product entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class BundleProduct : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public BundleProduct()
            : base()
        {
            UserPrices = new HashSet<BundleProductUserPrice>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets quantity.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public decimal Quantity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets price.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public decimal Price
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets bundle id.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int ProductBundleId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets product id.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int ProductId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets display order.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int DisplayOrder
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets options.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public ProductBundleOptionType Options
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets user group prices.
        /// </summary>
        [ProtoMember(7)]
        public virtual ISet<BundleProductUserPrice> UserPrices
        {
            get; protected set;
        }

        /// <summary>
        /// Gets or sets bundle.
        /// </summary>
        public virtual ProductBundle ProductBundle
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets product.
        /// </summary>
        public virtual ProductBase Product
        {
            get;
            set;
        }

        #endregion
    }
    #endregion

    #region BUNDLEPRODUCTUSERPRICE
    /// <summary>
    /// Bundle product user price.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class BundleProductUserPrice : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public BundleProductUserPrice() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets product bundle id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int BundleProductId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user group id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int UserGroupId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets price.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public decimal? Price
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Get or sets bundle product.
        /// </summary>
        public virtual BundleProduct BundleProduct
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user group.
        /// </summary>
        public virtual UserGroup UserGroup
        {
            get; set;
        }

        #endregion
    }
    #endregion    

    #region BILLPROFILE
    /// <summary>
    /// Bill profile entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class BillProfile : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public BillProfile() : base()
        {
            BillRates = new HashSet<BillRate>();
            UserGroups = new HashSet<UserGroup>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [StringLength(45)]
        [Required()]
        [DataMember()]
        [ProtoMember(1)]
        public string Name
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets rates.
        /// </summary>
        [ProtoMember(2)]
        public virtual ISet<BillRate> BillRates
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets user groups.
        /// </summary>
        public virtual ISet<UserGroup> UserGroups
        {
            get; protected set;
        }

        #endregion
    }
    #endregion

    #region BILLRATE
    /// <summary>
    /// Bill rate entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class BillRate : EntityBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public BillRate() : base()
        {
            BillRateSteps = new HashSet<BillRateStep>();
            Days = new HashSet<BillRatePeriodDay>();
            Usage = new HashSet<UsageRate>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets start fee.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public decimal StartFee
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets mimum fee.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public decimal MinimumFee
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets rate.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public decimal Rate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets amount of time charge will occur.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int ChargeEvery
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets amount of time that after which charge will start. 
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int ChargeAfter
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets rate options.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public BillRateOptionType Options
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if rate is default.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public bool IsDefault
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets billing profile id.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public int BillProfileId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets billing profile.
        /// </summary>
        public virtual BillProfile BillProfile
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets period days.
        /// </summary>
        [DataMember()]
        [ProtoMember(9)]
        public virtual ISet<BillRatePeriodDay> Days
        {
            get; protected set;
        }

        /// <summary>
        /// Gets  steps.
        /// </summary>
        [DataMember()]
        [ProtoMember(10)]
        public virtual ISet<BillRateStep> BillRateSteps
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets usages.
        /// </summary>
        public virtual ISet<UsageRate> Usage
        {
            get; protected set;
        }

        #endregion
    }
    #endregion

    #region BILLRATESTEP
    /// <summary>
    /// Bill rate setp entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class BillRateStep : EntityBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public BillRateStep() : base()
        {
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets step minute.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int Minute
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets action.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public BillRateStepAction Action
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets charge value.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public decimal Charge
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets rate value.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public decimal Rate
        {
            get; set;
        }

        /// <summary>
        /// Get or sets target minute.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int TargetMinute
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets billing rate id.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        [Required()]
        public int BillRateId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets billing rate.
        /// </summary>
        public virtual BillRate BillRate
        {
            get;
            set;
        }

        #endregion
    }
    #endregion    

    #region BILLRATEPERIODDAY
    /// <summary>
    /// Bill rate period day entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class BillRatePeriodDay : PeriodDay
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public BillRatePeriodDay() : base()
        {
            Times = new HashSet<BillRatePeriodDayTime>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets bill rate period.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int BillRateId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets bill rate.
        /// </summary>
        public virtual BillRate BillRate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets period day times.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public virtual ISet<BillRatePeriodDayTime> Times
        {
            get;
            protected set;
        }

        #endregion
    }
    #endregion

    #region BILLRATEPERIODDAYTIME
    /// <summary>
    /// Bill rate period day time entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class BillRatePeriodDayTime : PeriodDayTime
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public BillRatePeriodDayTime() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets time period day id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int PeriodDayId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES
        /// <summary>
        /// Gets or sets period day.
        /// </summary>
        public virtual BillRatePeriodDay Day
        {
            get;
            set;
        }
        #endregion
    }
    #endregion

    #region USAGESESSION
    /// <summary>
    /// Usage session.
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class UsageSession : EntityBase, IModifiable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UsageSession() : base()
        {
            Usage = new HashSet<Usage>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        public int UserId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets current usage id.
        /// </summary>
        [DataMember()]
        public int? CurrentUsageId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets current second.
        /// </summary>
        [DataMember()]
        public double CurrentSecond
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets amount of negative seconds in this usage session.
        /// </summary>
        [DataMember()]
        public double NegativeSeconds
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets start fee.
        /// </summary>
        [DataMember()]
        public decimal StartFee
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets minimum fee.
        /// </summary>
        [DataMember()]
        public decimal MinimumFee
        {
            get; set;
        }

        /// <summary>
        /// Gets total amount charged in rate.
        /// </summary>
        [DataMember()]
        public decimal RatesTotal
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if session is active.
        /// </summary>
        [DataMember()]
        public bool IsActive
        {
            get; set;
        }

        /// <summary>
        /// Gets or set modified time.
        /// </summary>
        [DataMember()]
        public DateTime? ModifiedTime
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets created time.
        /// </summary>
        [DataMember()]
        public DateTime CreatedTime
        {
            get; set;
        }

        /// <summary>
        /// Indicates that when entity is saved creation time shouldnt be set automatically.
        /// </summary>
        [NotMapped()]
        public bool IgnoreCreatedUpdate
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates that when entity is saved update time and user shouldnt be set automatically.
        /// </summary>
        [NotMapped()]
        public bool IgnoreUpdatedUpdate { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public virtual UserMember User
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets current usage.
        /// </summary>
        public virtual Usage CurrentUsage
        {
            get; set;
        }

        /// <summary>
        /// Gets usages.
        /// </summary>
        public virtual ISet<Usage> Usage
        {
            get; protected set;
        }

        #endregion
    }
    #endregion

    #region USAGETIME
    /// <summary>
    /// Usage time entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    public class UsageTime : UsageUserSession
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UsageTime() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets product time order line id.
        /// </summary>
        [DataMember()]
        public int InvoiceLineId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES
        /// <summary>
        /// Gets or sets product time invoice line.
        /// </summary>
        public virtual InvoiceLineTime InvoiceLine
        {
            get; set;
        }
        #endregion
    }
    #endregion

    #region USAGETIMEFIXED
    /// <summary>
    /// Usage time fixed.
    /// </summary>
    [DataContract()]
    [Serializable()]
    public class UsageTimeFixed : UsageUserSession
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UsageTimeFixed() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets product time fixed order line id.
        /// </summary>
        public int InvoiceLineId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES
        /// <summary>
        /// Gets or sets product time fixed invoice line.
        /// </summary>
        public virtual InvoiceLineTimeFixed InvoiceLine
        {
            get; set;
        }
        #endregion
    }
    #endregion

    #region USAGERATE
    /// <summary>
    /// Rate usage entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    public class UsageRate : UsageUserSession
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UsageRate() : base()
        {
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets bill profile rate id.
        /// </summary>
        [DataMember()]
        public int BillRateId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets total.
        /// </summary>
        [DataMember()]
        public decimal Total
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets rate.
        /// </summary>
        [DataMember()]
        public decimal Rate
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets bill profile time stamp.
        /// </summary>
        [DataMember()]
        public DateTime BillProfileStamp
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets bill rate.
        /// </summary>
        public virtual BillRate BillRate
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region DEPOSITTRANSACTION
    /// <summary>
    /// Deposit transaction entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class DepositTransaction : ModifiableByWithRequiredUserMemberBase, IVoidable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new deposit transaction entity.
        /// </summary>
        public DepositTransaction()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets balance transaction type.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public DepositTransactionType Type
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets transaction amount.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public decimal Amount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets balance.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public decimal Balance
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if voided.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public bool IsVoided
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets shift id.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int? ShiftId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register id.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public int? RegisterId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets shift.
        /// </summary>
        public virtual Shift Shift
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register.
        /// </summary>
        public virtual Register Register
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region POINTTRANSACTION
    /// <summary>
    /// Points transaction entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class PointTransaction : ModifiableByWithRequiredUserMemberBase, IVoidable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new points transaction instance.
        /// </summary>
        public PointTransaction()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets balance transaction type.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public LoyalityPointsTransactionType Type
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets points amount.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int Amount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets points balance.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int Balance
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if voided.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public bool IsVoided
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets shift id.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int? ShiftId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register id.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public int? RegisterId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets shift.
        /// </summary>
        public virtual Shift Shift
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register.
        /// </summary>
        public virtual Register Register
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region STOCKTRANSACTION
    /// <summary>
    /// Stock transaction entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class StockTransaction : ModifiableByOperatorBase, IVoidable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public StockTransaction()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets product id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int ProductId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets source product id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int? SourceProductId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets stock transaction type.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public StockTransactionType Type
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets transaction amount.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public decimal Amount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets on hand stock amount.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public decimal OnHand
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets amount of source product.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public decimal? SourceProductAmount
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets amount of source product on hand.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public decimal? SourceProductOnHand
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if voided.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public bool IsVoided
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets shift id.
        /// </summary>
        [DataMember()]
        [ProtoMember(9)]
        public int? ShiftId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register id.
        /// </summary>
        [DataMember()]
        [ProtoMember(10)]
        public int? RegisterId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets product.
        /// </summary>
        public virtual ProductBase Product
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets source product.
        /// </summary>
        public virtual ProductBase SourceProduct
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region PAYMENT
    /// <summary>
    /// Payment entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class Payment : ModifiableByWithRequiredUserMemberBase, IDeletable, IRefundable, IVoidable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new payment instance.
        /// </summary>
        public Payment() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets payment method id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int PaymentMethodId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets amount.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public decimal Amount
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets received amount.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public decimal AmountReceived
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if deleted.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public bool IsDeleted
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if voided.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public bool IsVoided
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets transaction id.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public int? DepositTransactionId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets loaylity transaction id.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public int? PointTransactionId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets shift id.
        /// </summary>
        [DataMember()]
        [ProtoMember(9)]
        public int? ShiftId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register id.
        /// </summary>
        [DataMember()]
        [ProtoMember(10)]
        public int? RegisterId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets refunded amount.
        /// </summary>
        [DataMember()]
        [ProtoMember(11)]
        public decimal RefundedAmount
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets refund status.
        /// </summary>
        [DataMember()]
        [ProtoMember(12)]
        public RefundStatus RefundStatus
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets balance transaction for this payment.
        /// </summary>
        public virtual DepositTransaction DepositTransaction
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets loyality transaction for this payment.
        /// </summary>
        public virtual PointTransaction PointTransaction
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets payment method.
        /// </summary>
        public virtual PaymentMethod PaymentMethod
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets shift.
        /// </summary>
        public virtual Shift Shift
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register.
        /// </summary>
        public virtual Register Register
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region PRODUCTORDER
    /// <summary>
    /// Product order entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class ProductOrder : ModifiableByWithRequiredUserMemberBase, IDeletable, IVoidable, IDeliverable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductOrder()
        {
            OrderLines = new HashSet<ProductOL>();
            Invoices = new HashSet<Invoice>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets order status.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public OrderStatus Status
        {
            get;
            set;
        }

        /// <summary>
        /// Gets sub total.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public decimal SubTotal
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets sub total.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public decimal Total
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets total points.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int PointsTotal
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets tax amount.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public decimal Tax
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if entity is deleted.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public bool IsDeleted
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if voided.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public bool IsVoided
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets host id.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public int? HostId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets shift id.
        /// </summary>
        [DataMember()]
        [ProtoMember(11)]
        public int? ShiftId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register id.
        /// </summary>
        [DataMember()]
        [ProtoMember(12)]
        public int? RegisterId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets prefered payment method id.
        /// </summary>
        [DataMember()]
        [ProtoMember(13)]
        public int? PreferedPaymentMethodId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if delivered.
        /// </summary>
        [DataMember()]
        [ProtoMember(14)]
        public bool IsDelivered
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets delivered time.
        /// </summary>
        [DataMember()]
        [ProtoMember(15)]
        public DateTime? DeliveredTime
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets order source.
        /// </summary>
        [DataMember()]
        [ProtoMember(16)]
        public OrderSource Source
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets order source.
        /// </summary>
        [DataMember()]
        [ProtoMember(17)]
        [MaxLength(255)]
        public string UserNote
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets host.
        /// </summary>
        public virtual Host Host
        {
            get;
            set;
        }

        /// <summary>
        /// Gets order products.
        /// </summary>
        [ProtoMember(9)]
        public virtual ISet<ProductOL> OrderLines
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets invoices.
        /// </summary>
        [ProtoMember(10)]
        public virtual ISet<Invoice> Invoices
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets shift.
        /// </summary>
        public virtual Shift Shift
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register.
        /// </summary>
        public virtual Register Register
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets prefered payment method.
        /// </summary>
        public virtual PaymentMethod PreferedPaymentMethod
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region PRODUCTOLPRODUCT
    /// <summary>
    /// Product orderline product entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class ProductOLProduct : ProductOLExtended
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductOLProduct()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets product id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int ProductId
        {
            get;
            set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets product.
        /// </summary>
        public virtual ProductBaseExtended Product
        {
            get;
            set;
        }

        #endregion
    }
    #endregion    

    #region PRODUCTOLTIME
    /// <summary>
    /// Product order line time entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class ProductOLTime : ProductOLExtended
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductOLTime()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets product time id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int ProductTimeId
        {
            get; set;
        }

        #endregion

        #region VIRTUAL PROTPERTIES

        /// <summary>
        /// Gets or sets product time.
        /// </summary>
        public virtual ProductTime ProductTime
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region PRODUCTOLTIMEFIXED
    /// <summary>
    /// Time fixed order line entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class ProductOLTimeFixed : ProductOL
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductOLTimeFixed() : base()
        { }
        #endregion

        #region PROPERTIES

        #endregion
    }
    #endregion

    #region PRODUCTOLSESSION
    /// <summary>
    /// Usage session order line entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class ProductOLSession : ProductOL
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ProductOLSession() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets session id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int UsageSessionId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets usage session.
        /// </summary>
        public virtual UsageSession UsageSession
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region INVOICE
    /// <summary>
    /// Invoice entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class Invoice : ModifiableByWithRequiredUserMemberBase, IVoidable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Invoice() : base()
        {
            InvoicePayments = new HashSet<InvoicePayment>();
            InvoiceLines = new HashSet<InvoiceLine>();
            Voids = new HashSet<VoidInvoice>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets product order id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int ProductOrderId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public InvoiceStatus Status
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets invoice sub total amount.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public decimal SubTotal
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets total amount of points.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int PointsTotal
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets invoice total amount of tax.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public decimal TaxTotal
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets total amount.
        /// </summary>
        /// <remarks>
        /// This amount is sum of sub total and tax total.
        /// </remarks>
        [DataMember()]
        [ProtoMember(6)]
        public decimal Total
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets outstanding amount.
        /// </summary>
        [DataMember]
        [ProtoMember(7)]
        public decimal Outstanding
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets outstanding points.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public int OutstandngPoints
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets shift id.
        /// </summary>
        [DataMember()]
        [ProtoMember(11)]
        public int? ShiftId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register id.
        /// </summary>
        [DataMember()]
        [ProtoMember(12)]
        public int? RegisterId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if invoice is voided.
        /// </summary>
        [DataMember()]
        [ProtoMember(13)]
        public bool IsVoided
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets payments maid against this invoice.
        /// </summary>
        [DataMember()]
        [ProtoMember(9)]
        public virtual ISet<InvoicePayment> InvoicePayments
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets invoice lines.
        /// </summary>
        [DataMember()]
        [ProtoMember(10)]
        public virtual ISet<InvoiceLine> InvoiceLines
        {
            get; protected set;
        }

        /// <summary>
        /// Gets voids.
        /// </summary>
        [DataMember()]
        [ProtoMember(14)]
        public virtual ISet<VoidInvoice> Voids
        {
            get; protected set;
        }

        /// <summary>
        /// Gets or sets product order.
        /// </summary>
        [DataMember()]
        [ProtoMember(15, AsReference = true)]
        public virtual ProductOrder ProductOrder
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets shift.
        /// </summary>
        [DataMember()]
        [ProtoMember(16)]
        public virtual Shift Shift
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register.
        /// </summary>
        public virtual Register Register
        {
            get; set;
        }

        #endregion
    }
    #endregion    

    #region INVOICELINEPRODUCT
    /// <summary>
    /// Invoice line product entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class InvoiceLineProduct : InvoiceLineExtended, IOrderLineReference
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public InvoiceLineProduct() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or set order line.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int OrderLineId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets product id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int ProductId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets order line.
        /// </summary>
        public virtual ProductOLProduct OrderLine
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets product.
        /// </summary>
        public virtual ProductBaseExtended Product
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region INVOICELINETIME
    /// <summary>
    /// Invoice line time entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class InvoiceLineTime : InvoiceLineExtended, IOrderLineReference, ITimeDepletable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public InvoiceLineTime() : base()
        {
            Usages = new HashSet<UsageTime>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or set order line.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int OrderLineId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets product time id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int ProductTimeId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if product is depleted.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public bool IsDepleted
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets order line.
        /// </summary>
        public virtual ProductOLTime OrderLine
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets product.
        /// </summary>
        public virtual ProductTime Product
        {
            get; set;
        }

        /// <summary>
        /// Gets usages.
        /// </summary>
        public virtual ISet<UsageTime> Usages
        {
            get; protected set;
        }

        #endregion
    }
    #endregion

    #region INVOICELINETIMEFIXED
    /// <summary>
    /// Invoice line time fixed entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class InvoiceLineTimeFixed : InvoiceLine, ITimeDepletable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public InvoiceLineTimeFixed() : base()
        {
            Usages = new HashSet<UsageTimeFixed>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or set order line.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int OrderLineId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if product is depleted.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public bool IsDepleted
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets fixed time order line.
        /// </summary>
        public virtual ProductOLTimeFixed OrderLine
        {
            get; set;
        }

        /// <summary>
        /// Gets usages.
        /// </summary>
        public virtual ISet<UsageTimeFixed> Usages
        {
            get; protected set;
        }

        #endregion
    }
    #endregion

    #region INVOICELINESESSION
    /// <summary>
    /// Invoice line usage session entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class InvoiceLineSession : InvoiceLine
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public InvoiceLineSession() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or set order line.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int OrderLineId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets session id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int UsageSessionId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets fixed time order line.
        /// </summary>
        public virtual ProductOLSession OrderLine
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets usage session.
        /// </summary>
        public virtual UsageSession UsageSession
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region INVOICEPAYMENT
    /// <summary>
    /// Invoice payment entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class InvoicePayment : ModifiableByWithRequiredUserMemberBase, IRefundable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public InvoicePayment() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets payment id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int PaymentId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets invoice id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int InvoiceId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets amount taken from the referenced payment.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public decimal Amount
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets shift id.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int? ShiftId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register id.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public int? RegisterId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets refunded amount.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public decimal RefundedAmount
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets refund status.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public RefundStatus RefundStatus
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets payment.
        /// </summary>
        [ProtoMember(4)]
        public virtual Payment Payment
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets invoice.
        /// </summary>
        public virtual Invoice Invoice
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets shift.
        /// </summary>
        public virtual Shift Shift
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register.
        /// </summary>
        public virtual Register Register
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region DEPOSITPAYMENT
    /// <summary>
    /// Deposit payment entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class DepositPayment : ModifiableByWithRequiredUserMemberBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public DepositPayment() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets deposit transaction id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int DepositTransactionId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets payment id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int PaymentId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets shift id.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int? ShiftId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register id.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int? RegisterId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets payment.
        /// </summary>
        [ProtoMember(3)]
        public virtual Payment Payment
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets deposit transaction.
        /// </summary>
        public virtual DepositTransaction DepositTransaction
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets shift.
        /// </summary>
        public virtual Shift Shift
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register.
        /// </summary>
        public virtual Register Register
        {
            get; set;
        }

        #endregion
    }
    #endregion    

    #endregion

    #region PRESETTIMESALE
    /// <summary>
    /// Sale time value entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class PresetTimeSale : ValueBase<int>, IDisplayOrder
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public PresetTimeSale() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets display order.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int DisplayOrder
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region PRESETTIMESALEMONEY
    /// <summary>
    /// Sale time money value entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class PresetTimeSaleMoney : ValueBase<decimal>, IDisplayOrder
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public PresetTimeSaleMoney() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets display order.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int DisplayOrder
        {
            get; set;
        }

        #endregion
    }
    #endregion    

    #region USERNOTE
    /// <summary>
    /// User note entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class UserNote : Note
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserNote() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int UserId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user note options.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public UserNoteOptions UserNoteOptions
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public virtual UserMember User
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region REGISTER

    /// <summary>
    /// Register entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class Register : ModifiableByOperatorBase, IDeletable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Register() : base()
        {
            Shifts = new HashSet<Shift>();
            Transactions = new HashSet<RegisterTransaction>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets register number.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int Number
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets terminal name.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        [StringLength(45)]
        public string Name
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register mac address.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        [StringLength(255)]
        public string MacAddress
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets register options.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public RegisterOptions Options
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if register is deleted.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public bool IsDeleted
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets register idle timeout.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public int? IdleTimeout
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register start cash.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public decimal StartCash
        {
            get; set;
        }

        #endregion

        #region VIRTUAL PROPERTIES

        /// <summary>
        /// Gets or sets shifts.
        /// </summary>
        public virtual ISet<Shift> Shifts
        {
            get; protected set;
        }

        /// <summary>
        /// Gets register payments.
        /// </summary>
        public virtual ISet<RegisterTransaction> Transactions
        {
            get; protected set;
        }

        #endregion
    }

    #endregion

    #region SHIFT

    /// <summary>
    /// Shift entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class Shift : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Shift() : base()
        {
            ShiftCounts = new HashSet<ShiftCount>();
            RegisterTransactions = new HashSet<RegisterTransaction>();
            Deposits = new HashSet<DepositTransaction>();
            DepositPayments = new HashSet<DepositPayment>();
            InvoicePayment = new HashSet<InvoicePayment>();
            Payments = new HashSet<Payment>();
            Refunds = new HashSet<Refund>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets if shift is currently active.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public bool IsActive
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets operator id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int OperatorId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register id.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int RegisterId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets start date.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public DateTime Start
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets start cash.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public decimal StartCash
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if shift is ending.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public bool IsEnding
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets ended user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public int? EndedById
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets end date.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public DateTime? EndTime
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets operator.
        /// </summary>
        public virtual UserOperator Operator
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets ended operator.
        /// </summary>
        public virtual UserOperator EndedBy
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register.
        /// </summary>
        public virtual Register Register
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets shift counts.
        /// </summary>
        public virtual ISet<ShiftCount> ShiftCounts
        {
            get; protected set;
        }

        /// <summary>
        /// Gets register transactions.
        /// </summary>
        public virtual ISet<RegisterTransaction> RegisterTransactions
        {
            get; protected set;
        }

        /// <summary>
        /// Gets deposits.
        /// </summary>
        public virtual ISet<DepositTransaction> Deposits
        {
            get; set;
        }

        /// <summary>
        /// Gets deposit payments.
        /// </summary>
        public virtual ISet<DepositPayment> DepositPayments
        {
            get; protected set;
        }

        /// <summary>
        /// Gets or sets invoice payments.
        /// </summary>
        public virtual ISet<InvoicePayment> InvoicePayment
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets payments.
        /// </summary>
        public virtual ISet<Payment> Payments
        {
            get; protected set;
        }

        /// <summary>
        /// Gets or sets refunds.
        /// </summary>
        public virtual ISet<Refund> Refunds
        {
            get; protected set;
        }

        #endregion
    }

    #endregion

    #region SHIFTCOUNT

    /// <summary>
    /// Shift count entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class ShiftCount : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ShiftCount() : base()
        { }

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets shift id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int ShiftId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets payment method id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int PaymentMethodId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets start cash.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public decimal StartCash
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets sales.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public decimal Sales
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets deposits.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public decimal Deposits
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets pay ins.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public decimal PayIns
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets withdrawals.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public decimal Withdrawals
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets payouts.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public decimal PayOuts
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets refunds.
        /// </summary>
        [DataMember()]
        [ProtoMember(9)]
        public decimal Refunds
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets voids.
        /// </summary>
        [DataMember()]
        [ProtoMember(10)]
        public decimal Voids
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets expected.
        /// </summary>
        [DataMember()]
        [ProtoMember(11)]
        public decimal Expected
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets actual.
        /// </summary>
        [DataMember()]
        [ProtoMember(12)]
        public decimal Actual
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets difference.
        /// </summary>
        [DataMember()]
        [ProtoMember(13)]
        public decimal Difference
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets note.
        /// </summary>
        [DataMember()]
        [ProtoMember(14)]
        public string Note
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets shift.
        /// </summary>
        public virtual Shift Shift
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets payment method.
        /// </summary>
        public virtual PaymentMethod PaymentMethod
        {
            get; set;
        }

        #endregion
    }

    #endregion

    #region REGISTERTRANSACTION

    /// <summary>
    /// Register transaction entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class RegisterTransaction : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public RegisterTransaction() : base()
        {
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets register id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int RegisterId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets shift id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int? ShiftId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets payment amount.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public decimal Amount
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets type.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public RegisterTransactionType Type
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets note.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public string Note
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets shift.
        /// </summary>
        public virtual Shift Shift
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register.
        /// </summary>
        public virtual Register Register
        {
            get; set;
        }

        #endregion
    }

    #endregion

    #region ASSETTYPE

    /// <summary>
    /// Asset type entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class AssetType : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AssetType() : base()
        {
            Assets = new HashSet<Asset>();
            Transactions = new HashSet<AssetTransaction>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [ProtoMember(1)]
        [DataMember()]
        public string Name
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets description.
        /// </summary>
        [ProtoMember(2)]
        [DataMember()]
        public string Description
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets part number.
        /// </summary>
        [ProtoMember(3)]
        [DataMember()]
        public string PartNumber
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets assets.
        /// </summary>
        [ProtoMember(4)]
        public virtual ISet<Asset> Assets
        {
            get; protected set;
        }

        /// <summary>
        /// Gets or sets transactions.
        /// </summary>
        public virtual ISet<AssetTransaction> Transactions
        {
            get; protected set;
        }

        #endregion
    }

    #endregion

    #region ASSET

    /// <summary>
    /// Asset entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class Asset : ModifiableByOperatorBase, IEnabled
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Asset() : base()
        {
            Transactions = new HashSet<AssetTransaction>();
        }

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets asset type id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int AssetTypeId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets asset number.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int Number
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets asset name.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public string Tag
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets RFID identifier.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public string SmartCardUID
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets barcode.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public string Barcode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets serial number.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public string SerialNumber
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if asset is enabled.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public bool IsEnabled
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets asset type.
        /// </summary>
        public virtual AssetType AssetType
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets asset leases.
        /// </summary>
        public virtual ISet<AssetTransaction> Transactions
        {
            get; protected set;
        }

        #endregion
    }

    #endregion

    #region ASSETTRANSACTION

    /// <summary>
    /// Asset transaction entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class AssetTransaction : ModifiableByWithRequiredUserMemberBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AssetTransaction() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets asset type id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int AssetTypeId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets asset type name.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public string AssetTypeName
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets asset id.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int AssetId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if transaction is active.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public bool IsActive
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets checked in operator id.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int? CheckedInById
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets checked in time.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public DateTime? CheckInTime
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets shift id.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public int? ShiftId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets register id.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public int? RegisterId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets checked in operator.
        /// </summary>
        public virtual UserOperator CheckedInBy
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets asset type.
        /// </summary>
        public virtual AssetType AssetType
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets asset.
        /// </summary>
        [ProtoMember(9)]
        public virtual Asset Asset
        {
            get; set;
        }

        #endregion
    }

    #endregion    

    #region REFUND
    /// <summary>
    /// Refund base entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public abstract class Refund : EntityWithShift
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Refund() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets payment id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int PaymentId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets amount.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public decimal Amount
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets deposit transaction id.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int? DepositTransactionId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets point transaction id.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public int? PointTransactionId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets refund payment method id.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public int RefundMethodId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets payment.
        /// </summary>
        public virtual Payment Payment
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets deposit transactions.
        /// </summary>
        public virtual DepositTransaction DepositTransaction
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets point transaction id.
        /// </summary>
        public virtual PointTransaction PointTransaction
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets refund payment method.
        /// </summary>
        public virtual PaymentMethod RefundMethod
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region REFUNDINVOICEPAYMENT
    /// <summary>
    /// Invoice payment refund.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class RefundInvoicePayment : Refund
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public RefundInvoicePayment() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets invoice payment id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int InvoicePaymentId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets invoice id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int InvoiceId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets invoice payment.
        /// </summary>
        public virtual InvoicePayment InvoicePayment
        {
            get; set;
        }

        /// <summary>
        /// Gets or set invoice.
        /// </summary>
        public virtual Invoice Invoice
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region VOIDINVOICE
    /// <summary>
    /// Invoice void entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class VoidInvoice : Void
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public VoidInvoice() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets invoice id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int InvoiceId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets invoice.
        /// </summary>
        public virtual Invoice Invoice
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region HOSTGROUPUSERBILLPROFILE
    /// <summary>
    /// Host group user bill profile entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class HostGroupUserBillProfile : EntityBase,
        IEnabled
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public HostGroupUserBillProfile() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets host group id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int HostGroupId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user group id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int UserGroupId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets bill profile id.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int BillProfileId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if is enabled.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public bool IsEnabled
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets host group.
        /// </summary>
        public HostGroup HostGroup
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets bill profile.
        /// </summary>
        public virtual BillProfile BillProfile
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user group.
        /// </summary>
        public virtual UserGroup UserGroup
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region HOSTGROUPWAITINGLINE
    /// <summary>
    /// Waiting line entitiy.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class HostGroupWaitingLine : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public HostGroupWaitingLine() : base()
        {
            Entries = new HashSet<HostGroupWaitingLineEntry>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets waiting line timeout options.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public WaitingLineTimeoutOption TimeOutOptions
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if user group priorities are enabled.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public bool EnablePriorities
        {
            get; set;
        }

        #endregion

        #region VIRTUAL PROPERTIES

        /// <summary>
        /// Gets or sets host group.
        /// </summary>
        public virtual HostGroup HostGroup
        {
            get; set;
        }

        /// <summary>
        /// Gets entries.
        /// </summary>
        public virtual ISet<HostGroupWaitingLineEntry> Entries
        {
            get; protected set;
        }

        #endregion
    }
    #endregion

    #region HOSTGROUPWAITINGLINEENTRY
    /// <summary>
    /// Waiting line entry.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class HostGroupWaitingLineEntry : ModifiedByBase<UserOperator, User>
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public HostGroupWaitingLineEntry() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets waiting line id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int HostGroupId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int UserId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets waiting line number.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public int Position
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if position was set manually.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public bool IsManualPosition
        {
            get; set;
        }

        /// <summary>
        /// Gets total time in waiting line.
        /// </summary>
        [ProtoMember(5)]
        public double TimeInLine
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets ready time.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public double ReadyTime
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets if ready state timed out.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public bool IsReadyTimedOut
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets waiting line state.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public WaitingLineState State
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets host group.
        /// </summary>
        public virtual HostGroup HostGroup
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets waiting line.
        /// </summary>
        public virtual HostGroupWaitingLine WatingLine
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public virtual UserMember User
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region RESERVATION
    /// <summary>
    /// Reservation entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class Reservation : ModifiableByUserCreatedByUserBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Reservation()
        {
            Users = new HashSet<ReservationUser>();
            Hosts = new HashSet<ReservationHost>();
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int? UserId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets reservation pin.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        [MinLength(6)]
        [MaxLength(6)]
        public string Pin
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets reservation date time.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public DateTime Date
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets duration.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        [Range(1, int.MaxValue)]
        public int Duration
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets contact phone.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        [StringLength(20)]
        public string ContactPhone
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets contact email.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        [StringLength(254)]
        public string ContactEmail
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets reservation note.
        /// </summary>
        [DataMember()]
        [ProtoMember(7)]
        public string Note
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets reservation status.
        /// </summary>
        [DataMember()]
        [ProtoMember(8)]
        public ReservationStatus Status
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets users.
        /// </summary>
        [DataMember()]
        [ProtoMember(100)]
        public virtual ISet<ReservationUser> Users
        {
            get; protected set;
        }

        /// <summary>
        /// Gets entries.
        /// </summary>
        [DataMember()]
        [ProtoMember(101)]
        public virtual ISet<ReservationHost> Hosts
        {
            get; protected set;
        }

        /// <summary>
        /// Gets or sets reservation user.
        /// </summary>
        public virtual UserMember User
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region RESERVATIONUSER
    /// <summary>
    /// Reservation user entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class ReservationUser : ModifiableByUserCreatedByUserBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ReservationUser()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets reservation id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int ReservationId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int UserId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets reservation.
        /// </summary>
        public virtual Reservation Reservation
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public virtual UserMember User
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region RESERVATIONHOST
    /// <summary>
    /// Reservation host entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class ReservationHost : ModifiableByUserCreatedByUserBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public ReservationHost() : base()
        {
        }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets reservation id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int ReservationId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets host id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int HostId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets prefered user id.
        /// </summary>        
        [DataMember()]
        [ProtoMember(3)]
        public int? PreferedUserId
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets reservation.
        /// </summary>
        public virtual Reservation Reservation
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets host.
        /// </summary>
        public virtual Host Host
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets prefered user.
        /// </summary>
        public virtual UserMember PreferedUser
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region TOKEN
    /// <summary>
    /// Token entity.
    /// </summary>
    [DataContract()]
    [ProtoContract()]
    [Serializable()]
    public class Token : ModifiableByUserCreatedByUserBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Token() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int? UserId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets token value.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        [MaxLength(32)]
        public string Value
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user confirmation code.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        [MaxLength(6)]
        public string ConfirmationCode
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets token type.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public TokenType Type
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets token status.
        /// </summary>
        [DataMember()]
        [ProtoMember(5)]
        public TokenStatus Status
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets optional expiration time.
        /// </summary>
        [DataMember()]
        [ProtoMember(6)]
        public DateTime? Expires
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public virtual User User
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region VERIFICATION
    /// <summary>
    /// Verification entity base.
    /// </summary>
    [DataContract()]
    [ProtoContract()]
    [Serializable()]
    public class Verification : ModifiableByUserCreatedByUserBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public Verification() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets associated token id.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        public int TokenId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int? UserId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets verification status.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public VerificationStatus Status
        {
            get; set;
        }

        #endregion

        #region NAVIGATION PROPETIES

        /// <summary>
        /// Gets or sets associated token.
        /// </summary>
        public virtual Token Token
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public virtual User User
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region VERIFICATIONEMAIL
    /// <summary>
    /// Email verification entity.
    /// </summary>
    [DataContract()]
    [ProtoContract()]
    [Serializable()]
    public class VerificationEmail : Verification
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public VerificationEmail() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets email.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [MaxLength(254)]
        public string Email
        {
            get; set;
        }

        #endregion
    }
    #endregion

    #region VERIFICATIONMOBILEPHONE
    /// <summary>
    /// Phone number verification entity.
    /// </summary>
    [DataContract()]
    [ProtoContract()]
    [Serializable()]
    public class VerificationMobilePhone : Verification
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public VerificationMobilePhone() : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets phone number.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [MaxLength(20)]
        public string PhoneNumber
        {
            get; set;
        }

        #endregion
    }
    #endregion
}
