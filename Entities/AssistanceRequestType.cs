namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Assistance request type entity.
    /// </summary>
    public sealed class AssistanceRequestType : GizmoDALV2.Entities.ModifiableByOperatorBase
    {
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
    }
}
