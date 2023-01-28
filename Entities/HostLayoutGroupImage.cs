using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
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
}