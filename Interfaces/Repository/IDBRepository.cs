using System;
using System.Collections.Generic;
using ServerService;
using System.Linq.Expressions;
using SharedLib;
using System.Threading.Tasks;

namespace Gizmo.DAL
{
    #region IDBRepository

    /// <summary>
    /// Entity repository interface.
    /// Exposes functions for entity manipulation.
    /// </summary>
    public interface IDBRepository
    {
        #region PLUGIN LIB

        /// <summary>
        /// Gets PluginLibrary entities.
        /// </summary>
        /// <returns>PluginLibrary entities.</returns>
        IEnumerable<Entities.PluginLibrary> PluginLibGet();

        /// <summary>
        /// Gets plugin PluginLibrary entites for specified module scope.
        /// </summary>
        /// <param name="scope">Module scope.</param>
        /// <returns>PluginLibrary entities.</returns>
        IEnumerable<Entities.PluginLibrary> PluginLibGet(ModuleScopes scope);

        /// <summary>
        /// Updates existing PluginLibrary entity.
        /// </summary>
        /// <returns>PluginLibrary entities.</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void PluginLibUpdate(Entities.PluginLibrary entity);

        #endregion

        #region VARIABLE

        /// <summary>
        /// Gets Variable entites.
        /// </summary>
        /// <remarks>
        /// By default Variable entities returned sorted by the their UseOrder.
        /// </remarks>
        /// <returns>Variable entities.</returns>
        IEnumerable<Entities.Variable> VariableGet();

        /// <summary>
        /// Gets Variable entites for specified module scope.
        /// </summary>
        /// <param name="scope">Module scope.</param>
        /// <remarks>
        /// By default Variable entities returned sorted by the their UseOrder.
        /// </remarks>
        /// <returns>Variable entities.</returns>
        IEnumerable<Entities.Variable> VariableGet(ModuleScopes scope);

        /// <summary>
        /// Adds new variable.
        /// </summary>
        /// <param name="entity">Variable entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        /// <remarks>
        /// By default variable entities returned sorted by the their UseOrder./>
        /// </remarks>
        void VariableAdd(Entities.Variable entity);

        /// <summary>
        /// Updates existing variable.
        /// </summary>
        /// <param name="entity">Variable entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void VariableUpdate(Entities.Variable entity);

        /// <summary>
        /// Updates variable entities.
        /// </summary>
        /// <param name="entitySet">Variable entity set.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entitySet"/> is null.
        /// </exception>
        /// <remarks>
        /// Specified entity set represents the desired database state for entities so when updating by entity set any non present entity will be removed from database.
        /// If entity has UseOrder or DisplayOrder the properties will be updated based by entity index in specified entity set.  
        /// </remarks>
        void VariableUpdate(IEnumerable<Entities.Variable> entitySet);

        /// <summary>
        /// Removes existing variable.
        /// </summary>
        /// <param name="entityId">Variable entity id.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown when entity with specified <paramref name="entityId"/> not found.
        /// </exception>
        void VariableRemove(int entityId);

        #endregion

        #region SECURITY PROFILE

        /// <summary>
        /// Gets security profiles.
        /// </summary>
        /// <returns>Security profile entities.</returns>
        /// <remarks>
        /// When getting security profiles their associated Policies and Restrictions entities are included.
        /// </remarks>
        IEnumerable<Entities.SecurityProfile> SecurityProfileGet();

        /// <summary>
        /// Adds new security profile.
        /// </summary>
        /// <param name="entity">Security profile entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void SecurityProfileAdd(Entities.SecurityProfile entity);

        /// <summary>
        /// Updates security profile.
        /// </summary>
        /// <param name="entity">Security profile entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void SecurityProfileUpdate(Entities.SecurityProfile entity);

        /// <summary>
        /// Removes security profile.
        /// </summary>
        /// <param name="entityId">Security profile entity id.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown when entity with specified <paramref name="entityId"/> not found.
        /// </exception>
        void SecurityProfileRemove(int entityId);

        #endregion

        #region ATTRIBUTES

        /// <summary>
        /// Gets Attribute entities.
        /// </summary>
        /// <returns>Attribute entities.</returns>
        IEnumerable<Entities.Attribute> AttributeGet();

        /// <summary>
        /// Gets filtered Attribute entities.
        /// </summary>
        /// <param name="filters">Entity filters.</param>
        /// <returns>Attribute entities.</returns>
        IEnumerable<Entities.Attribute> AttributeGet(IEnumerable<Filter> filters);

        /// <summary>
        /// Adds new attribute.
        /// </summary>
        /// <param name="entity">Attribute entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void AttributeAdd(Entities.Attribute entity);

        /// <summary>
        /// Updates attribute.
        /// </summary>
        /// <param name="entity">Attribute entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void AttributeUpdate(Entities.Attribute entity);

        /// <summary>
        /// Removes attribute.
        /// </summary>
        /// <param name="entityId">Attribute entity id.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown when entity with specified <paramref name="entityId"/> not found.
        /// </exception>
        void AttributeRemove(int entityId);

