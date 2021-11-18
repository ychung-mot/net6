using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace Crt.Data.Database.Entities
{
    public partial class CrtProjectSegmentsVw
    {
        public decimal ProjectId { get; set; }
        public decimal? SegmentId { get; set; }
        public decimal? StartLatitude { get; set; }
        public decimal? StartLongitude { get; set; }
        public decimal? EndLatitude { get; set; }
        public decimal? EndLongitude { get; set; }
        public Geometry Geometry { get; set; }
        public string SegmentDescription { get; set; }
    }
}
