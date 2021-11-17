﻿using System;
using System.Text.Json.Serialization;

namespace Crt.Model.Dtos.Project
{
    public class ProjectSearchDto
    {
        [JsonPropertyName("id")]
        public decimal ProjectId { get; set; }
        [JsonIgnore]
        public decimal RegionNumber { get; set; }
        [JsonIgnore]
        public string RegionName { get; set; }
        [JsonIgnore]
        public string ProjectNumber { get; set; }
        [JsonIgnore]
        public string ProjectName { get; set; }

        [JsonPropertyName("regionId")]
        public string Region { get => $"{RegionNumber}-{RegionName}"; }
        [JsonPropertyName("projectNumber")]
        public string Project { get => $"{ProjectNumber}-{ProjectName}"; }
        public DateTime? EndDate { get; set; }
        public bool IsInProgress { get => EndDate == null || DateTime.Today < EndDate; }

        //the following two fields are used to generate the links for Planning Target & Tender Details
        public string WinningContractorName { get; set; }
        public decimal? ProjectValue { get; set; }
    }
}
