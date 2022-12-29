using System;
using System.Runtime.Serialization;

namespace GizmoDALV2.Entities
{
    /// <summary>
    /// App exe image.
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class AppExeImage : ImageBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AppExeImage()
            : base()
        { }
        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets app exe.
        /// </summary>
        public virtual AppExe AppExe
        {
            get;
            set;
        }

        #endregion
    }
}