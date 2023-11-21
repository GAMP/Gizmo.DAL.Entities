using ProtoBuf;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Task base class.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public abstract class TaskBase : ModifiableByOperatorBase, IReplicatable
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public TaskBase() : base()
        {
            Guid = Guid.NewGuid();
            UsedByTask = new HashSet<ClientTask>();
            UsedByAppExe = new HashSet<AppExeTask>();
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
        /// Gets or sets guid.
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
        /// Gets list of used by items.
        /// </summary>
        public virtual ISet<AppExeTask> UsedByAppExe
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets list of used by items.
        /// </summary>
        public virtual ISet<ClientTask> UsedByTask
        {
            get;
            protected set;
        }

        #endregion
    }
}