using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Assistance request type entity.
    /// </summary>
    [Serializable()]
    public class AssistanceRequestType : GizmoDALV2.Entities.ModifiableByOperatorBase
    {
        #region CONSTRUCTOR

        /// <summary>
        /// Creates new instance.
        /// </summary>
        public AssistanceRequestType() { }

        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets request type title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets display order.
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets if request is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

        #endregion
    }
}
