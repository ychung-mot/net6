﻿using Crt.Model.Dtos.Region;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Crt.Model.Dtos.User
{
    public class UserCurrentDto
    {
        public UserCurrentDto()
        {
            Permissions = new List<string>();
        }

        [JsonPropertyName("id")]
        public decimal SystemUserId { get; set; }   
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsSystemAdmin { get; set; }
        public bool IsProjectMgr { get; set; }
        public decimal[] RegionIds { get; set; }

        public virtual IList<RegionDto> Regions { get; set; }
        public virtual IList<string> Permissions { get; set; }
    }
}
