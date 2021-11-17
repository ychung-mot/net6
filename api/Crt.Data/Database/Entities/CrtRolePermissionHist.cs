﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Crt.Data.Database.Entities
{
    public partial class CrtRolePermissionHist
    {
        public long RolePermissionHistId { get; set; }
        public decimal RolePermissionId { get; set; }
        public decimal RoleId { get; set; }
        public decimal PermissionId { get; set; }
        public DateTime EffectiveDateHist { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? EndDateHist { get; set; }
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
    }
}
