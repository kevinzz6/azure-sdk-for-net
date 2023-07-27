// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing a collection of <see cref="SynapseIPFirewallRuleInfoResource" /> and their operations.
    /// Each <see cref="SynapseIPFirewallRuleInfoResource" /> in the collection will belong to the same instance of <see cref="SynapseWorkspaceResource" />.
    /// To get a <see cref="SynapseIPFirewallRuleInfoCollection" /> instance call the GetSynapseIPFirewallRuleInfos method from an instance of <see cref="SynapseWorkspaceResource" />.
    /// </summary>
    public partial class SynapseIPFirewallRuleInfoCollection : ArmCollection, IEnumerable<SynapseIPFirewallRuleInfoResource>, IAsyncEnumerable<SynapseIPFirewallRuleInfoResource>
    {
        private readonly ClientDiagnostics _synapseIPFirewallRuleInfoIPFirewallRulesClientDiagnostics;
        private readonly IpFirewallRulesRestOperations _synapseIPFirewallRuleInfoIPFirewallRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SynapseIPFirewallRuleInfoCollection"/> class for mocking. </summary>
        protected SynapseIPFirewallRuleInfoCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseIPFirewallRuleInfoCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SynapseIPFirewallRuleInfoCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseIPFirewallRuleInfoIPFirewallRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", SynapseIPFirewallRuleInfoResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SynapseIPFirewallRuleInfoResource.ResourceType, out string synapseIPFirewallRuleInfoIPFirewallRulesApiVersion);
            _synapseIPFirewallRuleInfoIPFirewallRulesRestClient = new IpFirewallRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseIPFirewallRuleInfoIPFirewallRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SynapseWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SynapseWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a firewall rule
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/firewallRules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpFirewallRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleName"> The IP firewall rule name. </param>
        /// <param name="info"> IP firewall rule properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> or <paramref name="info"/> is null. </exception>
        public virtual async Task<ArmOperation<SynapseIPFirewallRuleInfoResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string ruleName, SynapseIPFirewallRuleInfoData info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));
            Argument.AssertNotNull(info, nameof(info));

            using var scope = _synapseIPFirewallRuleInfoIPFirewallRulesClientDiagnostics.CreateScope("SynapseIPFirewallRuleInfoCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _synapseIPFirewallRuleInfoIPFirewallRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleName, info, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation<SynapseIPFirewallRuleInfoResource>(new SynapseIPFirewallRuleInfoOperationSource(Client), _synapseIPFirewallRuleInfoIPFirewallRulesClientDiagnostics, Pipeline, _synapseIPFirewallRuleInfoIPFirewallRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleName, info).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a firewall rule
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/firewallRules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpFirewallRules_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ruleName"> The IP firewall rule name. </param>
        /// <param name="info"> IP firewall rule properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> or <paramref name="info"/> is null. </exception>
        public virtual ArmOperation<SynapseIPFirewallRuleInfoResource> CreateOrUpdate(WaitUntil waitUntil, string ruleName, SynapseIPFirewallRuleInfoData info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));
            Argument.AssertNotNull(info, nameof(info));

            using var scope = _synapseIPFirewallRuleInfoIPFirewallRulesClientDiagnostics.CreateScope("SynapseIPFirewallRuleInfoCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _synapseIPFirewallRuleInfoIPFirewallRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleName, info, cancellationToken);
                var operation = new SynapseArmOperation<SynapseIPFirewallRuleInfoResource>(new SynapseIPFirewallRuleInfoOperationSource(Client), _synapseIPFirewallRuleInfoIPFirewallRulesClientDiagnostics, Pipeline, _synapseIPFirewallRuleInfoIPFirewallRulesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleName, info).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a firewall rule
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/firewallRules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpFirewallRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleName"> The IP firewall rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual async Task<Response<SynapseIPFirewallRuleInfoResource>> GetAsync(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _synapseIPFirewallRuleInfoIPFirewallRulesClientDiagnostics.CreateScope("SynapseIPFirewallRuleInfoCollection.Get");
            scope.Start();
            try
            {
                var response = await _synapseIPFirewallRuleInfoIPFirewallRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseIPFirewallRuleInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a firewall rule
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/firewallRules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpFirewallRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleName"> The IP firewall rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual Response<SynapseIPFirewallRuleInfoResource> Get(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _synapseIPFirewallRuleInfoIPFirewallRulesClientDiagnostics.CreateScope("SynapseIPFirewallRuleInfoCollection.Get");
            scope.Start();
            try
            {
                var response = _synapseIPFirewallRuleInfoIPFirewallRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseIPFirewallRuleInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a list of firewall rules
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/firewallRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpFirewallRules_ListByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SynapseIPFirewallRuleInfoResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SynapseIPFirewallRuleInfoResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseIPFirewallRuleInfoIPFirewallRulesRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapseIPFirewallRuleInfoIPFirewallRulesRestClient.CreateListByWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SynapseIPFirewallRuleInfoResource(Client, SynapseIPFirewallRuleInfoData.DeserializeSynapseIPFirewallRuleInfoData(e)), _synapseIPFirewallRuleInfoIPFirewallRulesClientDiagnostics, Pipeline, "SynapseIPFirewallRuleInfoCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns a list of firewall rules
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/firewallRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpFirewallRules_ListByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SynapseIPFirewallRuleInfoResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SynapseIPFirewallRuleInfoResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseIPFirewallRuleInfoIPFirewallRulesRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapseIPFirewallRuleInfoIPFirewallRulesRestClient.CreateListByWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SynapseIPFirewallRuleInfoResource(Client, SynapseIPFirewallRuleInfoData.DeserializeSynapseIPFirewallRuleInfoData(e)), _synapseIPFirewallRuleInfoIPFirewallRulesClientDiagnostics, Pipeline, "SynapseIPFirewallRuleInfoCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/firewallRules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpFirewallRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleName"> The IP firewall rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _synapseIPFirewallRuleInfoIPFirewallRulesClientDiagnostics.CreateScope("SynapseIPFirewallRuleInfoCollection.Exists");
            scope.Start();
            try
            {
                var response = await _synapseIPFirewallRuleInfoIPFirewallRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/firewallRules/{ruleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IpFirewallRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="ruleName"> The IP firewall rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleName"/> is null. </exception>
        public virtual Response<bool> Exists(string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var scope = _synapseIPFirewallRuleInfoIPFirewallRulesClientDiagnostics.CreateScope("SynapseIPFirewallRuleInfoCollection.Exists");
            scope.Start();
            try
            {
                var response = _synapseIPFirewallRuleInfoIPFirewallRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, ruleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SynapseIPFirewallRuleInfoResource> IEnumerable<SynapseIPFirewallRuleInfoResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SynapseIPFirewallRuleInfoResource> IAsyncEnumerable<SynapseIPFirewallRuleInfoResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
