namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// User permission set permission entity.
    /// </summary>
    public sealed class UserPermissionSetPermission : EntityBase
    {
        /// <summary>
        /// Gets or sets permission set id.
        /// </summary>
        public int PermissionSetId { get; set; }

        /// <summary>
        /// Gets or sets permission type.
        /// </summary>
        /// <remarks>
        /// Effectively an resource.
        /// </remarks>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets permission value.
        /// </summary>
        /// <remarks>
        /// Effectively a operation.
        /// </remarks>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets permission set id.
        /// </summary>
        public UserPermissionSet PermissionSet
        {
            get;set;
        }
    }
}
