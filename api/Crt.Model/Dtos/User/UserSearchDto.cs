﻿using System;
using System.Text.Json.Serialization;

namespace Crt.Model.Dtos.User
{
    public class UserSearchDto
    {
        [JsonPropertyName("id")]
        public decimal SystemUserId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string RegionNumbers { get; set; }
        public bool HasLogInHistory { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsProjectMgr { get; set; }
        public bool IsActive => EndDate == null || EndDate > DateTime.Today;
    }
}
