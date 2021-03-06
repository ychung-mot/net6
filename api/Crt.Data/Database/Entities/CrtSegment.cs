using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace Crt.Data.Database.Entities
{
    public partial class CrtSegment
    {
        public decimal SegmentId { get; set; }
        public decimal ProjectId { get; set; }
        /// <summary>
        /// Segment description field which provides more information to better qualify the segment. It is stored and displayed on the project segment screen alongside the start and end coordinates
        /// </summary>
        public string Description { get; set; }
        public decimal? StartLatitude { get; set; }
        public decimal? StartLongitude { get; set; }
        public decimal? EndLatitude { get; set; }
        public decimal? EndLongitude { get; set; }
        public Geometry Geometry { get; set; }
        public DateTime? EndDate { get; set; }
        public long ConcurrencyControlNumber { get; set; }
        public string AppCreateUserid { get; set; }
        public DateTime AppCreateTimestamp { get; set; }
        public Guid AppCreateUserGuid { get; set; }
        public string AppLastUpdateUserid { get; set; }
        public DateTime AppLastUpdateTimestamp { get; set; }
        public Guid AppLastUpdateUserGuid { get; set; }
        public string DbAuditCreateUserid { get; set; }
        public DateTime DbAuditCreateTimestamp { get; set; }
        public string DbAuditLastUpdateUserid { get; set; }
        public DateTime DbAuditLastUpdateTimestamp { get; set; }

        public virtual CrtProject Project { get; set; }
    }
}
