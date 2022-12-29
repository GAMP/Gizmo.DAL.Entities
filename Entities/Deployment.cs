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
}