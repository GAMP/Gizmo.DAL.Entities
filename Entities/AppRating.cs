using System;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// App rating entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    public class AppRating
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AppRating()
            : base()
        { }
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets value.
        /// </summary>
        [DataMember()]
        public int Value { get; set; }

        /// <summary>
        /// Gets or sets last vote time.
        /// </summary>
        [DataMember()]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets application id.
        /// </summary>
        [DataMember()]
        public int AppId { get; set; }

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        [DataMember()]
        public int UserId { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets application.
        /// </summary>
        public virtual App App { get; set; }

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public virtual UserMember User { get; set; }

        #endregion
    }
}