        #endregion

        #region APP

        /// <summary>
        /// Gets App entities.
        /// </summary>
        /// <returns>App entities.</returns>
        IEnumerable<Entities.App> AppGet();

        /// <summary>
        /// Gets App entity graph.
        /// </summary>
        /// <param name="entityId">App entity id.</param>
        /// <returns>Found app entity graph.</returns>
        /// <exception cref="EntityNotFoundException">
        /// Thrown when entity with specified <paramref name="entityId"/> not found.
        /// </exception>
        /// <remarks>
        /// The purpose of this function is to return app entity with all required reference collections populated.
        /// </remarks>
        Entities.App AppGetGraph(int entityId);

        /// <summary>
        /// Adds new App.
        /// </summary>
        /// <param name="entity">App entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void AppAdd(Entities.App entity);

        /// <summary>
        /// Updates app.
        /// </summary>
        /// <param name="entity">App entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        /// <remarks>
        /// This function should receive a graph that represent the required database state of the entity.
        /// </remarks>
        void AppUpdate(Entities.App entity);

        /// <summary>
        /// Moves app into a new category.
        /// </summary>
        /// <param name="entityId">App entity Id.</param>
        /// <param name="newCategoryEntityId">New app category entity id.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown when entity with specified <paramref name="entityId"/> or <paramref name="newCategoryEntityId"/> not found.
        /// </exception>
        void AppMove(int entityId, int newCategoryEntityId);

        /// <summary>
        /// Renames app.
        /// </summary>
        /// <param name="entityId">App entity Id.</param>
        /// <param name="newName">New app name.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown when entity with specified <paramref name="entityId"/> not found.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// Thrown if specified <paramref name="newName"/> equals null or empty string.
        /// </exception>
        void AppRename(int entityId, string newName);

        /// <summary>
        /// Removes app.
        /// </summary>
        /// <param name="entityId">App entity Id.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown when entity with specified <paramref name="entityId"/> not found.
        /// </exception>
        void AppRemove(int entityId);

        /// <summary>
        /// Gets app image.
        /// </summary>
        /// <param name="entityId">App entity Id.</param>
        /// <returns>AppImage entity, null if app has no image set.</returns>
        /// <exception cref="EntityNotFoundException">
        /// Thrown when entity with specified <paramref name="entityId"/> not found.
        /// </exception>
        Entities.AppImage AppGetImage(int entityId);

        #endregion

        #region APP STAT

        /// <summary>
        /// Gets AppStat entities.
        /// </summary>
        /// <returns>AppStat entities.</returns>
        IEnumerable<Entities.AppStat> AppStatGet();

        /// <summary>
        /// Gets filtered AppStat entities.
        /// </summary>
        /// <param name="filters">Entity filters.</param>
        /// <returns>AppStat entities.</returns>
        IEnumerable<Entities.AppStat> AppStatGet(IEnumerable<Filter> filters);

        #endregion

        #region APP ENTERPRISE

        /// <summary>
        /// Gets AppEnterprise entities.
        /// </summary>
        /// <returns>AppEnterprise entities.</returns>
        IEnumerable<Entities.AppEnterprise> AppEnterpriseGet();

        /// <summary>
        /// Adds new app enterprise.
        /// </summary>
        /// <param name="entity">AppEnterprise entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void AppEnterpriseAdd(Entities.AppEnterprise entity);

        /// <summary>
        /// Updates app enterprise.
        /// </summary>
        /// <param name="entity">AppEnterprise entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void AppEnterpriseUpdate(Entities.AppEnterprise entity);

        /// <summary>
        /// Removes existing app enterprise.
        /// </summary>
        /// <param name="entityId">AppEnterprise entity id.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown when entity with specified <paramref name="entityId"/> not found.
        /// </exception>
        void AppEnterpriseRemove(int entityId);

        #endregion

        #region APP GROUP

        /// <summary>
        /// Gets AppGroup entities.
        /// </summary>
        /// <returns>AppGroup entities.</returns>
        IEnumerable<Entities.AppGroup> AppGroupGet();

        /// <summary>
        /// Adds app group.
        /// </summary>
        /// <param name="entity">AppGroup entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void AppGroupAdd(Entities.AppGroup entity);

        /// <summary>
        /// Updates app group.
        /// </summary>
        /// <param name="entity">AppGroup entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void AppGroupUpdate(Entities.AppGroup entity);

        /// <summary>
        /// Removes app group.
        /// </summary>
        /// <param name="entityId">AppGroup entity id.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown when entity with specified <paramref name="entityId"/> not found.
        /// </exception>
        void AppGroupRemove(int entityId);

        #endregion

        #region APP CATEGORY

        /// <summary>
        /// Gets AppCategory entities.
        /// </summary>
        /// <returns>
        /// AppCategory entities.
        /// </returns>
        IEnumerable<Entities.AppCategory> AppCategoryGet();

