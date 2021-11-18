using System;
using System.Collections.Generic;

namespace Crt.Data.Database.Entities
{
    public partial class CrtProjectVw
    {
        public decimal ProjectId { get; set; }
        public string ProjectNumber { get; set; }
        public string ProjectName { get; set; }
        public string PrjDescription { get; set; }
        public string PrjScope { get; set; }
        public decimal? RegionNumber { get; set; }
        public string RegionName { get; set; }
        public string CapIndxCode { get; set; }
        public string CapIndxDesc { get; set; }
        public string NearestTwnCode { get; set; }
        public string NearestTwnDesc { get; set; }
        public string RcCode { get; set; }
        public string RcDesc { get; set; }
        public string ProjectMgrCode { get; set; }
        public string ProjectMgrDesc { get; set; }
        public decimal? AnncmentValue { get; set; }
        public decimal? C035Value { get; set; }
        public string AnncmentComment { get; set; }
        public decimal? EstimatedValue { get; set; }
    }
}
