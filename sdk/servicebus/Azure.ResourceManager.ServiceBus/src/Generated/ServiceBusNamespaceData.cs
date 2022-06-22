// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary> A class representing the ServiceBusNamespace data model. </summary>
    public partial class ServiceBusNamespaceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ServiceBusNamespaceData. </summary>
        /// <param name="location"> The location. </param>
        public ServiceBusNamespaceData(AzureLocation location) : base(location)
        {
            PrivateEndpointConnections = new ChangeTrackingList<ServiceBusPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of ServiceBusNamespaceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> Properties of SKU. </param>
        /// <param name="identity"> Properties of BYOK Identity description. </param>
        /// <param name="provisioningState"> Provisioning state of the namespace. </param>
        /// <param name="status"> Status of the namespace. </param>
        /// <param name="createdOn"> The time the namespace was created. </param>
        /// <param name="updatedOn"> The time the namespace was updated. </param>
        /// <param name="serviceBusEndpoint"> Endpoint you can use to perform Service Bus operations. </param>
        /// <param name="metricId"> Identifier for Azure Insights metrics. </param>
        /// <param name="zoneRedundant"> Enabling this property creates a Premium Service Bus Namespace in regions supported availability zones. </param>
        /// <param name="encryption"> Properties of BYOK Encryption description. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections. </param>
        /// <param name="disableLocalAuth"> This property disables SAS authentication for the Service Bus namespace. </param>
        /// <param name="alternateName"> Alternate name for namespace. </param>
        internal ServiceBusNamespaceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ServiceBusSku sku, ManagedServiceIdentity identity, string provisioningState, string status, DateTimeOffset? createdOn, DateTimeOffset? updatedOn, string serviceBusEndpoint, string metricId, bool? zoneRedundant, Models.EncryptionProperties encryption, IList<ServiceBusPrivateEndpointConnectionData> privateEndpointConnections, bool? disableLocalAuth, string alternateName) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            Identity = identity;
            ProvisioningState = provisioningState;
            Status = status;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            ServiceBusEndpoint = serviceBusEndpoint;
            MetricId = metricId;
            ZoneRedundant = zoneRedundant;
            Encryption = encryption;
            PrivateEndpointConnections = privateEndpointConnections;
            DisableLocalAuth = disableLocalAuth;
            AlternateName = alternateName;
        }

        /// <summary> Properties of SKU. </summary>
        public ServiceBusSku Sku { get; set; }
        /// <summary> Properties of BYOK Identity description. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Provisioning state of the namespace. </summary>
        public string ProvisioningState { get; }
        /// <summary> Status of the namespace. </summary>
        public string Status { get; }
        /// <summary> The time the namespace was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The time the namespace was updated. </summary>
        public DateTimeOffset? UpdatedOn { get; }
        /// <summary> Endpoint you can use to perform Service Bus operations. </summary>
        public string ServiceBusEndpoint { get; }
        /// <summary> Identifier for Azure Insights metrics. </summary>
        public string MetricId { get; }
        /// <summary> Enabling this property creates a Premium Service Bus Namespace in regions supported availability zones. </summary>
        public bool? ZoneRedundant { get; set; }
        /// <summary> Properties of BYOK Encryption description. </summary>
        public Models.EncryptionProperties Encryption { get; set; }
        /// <summary> List of private endpoint connections. </summary>
        public IList<ServiceBusPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> This property disables SAS authentication for the Service Bus namespace. </summary>
        public bool? DisableLocalAuth { get; set; }
        /// <summary> Alternate name for namespace. </summary>
        public string AlternateName { get; set; }
    }
}
