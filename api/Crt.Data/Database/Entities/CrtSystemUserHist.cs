﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Crt.Data.Database.Entities
{
    public partial class CrtSystemUserHist
    {
        public long SystemUserHistId { get; set; }
        public DateTime EffectiveDateHist { get; set; }
        public DateTime? EndDateHist { get; set; }
        public string Username { get; set; }
        public string ApiClientId { get; set; }
        public decimal SystemUserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid? UserGuid { get; set; }
        public DateTime AppCreateTimestamp { get; set; }
        public Guid AppCreateUserGuid { get; set; }
        public string AppCreateUserid { get; set; }
        public DateTime AppLastUpdateTimestamp { get; set; }
        public Guid AppLastUpdateUserGuid { get; set; }
        public string AppLastUpdateUserid { get; set; }
        public long ConcurrencyControlNumber { get; set; }
        public DateTime DbAuditCreateTimestamp { get; set; }
        public string DbAuditCreateUserid { get; set; }
        public DateTime DbAuditLastUpdateTimestamp { get; set; }
        public string DbAuditLastUpdateUserid { get; set; }
    }
}
