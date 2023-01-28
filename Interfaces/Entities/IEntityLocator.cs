using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gizmo.DAL
{
    /// <summary>
    /// Entity locator interface.
    /// </summary>
    /// <typeparam name="T">Entity type.</typeparam>
    public interface IEntityLocator<T> where T : Entities.EntityBase
    {
        #region FUNCTIONS
        
        /// <summary>
        /// Gets all entites.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAsync();

        /// <summary>
        /// Gets entity by entity id.
        /// </summary>
        /// <param name="entityId">Entity id.</param>
        /// <returns>
        /// Found entity.
        /// </returns>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        Task<T> GetAsync(int entityId);

        /// <summary>
        /// Gets entity by entity id.
        /// </summary>
        /// <param name="entityId">>Entity id.</param>
        /// <returns>Found entity. Null in case entity not found.</returns>
        Task<T> TryGetAsync(int entityId);

        #endregion
    }
}
