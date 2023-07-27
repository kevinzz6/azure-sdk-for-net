// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Support.Models;

namespace Azure.ResourceManager.Support
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _supportTicketClientDiagnostics;
        private SupportTicketsRestOperations _supportTicketRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics SupportTicketClientDiagnostics => _supportTicketClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Support", SupportTicketResource.ResourceType.Namespace, Diagnostics);
        private SupportTicketsRestOperations SupportTicketRestClient => _supportTicketRestClient ??= new SupportTicketsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(SupportTicketResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of SupportTicketResources in the SubscriptionResource. </summary>
        /// <returns> An object representing collection of SupportTicketResources and their operations over a SupportTicketResource. </returns>
        public virtual SupportTicketCollection GetSupportTickets()
        {
            return GetCachedClient(Client => new SupportTicketCollection(Client, Id));
        }

        /// <summary>
        /// Check the availability of a resource name. This API should be used to check the uniqueness of the name for support ticket creation for the selected subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupportTickets_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SupportNameAvailabilityResult>> CheckSupportTicketNameAvailabilityAsync(SupportNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = SupportTicketClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckSupportTicketNameAvailability");
            scope.Start();
            try
            {
                var response = await SupportTicketRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the availability of a resource name. This API should be used to check the uniqueness of the name for support ticket creation for the selected subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SupportTickets_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SupportNameAvailabilityResult> CheckSupportTicketNameAvailability(SupportNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = SupportTicketClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckSupportTicketNameAvailability");
            scope.Start();
            try
            {
                var response = SupportTicketRestClient.CheckNameAvailability(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
