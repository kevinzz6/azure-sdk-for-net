// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Authentication configuration properties of a server. </summary>
    public partial class PostgreSqlFlexibleServerAuthConfig
    {
        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerAuthConfig. </summary>
        public PostgreSqlFlexibleServerAuthConfig()
        {
        }

        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerAuthConfig. </summary>
        /// <param name="activeDirectoryAuth"> If Enabled, Azure Active Directory authentication is enabled. </param>
        /// <param name="passwordAuth"> If Enabled, Password authentication is enabled. </param>
        /// <param name="tenantId"> Tenant id of the server. </param>
        internal PostgreSqlFlexibleServerAuthConfig(PostgreSqlFlexibleServerActiveDirectoryAuthEnum? activeDirectoryAuth, PostgreSqlFlexibleServerPasswordAuthEnum? passwordAuth, Guid? tenantId)
        {
            ActiveDirectoryAuth = activeDirectoryAuth;
            PasswordAuth = passwordAuth;
            TenantId = tenantId;
        }

        /// <summary> If Enabled, Azure Active Directory authentication is enabled. </summary>
        public PostgreSqlFlexibleServerActiveDirectoryAuthEnum? ActiveDirectoryAuth { get; set; }
        /// <summary> If Enabled, Password authentication is enabled. </summary>
        public PostgreSqlFlexibleServerPasswordAuthEnum? PasswordAuth { get; set; }
        /// <summary> Tenant id of the server. </summary>
        public Guid? TenantId { get; set; }
    }
}
