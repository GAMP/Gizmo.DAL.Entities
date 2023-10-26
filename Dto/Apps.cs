using Gizmo.DAL.Entities;

using ProtoBuf;

using ServerService;

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GizmoDALV2.DTO
{
    #region AppEntityContainer
    /// <summary>
    /// App entity container dto.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class AppEntityContainer
    {
        #region FIELDS
        private IEnumerable<AppEnterprise> enterprises;
        private IEnumerable<AppCategory> categories;
        private IEnumerable<App> apps;
        private IEnumerable<AppExe> executables;
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Get or sets enterprises.
        /// </summary>
        [ProtoMember(1, AsReference = true)]
        [DataMember()]
        public IEnumerable<AppEnterprise> Enterprises
        {
            get
            {
                if (enterprises == null)
                    enterprises = new List<AppEnterprise>();
                return enterprises;
            }
            set
            {
                enterprises = value;
            }
        }

        /// <summary>
        /// Gets or sets categories.
        /// </summary>
        [ProtoMember(2, AsReference = true)]
        [DataMember()]
        public IEnumerable<AppCategory> Categories
        {
            get
            {
                if (categories == null)
                    categories = new List<AppCategory>();
                return categories;
            }
            set
            {
                categories = value;
            }
        }

        /// <summary>
        /// Gets or sets apps.
        /// </summary>
        [ProtoMember(3, AsReference = true)]
        [DataMember()]
        public IEnumerable<App> Apps
        {
            get
            {
                if (apps == null)
                    apps = new List<App>();
                return apps;
            }
            set
            {
                apps = value;
            }
        }

        /// <summary>
        /// Gets or sets executables.
        /// </summary>
        [ProtoMember(4, AsReference = true)]
        [DataMember()]
        public IEnumerable<AppExe> Executables
        {
            get
            {
                if (executables == null)
                    executables = new List<AppExe>();
                return executables;
            }
            set
            {
                executables = value;
            }
        }

        #endregion
    }
    #endregion

    #region AppInfoContainer
    /// <summary>
    /// Application info container.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class AppInfoContainer
    {
        #region FIELDS
        private IEnumerable<ServerService.AppRating> appRatings;
        private IEnumerable<ServerService.AppStat> appStats;
        private IEnumerable<AppExeStat> appExe;
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets app ratings.
        /// </summary>
        [ProtoMember(1)]
        [DataMember()]
        public IEnumerable<ServerService.AppRating> AppRating
        {
            get
            {
                if (appRatings == null)
                    appRatings = new List<ServerService.AppRating>();
                return appRatings;
            }
            set
            {
                appRatings = value;
            }
        }

        /// <summary>
        /// Gets or sets app stats.
        /// </summary>
        [ProtoMember(2)]
        [DataMember()]
        public IEnumerable<ServerService.AppStat> AppStat
        {
            get
            {
                if (appStats == null)
                    appStats = new List<ServerService.AppStat>();
                return appStats;
            }
            set
            {
                appStats = value;
            }
        }

        /// <summary>
        /// Gets or sets app exe stat.
        /// </summary>
        [ProtoMember(3)]
        [DataMember()]
        public IEnumerable<AppExeStat> AppExeStat
        {
            get
            {
                if (appExe == null)
                    appExe = new List<AppExeStat>();
                return appExe;
            }
            set
            {
                appExe = value;
            }
        }

        #endregion
    }
    #endregion

    #region NewsEntityContainer
    /// <summary>
    /// News and adds entity container.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class NewsEntityContainer
    {
        #region FILEDS
        IEnumerable<News> news;
        IEnumerable<Feed> feeds;
        #endregion

        #region PROPERTIES

        /// <summary>
        /// Gets or sets news.
        /// </summary>
        [ProtoMember(1)]
        public IEnumerable<News> News
        {
            get
            {
                if (news == null)
                    news = new List<News>();
                return news;
            }
            set { news = value; }
        }

        /// <summary>
        /// Gets or sets feeds.
        /// </summary>
        [ProtoMember(2)]
        public IEnumerable<Feed> Feeds
        {
            get
            {
                if (feeds == null)
                    feeds = new List<Feed>();
                return feeds;
            }
            set { feeds = value; }
        }

        #endregion
    }
    #endregion
}
