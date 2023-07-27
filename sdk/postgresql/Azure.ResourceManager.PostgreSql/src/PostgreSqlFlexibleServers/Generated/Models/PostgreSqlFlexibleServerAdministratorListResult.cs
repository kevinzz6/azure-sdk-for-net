// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.PostgreSql.FlexibleServers;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> A list of active directory administrators. </summary>
    internal partial class PostgreSqlFlexibleServerAdministratorListResult
    {
        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerAdministratorListResult. </summary>
        internal PostgreSqlFlexibleServerAdministratorListResult()
        {
            Value = new ChangeTrackingList<PostgreSqlFlexibleServerActiveDirectoryAdministratorData>();
        }

        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerAdministratorListResult. </summary>
        /// <param name="value"> The list of active directory administrators. </param>
        /// <param name="nextLink"> The link used to get the next page of active directory. </param>
        internal PostgreSqlFlexibleServerAdministratorListResult(IReadOnlyList<PostgreSqlFlexibleServerActiveDirectoryAdministratorData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of active directory administrators. </summary>
        public IReadOnlyList<PostgreSqlFlexibleServerActiveDirectoryAdministratorData> Value { get; }
        /// <summary> The link used to get the next page of active directory. </summary>
        public string NextLink { get; }
    }
}
