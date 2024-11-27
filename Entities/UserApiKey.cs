using System;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// User api key entity.
    /// </summary>
    public sealed class UserApiKey : UserOperator
    {
        /// <summary>
        /// Gets or sets the api key.
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or sets the api key type.
        /// </summary>
        public ApiKeyType Type { get; set; }

        /// <summary>
        /// Gets or sets the api key expire time.
        /// </summary>
        public DateTime? ExpireTime { get; set; }
    }
}
