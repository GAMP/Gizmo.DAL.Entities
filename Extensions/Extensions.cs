using IntegrationLib;
using System;
using System.Security.Claims;

namespace GizmoDALV2
{
    /// <summary>
    /// Generic extensions.
    /// </summary>
    public static class Extenstions
    {
        #region FUNCTIONS

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

            entity.CreatedTime = SharedLib.InternalDate.Now;
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

            entity.ModifiedTime = SharedLib.InternalDate.Now;
        }

        /// <summary>
        /// Gets current user id.
        /// </summary>
        /// <returns>Current user id.</returns>
        public static int? GetCurrentUserId()
        {
            //get current thread principal
            var principal = System.Threading.Thread.CurrentPrincipal as ClaimsPrincipal;

            //try to obtain user identity
            if (principal?.Identity is IUserIdentity identity)
            {
                //return user id
                return identity.UserId;
            }

            //get current http principal
            principal = HttpContextIdentityProvider.Current?.CurrentPrincipal;

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
            //get current thread principal
            var principal = System.Threading.Thread.CurrentPrincipal as ClaimsPrincipal;

            //try to obtain user identity
            if (principal?.Identity is IUserIdentity identity)
            {
                //ensure if the current user is operator
                if (identity.Role != Gizmo.UserRoles.Operator)
                    return null;

                //return user id
                return identity.UserId;
            }

            //get current http principal
            principal = HttpContextIdentityProvider.Current?.CurrentPrincipal;

            //no http principal attached to current thread
            if (principal == null)
                return null;

            //get current name identifier (user id)
            var nameIdClaim = principal.FindFirst(ClaimTypes.NameIdentifier);

            //name id set parse it else return null
            return nameIdClaim != null ? int.Parse(nameIdClaim.Value) : (int?)null;
        }

        #endregion
    }
}
