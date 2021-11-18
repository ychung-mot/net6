using System;
using System.Collections.Generic;

namespace Crt.Data.Database.Entities
{
    /// <summary>
    /// Defines CRT project quantity and accomplishment
    /// </summary>
    public partial class CrtQtyAccmp
    {
        /// <summary>
        /// A system generated unique identifier.
        /// </summary>
        public decimal QtyAccmpId { get; set; }
        /// <summary>
        /// ID linked with the project
        /// </summary>
        public decimal ProjectId { get; set; }
        /// <summary>
        /// Unique identifier linked with fiscal year on the look up table
        /// </summary>
        public decimal FiscalYearLkupId { get; set; }
        /// <summary>
        /// Unique identifier linked with the look up table offering extra attributes
        /// </summary>
        public decimal QtyAccmpLkupId { get; set; }
        /// <summary>
        /// forecast value associated with quantity or accomplishment
        /// </summary>
        public decimal? Forecast { get; set; }
        /// <summary>
        /// determined value of quantity before the actual. Can only apply to quantity
        /// </summary>
        public decimal? Schedule7 { get; set; }
        /// <summary>
        /// actual value of quantity or accomplishment.
        /// </summary>
        public decimal? Actual { get; set; }
        /// <summary>
        /// comments on entries associated with either quantity or accomplishment
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// Marks the status of quantity and/or accomplishment item
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

        public virtual CrtCodeLookup FiscalYearLkup { get; set; }
        public virtual CrtProject Project { get; set; }
        public virtual CrtCodeLookup QtyAccmpLkup { get; set; }
    }
}
