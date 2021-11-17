﻿using Crt.Model.Dtos.CodeLookup;
using System;
using System.Text.Json.Serialization;

namespace Crt.Model.Dtos.QtyAccmp
{
    public class QtyAccmpDto
    {
        [JsonPropertyName("id")]
        public decimal QtyAccmpId { get; set; }
        public decimal ProjectId { get; set; }
        public decimal FiscalYearLkupId { get; set; }
        public decimal QtyAccmpLkupId { get; set; }
        public decimal Forecast { get; set; }
        public decimal? Schedule7 { get; set; }
        public decimal Actual { get; set; }
        public string Comment { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual CodeLookupDto FiscalYearLkup { get; set; }
        public virtual CodeLookupDto QtyAccmpLkup { get; set; }
    }
}