        /// <summary>
        /// Adds app category. 
        /// </summary>
        /// <param name="entity">AppCategory entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void AppCategoryAdd(Entities.AppCategory entity);

        /// <summary>
        /// Updates app category.
        /// </summary>
        /// <param name="entity">AppCategory entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void AppCategoryUpdate(Entities.AppCategory entity);

        /// <summary>
        /// Moves app category into new parent category.
        /// </summary>
        /// <param name="entityId">AppCategory entity id.</param>
        /// <param name="newCategoryEntityId">New AppCategory entity id.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown when entity with specified <paramref name="entityId"/> or <paramref name="newCategoryEntityId"/> not found.
        /// </exception>
        /// <remarks>
        /// If null specified for <paramref name="newCategoryEntityId"/> app category becomes root category.
        /// </remarks>
        void AppCategoryMove(int entityId, int? newCategoryEntityId);

        /// <summary>
        /// Removes app category.
        /// <param name="entityId">AppCategory entity id.</param>
        /// </summary>
        /// <exception cref="EntityNotFoundException">
        /// Thrown when entity with specified <paramref name="entityId"/> not found.
        /// </exception>
        void AppCategoryRemove(int entityId);

        #endregion

        #region DEPLOYMENT

        /// <summary>
        /// Gets Deployment entities.
        /// </summary>
        /// <returns>Deployment entities.</returns>
        IEnumerable<Entities.Deployment> DeploymentGet();

        /// <summary>
        /// Gets dependent App entities.
        /// </summary>
        /// <param name="entityId">Deployment entity Id.</param>
        /// <returns>Dependent App entities.</returns>
        /// <remarks>
        /// This function return app entities that depend on specified deployment.
        /// </remarks>
        /// <exception cref="EntityNotFoundException">
        /// Thrown when entity with specified <paramref name="entityId"/> not found.
        /// </exception>
        IEnumerable<Entities.App> DeploymentGetDependentApp(int entityId);

        /// <summary>
        /// Adds new deployment.
        /// </summary>
        /// <param name="entity">Deployment entity</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void DeploymentAdd(Entities.Deployment entity);

        /// <summary>
        /// Updates deployment.
        /// </summary>
        /// <param name="entity">Deployment entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void DeploymentUpdate(Entities.Deployment entity);

        /// <summary>
        /// Removes deployment.
        /// </summary>
        /// <param name="entityId">Deployment entity id.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown when entity with specified <paramref name="entityId"/> not found.
        /// </exception>
        void DeploymentRemove(int entityId);

        #endregion

        #region LICENSE

        /// <summary>
        /// Gets License entities.
        /// </summary>
        /// <returns>License entities.</returns>
        /// <remarks>
        /// When calling this function associated LicenseKeys are populated on returned entities.
        /// By default License entities returned sorted by the their Name.
        /// </remarks>
        IEnumerable<Entities.License> LicenseGet();

        /// <summary>
        /// Adds license.
        /// </summary>
        /// <param name="entity">License entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void LicenseAdd(Entities.License entity);

        /// <summary>
        /// Updates license.
        /// </summary>
        /// <param name="entity">License entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void LicenseUpdate(Entities.License entity);

        /// <summary>
        /// Removes license.
        /// </summary>
        /// <param name="entityId">License entity id.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown when entity with specified <paramref name="entityId"/> not found.
        /// </exception>
        void LicenseRemove(int entityId);

        /// <summary>
        /// Gets App entities.
        /// </summary>
        /// <param name="entityId">License entity Id.</param>
        /// <returns>Dependent App entities.</returns>
        IEnumerable<Entities.App> LicenseGetDependentApp(int entityId);

        #endregion

        #region PERSONAL FILE

        /// <summary>
        /// Gets PersonalFile entities.
        /// </summary>
        /// <returns>PersonalFile entities.</returns>
        IEnumerable<Entities.PersonalFile> PersonalFileGet();

        /// <summary>
        /// Adds personal file.
        /// </summary>
        /// <param name="entity">PersonalFile entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void PersonalFileAdd(Entities.PersonalFile entity);

        /// <summary>
        /// Updates personal file.
        /// </summary>
        /// <param name="entity">PersonalFile entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void PersonalFileUpdate(Entities.PersonalFile entity);

        /// <summary>
        /// Removes personal file.
        /// </summary>
        /// <param name="entityId">PersonalFile entity id.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown when entity with specified <paramref name="entityId"/> not found.
        /// </exception>
        void PersonalFileRemove(int entityId);

        /// <summary>
        /// Gets dependent App entities.
        /// </summary>
        /// <param name="entityId">PersonalFile entity Id.</param>
        /// <returns>Dependent app entities.</returns>
        /// <exception cref="EntityNotFoundException">
        /// Thrown when entity with specified <paramref name="entityId"/> not found.
        /// </exception>
        IEnumerable<Entities.App> PersonalFileGetDependentApp(int entityId);

        #endregion

        #region HOST GROUP

