﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Crt.Data.Database.Entities
{
    public partial class CrtRegion
    {
        public CrtRegion()
        {
            CrtProjects = new HashSet<CrtProject>();
            CrtRegionDistricts = new HashSet<CrtRegionDistrict>();
            CrtRegionUsers = new HashSet<CrtRegionUser>();
        }

        public decimal RegionId { get; set; }
        public decimal RegionNumber { get; set; }
        public string RegionName { get; set; }
        public DateTime? EndDate { get; set; }
        public long ConcurrencyControlNumber { get; set; }
        public string DbAuditCreateUserid { get; set; }
        public DateTime DbAuditCreateTimestamp { get; set; }
        public string DbAuditLastUpdateUserid { get; set; }
        public DateTime DbAuditLastUpdateTimestamp { get; set; }

        public virtual ICollection<CrtProject> CrtProjects { get; set; }
        public virtual ICollection<CrtRegionDistrict> CrtRegionDistricts { get; set; }
        public virtual ICollection<CrtRegionUser> CrtRegionUsers { get; set; }
    }
}
