using ServerService;

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Gizmo.DAL
{
    #region IDBRepositoryAsync

    /// <summary>
    /// Extends database repository interface with async methods.
    /// </summary>
    public interface IDBRepositoryAsync : IDBRepository
    {
        #region ATTRIBUTES
        /// <summary>
        /// Gets Attribute entities.
        /// </summary>
        /// <returns>Attribute entities.</returns>
        Task<IEnumerable<Entities.Attribute>> AttributeGetAsync();

        /// <summary>
        /// Gets filtered Attribute entities.
        /// </summary>
        /// <param name="filters">Entity filters.</param>
        /// <returns>Attribute entities.</returns>
        Task<IEnumerable<Entities.Attribute>> AttributeGetAsync(IEnumerable<Filter> filters);

        /// <summary>
        /// Adds new attribute.
        /// </summary>
        /// <param name="entity">Attribute entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        Task AttributeAddAsync(Entities.Attribute entity);

        /// <summary>
        /// Updates attribute.
        /// </summary>
        /// <param name="entity">Attribute entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        Task AttributeUpdateAsync(Entities.Attribute entity);

        /// <summary>
        /// Removes attribute.
        /// </summary>
        /// <param name="entityId">Attribute entity id.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown when entity with specified <paramref name="entityId"/> not found.
        /// </exception>
        Task AttributeRemoveAsync(int entityId);
        #endregion

        #region APP STAT

        /// <summary>
        /// Gets app stats.
        /// </summary>
        /// <returns>Associated task.</returns>
        Task<IEnumerable<Entities.AppStat>> AppStatGetAsync();

        /// <summary>
        /// Gets filtered app stats.
        /// </summary>
        /// <param name="filter">Entity filter.</param>
        /// <returns>Associated task.</returns>
        Task<IEnumerable<Entities.AppStat>> AppStatGetAsync(IEnumerable<Filter> filter);

        #endregion

        #region SETTINGS

        /// <summary>
        /// Sets a settings value.
        /// </summary>
        /// <param name="key">Settings key.</param>
        /// <param name="value">Settings value.</param>
        void SettingSet(string key, string value);

        /// <summary>
        /// Sets a settings value.
        /// </summary>
        /// <param name="key">Settings key.</param>
        /// <param name="value">Settings value.</param>
        Task SettingSetAsync(string key, string value);

        /// <summary>
        /// Sets a settings value.
        /// </summary>
        /// <param name="key">Settings key.</param>
        /// <param name="value">Settings value.</param>
        /// <param name="group">Settings group.</param>
        Task SettingSetAsync(string key, string value, string group);

        /// <summary>
        /// Gets a settings value.
        /// </summary>
        /// <typeparam name="T">Value type.</typeparam>
        /// <param name="key">Settings key.</param>
        /// <returns>Settings value.</returns>
        Task<T> SettingGetAsync<T>(string key);

        #endregion

        #region USER ATTRIBUTES

        /// <summary>
        /// Gets UserAttribute entities.
        /// </summary>
        /// <returns>UserAttribute entities.</returns>
        Task<IEnumerable<Entities.UserAttribute>> UserAttributeGetAsync();

        /// <summary>
        /// Gets filtered UserAttribute entities.
        /// </summary>
        /// <param name="filters">Entity filters.</param>
        /// <returns>Filtered UserAttribute entities.</returns>
        Task<IEnumerable<Entities.UserAttribute>> UserAttributeGetAsync(IEnumerable<Filter> filters);

        /// <summary>
        /// Sets attribute value.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <param name="attributeId">Attribute id.</param>
        /// <param name="attributeValue">Attribute value.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if attribute with specified <paramref name="attributeId"/> does not exist.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// Thrown if specified <paramref name="attributeValue"/> equals null or empty string.
        /// </exception>
        Task UserAttributeSetValueAsync(int entityId, int attributeId, string attributeValue);

        /// <summary>
        /// Sets attribute value.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <param name="attributeName">Attribute name.</param>
        /// <param name="attributeValue">Attribute value.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// Thrown if specified <paramref name="attributeName"/> equals null or empty string.
        /// </exception>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if attribute with specified <paramref name="attributeName"/> does not exist.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// Thrown if specified <paramref name="attributeValue"/> equals null or empty string.
        /// </exception>
        Task UserAttributeSetValueAsync(int entityId, string attributeName, string attributeValue);

        /// <summary>
        /// Gets attribute value.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <param name="attributeId">Attribute id.</param>
        /// <returns>Attribute value, null if attribute is not set.</returns>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if attribute with specified <paramref name="attributeId"/> does not exist.
        /// </exception>
        Task<string> UserAttributeGetValueAsync(int entityId, int attributeId);

        /// <summary>
        /// Gets attribute value.
        /// </summary>
        /// <param name="entityId">User id.</param>
        /// <param name="attributeName">Attribute name.</param>
        /// <returns>Attribute value, null if attribute is not set.</returns>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// Thrown if specified <paramref name="attributeName"/> equals null or empty string.
        /// </exception>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if attribute with specified <paramref name="attributeName"/> does not exist.
        /// </exception>
        Task<string> UserAttributeGetValueAsync(int entityId, string attributeName);

        /// <summary>
        /// Removes attribute from user.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <param name="attributeId">Attribute name.</param>
        /// <returns>True if attribute was set and removed, false otherwise.</returns>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if attribute with specified <paramref name="attributeId"/> does not exist.
        /// </exception>
        Task<bool> UserAttributeRemoveAsync(int entityId, int attributeId);

        /// <summary>
        /// Removes attribute from user.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <param name="attributeName">Attribute name.</param>
        /// <returns>True if attribute was set and removed, false otherwise.</returns>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// Thrown if specified <paramref name="attributeName"/> equals null or empty string.
        /// </exception>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if attribute with specified <paramref name="attributeName"/> does not exist.
        /// </exception>
        Task<bool> UserAttributeRemoveAsync(int entityId, string attributeName);

        #endregion

        #region APPLICATION CATEGORY

        /// <summary>
        /// Gets app categories.
        /// </summary>
        /// <returns>App categories.</returns>
        Task<IEnumerable<Entities.AppCategory>> AppCategoryGetAsync();

        /// <summary>
        /// Adds app category.
        /// </summary>
        /// <param name="entity">App category instance.</param>
        /// <returns>Associated task.</returns>
        Task AppCategoryAddAsync(Entities.AppCategory entity);

        /// <summary>
        /// Updates app category.
        /// </summary>
        /// <param name="entity">App category instance.</param>
        /// <returns>Associated task.</returns>
        Task AppCategoryUpdateAsync(Entities.AppCategory entity);

        /// <summary>
        /// Removes app category.
        /// </summary>
        /// <param name="entityId">App category id.</param>
        /// <returns>Associated task.</returns>
        Task AppCategoryRemoveAsync(int entityId);

        /// <summary>
        /// Moves app category.
        /// </summary>
        /// <param name="entityId">App category id.</param>
        /// <param name="categoryId">New parent app category id.</param>
        /// <returns>Associated task.</returns>
        /// <remarks>
        /// If null specified for <paramref name="categoryId"/> specified then the category becomes a root category.
        /// </remarks>
        Task AppCategoryMoveAsync(int entityId, int? categoryId);

        #endregion

        #region USER

        /// <summary>
        /// Gets UserMember entities.
        /// </summary>
        /// <returns>UserMember entities.</returns>
        Task<IEnumerable<Entities.UserMember>> UserGetAsync();

        /// <summary>
        /// Gets filtered UserMember entities.
        /// </summary>
        /// <param name="filters">Entity filters.</param>
        /// <returns>Filtered UserMember entities.</returns>
        Task<IEnumerable<Entities.UserMember>> UserGetAsync(IEnumerable<Filter> filters);

        /// <summary>
        /// Gets UserMember by id.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <returns>
        /// Found user, null if no entity is found with specified <paramref name="entityId"/>.
        /// </returns>
        Task<Entities.UserMember> UserGetAsync(int entityId);

        /// <summary>
        /// Gets user by username.
        /// </summary>
        /// <param name="username">Username.</param>
        /// <returns>Found user, null if no user is found with specified <paramref name="username"/>.</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if specified <paramref name="username"/> equals to null or empty string.
        /// </exception>
        Task<Entities.UserMember> UserGetAsync(string username);

        /// <summary>
        /// Creates new user.
        /// </summary>
        /// <param name="entity">UserMember entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if specified <paramref name="entity"/> is null.
        /// </exception>
        Task UserCreateAsync(Entities.UserMember entity);

        /// <summary>
        /// Updates user.
        /// </summary>
        /// <param name="entity">UserMember entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if specified <paramref name="entity"/> is null.
        /// </exception>
        Task UserUpdateAsync(Entities.UserMember entity);

        /// <summary>
        /// Gets user picture.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <returns>
        /// User picture byte array, null if no picture is set.
        /// </returns>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        Task<byte[]> UserPictureGetAsync(int entityId);

        /// <summary>
        /// Sets user picture.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <param name="picture">New user picture value.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        Task UserPictureSetAsync(int entityId, byte[] picture);

        /// <summary>
        /// Removes user.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        /// <remarks>
        /// When removing user all related data is removed from database.
        /// </remarks>
        Task UserRemoveAsync(int entityId);

        /// <summary>
        /// Deltes user.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        Task UserDeleteAsync(int entityId);

        /// <summary>
        /// Undeletes user.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        Task UserUndeleteAsync(int entityId);

        /// <summary>
        /// Renames user.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <param name="newUserName">New username.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// Thrown if specified <paramref name="newUserName"/> equals to null or empty string.
        /// </exception>
        Task UserRenameAsync(int entityId, string newUserName);

        /// <summary>
        /// Sets user email.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <param name="newUserEmail">New user email.</param>
        /// <remarks>
        /// New email value can be set to null if required.
        /// </remarks>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        Task UserEmailSetAsync(int entityId, string newUserEmail);

        /// <summary>
        /// Sets user group.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <param name="newGroup">New user group id.</param>
        /// <remarks>
        /// New user group can be set to null.
        /// </remarks>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        Task UserGroupSetAsync(int entityId, int newGroup);

        /// <summary>
        /// Sets user password.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <param name="newPassword">New password value.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// Thrown if specified <paramref name="newPassword"/> equals to null or empty string.
        /// </exception>
        Task UserPasswordSetAsync(int entityId, string newPassword);

        /// <summary>
        /// Sets user password.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <param name="newPassword">New password value.</param>
        /// <param name="allowNull">Indicates if null value allowed for specified <paramref name="newPassword"/>.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        Task UserPasswordSetAsync(int entityId, string newPassword, bool allowNull);

        /// <summary>
        /// Disables specified user.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <param name="enable">Enable value. Set true for disable user and false to enable.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        Task UserDisableAsync(int entityId, bool enable);

        /// <summary>
        /// Validates user credentials.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <param name="password">Password.</param>
        /// <returns>Bool if valid otherwise false.</returns>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        /// <remarks>
        /// If user has no credentials set then function return false.
        /// If user has credentials set and credentials password equals to null and specified password is null function returns true.
        /// </remarks>
        Task<bool> UserCredentialsValidAsync(int entityId, string password);

        /// <summary>
        /// Gets user balance.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <returns>User balance.</returns>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        Task<UserBalance> UserBalanceGetAsync(int entityId);

        /// <summary>
        /// Gets users balance values.
        /// </summary>
        /// <returns>User balances.</returns>
        Task<Dictionary<int, UserBalance>> UserBalanceGetAsync();

        /// <summary>
        /// Enables or dsiables negative balance.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <param name="enable">Enable falg.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        /// <remarks>
        /// If <paramref name="enable"/> is set to null the negative balance state is inherited from user group if one is set for the user.
        /// </remarks>
        Task UserNegativeBalanceEnableAsync(int entityId, bool? enable);

        /// <summary>
        /// Sets user SmartCard UID.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <param name="smartCardUID">SmartCard UID string.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        Task UserSmartCardUIDSetAsync(int entityId, string smartCardUID);

        /// <summary>
        /// Gets user notes.
        /// </summary>
        /// <param name="userId">User id.</param>
        /// <returns>User notes.</returns>
        Task<IEnumerable<Entities.UserNote>> UserNoteGetAsync(int userId);

        /// <summary>
        /// Gets user notes.
        /// </summary>
        /// <param name="filters">Filter set.</param>
        /// <returns>User notes.</returns>
        Task<IEnumerable<Entities.UserNote>> UserNoteGetAsync(IEnumerable<Filter> filters);

        #endregion

        #region OPERATOR

        /// <summary>
        /// Gets UserOperator entities.
        /// </summary>
        /// <returns>UserOperator entities.</returns>
        Task<IEnumerable<Entities.UserOperator>> UserOperatorGetAsync();

        /// <summary>
        /// Gets UserOperator entities.
        /// </summary>
        /// <param name="filters">Entity filters.</param>
        /// <returns>Filtered UserOperator entities.</returns>
        Task<IEnumerable<Entities.UserOperator>> UserOperatorGetAsync(IEnumerable<Filter> filters);

        /// <summary>
        /// Gets UserOperator by id.
        /// </summary>
        /// <param name="entityId">UserOperator entity id.</param>
        /// <returns>
        /// UserOperator entity, null in case no operator found with specified <paramref name="entityId"/>.
        /// </returns>
        Task<Entities.UserOperator> UserOperatorGetAsync(int entityId);

        /// <summary>
        /// Gets UserOperator by user name.
        /// </summary>
        /// <param name="username">Username.</param>
        /// <returns>UserOperator entity, null in case no user found with specified <paramref name="username"/> found.</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if specified <paramref name="username"/> equals to null or empty string.
        /// </exception>
        Task<Entities.UserOperator> UserOperatorGetAsync(string username);

        /// <summary>
        /// Creates new operator.
        /// </summary>
        /// <param name="entity">UserOperator entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if specified <paramref name="entity"/> is null.
        /// </exception>
        Task UserOperatorCreateAsync(Entities.UserOperator entity);

        /// <summary>
        /// Updates operator.
        /// </summary>
        /// <param name="entity">UserOperator entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if specified <paramref name="entity"/> is null.
        /// </exception>
        Task UserOperatorUpdateAsync(Entities.UserOperator entity);

        /// <summary>
        /// Deletes operator.
        /// </summary>
        /// <param name="entityId">UserOperator entity id.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if no operator found with specified <paramref name="entityId"/>.
        /// </exception>
        Task UserOperatorDeleteAsync(int entityId);

        /// <summary>
        /// Removes operator.
        /// </summary>
        /// <param name="entityId">Operator entity id.</param>
        /// <remarks>
        /// Removes operator and all related entities from database.
        /// </remarks>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if no operator found with specified <paramref name="entityId"/>.
        /// </exception>
        Task UserOperatorRemoveAsync(int entityId);

        /// <summary>
        /// Sets new opeator password.
        /// </summary>
        /// <param name="entityId">UserOperator entity id.</param>
        /// <param name="newPassword">New password value.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if no operator found with specified <paramref name="entityId"/>.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// Thrown if specified <paramref name="newPassword"/> equals to null or empty string.
        /// </exception>
        Task UserOperatorPasswordSetAsync(int entityId, string newPassword);

        #endregion

        #region DEPOSITS

        /// <summary>
        /// Gets total amount of user deposits.
        /// </summary>
        /// <param name="userId">User id.</param>
        /// <returns>Deposits amount.</returns>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="userId"/> does not exist.
        /// </exception>
        Task<decimal> DepositBalanceGetAsync(int userId);

        /// <summary>
        /// Gets deposit balances for all users.
        /// </summary>
        /// <returns>User id mapped points dictionary.</returns>
        /// <remarks>
        /// The dictionary might not contain all user ids, it will only contain users that have deposti transactions and thus have a deposit balance.
        /// If dictionary does not contain user it means that his deposit balance equals to zero.
        /// </remarks>
        Task<Dictionary<int, decimal>> DepositBalanceGetAsync();

        #endregion

        #region POINTS

        /// <summary>
        /// Gets total amount of points user currently have.
        /// </summary>
        /// <param name="userId">User id.</param>
        /// <returns>Points amount.</returns>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="userId"/> does not exist.
        /// </exception>
        Task<int> PointsBalanceGetAsync(int userId);

        /// <summary>
        /// Gets point balances for all users.
        /// </summary>
        /// <returns>User id mapped points dictionary.</returns>
        /// <remarks>
        /// The dictionary might not contain all user ids, it will only contain users that have points transactions and thus have a points balance.
        /// If dictionary does not contain user it means that his points balance equals to zero.
        /// </remarks>
        Task<Dictionary<int, int>> PointsBalanceGetAsync();

        #endregion

        #region GENERIC ENTITIES

        /// <summary>
        /// Marks an entity as deleted.
        /// </summary>
        /// <param name="entity">Entity instance.</param>
        /// <returns>
        /// True if entity was marked as deleted, false in case entity was already marked as deleted.
        /// </returns>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if specified entity <paramref name="entity"/> not found.
        /// </exception>
        Task<bool> MarkDeletedAsync(IDeletable entity);

        #endregion

        #region USAGE SESSION

        /// <summary>
        /// Invoices active usage session.
        /// </summary>
        /// <param name="userId">User id.</param>
        /// <returns>Associated invoice. The function will return null if no active usage session existed.</returns>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="userId"/> does not exist.
        /// </exception>
        Task<Entities.Invoice> UsageSessionInvoiceActiveAsync(int userId);

        #endregion
    }

    #endregion
}
