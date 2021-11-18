using System;
using System.Collections.Generic;

namespace Crt.Data.Database.Entities
{
    /// <summary>
    /// Ministry Region District lookup values
    /// </summary>
    public partial class CrtRegionDistrict
    {
        /// <summary>
        /// Unique identifier
        /// </summary>
        public decimal RegionDistrictId { get; set; }
        /// <summary>
        /// unique identifier for Ministry region
        /// </summary>
        public decimal RegionId { get; set; }
        /// <summary>
        /// unique identifier for Ministry district
        /// </summary>
        public decimal DistrictId { get; set; }
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

        public virtual CrtDistrict District { get; set; }
        public virtual CrtRegion Region { get; set; }
    }
}
