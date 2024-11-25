using System.Collections.Generic;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// User permission set entity.
    /// </summary>
    public sealed class UserPermissionSet : ModifiableByOperatorBase
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public UserPermissionSet()
            : base()
        {
            Permissions = new HashSet<UserPermissionSetPermission>();
        }

        /// <summary>
        /// Gets or sets permission set name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets permissions.
        /// </summary>
        public ISet<UserPermissionSetPermission> Permissions { get; set; }
    }
}
