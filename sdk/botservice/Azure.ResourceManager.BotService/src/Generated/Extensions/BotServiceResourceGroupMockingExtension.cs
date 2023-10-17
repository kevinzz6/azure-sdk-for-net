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
using Azure.ResourceManager.BotService;

namespace Azure.ResourceManager.BotService.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class BotServiceResourceGroupMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="BotServiceResourceGroupMockingExtension"/> class for mocking. </summary>
        protected BotServiceResourceGroupMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BotServiceResourceGroupMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BotServiceResourceGroupMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of BotResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of BotResources and their operations over a BotResource. </returns>
        public virtual BotCollection GetBots()
        {
            return GetCachedClient(client => new BotCollection(client, Id));
        }

        /// <summary>
        /// Returns a BotService specified by the parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.BotService/botServices/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the Bot resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<BotResource>> GetBotAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            return await GetBots().GetAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a BotService specified by the parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.BotService/botServices/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The name of the Bot resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<BotResource> GetBot(string resourceName, CancellationToken cancellationToken = default)
        {
            return GetBots().Get(resourceName, cancellationToken);
        }
    }
}
