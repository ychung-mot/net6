using System;
using System.Collections.Generic;

namespace Crt.Data.Database.Entities
{
    public partial class CrtPrjQtyAccomplishmentsVw
    {
        public decimal ProjectId { get; set; }
        public decimal QtyAccmpId { get; set; }
        public string QtyAccmpFiscalYear { get; set; }
        public string QtyAccmpType { get; set; }
        public string QtyAccmpCode { get; set; }
        public string QtyAccmpDesc { get; set; }
        public decimal? QtyAccmpForecast { get; set; }
        public decimal? QtyAccmpSchedule7 { get; set; }
        public decimal? QtyAccmpActual { get; set; }
        public string QtyAccmpComment { get; set; }
        public DateTime? QtyAccmpEndDate { get; set; }
        public DateTime QtyAccmpDbAuditCreateTimestamp { get; set; }
        public DateTime QtyAccmpDbAuditLastUpdateTimestamp { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
