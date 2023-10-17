// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Advisor;

namespace Azure.ResourceManager.Advisor.Mocking
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    public partial class AdvisorTenantMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="AdvisorTenantMockingExtension"/> class for mocking. </summary>
        protected AdvisorTenantMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AdvisorTenantMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AdvisorTenantMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of MetadataEntityResources in the TenantResource. </summary>
        /// <returns> An object representing collection of MetadataEntityResources and their operations over a MetadataEntityResource. </returns>
        public virtual MetadataEntityCollection GetMetadataEntities()
        {
            return GetCachedClient(client => new MetadataEntityCollection(client, Id));
        }

        /// <summary>
        /// Gets the metadata entity.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Advisor/metadata/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecommendationMetadata_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of metadata entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<MetadataEntityResource>> GetMetadataEntityAsync(string name, CancellationToken cancellationToken = default)
        {
            return await GetMetadataEntities().GetAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the metadata entity.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Advisor/metadata/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RecommendationMetadata_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Name of metadata entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<MetadataEntityResource> GetMetadataEntity(string name, CancellationToken cancellationToken = default)
        {
            return GetMetadataEntities().Get(name, cancellationToken);
        }
    }
}
