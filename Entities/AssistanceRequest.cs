using GizmoDALV2.Entities;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Assistance request entity.
    /// </summary>
    public class AssistanceRequest : ModifiedByBase<User, User>
    {
        #region CONSTRUCTOR
        
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AssistanceRequest()
        { } 

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets request type id.
        /// </summary>
        public int AssitanceRequestTypeId { get; set; }

        /// <summary>
        /// Gets or sets user id.
        /// </summary>
        public int? UserId
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets host id.
        /// </summary>
        public int HostId { get; set; }

        /// <summary>
        /// Gets or sets status.
        /// </summary>
        public AssistanceRequestStatus Status { get; set; }

        /// <summary>
        /// Gets or sets note.
        /// </summary>
        public string Note { get; set; } 

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets or sets host.
        /// </summary>
        public virtual Host Host { get; set; }

        /// <summary>
        /// Gets or sets user.
        /// </summary>
        public virtual UserMember User { get; set; }

        #endregion
    }
}
