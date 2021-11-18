using System;
using System.Collections.Generic;

namespace Crt.Data.Database.Entities
{
    /// <summary>
    /// Defines CRT project quantity and accomplishment
    /// </summary>
    public partial class CrtQtyAccmpHist
    {
        /// <summary>
        /// A system generated unique identifier.
        /// </summary>
        public decimal QtyAccmpHistId { get; set; }
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
        public decimal? FiscalYearLkupId { get; set; }
        /// <summary>
        /// Fiscal Year lookup ID associated with Financial Target 
        /// </summary>
        public decimal? QtyAccmpLkupId { get; set; }
        /// <summary>
        /// Dollar value associated with financial target
        /// </summary>
        public decimal? Forecast { get; set; }
        /// <summary>
        /// Forecast type allows users to plan their program outside the bounds of current fiscal/allocation	
        /// </summary>
        public decimal? Schedule7 { get; set; }
        /// <summary>
        /// Project Element ID FK
        /// </summary>
        public decimal? Actual { get; set; }
        /// <summary>
        /// Description of the selected financial target - planning to be completed in the next fiscal year
        /// </summary>
        public string Comment { get; set; }
        public DateTime EffectiveDateHist { get; set; }
        /// <summary>
        /// Date the project is completed. This shows is proxy for project status, either active or complete
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
