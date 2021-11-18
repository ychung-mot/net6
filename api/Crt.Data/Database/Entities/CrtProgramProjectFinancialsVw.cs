using System;
using System.Collections.Generic;

namespace Crt.Data.Database.Entities
{
    public partial class CrtProgramProjectFinancialsVw
    {
        public decimal ProjectId { get; set; }
        public decimal? FinTargetId { get; set; }
        public string FinTargetFiscalYear { get; set; }
        public string PrjPhaseCode { get; set; }
        public string PrjPhaseDesc { get; set; }
        public string FundingTypeCode { get; set; }
        public string FundingTypeDesc { get; set; }
        public decimal? FinTargetAmount { get; set; }
        public string FinTargetDescription { get; set; }
        public DateTime? FinTargetEndDate { get; set; }
        public string PrgCtgryCode { get; set; }
        public string ProgramGategory { get; set; }
        public decimal? ProgramLkupId { get; set; }
        public string ProgramCode { get; set; }
        public string ProgramDesc { get; set; }
        public string FinTargetServiceLineCode { get; set; }
        public string FinTargetServiceLineDesc { get; set; }
        public DateTime? ServiceLineEndDate { get; set; }
        public decimal? ElementId { get; set; }
        public string FinTargetPrgElement { get; set; }
        public string FinTargetPrgElementDescription { get; set; }
        public DateTime? PrgElementEndDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? FinTargetDbAuditCreateTimestamp { get; set; }
        public DateTime? FinTargetDbAuditLastUpdateTimestamp { get; set; }
    }
}
