// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.IotHub.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.IotHub
{
    /// <summary>
    /// A class representing the IotHubCertificateDescription data model.
    /// The X509 Certificate.
    /// </summary>
    public partial class IotHubCertificateDescriptionData : ResourceData
    {
        /// <summary> Initializes a new instance of IotHubCertificateDescriptionData. </summary>
        public IotHubCertificateDescriptionData()
        {
        }

        /// <summary> Initializes a new instance of IotHubCertificateDescriptionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The description of an X509 CA Certificate. </param>
        /// <param name="etag"> The entity tag. </param>
        internal IotHubCertificateDescriptionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IotHubCertificateProperties properties, ETag? etag) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            ETag = etag;
        }

        /// <summary> The description of an X509 CA Certificate. </summary>
        public IotHubCertificateProperties Properties { get; set; }
        /// <summary> The entity tag. </summary>
        public ETag? ETag { get; }
    }
}
