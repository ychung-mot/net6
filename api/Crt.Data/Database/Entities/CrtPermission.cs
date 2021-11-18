using System;
using System.Collections.Generic;

namespace Crt.Data.Database.Entities
{
    /// <summary>
    /// Permission definition table for assignment to individual system users.
    /// </summary>
    public partial class CrtPermission
    {
        public CrtPermission()
        {
            CrtRolePermissions = new HashSet<CrtRolePermission>();
        }

        /// <summary>
        /// Unique identifier for a record
        /// </summary>
        public decimal PermissionId { get; set; }
        /// <summary>
        /// Business name for a permission
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Description of a permission.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Date permission was deactivated
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

        public virtual ICollection<CrtRolePermission> CrtRolePermissions { get; set; }
    }
}
