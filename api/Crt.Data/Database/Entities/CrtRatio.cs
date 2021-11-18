using System;
using System.Collections.Generic;

namespace Crt.Data.Database.Entities
{
    /// <summary>
    /// Defines CRT financial targets
    /// </summary>
    public partial class CrtRatio
    {
        /// <summary>
        /// A system generated unique identifier.
        /// </summary>
        public decimal RatioId { get; set; }
        /// <summary>
        /// A system generated unique identifier.
        /// </summary>
        public decimal ProjectId { get; set; }
        /// <summary>
        /// Proportion of the project that falls within a ratio object e.g. electoral district,economic region, highway
        /// </summary>
        public decimal? Ratio { get; set; }
        /// <summary>
        /// Link to code lookup table ratio record values for electoral district, economic region, highway
        /// </summary>
        public decimal? RatioRecordLkupId { get; set; }
        /// <summary>
        /// Link to code lookup table for type of record i.e. service area, electoral district, economic region, highway, district
        /// </summary>
        public decimal RatioRecordTypeLkupId { get; set; }
        /// <summary>
        /// Unique idenifier for service area
        /// </summary>
        public decimal? ServiceAreaId { get; set; }
        /// <summary>
        /// Unique idenifier for districts
        /// </summary>
        public decimal? DistrictId { get; set; }
        /// <summary>
        /// Date the project is completed. This shows is proxy for project status, either active or complete
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

        public virtual CrtProject Project { get; set; }
        public virtual CrtCodeLookup RatioRecordLkup { get; set; }
        public virtual CrtCodeLookup RatioRecordTypeLkup { get; set; }
    }
}