        /// <summary>
        /// Gets HostGroup entities.
        /// </summary>
        /// <returns>HostGroup entities.</returns>
        /// <remarks>
        /// When calling this function the reference properties DisallowedTimeOffers,DisallowedUserGroups populated on the HostGroup entities.
        /// </remarks>
        IEnumerable<Entities.HostGroup> HostGroupGet();

        /// <summary>
        /// Adds host gorup.
        /// </summary>
        /// <param name="entity">HostGroup entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void HostGroupAdd(Entities.HostGroup entity);

        /// <summary>
        /// Updates host group.
        /// </summary>
        /// <param name="entity">HostGroup entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void HostGroupUpdate(Entities.HostGroup entity);

        /// <summary>
        /// Removes host group.
        /// </summary>
        /// <param name="entityId">HostGroup entity id.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown when entity with specified <paramref name="entityId"/> not found.
        /// </exception>
        void HostGroupRemove(int entityId);

        #endregion

        #region HOST LAYOUT GROUP

        /// <summary>
        /// Gets HostLayoutGroup entities.
        /// </summary>
        /// <returns>HostLayoutGroup entities.</returns>
        /// <remarks>
        /// When calling this function the reference properties Layouts populated on the HostLayoutGroup entities.
        /// </remarks>
        IEnumerable<Entities.HostLayoutGroup> HostLayoutGroupGet();

        /// <summary>
        /// Adds host layout group.
        /// </summary>
        /// <param name="entity">HostLayoutGroup entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void HostLayoutGroupAdd(Entities.HostLayoutGroup entity);

        /// <summary>
        /// Updates host layout group.
        /// </summary>
        /// <param name="entity">HostLayoutGroup entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void HostLayoutGroupUpdate(Entities.HostLayoutGroup entity);

        /// <summary>
        /// Removes host layout group.
        /// </summary>
        /// <param name="entityId">HostLayoutGroup entity id.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown when entity with specified <paramref name="entityId"/> not found.
        /// </exception>
        void HostLayoutGroupRemove(int entityId);

        #endregion

        #region MAPPING

        /// <summary>
        /// Gets Mapping entities.
        /// </summary>
        /// <returns>
        /// Mapping entities
        /// </returns>
        IEnumerable<Entities.Mapping> MappingGet();

        /// <summary>
        /// Adds mapping.
        /// </summary>
        /// <param name="entity">Mapping entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void MappingAdd(Entities.Mapping entity);

        /// <summary>
        /// Updates mapping.
        /// </summary>
        /// <param name="entity">Mapping entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void MappingUpdate(Entities.Mapping entity);

        /// <summary>
        /// Removes mapping.
        /// </summary>
        /// <param name="entityId">Mapping entity id.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown when entity with specified <paramref name="entityId"/> not found.
        /// </exception>
        void MappingRemove(int entityId);

        #endregion

        #region NEWS

        /// <summary>
        /// Gets News entities.
        /// </summary>
        /// <returns>News entities.</returns>
        IEnumerable<Entities.News> NewsGet();

        /// <summary>
        /// Adds news.
        /// </summary>
        /// <param name="entity">News entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void NewsAdd(Entities.News entity);

        /// <summary>
        /// Updates news.
        /// </summary>
        /// <param name="entity">News entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void NewsUpdate(Entities.News entity);

        /// <summary>
        /// Removes news.
        /// </summary>
        /// <param name="entityId">News entity id.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown when entity with specified <paramref name="entityId"/> not found.
        /// </exception>
        void NewsRemove(int entityId);

        #endregion

        #region FEED

        /// <summary>
        /// Gets Feed entities.
        /// </summary>
        /// <returns>Feed entities.</returns>
        IEnumerable<Entities.Feed> FeedGet();

        /// <summary>
        /// Adds feed.
        /// </summary>
        /// <param name="entity">Feed entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void FeedAdd(Entities.Feed entity);

        /// <summary>
        /// Update feed.
        /// </summary>
        /// <param name="entity">Feed entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void FeedUpdate(Entities.Feed entity);

        /// <summary>
        /// Removes feed.
        /// </summary>
        /// <param name="entityId">Feed entity id.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown when entity with specified <paramref name="entityId"/> not found.
        /// </exception>
        void FeedRemove(int entityId);

        #endregion        

        #region USER GROUP

        /// <summary>
        /// Gets UserGroup entities.
        /// </summary>
        /// <returns>UserGroup entities.</returns>
        IEnumerable<Entities.UserGroup> UserGroupGet();

        /// <summary>
        /// Adds user group.
        /// </summary>
        /// <param name="entity">UserGroup entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void UserGroupAdd(Entities.UserGroup entity);

        /// <summary>
        /// Upadates user group.
        /// </summary>
        /// <param name="entity">UserGroup entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void UserGroupUpdate(Entities.UserGroup entity);

