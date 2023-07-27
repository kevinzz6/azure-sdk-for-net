// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.MySql.Models;

namespace Azure.ResourceManager.MySql
{
    /// <summary>
    /// A class representing the MySqlServerAdministrator data model.
    /// Represents a and external administrator to be created.
    /// </summary>
    public partial class MySqlServerAdministratorData : ResourceData
    {
        /// <summary> Initializes a new instance of MySqlServerAdministratorData. </summary>
        public MySqlServerAdministratorData()
        {
        }

        /// <summary> Initializes a new instance of MySqlServerAdministratorData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="administratorType"> The type of administrator. </param>
        /// <param name="loginAccountName"> The server administrator login account name. </param>
        /// <param name="secureId"> The server administrator Sid (Secure ID). </param>
        /// <param name="tenantId"> The server Active Directory Administrator tenant id. </param>
        internal MySqlServerAdministratorData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, MySqlAdministratorType? administratorType, string loginAccountName, Guid? secureId, Guid? tenantId) : base(id, name, resourceType, systemData)
        {
            AdministratorType = administratorType;
            LoginAccountName = loginAccountName;
            SecureId = secureId;
            TenantId = tenantId;
        }

        /// <summary> The type of administrator. </summary>
        public MySqlAdministratorType? AdministratorType { get; set; }
        /// <summary> The server administrator login account name. </summary>
        public string LoginAccountName { get; set; }
        /// <summary> The server administrator Sid (Secure ID). </summary>
        public Guid? SecureId { get; set; }
        /// <summary> The server Active Directory Administrator tenant id. </summary>
        public Guid? TenantId { get; set; }
    }
}
