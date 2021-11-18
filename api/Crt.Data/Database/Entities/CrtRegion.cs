using System;
using System.Collections.Generic;

namespace Crt.Data.Database.Entities
{
    /// <summary>
    /// Ministry Region lookup values
    /// </summary>
    public partial class CrtRegion
    {
        public CrtRegion()
        {
            CrtProjects = new HashSet<CrtProject>();
            CrtRegionDistricts = new HashSet<CrtRegionDistrict>();
            CrtRegionUsers = new HashSet<CrtRegionUser>();
        }

        /// <summary>
        /// Unique ID for a ministry organizational unit (Region) responsible for an exclusive geographic area within the province.  
        /// </summary>
        public decimal RegionId { get; set; }
        /// <summary>
        /// Number assigned to the Ministry region
        /// </summary>
        public decimal RegionNumber { get; set; }
        /// <summary>
        /// Name of the Ministry region
        /// </summary>
        public string RegionName { get; set; }
        /// <summary>
        /// Date the entity ends or changes
        /// </summary>
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Record under edit indicator used for optomisitc record contention management.  If number differs from start of edit, then user will be prompted to that record has been updated by someone else.
        /// </summary>
        public long ConcurrencyControlNumber { get; set; }
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

        public virtual ICollection<CrtProject> CrtProjects { get; set; }
        public virtual ICollection<CrtRegionDistrict> CrtRegionDistricts { get; set; }
        public virtual ICollection<CrtRegionUser> CrtRegionUsers { get; set; }
    }
}