        /// <summary>
        /// Removes user group.
        /// </summary>
        /// <param name="entityId">UserGroup entity id.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown when entity with specified <paramref name="entityId"/> not found.
        /// </exception>
        /// <remarks>
        /// When user group removed all users in that user group become ungroupped.
        /// </remarks>
        void UserGroupRemove(int entityId);

        #endregion                

        #region TASK

        /// <summary>
        /// Gets TaskBase entities.
        /// </summary>
        /// <returns>TaskBase entities.</returns>
        /// <remarks>
        /// When calling this function the reference properties UsedByTask,UsedByAppExe populated on the returned entities.
        /// </remarks>
        IEnumerable<Entities.TaskBase> TaskGet();

        /// <summary>
        /// Adds task.
        /// </summary>
        /// <param name="entity">TaskBase entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void TaskAdd(Entities.TaskBase entity);

        /// <summary>
        /// Updates task.
        /// </summary>
        /// <param name="entity">TaskBase entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void TaskUpdate(Entities.TaskBase entity);

        /// <summary>
        /// Removes task.
        /// </summary>
        /// <param name="entityId">TaskBase entity id.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown when entity with specified <paramref name="entityId"/> not found.
        /// </exception>
        void TaskRemove(int entityId);

        #endregion

        #region CLIENT TASK

        /// <summary>
        /// Gets ClientTask entities.
        /// </summary>
        /// <returns>ClientTask entities.</returns>
        /// <remarks>
        /// When calling this function the reference property TaskBase populated on the returned entities.
        /// By default the returned ClientTask entities are sorted by UseOrder property.
        /// </remarks>
        IEnumerable<Entities.ClientTask> ClientTaskGet();

        /// <summary>
        /// Adds client task.
        /// </summary>
        /// <param name="entity">ClientTask entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void ClientTaskAdd(Entities.ClientTask entity);

        /// <summary>
        /// Updates client task.
        /// </summary>
        /// <param name="entity">ClientTask entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void ClientTaskUpdate(Entities.ClientTask entity);

        /// <summary>
        /// Removes client task.
        /// </summary>
        /// <param name="entityId">ClientTask entity id.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown when entity with specified <paramref name="entityId"/> not found.
        /// </exception>
        void ClientTaskRemove(int entityId);

        #endregion

        #region USER

        /// <summary>
        /// Gets UserMember entities.
        /// </summary>
        /// <returns>UserMember entities.</returns>
        IEnumerable<Entities.UserMember> UserGet();

        /// <summary>
        /// Gets filtered UserMember entities.
        /// </summary>
        /// <param name="filters">Entity filters.</param>
        /// <returns>Filtered UserMember entities.</returns>
        IEnumerable<Entities.UserMember> UserGet(IEnumerable<Filter> filters);

        /// <summary>
        /// Gets UserMember by id.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <returns>
        /// Found user, null if no entity is found with specified <paramref name="entityId"/>.
        /// </returns>
        Entities.UserMember UserGet(int entityId);

        /// <summary>
        /// Gets user by username.
        /// </summary>
        /// <param name="username">Username.</param>
        /// <returns>Found user, null if no user is found with specified <paramref name="username"/>.</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if specified <paramref name="username"/> equals to null or empty string.
        /// </exception>
        Entities.UserMember UserGet(string username);

        /// <summary>
        /// Creates new user.
        /// </summary>
        /// <param name="entity">UserMember entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if specified <paramref name="entity"/> is null.
        /// </exception>
        void UserCreate(Entities.UserMember entity);

        /// <summary>
        /// Updates user.
        /// </summary>
        /// <param name="entity">UserMember entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if specified <paramref name="entity"/> is null.
        /// </exception>
        void UserUpdate(Entities.UserMember entity);

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
        byte[] UserPictureGet(int entityId);

        /// <summary>
        /// Sets user picture.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <param name="picture">New user picture value.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        void UserPictureSet(int entityId, byte[] picture);

        /// <summary>
        /// Sets user SmartCard UID.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <param name="smartCardUID">SmartCard UID string.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        void UserSmartCardUIDSet(int entityId, string smartCardUID);

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
        void UserRemove(int entityId);

        /// <summary>
        /// Deltes user.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        void UserDelete(int entityId);

        /// <summary>
        /// Undeletes user.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        void UserUndelete(int entityId);

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
        void UserRename(int entityId, string newUserName);

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
        void UserEmailSet(int entityId, string newUserEmail);

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
        void UserGroupSet(int entityId, int newGroup);

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
        void UserPasswordSet(int entityId, string newPassword);

        /// <summary>
        /// Sets user password.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <param name="newPassword">New password value.</param>
        /// <param name="allowNull">Indicates if null value allowed for specified <paramref name="newPassword"/>.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        void UserPasswordSet(int entityId, string newPassword, bool allowNull);

        /// <summary>
        /// Disables specified user.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <param name="enable">Enable value. Set true for disable user and false to enable.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        void UserDisable(int entityId, bool enable);

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
        bool UserCredentialsValid(int entityId, string password);

