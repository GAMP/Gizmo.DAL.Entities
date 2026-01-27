using Gizmo.Server;
using Gizmo.Server.Security;
using System;
using System.Security.Claims;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Generic extensions.
    /// </summary>
    public static class EntityExtensions
    {
        /// <summary>
        /// Sets created by.
        /// </summary>
        /// <param name="entity">Entity.</param>
        public static void SetCreatedBy(this ICreatedBy entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            var userId = GetCurrentOperatorId();

            if (userId != null)
                entity.CreatedById = userId;
        }

        /// <summary>
        /// Sets created time property.
        /// </summary>
        /// <param name="entity">Entity.</param>
        public static void SetCreatedTime(this ICreatable entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            entity.CreatedTime = DateTime.UtcNow;
        }

        /// <summary>
        /// Sets modified by property.
        /// </summary>
        /// <param name="entity">Entity.</param>
        public static void SetModifiedBy(this IModifiedBy entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            var userId = GetCurrentOperatorId();

            if (userId != null)
                entity.ModifiedById = userId;
        }

        /// <summary>
        /// Sets modified time property.
        /// </summary>
        /// <param name="entity">Entity.</param>
        public static void SetModifiedTime(this IModifiable entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            entity.ModifiedTime = DateTime.UtcNow;
        }

        /// <summary>
        /// Gets current user id.
        /// </summary>
        /// <returns>Current user id.</returns>
        public static int? GetCurrentUserId()
        {
            if (System.Threading.Thread.CurrentPrincipal is IGizmoServerPrincipal gizmoServerPrincipal)
            {
                return gizmoServerPrincipal.UserId;
            }

            //get current http principal
            var principal = Web.HttpContextIdentityProvider.Current?.CurrentPrincipal;

            //no http principal attached to current thread
            if (principal == null)
                return null;

            //get current name identifier (user id)
            var nameIdClaim = principal.FindFirst(ClaimTypes.NameIdentifier);

            //name id set parse it else return null
            return nameIdClaim != null ? int.Parse(nameIdClaim.Value) : (int?)null;
        }

        /// <summary>
        /// Gets current operator id.
        /// </summary>
        /// <returns>Operator id.</returns>
        public static int? GetCurrentOperatorId()
        {
            if(System.Threading.Thread.CurrentPrincipal is IGizmoServerPrincipal gizmoServerPrincipal)
            {
                if (gizmoServerPrincipal.Role != UserRoles.Operator)
                    return null;

                return gizmoServerPrincipal.UserId;
            }

            //get current http principal
            var principal = Web.HttpContextIdentityProvider.Current?.CurrentPrincipal;

            //no http principal attached to current thread
            if (principal == null)
                return null;

            //get current name identifier (user id)
            var nameIdClaim = principal.FindFirst(ClaimTypes.NameIdentifier);

            //name id set parse it else return null
            return nameIdClaim != null ? int.Parse(nameIdClaim.Value) : null;
        }
    }
}
