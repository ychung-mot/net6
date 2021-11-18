using System;
using System.Collections.Generic;

namespace Crt.Data.Database.Entities
{
    /// <summary>
    /// Ministry Districts lookup values.
    /// </summary>
    public partial class CrtDistrict
    {
        public CrtDistrict()
        {
            CrtRegionDistricts = new HashSet<CrtRegionDistrict>();
            CrtServiceAreas = new HashSet<CrtServiceArea>();
        }

        /// <summary>
        /// Unique identifier for district records
        /// </summary>
        public decimal DistrictId { get; set; }
        /// <summary>
        /// Number assigned to represent the District
        /// </summary>
        public decimal DistrictNumber { get; set; }
        /// <summary>
        /// The name of the District
        /// </summary>
        public string DistrictName { get; set; }
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

        public virtual ICollection<CrtRegionDistrict> CrtRegionDistricts { get; set; }
        public virtual ICollection<CrtServiceArea> CrtServiceAreas { get; set; }
    }
}