        /// <summary>
        /// Gets user balance.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <returns>User balance.</returns>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        UserBalance UserBalanceGet(int entityId);

        /// <summary>
        /// Gets users balance values.
        /// </summary>
        /// <returns>User balances.</returns>
        Dictionary<int,UserBalance> UserBalanceGet();

        /// <summary>
        /// Gets monetary amount for minutes.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <param name="minutesAmount">Amount of minutes.</param>
        /// <returns>Monetary amount minutes will cost.</returns>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        /// <remarks>
        /// This function will return zero if specified <paramref name="minutesAmount"/> equals zero.
        /// This function will returnt zero if specifed UserMember <paramref name="entityId"/> does not have a user group or billing profile attached to it.
        /// </remarks>
        decimal? GetMoneyForTime(int entityId, int minutesAmount);

        /// <summary>
        /// Gets amount of minutes for monetary amount.
        /// </summary>
        /// <param name="entityId">UserMember entity id.</param>
        /// <param name="moneyAmount">Amount of money.</param>
        /// <returns>Monetary amount minutes will cost.</returns>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        /// <remarks>
        /// This function will return zero if specified <paramref name="moneyAmount"/> equals zero.
        /// This function will returnt zero if specifed UserMember <paramref name="entityId"/> does not have a user group or billing profile attached to it.
        /// </remarks>
        double? GetTimeForMoney(int entityId, decimal moneyAmount);

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
        void UserNegativeBalanceEnable(int entityId, bool? enable);

        /// <summary>
        /// Gets user notes.
        /// </summary>
        /// <param name="userId">User id.</param>
        /// <returns>User notes.</returns>
        IEnumerable<Entities.UserNote> UserNoteGet(int userId);

        /// <summary>
        /// Gets user notes.
        /// </summary>
        /// <param name="filters">Filter set.</param>
        /// <returns>User notes.</returns>
        IEnumerable<Entities.UserNote> UserNoteGet(IEnumerable<Filter> filters);

        #endregion

        #region USER OPERATOR

        /// <summary>
        /// Gets UserOperator entities.
        /// </summary>
        /// <returns>UserOperator entities.</returns>
        IEnumerable<Entities.UserOperator> UserOperatorGet();

        /// <summary>
        /// Gets UserOperator entities.
        /// </summary>
        /// <param name="filters">Entity filters.</param>
        /// <returns>Filtered UserOperator entities.</returns>
        IEnumerable<Entities.UserOperator> UserOperatorGet(IEnumerable<Filter> filters);

        /// <summary>
        /// Gets UserOperator by id.
        /// </summary>
        /// <param name="entityId">UserOperator entity id.</param>
        /// <returns>
        /// UserOperator entity, null in case no operator found with specified <paramref name="entityId"/>.
        /// </returns>
        Entities.UserOperator UserOperatorGet(int entityId);

        /// <summary>
        /// Gets UserOperator by user name.
        /// </summary>
        /// <param name="username">Username.</param>
        /// <returns>UserOperator entity, null in case no user found with specified <paramref name="username"/> found.</returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if specified <paramref name="username"/> equals to null or empty string.
        /// </exception>
        Entities.UserOperator UserOperatorGet(string username);

        /// <summary>
        /// Creates new operator.
        /// </summary>
        /// <param name="entity">UserOperator entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if specified <paramref name="entity"/> is null.
        /// </exception>
        void UserOperatorCreate(Entities.UserOperator entity);

        /// <summary>
        /// Updates operator.
        /// </summary>
        /// <param name="entity">UserOperator entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if specified <paramref name="entity"/> is null.
        /// </exception>
        void UserOperatorUpdate(Entities.UserOperator entity);

        /// <summary>
        /// Deletes operator.
        /// </summary>
        /// <param name="entityId">UserOperator entity id.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if no operator found with specified <paramref name="entityId"/>.
        /// </exception>
        void UserOperatorDelete(int entityId);

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
        void UserOperatorRemove(int entityId);

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
        void UserOperatorPasswordSet(int entityId, string newPassword);

        #endregion

        #region LOG

        /// <summary>
        /// Gets Log entities.
        /// </summary>
        /// <returns>Log entities.</returns>
        IEnumerable<Entities.Log> LogGet();

        /// <summary>
        /// Gets Log entities.
        /// </summary>
        /// <param name="pattern">Message pattern.</param>
        /// <param name="maxDate">Maximum date.</param>
        /// <param name="pageNumber">Number of pages.</param>
        /// <param name="recordsPerPage">Maximum records per page.</param>
        /// <param name="totalRecords">Total records found in this query.</param>
        /// <returns>Log entities.</returns>
        IEnumerable<Entities.Log> LogGet(Entities.Log pattern, DateTime maxDate, int pageNumber, int recordsPerPage, out int totalRecords);

