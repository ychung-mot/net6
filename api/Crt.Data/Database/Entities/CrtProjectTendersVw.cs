using System;
using System.Collections.Generic;

namespace Crt.Data.Database.Entities
{
    public partial class CrtProjectTendersVw
    {
        public decimal ProjectId { get; set; }
        public decimal? TenderId { get; set; }
        public string TenderNumber { get; set; }
        public DateTime? PlannedDate { get; set; }
        public DateTime? ActualDate { get; set; }
        public decimal? TenderValue { get; set; }
        public string WinningContractor { get; set; }
        public decimal? BidValue { get; set; }
        public string TenderComment { get; set; }
    }
}
