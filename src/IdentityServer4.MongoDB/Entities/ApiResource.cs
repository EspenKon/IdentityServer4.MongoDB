﻿using System;
using System.Collections.Generic;
using IdentityServer4.MongoDB.Repositories;

namespace IdentityServer4.MongoDB.Entities
{
    public class ApiResource : Entity
    {
        public bool Enabled { get; set; } = true;
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public List<ApiSecret> Secrets { get; set; }
        public List<ApiScope> Scopes { get; set; }
        public List<ApiResourceClaim> UserClaims { get; set; }
        public List<ApiResourceProperty> Properties { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime? Updated { get; set; }
        public DateTime? LastAccessed { get; set; }
        public bool NonEditable { get; set; }
    }
}