        /// <summary>
        /// Gets Log entity.
        /// </summary>
        /// <param name="entityId">Log entity id.</param>
        /// <returns>
        /// Log entity, null if entity with specified <paramref name="entityId"/> not found.
        /// </returns>
        /// <remarks>
        /// When calling this function the reference property Exception populated on the returned entity.
        /// </remarks>
        Entities.Log LogGet(int entityId);

        /// <summary>
        /// Adds log entity.
        /// </summary>
        /// <param name="entity">Log entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void LogAdd(Entities.Log entity);

        /// <summary>
        /// Removes all log entites up to specified date.
        /// </summary>
        /// <param name="time">Date time.</param>
        void LogRemove(DateTime time);

        #endregion

        #region MONETARY UNIT

        /// <summary>
        /// Gets MonetaryUnit entities.
        /// </summary>
        /// <returns>MonetaryUnit entities.</returns>
        /// <remarks>
        /// By default MonetaryUnit entities returned sorted by the their DisplayOrder.
        /// </remarks>
        IEnumerable<Entities.MonetaryUnit> MonetaryUnitGet();

        /// <summary>
        /// Adds monetary unit.
        /// </summary>
        /// <param name="entity">MonetaryUnit entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void MonetaryUnitAdd(Entities.MonetaryUnit entity);

        /// <summary>
        /// Updates monetary unit.
        /// </summary>
        /// <param name="entity">MonetaryUnit entity.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entity"/> is null.
        /// </exception>
        void MonetaryUnitUpdate(Entities.MonetaryUnit entity);

        /// <summary>
        /// Adds or update monetary unit set.
        /// </summary>
        /// <param name="entitySet">MonetaryUnit entities set.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when specified <paramref name="entitySet"/> is null.
        /// </exception>
        void MonetaryUnitUpdate(IEnumerable<Entities.MonetaryUnit> entitySet);

        /// <summary>
        /// Removes monetary unit.
        /// </summary>
        /// <param name="entityId">MonetaryUnit entity id.</param>
        /// <exception cref="EntityNotFoundException">
        /// Thrown when entity with specified <paramref name="entityId"/> not found.
        /// </exception>
        void MonetaryUnitRemove(int entityId);

        #endregion

        #region SETTINGS

        /// <summary>
        /// Sets a settings value.
        /// </summary>
        /// <param name="key">Settings key.</param>
        /// <param name="value">Settings value.</param>
        /// <param name="group">Settings group.</param>
        void SettingSet(string key, string value, string group);

        /// <summary>
        /// Gets a settings value.
        /// </summary>
        /// <typeparam name="T">Value type.</typeparam>
        /// <param name="key">Settings key.</param>
        /// <returns>Settings value.</returns>
        T SettingGet<T>(string key);

        #endregion

        #region USER ATTRIBUTES

        /// <summary>
        /// Gets UserAttribute entities.
        /// </summary>
        /// <returns>UserAttribute entities.</returns>
        IEnumerable<Entities.UserAttribute> UserAttributeGet();

        /// <summary>
        /// Gets filtered UserAttribute entities.
        /// </summary>
        /// <param name="filters">Entity filters.</param>
        /// <returns>Filtered UserAttribute entities.</returns>
        IEnumerable<Entities.UserAttribute> UserAttributeGet(IEnumerable<Filter> filters);

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
        void UserAttributeSetValue(int entityId, int attributeId, string attributeValue);

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
        void UserAttributeSetValue(int entityId, string attributeName, string attributeValue);

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
        string UserAttributeGetValue(int entityId, int attributeId);

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
        string UserAttributeGetValue(int entityId, string attributeName);

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
        bool UserAttributeRemove(int entityId, int attributeId);

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
        bool UserAttributeRemove(int entityId, string attributeName);

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
        decimal DepositBalanceGet(int userId);

        /// <summary>
        /// Gets deposit balances for all users.
        /// </summary>
        /// <returns>User id mapped points dictionary.</returns>
        /// <remarks>
        /// The dictionary might not contain all user ids, it will only contain users that have deposti transactions and thus have a deposit balance.
        /// If dictionary does not contain user it means that his deposit balance equals to zero.
        /// </remarks>
        Dictionary<int,decimal> DepositBalanceGet();

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
        int PointsBalanceGet(int userId);

        /// <summary>
        /// Gets point balances for all users.
        /// </summary>
        /// <returns>User id mapped points dictionary.</returns>
        /// <remarks>
        /// The dictionary might not contain all user ids, it will only contain users that have points transactions and thus have a points balance.
        /// If dictionary does not contain user it means that his points balance equals to zero.
        /// </remarks>
        Dictionary<int, int> PointsBalanceGet();

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
        bool MarkDeleted(IDeletable entity);

        #endregion

        #region USAGE SESSION

        /// <summary>
        /// Gets a list of active usage sessions.
        /// </summary>
        /// <returns>List of active usage sessions id's.</returns>
        IEnumerable<int> UsageSessionGetActive();

        /// <summary>
        /// Gets filtered UsageSession entities.
        /// </summary>
        /// <param name="filters">Entity filters.</param>
        /// <returns>Filtered UsageSession entities.</returns>
        IEnumerable<Entities.UsageSession> UsageSessionGet(IEnumerable<Filter> filters);

