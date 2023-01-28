using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// App image entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class AppImage : ImageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AppImage()
            : base()
        { }
        #endregion

        #region NAVIGATION PROPERTIES
        /// <summary>
        /// Gets or sets app.
        /// </summary>
        public virtual App App
        {
            get;
            set;
        }
        #endregion
    }
}