// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDBForPostgreSql;

namespace Azure.ResourceManager.CosmosDBForPostgreSql.Models
{
    /// <summary> A list of server configurations. </summary>
    internal partial class ServerConfigurationListResult
    {
        /// <summary> Initializes a new instance of ServerConfigurationListResult. </summary>
        internal ServerConfigurationListResult()
        {
            Value = new ChangeTrackingList<ServerConfigurationData>();
        }

        /// <summary> Initializes a new instance of ServerConfigurationListResult. </summary>
        /// <param name="value"> The list of server configurations. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal ServerConfigurationListResult(IReadOnlyList<ServerConfigurationData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of server configurations. </summary>
        public IReadOnlyList<ServerConfigurationData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
