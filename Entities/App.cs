using ProtoBuf;

using SharedLib;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
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
        public SharedLib.AgeRatingType AgeRatingType
        {
            get
            {
                if (AgeRating > 0)
                {
                    return SharedLib.AgeRatingType.Manual;
                }
                else if (AgeRating < 0 & AgeRating >= -20)
                {
                    return SharedLib.AgeRatingType.PEGI;
                }
                else if (AgeRating < -20 & AgeRating >= -40)
                {
                    return SharedLib.AgeRatingType.ESRB;
                }
                return SharedLib.AgeRatingType.None;
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
}
