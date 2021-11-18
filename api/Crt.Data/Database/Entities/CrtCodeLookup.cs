using System;
using System.Collections.Generic;

namespace Crt.Data.Database.Entities
{
    /// <summary>
    /// A range of lookup values used to decipher codes used in submissions to business legible values for reporting purposes.  As many code lookups share this table, views are available to join for reporting purposes.
    /// </summary>
    public partial class CrtCodeLookup
    {
        public CrtCodeLookup()
        {
            CrtElementProgramCategoryLkups = new HashSet<CrtElement>();
            CrtElementProgramLkups = new HashSet<CrtElement>();
            CrtElementServiceLineLkups = new HashSet<CrtElement>();
            CrtFinTargetFiscalYearLkups = new HashSet<CrtFinTarget>();
            CrtFinTargetFundingTypeLkups = new HashSet<CrtFinTarget>();
            CrtFinTargetPhaseLkups = new HashSet<CrtFinTarget>();
            CrtProjectCapIndxLkups = new HashSet<CrtProject>();
            CrtProjectNearstTwnLkups = new HashSet<CrtProject>();
            CrtProjectProjectMgrLkups = new HashSet<CrtProject>();
            CrtProjectRcLkups = new HashSet<CrtProject>();
            CrtQtyAccmpFiscalYearLkups = new HashSet<CrtQtyAccmp>();
            CrtQtyAccmpQtyAccmpLkups = new HashSet<CrtQtyAccmp>();
            CrtRatioRatioRecordLkups = new HashSet<CrtRatio>();
            CrtRatioRatioRecordTypeLkups = new HashSet<CrtRatio>();
            CrtTenders = new HashSet<CrtTender>();
        }

        /// <summary>
        /// Unique identifier for a record.
        /// </summary>
        public decimal CodeLookupId { get; set; }
        /// <summary>
        /// Unique identifier for a group of lookup codes.  A database view is available for each group for use in analytics.
        /// </summary>
        public string CodeSet { get; set; }
        /// <summary>
        /// Display name or business name for a submission value.  These values are for display in analytical reporting.
        /// </summary>
        public string CodeName { get; set; }
        /// <summary>
        /// Look up code values provided in submissions.   These values are used for validating submissions and for display of CODE NAMES in analytical reporting.  Values must be unique per CODE SET.
        /// </summary>
        public string CodeValueText { get; set; }
        /// <summary>
        ///  Numeric enumeration values provided in submissions.   These values are used for validating submissions and for display of CODE NAMES in analytical reporting.  Values must be unique per CODE SET.
        /// </summary>
        public decimal? CodeValueNum { get; set; }
        /// <summary>
        /// Specifies if the code value is text or numeric.
        /// </summary>
        public string CodeValueFormat { get; set; }
        /// <summary>
        /// When displaying list of values, value can be used to present list in desired order.
        /// </summary>
        public decimal? DisplayOrder { get; set; }
        /// <summary>
        /// The latest date submissions will be accepted.
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

        public virtual ICollection<CrtElement> CrtElementProgramCategoryLkups { get; set; }
        public virtual ICollection<CrtElement> CrtElementProgramLkups { get; set; }
        public virtual ICollection<CrtElement> CrtElementServiceLineLkups { get; set; }
        public virtual ICollection<CrtFinTarget> CrtFinTargetFiscalYearLkups { get; set; }
        public virtual ICollection<CrtFinTarget> CrtFinTargetFundingTypeLkups { get; set; }
        public virtual ICollection<CrtFinTarget> CrtFinTargetPhaseLkups { get; set; }
        public virtual ICollection<CrtProject> CrtProjectCapIndxLkups { get; set; }
        public virtual ICollection<CrtProject> CrtProjectNearstTwnLkups { get; set; }
        public virtual ICollection<CrtProject> CrtProjectProjectMgrLkups { get; set; }
        public virtual ICollection<CrtProject> CrtProjectRcLkups { get; set; }
        public virtual ICollection<CrtQtyAccmp> CrtQtyAccmpFiscalYearLkups { get; set; }
        public virtual ICollection<CrtQtyAccmp> CrtQtyAccmpQtyAccmpLkups { get; set; }
        public virtual ICollection<CrtRatio> CrtRatioRatioRecordLkups { get; set; }
        public virtual ICollection<CrtRatio> CrtRatioRatioRecordTypeLkups { get; set; }
        public virtual ICollection<CrtTender> CrtTenders { get; set; }
    }
}
