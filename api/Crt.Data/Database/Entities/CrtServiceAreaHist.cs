using System;
using System.Collections.Generic;

namespace Crt.Data.Database.Entities
{
    /// <summary>
    /// Service Area lookup values
    /// </summary>
    public partial class CrtServiceAreaHist
    {
        /// <summary>
        /// Unique idenifier for history table records 
        /// </summary>
        public long ServiceAreaHistId { get; set; }
        /// <summary>
        /// Unique idenifier for table records
        /// </summary>
        public decimal ServiceAreaId { get; set; }
        /// <summary>
        /// Assigned number of the Service Area
        /// </summary>
        public decimal ServiceAreaNumber { get; set; }
        /// <summary>
        /// Name of the service area
        /// </summary>
        public string ServiceAreaName { get; set; }
        /// <summary>
        /// Unique identifier for DISTRICT.
        /// </summary>
        public decimal DistrictId { get; set; }
        public DateTime EffectiveDateHist { get; set; }
        /// <summary>
        /// Date the entity ends or changes
        /// </summary>
        public DateTime? EndDate { get; set; }
        public DateTime? EndDateHist { get; set; }
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
    }
}
