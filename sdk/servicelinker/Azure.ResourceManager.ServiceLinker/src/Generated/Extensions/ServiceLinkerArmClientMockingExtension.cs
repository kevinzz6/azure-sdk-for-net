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
using Azure.ResourceManager.ServiceLinker;

namespace Azure.ResourceManager.ServiceLinker.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class ServiceLinkerArmClientMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ServiceLinkerArmClientMockingExtension"/> class for mocking. </summary>
        protected ServiceLinkerArmClientMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceLinkerArmClientMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ServiceLinkerArmClientMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal ServiceLinkerArmClientMockingExtension(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of LinkerResources in the ArmClient. </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of LinkerResources and their operations over a LinkerResource. </returns>
        public virtual LinkerResourceCollection GetLinkerResources(ResourceIdentifier scope)
        {
            return new LinkerResourceCollection(Client, scope);
        }

        /// <summary>
        /// Returns Linker resource for a given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ServiceLinker/linkers/{linkerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Linker_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="linkerName"> The name Linker resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="linkerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<LinkerResource>> GetLinkerResourceAsync(ResourceIdentifier scope, string linkerName, CancellationToken cancellationToken = default)
        {
            return await GetLinkerResources(scope).GetAsync(linkerName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns Linker resource for a given name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceUri}/providers/Microsoft.ServiceLinker/linkers/{linkerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Linker_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="linkerName"> The name Linker resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="linkerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<LinkerResource> GetLinkerResource(ResourceIdentifier scope, string linkerName, CancellationToken cancellationToken = default)
        {
            return GetLinkerResources(scope).Get(linkerName, cancellationToken);
        }

        /// <summary>
        /// Gets an object representing a <see cref="LinkerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="LinkerResource.CreateResourceIdentifier" /> to create a <see cref="LinkerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="LinkerResource" /> object. </returns>
        public virtual LinkerResource GetLinkerResource(ResourceIdentifier id)
        {
            LinkerResource.ValidateResourceId(id);
            return new LinkerResource(Client, id);
        }
    }
}
