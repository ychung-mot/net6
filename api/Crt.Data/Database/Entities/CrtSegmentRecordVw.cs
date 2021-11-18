using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

namespace Crt.Data.Database.Entities
{
    public partial class CrtSegmentRecordVw
    {
        public decimal SegmentId { get; set; }
        public string ProjectName { get; set; }
        public decimal ProjectId { get; set; }
        public string Description { get; set; }
        public Geometry Geometry { get; set; }
    }
}
