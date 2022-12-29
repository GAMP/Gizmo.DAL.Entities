using ProtoBuf;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
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
}