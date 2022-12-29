using ProtoBuf;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
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
}