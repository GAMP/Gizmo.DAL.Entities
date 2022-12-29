using ProtoBuf;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
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
}