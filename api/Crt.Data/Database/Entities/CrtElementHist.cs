using System;
using System.Collections.Generic;

namespace Crt.Data.Database.Entities
{
    /// <summary>
    /// Defines CRT project element history
    /// </summary>
    public partial class CrtElementHist
    {
        /// <summary>
        /// A system generated unique identifier.
        /// </summary>
        public decimal ElementHistId { get; set; }
        /// <summary>
        /// A system generated unique identifier.
        /// </summary>
        public decimal ElementId { get; set; }
        /// <summary>
        /// Unique identifier for element code
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Description of project element
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Comment on project element
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// Lookup ID for the program within the program category to which the element belongs (e.g. RSIP, SRIP)
        /// </summary>
        public decimal? ProgramLkupId { get; set; }
        /// <summary>
        /// Lookup ID for the funding vertical within which the element belongs (e.g. Transit, Preservation, Capital)
        /// </summary>
        public decimal? ProgramCategoryLkupId { get; set; }
        /// <summary>
        /// Lookup ID for the code to which Element is charged
        /// </summary>
        public decimal? ServiceLineLkupId { get; set; }
        /// <summary>
        /// Active flag for Element
        /// </summary>
        public bool? IsActive { get; set; }
        /// <summary>
        /// Number with which project element is ordered on the UI
        /// </summary>
        public decimal? DisplayOrder { get; set; }
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
