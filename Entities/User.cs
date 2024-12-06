#nullable enable

using ProtoBuf;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// User base entity.
    /// </summary>
    [DataContract()]
    [Serializable()]
    [ProtoContract()]
    public class User : ModifiableByUserBase,
        IDeletable,
        IDisable,
        IReplicatable,
        IBranchedOptionalEntity
    {
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public User()
            : base()
        {
            Guid = Guid.NewGuid();
            Permissions = new HashSet<UserPermission>();
            CreatedUserSessions = new HashSet<UserSession>();
            CreatedUserSessionChanges = new HashSet<UserSessionChange>();
            Attributes = new HashSet<UserAttribute>();
            Tokens = new HashSet<Token>();
            Verifications = new HashSet<Verification>();
            UserAgreementStates = new HashSet<UserAgreementState>();
        }

        [NonSerialized()]
        private Branch? _branch;

        [NonSerialized()]
        private ISet<UserChannel> _channels = new HashSet<UserChannel>();

        [NonSerialized()]
        private UserPermissionSet? _permissionSet;

        /// <summary>
        /// Gets or sets first name.
        /// </summary>
        [DataMember()]
        [StringLength(45)]
        [ProtoMember(1)]
        public string? FirstName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets last name.
        /// </summary>
        [DataMember()]
        [StringLength(45)]
        [ProtoMember(2)]
        public string? LastName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets birth date.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public DateTime? BirthDate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets address.
        /// </summary>
        [DataMember()]
        [StringLength(255)]
        [ProtoMember(4)]
        public string? Address
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets city.
        /// </summary>
        [DataMember()]
        [StringLength(45)]
        [ProtoMember(5)]
        public string? City
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets country.
        /// </summary>
        [DataMember()]
        [StringLength(45)]
        [ProtoMember(6)]
        public string? Country
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets post code.
        /// </summary>
        [DataMember()]
        [StringLength(20)]
        [ProtoMember(7)]
        public string? PostCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets phone number.
        /// </summary>
        [DataMember()]
        [StringLength(20)]
        [ProtoMember(8)]
        public string? Phone
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets mobile phone number.
        /// </summary>
        [DataMember()]
        [StringLength(20)]
        [ProtoMember(9)]
        public string? MobilePhone
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets sex.
        /// </summary>
        [DataMember()]
        [ProtoMember(10)]
        public SharedLib.Sex Sex
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if user is deleted.
        /// </summary>
        [DataMember()]
        [ProtoMember(11)]
        public bool IsDeleted
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets if user is enabled.
        /// </summary>
        [DataMember()]
        [ProtoMember(12)]
        public bool IsDisabled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets item guid.
        /// </summary>
        [Required()]
        [DataMember()]
        [ProtoMember(13)]
        public Guid Guid
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets SmartCard UID.
        /// </summary>
        [DataMember()]
        [StringLength(255)]
        [ProtoMember(14)]
        public string? SmartCardUID
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets identification number.
        /// </summary>
        [DataMember()]
        [StringLength(255)]
        [ProtoMember(15)]
        public string? Identification
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets preferred channel.
        /// </summary>
        public Guid? PreferredChannel { get; set; }

        /// <summary>
        /// Gets or sets user permission set id.
        /// </summary>
        public int? PermissionSetId { get; set; }

        /// <inheritdoc/>  
        /// <remarks>
        /// This value optionally identifies at which branch user where created.
        /// </remarks>
        public int? BranchId
        {
            get; set;
        }

        /// <inheritdoc/>  
        public virtual Branch? Branch
        {
            get { return _branch; }
            protected set { _branch = value; }
        }

        /// <summary>
        /// Gets user credentials.
        /// </summary>
        public virtual UserCredential? UserCredential
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets user picture.
        /// </summary>
        public virtual UserPicture? UserPicture
        {
            get;
            set;
        }

        /// <summary>
        /// Gets user claims.
        /// </summary>
        [ProtoMember(16)]
        public virtual ISet<UserPermission> Permissions
        {
            get;
            protected set;
        }

        /// <summary>
        /// Get or sets user attributes.
        /// </summary>
        [ProtoMember(17)]
        public virtual ISet<UserAttribute> Attributes
        {
            get; protected set;
        }

        /// <summary>
        /// Gets or sets created user sessions.
        /// </summary>
        public virtual ISet<UserSession> CreatedUserSessions
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets created user session changes.
        /// </summary>
        public virtual ISet<UserSessionChange> CreatedUserSessionChanges
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets or sets user tokens.
        /// </summary>
        public virtual ISet<Token> Tokens
        {
            get; protected set;
        }

        /// <summary>
        /// Gets or sets verifications.
        /// </summary>
        public virtual ISet<Verification> Verifications
        {
            get; protected set;
        }

        /// <summary>
        /// Gets or sets user agreement states.
        /// </summary>
        public virtual ISet<UserAgreementState> UserAgreementStates
        {
            get; protected set;
        }

        /// <summary>
        /// Gets or sets user channels.
        /// </summary>
        public virtual ISet<UserChannel> Channels
        {
            get { return _channels; }
            set { _channels = value; }
        }

        /// <summary>
        /// Gets or sets user permission set.
        /// </summary>
        public UserPermissionSet? PermissionSet
        {
            get { return _permissionSet; }
            set { _permissionSet = value; }
        }
    }
}
