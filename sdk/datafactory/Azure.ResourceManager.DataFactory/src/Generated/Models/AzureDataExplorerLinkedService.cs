// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Azure Data Explorer (Kusto) linked service. </summary>
    public partial class AzureDataExplorerLinkedService : DataFactoryLinkedServiceDefinition
    {
        /// <summary> Initializes a new instance of AzureDataExplorerLinkedService. </summary>
        /// <param name="endpoint"> The endpoint of Azure Data Explorer (the engine's endpoint). URL will be in the format https://&lt;clusterName&gt;.&lt;regionName&gt;.kusto.windows.net. Type: string (or Expression with resultType string). </param>
        /// <param name="database"> Database name for connection. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="database"/> is null. </exception>
        public AzureDataExplorerLinkedService(DataFactoryElement<string> endpoint, DataFactoryElement<string> database)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(database, nameof(database));

            Endpoint = endpoint;
            Database = database;
            LinkedServiceType = "AzureDataExplorer";
        }

        /// <summary> Initializes a new instance of AzureDataExplorerLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="endpoint"> The endpoint of Azure Data Explorer (the engine's endpoint). URL will be in the format https://&lt;clusterName&gt;.&lt;regionName&gt;.kusto.windows.net. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalId"> The ID of the service principal used to authenticate against Azure Data Explorer. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalKey"> The key of the service principal used to authenticate against Kusto. </param>
        /// <param name="database"> Database name for connection. Type: string (or Expression with resultType string). </param>
        /// <param name="tenant"> The name or ID of the tenant to which the service principal belongs. Type: string (or Expression with resultType string). </param>
        /// <param name="credential"> The credential reference containing authentication information. </param>
        internal AzureDataExplorerLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> endpoint, DataFactoryElement<string> servicePrincipalId, DataFactorySecretBaseDefinition servicePrincipalKey, DataFactoryElement<string> database, DataFactoryElement<string> tenant, DataFactoryCredentialReference credential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Endpoint = endpoint;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalKey = servicePrincipalKey;
            Database = database;
            Tenant = tenant;
            Credential = credential;
            LinkedServiceType = linkedServiceType ?? "AzureDataExplorer";
        }

        /// <summary> The endpoint of Azure Data Explorer (the engine's endpoint). URL will be in the format https://&lt;clusterName&gt;.&lt;regionName&gt;.kusto.windows.net. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Endpoint { get; set; }
        /// <summary> The ID of the service principal used to authenticate against Azure Data Explorer. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ServicePrincipalId { get; set; }
        /// <summary> The key of the service principal used to authenticate against Kusto. </summary>
        public DataFactorySecretBaseDefinition ServicePrincipalKey { get; set; }
        /// <summary> Database name for connection. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Database { get; set; }
        /// <summary> The name or ID of the tenant to which the service principal belongs. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Tenant { get; set; }
        /// <summary> The credential reference containing authentication information. </summary>
        public DataFactoryCredentialReference Credential { get; set; }
    }
}
