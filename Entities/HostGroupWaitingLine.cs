using ProtoBuf;
using SharedLib;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
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
}