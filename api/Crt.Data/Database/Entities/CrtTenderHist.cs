using System;
using System.Collections.Generic;

namespace Crt.Data.Database.Entities
{
    /// <summary>
    /// Defines CRT tender for the project
    /// </summary>
    public partial class CrtTenderHist
    {
        /// <summary>
        /// A system generated unique identifier.
        /// </summary>
        public decimal TenderHistId { get; set; }
        /// <summary>
        /// A system generated unique identifier.
        /// </summary>
        public decimal TenderId { get; set; }
        /// <summary>
        /// ID linked with the project
        /// </summary>
        public decimal ProjectId { get; set; }
        /// <summary>
        /// Number associated with a tender
        /// </summary>
        public string TenderNumber { get; set; }
        /// <summary>
        /// Date the tender is planned for
        /// </summary>
        public DateTime? PlannedDate { get; set; }
        /// <summary>
        /// Date that tender actually takes place
        /// </summary>
        public DateTime? ActualDate { get; set; }
        /// <summary>
        /// Dollar value of tender. This field is captured on the screen as  &quot;Ministry Estimate&quot;
        /// </summary>
        public decimal? TenderValue { get; set; }
        /// <summary>
        /// Unique identifier for the winning contractor of the tender
        /// </summary>
        public decimal? WinningCntrctrLkupId { get; set; }
        /// <summary>
        /// Bid amount in response to tender
        /// </summary>
        public decimal? BidValue { get; set; }
        /// <summary>
        /// Comments on the tender item
        /// </summary>
        public string Comment { get; set; }
        public DateTime? EffectiveDateHist { get; set; }
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
