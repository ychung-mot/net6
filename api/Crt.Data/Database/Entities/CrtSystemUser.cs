using System;
using System.Collections.Generic;

namespace Crt.Data.Database.Entities
{
    /// <summary>
    /// Defines users and their attributes as found in IDIR
    /// </summary>
    public partial class CrtSystemUser
    {
        public CrtSystemUser()
        {
            CrtRegionUsers = new HashSet<CrtRegionUser>();
            CrtUserRoles = new HashSet<CrtUserRole>();
        }

        /// <summary>
        /// A system generated unique identifier.
        /// </summary>
        public decimal SystemUserId { get; set; }
        /// <summary>
        /// This ID is used to track Keycloak client ID created for the users
        /// </summary>
        public string ApiClientId { get; set; }
        /// <summary>
        /// A system generated unique identifier.  Reflects the active directory unique idenifier for the user.
        /// </summary>
        public Guid? UserGuid { get; set; }
        /// <summary>
        /// IDIR or BCeID Active Directory defined universal identifier (SM_UNIVERSALID or userID) attributed to a user.  This value can change over time, while USER_GUID will remain consistant.
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// First Name of the user
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Last Name of the user
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Contact email address within Active Directory (Email = SMGOV_EMAIL)
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Date a user can no longer access the system or invoke data submissions.
        /// </summary>
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Record under edit indicator used for optomisitc record contention management.  If number differs from start of edit, then user will be prompted to that record has been updated by someone else.
        /// </summary>
        public long ConcurrencyControlNumber { get; set; }
        /// <summary>
        /// Unique idenifier of user who created record
        /// </summary>
        public string AppCreateUserid { get; set; }
        /// <summary>
        /// Date and time of record creation
        /// </summary>
        public DateTime AppCreateTimestamp { get; set; }
        /// <summary>
        /// Unique idenifier of user who created record
        /// </summary>
        public Guid AppCreateUserGuid { get; set; }
        /// <summary>
        /// Unique idenifier of user who last updated record
        /// </summary>
        public string AppLastUpdateUserid { get; set; }
        /// <summary>
        /// Date and time of last record update
        /// </summary>
        public DateTime AppLastUpdateTimestamp { get; set; }
        /// <summary>
        /// Unique idenifier of user who last updated record
        /// </summary>
        public Guid AppLastUpdateUserGuid { get; set; }
        /// <summary>
        /// Named database user who created record
        /// </summary>
        public string DbAuditCreateUserid { get; set; }
        /// <summary>
        /// Date and time record created in the database
        /// </summary>
        public DateTime DbAuditCreateTimestamp { get; set; }
        /// <summary>
        /// Named database user who last updated record
        /// </summary>
        public string DbAuditLastUpdateUserid { get; set; }
        /// <summary>
        /// Date and time record was last updated in the database.
        /// </summary>
        public DateTime DbAuditLastUpdateTimestamp { get; set; }

        public virtual ICollection<CrtRegionUser> CrtRegionUsers { get; set; }
        public virtual ICollection<CrtUserRole> CrtUserRoles { get; set; }
    }
}