        /// <summary>
        /// Invoices specified usage session.
        /// </summary>
        /// <param name="entityId">UsageSession entity id.</param>
        /// <remarks>The usage session will be marked as inactive after invoicing.</remarks>
        /// <returns>Associated invoice. The function will return null if no active usage session existed.</returns>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if usage session with specified <paramref name="entityId"/> does not exist.
        /// </exception>
        Entities.Invoice UsageSessionInvoice(int entityId);

        /// <summary>
        /// Invoices active usage session.
        /// </summary>
        /// <remarks>The usage session will be marked as inactive after invoicing.</remarks>
        /// <param name="userId">User id.</param>
        /// <returns>Associated invoice. The function will return null if no active usage session exist.</returns>
        /// <exception cref="EntityNotFoundException">
        /// Thrown if user with specified <paramref name="userId"/> does not exist.
        /// </exception>
        Entities.Invoice UsageSessionInvoiceActive(int userId);

        #endregion

        #region RESERVATIONS

        /// <summary>
        /// Adds user to existing reservation.
        /// </summary>
        /// <param name="entityId">Reservation entity id.</param>
        /// <param name="userId">User entity id.</param>
        /// <exception cref="EntityNotFoundException">Thrown when entity specified by <paramref name="entityId"/> or <paramref name="userId"/> not found.</exception>
        Task ReservationUserAddAsync(int entityId, int userId);

        /// <summary>
        /// Removes user from reservation.
        /// </summary>
        /// <param name="entityId">Reservation entity id.</param>
        /// <param name="userId">User entity id.</param>
        /// <exception cref="EntityNotFoundException">Thrown when entity specified by <paramref name="entityId"/> or <paramref name="userId"/> not found.</exception>
        Task ReservationUserRemoveAsync(int entityId, int userId);

        /// <summary>
        /// Adds host to existing reservation.
        /// </summary>
        /// <param name="entityId">Reservation entity id.</param>
        /// <param name="hostId">Host entity id.</param>
        /// <exception cref="EntityNotFoundException">Thrown when entity specified by <paramref name="entityId"/> or <paramref name="hostId"/> not found.</exception>
        Task ReservationHostAddAsync(int entityId, int hostId);

        /// <summary>
        /// Removes host from existing reservation.
        /// </summary>
        /// <param name="entityId">Reservation entity id.</param>
        /// <param name="hostId">Host entity id.</param>
        /// <exception cref="EntityNotFoundException">Thrown when entity specified by <paramref name="entityId"/> or <paramref name="hostId"/> not found.</exception>
        Task ReservationHostRemoveAsync(int entityId, int hostId);

        /// <summary>
        /// Sets existing reservation status.
        /// </summary>
        /// <param name="entityId">Reservation entity id.</param>
        /// <param name="status">New status.</param>
        /// <exception cref="EntityNotFoundException">Thrown when entity specified by <paramref name="entityId"/> not found.</exception>
        Task ReservationStatusSetAsync(int entityId, ReservationStatus status);

        /// <summary>
        /// Gets status of specified reservation.
        /// </summary>
        /// <param name="entityId">Reservation entiity id.</param>
        /// <returns>Reservation status.</returns>
        /// <exception cref="EntityNotFoundException">Thrown when entity specified by <paramref name="entityId"/> not found.</exception>
        Task<ReservationStatus> ReservationStatusGetAsync(int entityId);

        /// <summary>
        /// Adds new reservation.
        /// </summary>
        /// <param name="entity">Reservation entity.</param>
        /// <returns>Reservation entity.</returns>
        /// <exception cref="HostReservationException">Thrown in case of an error.</exception>
        /// <exception cref="EntityNotFoundException">Thrown if one of the entities related to reservation is not found.</exception>
        Task<Entities.Reservation> ReservationAddAsync(Entities.Reservation entity);

        /// <summary>
        /// Updates existing reservation.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Reservation entity.</returns>
        /// <exception cref="HostReservationException">Thrown in case of an error.</exception>
        /// <exception cref="EntityNotFoundException">Thrown if one of the entities related to reservation is not found.</exception>
        Task ReservationUpdateAync(Entities.Reservation entity);

        /// <summary>
        /// Gets reservation infos.
        /// </summary>
        /// <param name="filter">Filter.</param>
        /// <returns>Filtered reservation infos.</returns>
        Task<IEnumerable<ReservationInfo>> ReservationInfoGetAsync(ReservationFilter filter);

        /// <summary>
        /// Gets reservation info by id.
        /// </summary>
        /// <param name="entityId">Reservation entity id.</param>
        /// <returns>Reservation info.</returns>
        /// <exception cref="EntityNotFoundException">Thrown when entity specified by <paramref name="entityId"/> not found.</exception>
        Task<ReservationInfo> ReservationInfoGetByIdAsync(int entityId);

        #endregion
    }

    #endregion
}
