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
using Azure.ResourceManager.ResourceConnector.Mocking;
using Azure.ResourceManager.ResourceConnector.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ResourceConnector
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.ResourceConnector. </summary>
    public static partial class ResourceConnectorExtensions
    {
        private static ResourceConnectorArmClientMockingExtension GetResourceConnectorArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client0 => new ResourceConnectorArmClientMockingExtension(client0));
        }

        private static ResourceConnectorResourceGroupMockingExtension GetResourceConnectorResourceGroupMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client => new ResourceConnectorResourceGroupMockingExtension(client, resource.Id));
        }

        private static ResourceConnectorSubscriptionMockingExtension GetResourceConnectorSubscriptionMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client => new ResourceConnectorSubscriptionMockingExtension(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="ResourceConnectorApplianceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ResourceConnectorApplianceResource.CreateResourceIdentifier" /> to create a <see cref="ResourceConnectorApplianceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="ResourceConnectorArmClientMockingExtension.GetResourceConnectorApplianceResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ResourceConnectorApplianceResource" /> object. </returns>
        public static ResourceConnectorApplianceResource GetResourceConnectorApplianceResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetResourceConnectorArmClientMockingExtension(client).GetResourceConnectorApplianceResource(id);
        }

        /// <summary>
        /// Gets a collection of ResourceConnectorApplianceResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="ResourceConnectorResourceGroupMockingExtension.GetResourceConnectorAppliances()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ResourceConnectorApplianceResources and their operations over a ResourceConnectorApplianceResource. </returns>
        public static ResourceConnectorApplianceCollection GetResourceConnectorAppliances(this ResourceGroupResource resourceGroupResource)
        {
            return GetResourceConnectorResourceGroupMockingExtension(resourceGroupResource).GetResourceConnectorAppliances();
        }

        /// <summary>
        /// Gets the details of an Appliance with a specified resource group and name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ResourceConnector/appliances/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Appliances_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="ResourceConnectorResourceGroupMockingExtension.GetResourceConnectorApplianceAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="resourceName"> Appliances name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ResourceConnectorApplianceResource>> GetResourceConnectorApplianceAsync(this ResourceGroupResource resourceGroupResource, string resourceName, CancellationToken cancellationToken = default)
        {
            return await GetResourceConnectorResourceGroupMockingExtension(resourceGroupResource).GetResourceConnectorApplianceAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the details of an Appliance with a specified resource group and name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ResourceConnector/appliances/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Appliances_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="ResourceConnectorResourceGroupMockingExtension.GetResourceConnectorAppliance(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="resourceName"> Appliances name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<ResourceConnectorApplianceResource> GetResourceConnectorAppliance(this ResourceGroupResource resourceGroupResource, string resourceName, CancellationToken cancellationToken = default)
        {
            return GetResourceConnectorResourceGroupMockingExtension(resourceGroupResource).GetResourceConnectorAppliance(resourceName, cancellationToken);
        }

        /// <summary>
        /// Gets a list of Appliances in the specified subscription. The operation returns properties of each Appliance
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceConnector/appliances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Appliances_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="ResourceConnectorSubscriptionMockingExtension.GetResourceConnectorAppliances(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceConnectorApplianceResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ResourceConnectorApplianceResource> GetResourceConnectorAppliancesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetResourceConnectorSubscriptionMockingExtension(subscriptionResource).GetResourceConnectorAppliancesAsync(cancellationToken);
        }

        /// <summary>
        /// Gets a list of Appliances in the specified subscription. The operation returns properties of each Appliance
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceConnector/appliances</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Appliances_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="ResourceConnectorSubscriptionMockingExtension.GetResourceConnectorAppliances(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceConnectorApplianceResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ResourceConnectorApplianceResource> GetResourceConnectorAppliances(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetResourceConnectorSubscriptionMockingExtension(subscriptionResource).GetResourceConnectorAppliances(cancellationToken);
        }

        /// <summary>
        /// Gets the telemetry config.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceConnector/telemetryconfig</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Appliances_GetTelemetryConfig</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="ResourceConnectorSubscriptionMockingExtension.GetTelemetryConfigAppliance(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static async Task<Response<ApplianceTelemetryConfigResult>> GetTelemetryConfigApplianceAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return await GetResourceConnectorSubscriptionMockingExtension(subscriptionResource).GetTelemetryConfigApplianceAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the telemetry config.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceConnector/telemetryconfig</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Appliances_GetTelemetryConfig</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="ResourceConnectorSubscriptionMockingExtension.GetTelemetryConfigAppliance(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static Response<ApplianceTelemetryConfigResult> GetTelemetryConfigAppliance(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetResourceConnectorSubscriptionMockingExtension(subscriptionResource).GetTelemetryConfigAppliance(cancellationToken);
        }
    }
}
