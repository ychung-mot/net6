using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace Crt.Data.Database.Entities
{
    /// <summary>
    /// Defines CRT project elements
    /// </summary>
    public partial class CrtSegmentHist
    {
        /// <summary>
        /// A system generated unique identifier.
        /// </summary>
        public decimal SegmentHistId { get; set; }
        /// <summary>
        /// A system generated unique identifier.
        /// </summary>
        public decimal SegmentId { get; set; }
        /// <summary>
        /// A system generated unique identifier.
        /// </summary>
        public decimal ProjectId { get; set; }
        /// <summary>
        /// Segment description field which provides more information to better qualify the segment. It is stored and displayed on the project segment screen alongside the start and end coordinates
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Spatial Coordinates denoting the starting Latitude for the project/project segment
        /// </summary>
        public decimal? StartLatitude { get; set; }
        /// <summary>
        /// Spatial Coordinates denoting the starting Longitude for the project/project segment	
        /// </summary>
        public decimal? StartLongitude { get; set; }
        /// <summary>
        /// Spatial Coordinates denoting the End Latitude for the project/project segment
        /// </summary>
        public decimal? EndLatitude { get; set; }
        /// <summary>
        /// Spatial Coordinates denoting the end Longitude for the project/project segment
        /// </summary>
        public decimal? EndLongitude { get; set; }
        /// <summary>
        /// Line or point depicting the underlying geometry  	
        /// </summary>
        public Geometry Geometry { get; set; }
        /// <summary>
        /// Date the project is completed. This shows is proxy for project status, either active or complete
        /// </summary>
        public DateTime? EndDate { get; set; }
        public DateTime? EndDateHist { get; set; }
        public DateTime EffectiveDateHist { get; set; }
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
