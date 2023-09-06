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
using Azure.ResourceManager.HealthBot.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HealthBot
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.HealthBot. </summary>
    public static partial class HealthBotExtensions
    {
        private static HealthBotArmClientMockingExtension GetHealthBotArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client =>
            {
                return new HealthBotArmClientMockingExtension(client);
            });
        }

        private static HealthBotResourceGroupMockingExtension GetHealthBotResourceGroupMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new HealthBotResourceGroupMockingExtension(client, resource.Id);
            });
        }

        private static HealthBotSubscriptionMockingExtension GetHealthBotSubscriptionMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new HealthBotSubscriptionMockingExtension(client, resource.Id);
            });
        }

        /// <summary>
        /// Gets an object representing a <see cref="HealthBotResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HealthBotResource.CreateResourceIdentifier" /> to create a <see cref="HealthBotResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HealthBotResource" /> object. </returns>
        public static HealthBotResource GetHealthBotResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetHealthBotArmClientMockingExtension(client).GetHealthBotResource(id);
        }

        /// <summary> Gets a collection of HealthBotResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of HealthBotResources and their operations over a HealthBotResource. </returns>
        public static HealthBotCollection GetHealthBots(this ResourceGroupResource resourceGroupResource)
        {
            return GetHealthBotResourceGroupMockingExtension(resourceGroupResource).GetHealthBots();
        }

        /// <summary>
        /// Get a HealthBot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthBot/healthBots/{botName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="botName"> The name of the Bot resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="botName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="botName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<HealthBotResource>> GetHealthBotAsync(this ResourceGroupResource resourceGroupResource, string botName, CancellationToken cancellationToken = default)
        {
            return await GetHealthBotResourceGroupMockingExtension(resourceGroupResource).GetHealthBotAsync(botName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a HealthBot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthBot/healthBots/{botName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="botName"> The name of the Bot resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="botName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="botName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<HealthBotResource> GetHealthBot(this ResourceGroupResource resourceGroupResource, string botName, CancellationToken cancellationToken = default)
        {
            return GetHealthBotResourceGroupMockingExtension(resourceGroupResource).GetHealthBot(botName, cancellationToken);
        }

        /// <summary>
        /// Returns all the resources of a particular type belonging to a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HealthBot/healthBots</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HealthBotResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<HealthBotResource> GetHealthBotsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetHealthBotSubscriptionMockingExtension(subscriptionResource).GetHealthBotsAsync(cancellationToken);
        }

        /// <summary>
        /// Returns all the resources of a particular type belonging to a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HealthBot/healthBots</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HealthBotResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<HealthBotResource> GetHealthBots(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetHealthBotSubscriptionMockingExtension(subscriptionResource).GetHealthBots(cancellationToken);
        }
    }
}
