using ProtoBuf;
using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Usage user session base class.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class UsageUserSession : Usage
    {
        #region CONSTRUCTOR
    
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UsageUserSession() : base()
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

        #endregion
    }
}