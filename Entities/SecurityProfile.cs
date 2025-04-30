using ProtoBuf;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Security profile entity.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [ProtoContract()]
    public class SecurityProfile : ModifiableByOperatorBase
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Creates new instance.
        /// </summary>
        public SecurityProfile()
            : base()
        {
            Restrictions = new HashSet<SecurityProfileRestriction>();
            Policies = new HashSet<SecurityProfilePolicy>();
            HostGroups = new HashSet<HostGroup>();
            UserGroups = new HashSet<UserGroup>();
        }
        #endregion

        [NonSerialized()]
        private bool _disableStartMenu;
        [NonSerialized()]
        private bool _stickyShell;
        [NonSerialized()]
        private bool _disableDesktopSwitching;

        #region PROPERTIES

        /// <summary>
        /// Gets or sets profile name.
        /// </summary>
        [DataMember()]
        [ProtoMember(1)]
        [Required()]
        [StringLength(45)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets disabled drives.
        /// </summary>
        [DataMember()]
        [ProtoMember(2)]
        public int DisabledDrives
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets disable start menu.
        /// </summary>
        public bool DisableStartMenu
        {
            get { return _disableStartMenu; }
            set { _disableStartMenu = value; }
        }

        /// <summary>
        /// Gets or sets disable desktop switching.
        /// </summary>
        public bool DisableDesktopSwitching
        {
            get { return _disableDesktopSwitching; }
            set { _disableDesktopSwitching = value; }
        }

        /// <summary>
        /// Gets or sets sticky shell.
        /// </summary>
        public bool StickyShell
        {
            get { return _stickyShell; }
            set { _stickyShell = value; }
        }

        #endregion

        #region NAVIGATION PROPERTIES

        /// <summary>
        /// Gets restrictions.
        /// </summary>
        [DataMember()]
        [ProtoMember(3)]
        public virtual ISet<SecurityProfileRestriction> Restrictions
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets policies.
        /// </summary>
        [DataMember()]
        [ProtoMember(4)]
        public virtual ISet<SecurityProfilePolicy> Policies
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets host groups.
        /// </summary>
        public virtual ISet<HostGroup> HostGroups
        {
            get;
            protected set;
        }

        /// <summary>
        /// Gets user groups.
        /// </summary>
        public virtual ISet<UserGroup> UserGroups
        {
            get;
            protected set;
        }

        #endregion
    }
}
