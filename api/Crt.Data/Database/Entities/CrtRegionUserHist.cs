using System;
using System.Collections.Generic;

namespace Crt.Data.Database.Entities
{
    /// <summary>
    /// History of association between USER and REGION defining which users can submit or access data.
    /// </summary>
    public partial class CrtRegionUserHist
    {
        /// <summary>
        /// Unique identifier for REGION History
        /// </summary>
        public long RegionUserHistId { get; set; }
        /// <summary>
        /// Unique identifier for REGION
        /// </summary>
        public decimal RegionUserId { get; set; }
        /// <summary>
        /// identifier for REGION
        /// </summary>
        public decimal RegionId { get; set; }
        /// <summary>
        /// Unique identifier of related user
        /// </summary>
        public decimal SystemUserId { get; set; }
        public DateTime EffectiveDateHist { get; set; }
        /// <summary>
        /// Date reflecting when a user can no longer transmit submissions.
        /// </summary>
        public DateTime? EndDate { get; set; }
        public DateTime? EndDateHist { get; set; }
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
    }
}
