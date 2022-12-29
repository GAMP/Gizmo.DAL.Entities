using ProtoBuf;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
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
}