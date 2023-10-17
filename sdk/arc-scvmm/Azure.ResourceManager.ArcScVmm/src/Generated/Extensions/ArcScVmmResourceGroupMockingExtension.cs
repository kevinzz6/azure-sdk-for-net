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
using Azure.ResourceManager.ArcScVmm;

namespace Azure.ResourceManager.ArcScVmm.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class ArcScVmmResourceGroupMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ArcScVmmResourceGroupMockingExtension"/> class for mocking. </summary>
        protected ArcScVmmResourceGroupMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ArcScVmmResourceGroupMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ArcScVmmResourceGroupMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ScVmmServerResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ScVmmServerResources and their operations over a ScVmmServerResource. </returns>
        public virtual ScVmmServerCollection GetScVmmServers()
        {
            return GetCachedClient(client => new ScVmmServerCollection(client, Id));
        }

        /// <summary>
        /// Implements VMMServer GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VmmServers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vmmServerName"> Name of the VMMServer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmmServerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="vmmServerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ScVmmServerResource>> GetScVmmServerAsync(string vmmServerName, CancellationToken cancellationToken = default)
        {
            return await GetScVmmServers().GetAsync(vmmServerName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Implements VMMServer GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/vmmServers/{vmmServerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VmmServers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vmmServerName"> Name of the VMMServer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vmmServerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="vmmServerName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ScVmmServerResource> GetScVmmServer(string vmmServerName, CancellationToken cancellationToken = default)
        {
            return GetScVmmServers().Get(vmmServerName, cancellationToken);
        }

        /// <summary> Gets a collection of ScVmmCloudResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ScVmmCloudResources and their operations over a ScVmmCloudResource. </returns>
        public virtual ScVmmCloudCollection GetScVmmClouds()
        {
            return GetCachedClient(client => new ScVmmCloudCollection(client, Id));
        }

        /// <summary>
        /// Implements Cloud GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/clouds/{cloudName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clouds_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudName"> Name of the Cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="cloudName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ScVmmCloudResource>> GetScVmmCloudAsync(string cloudName, CancellationToken cancellationToken = default)
        {
            return await GetScVmmClouds().GetAsync(cloudName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Implements Cloud GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/clouds/{cloudName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clouds_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cloudName"> Name of the Cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cloudName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="cloudName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ScVmmCloudResource> GetScVmmCloud(string cloudName, CancellationToken cancellationToken = default)
        {
            return GetScVmmClouds().Get(cloudName, cancellationToken);
        }

        /// <summary> Gets a collection of ScVmmVirtualNetworkResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ScVmmVirtualNetworkResources and their operations over a ScVmmVirtualNetworkResource. </returns>
        public virtual ScVmmVirtualNetworkCollection GetScVmmVirtualNetworks()
        {
            return GetCachedClient(client => new ScVmmVirtualNetworkCollection(client, Id));
        }

        /// <summary>
        /// Implements VirtualNetwork GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualNetworks/{virtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkName"> Name of the VirtualNetwork. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ScVmmVirtualNetworkResource>> GetScVmmVirtualNetworkAsync(string virtualNetworkName, CancellationToken cancellationToken = default)
        {
            return await GetScVmmVirtualNetworks().GetAsync(virtualNetworkName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Implements VirtualNetwork GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualNetworks/{virtualNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkName"> Name of the VirtualNetwork. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ScVmmVirtualNetworkResource> GetScVmmVirtualNetwork(string virtualNetworkName, CancellationToken cancellationToken = default)
        {
            return GetScVmmVirtualNetworks().Get(virtualNetworkName, cancellationToken);
        }

        /// <summary> Gets a collection of ScVmmVirtualMachineResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ScVmmVirtualMachineResources and their operations over a ScVmmVirtualMachineResource. </returns>
        public virtual ScVmmVirtualMachineCollection GetScVmmVirtualMachines()
        {
            return GetCachedClient(client => new ScVmmVirtualMachineCollection(client, Id));
        }

        /// <summary>
        /// Implements VirtualMachine GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualMachines/{virtualMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineName"> Name of the VirtualMachine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ScVmmVirtualMachineResource>> GetScVmmVirtualMachineAsync(string virtualMachineName, CancellationToken cancellationToken = default)
        {
            return await GetScVmmVirtualMachines().GetAsync(virtualMachineName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Implements VirtualMachine GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualMachines/{virtualMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineName"> Name of the VirtualMachine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ScVmmVirtualMachineResource> GetScVmmVirtualMachine(string virtualMachineName, CancellationToken cancellationToken = default)
        {
            return GetScVmmVirtualMachines().Get(virtualMachineName, cancellationToken);
        }

        /// <summary> Gets a collection of ScVmmVirtualMachineTemplateResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ScVmmVirtualMachineTemplateResources and their operations over a ScVmmVirtualMachineTemplateResource. </returns>
        public virtual ScVmmVirtualMachineTemplateCollection GetScVmmVirtualMachineTemplates()
        {
            return GetCachedClient(client => new ScVmmVirtualMachineTemplateCollection(client, Id));
        }

        /// <summary>
        /// Implements VirtualMachineTemplate GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualMachineTemplates/{virtualMachineTemplateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineTemplates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineTemplateName"> Name of the VirtualMachineTemplate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ScVmmVirtualMachineTemplateResource>> GetScVmmVirtualMachineTemplateAsync(string virtualMachineTemplateName, CancellationToken cancellationToken = default)
        {
            return await GetScVmmVirtualMachineTemplates().GetAsync(virtualMachineTemplateName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Implements VirtualMachineTemplate GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualMachineTemplates/{virtualMachineTemplateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachineTemplates_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineTemplateName"> Name of the VirtualMachineTemplate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineTemplateName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineTemplateName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ScVmmVirtualMachineTemplateResource> GetScVmmVirtualMachineTemplate(string virtualMachineTemplateName, CancellationToken cancellationToken = default)
        {
            return GetScVmmVirtualMachineTemplates().Get(virtualMachineTemplateName, cancellationToken);
        }

        /// <summary> Gets a collection of ScVmmAvailabilitySetResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ScVmmAvailabilitySetResources and their operations over a ScVmmAvailabilitySetResource. </returns>
        public virtual ScVmmAvailabilitySetCollection GetScVmmAvailabilitySets()
        {
            return GetCachedClient(client => new ScVmmAvailabilitySetCollection(client, Id));
        }

        /// <summary>
        /// Implements AvailabilitySet GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/availabilitySets/{availabilitySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilitySets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="availabilitySetName"> Name of the AvailabilitySet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ScVmmAvailabilitySetResource>> GetScVmmAvailabilitySetAsync(string availabilitySetName, CancellationToken cancellationToken = default)
        {
            return await GetScVmmAvailabilitySets().GetAsync(availabilitySetName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Implements AvailabilitySet GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/availabilitySets/{availabilitySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailabilitySets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="availabilitySetName"> Name of the AvailabilitySet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ScVmmAvailabilitySetResource> GetScVmmAvailabilitySet(string availabilitySetName, CancellationToken cancellationToken = default)
        {
            return GetScVmmAvailabilitySets().Get(availabilitySetName, cancellationToken);
        }
    }
}
