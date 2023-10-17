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
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.NetApp
{
    /// <summary>
    /// A class representing a collection of <see cref="NetAppVolumeQuotaRuleResource" /> and their operations.
    /// Each <see cref="NetAppVolumeQuotaRuleResource" /> in the collection will belong to the same instance of <see cref="NetAppVolumeResource" />.
    /// To get a <see cref="NetAppVolumeQuotaRuleCollection" /> instance call the GetNetAppVolumeQuotaRules method from an instance of <see cref="NetAppVolumeResource" />.
    /// </summary>
    public partial class NetAppVolumeQuotaRuleCollection : ArmCollection, IEnumerable<NetAppVolumeQuotaRuleResource>, IAsyncEnumerable<NetAppVolumeQuotaRuleResource>
    {
        private readonly ClientDiagnostics _netAppVolumeQuotaRuleVolumeQuotaRulesClientDiagnostics;
        private readonly VolumeQuotaRulesRestOperations _netAppVolumeQuotaRuleVolumeQuotaRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetAppVolumeQuotaRuleCollection"/> class for mocking. </summary>
        protected NetAppVolumeQuotaRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetAppVolumeQuotaRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetAppVolumeQuotaRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _netAppVolumeQuotaRuleVolumeQuotaRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetApp", NetAppVolumeQuotaRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetAppVolumeQuotaRuleResource.ResourceType, out string netAppVolumeQuotaRuleVolumeQuotaRulesApiVersion);
            _netAppVolumeQuotaRuleVolumeQuotaRulesRestClient = new VolumeQuotaRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, netAppVolumeQuotaRuleVolumeQuotaRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetAppVolumeResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetAppVolumeResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create the specified quota rule within the given volume
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/volumeQuotaRules/{volumeQuotaRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeQuotaRules_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="volumeQuotaRuleName"> The name of volume quota rule. </param>
        /// <param name="data"> Quota rule object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeQuotaRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeQuotaRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetAppVolumeQuotaRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string volumeQuotaRuleName, NetAppVolumeQuotaRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeQuotaRuleName, nameof(volumeQuotaRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _netAppVolumeQuotaRuleVolumeQuotaRulesClientDiagnostics.CreateScope("NetAppVolumeQuotaRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _netAppVolumeQuotaRuleVolumeQuotaRulesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, volumeQuotaRuleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetAppArmOperation<NetAppVolumeQuotaRuleResource>(new NetAppVolumeQuotaRuleOperationSource(Client), _netAppVolumeQuotaRuleVolumeQuotaRulesClientDiagnostics, Pipeline, _netAppVolumeQuotaRuleVolumeQuotaRulesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, volumeQuotaRuleName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create the specified quota rule within the given volume
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/volumeQuotaRules/{volumeQuotaRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeQuotaRules_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="volumeQuotaRuleName"> The name of volume quota rule. </param>
        /// <param name="data"> Quota rule object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeQuotaRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeQuotaRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetAppVolumeQuotaRuleResource> CreateOrUpdate(WaitUntil waitUntil, string volumeQuotaRuleName, NetAppVolumeQuotaRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeQuotaRuleName, nameof(volumeQuotaRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _netAppVolumeQuotaRuleVolumeQuotaRulesClientDiagnostics.CreateScope("NetAppVolumeQuotaRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _netAppVolumeQuotaRuleVolumeQuotaRulesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, volumeQuotaRuleName, data, cancellationToken);
                var operation = new NetAppArmOperation<NetAppVolumeQuotaRuleResource>(new NetAppVolumeQuotaRuleOperationSource(Client), _netAppVolumeQuotaRuleVolumeQuotaRulesClientDiagnostics, Pipeline, _netAppVolumeQuotaRuleVolumeQuotaRulesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, volumeQuotaRuleName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get details of the specified quota rule
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/volumeQuotaRules/{volumeQuotaRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeQuotaRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeQuotaRuleName"> The name of volume quota rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeQuotaRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeQuotaRuleName"/> is null. </exception>
        public virtual async Task<Response<NetAppVolumeQuotaRuleResource>> GetAsync(string volumeQuotaRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeQuotaRuleName, nameof(volumeQuotaRuleName));

            using var scope = _netAppVolumeQuotaRuleVolumeQuotaRulesClientDiagnostics.CreateScope("NetAppVolumeQuotaRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _netAppVolumeQuotaRuleVolumeQuotaRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, volumeQuotaRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetAppVolumeQuotaRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get details of the specified quota rule
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/volumeQuotaRules/{volumeQuotaRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeQuotaRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeQuotaRuleName"> The name of volume quota rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeQuotaRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeQuotaRuleName"/> is null. </exception>
        public virtual Response<NetAppVolumeQuotaRuleResource> Get(string volumeQuotaRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeQuotaRuleName, nameof(volumeQuotaRuleName));

            using var scope = _netAppVolumeQuotaRuleVolumeQuotaRulesClientDiagnostics.CreateScope("NetAppVolumeQuotaRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _netAppVolumeQuotaRuleVolumeQuotaRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, volumeQuotaRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetAppVolumeQuotaRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all quota rules associated with the volume
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/volumeQuotaRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeQuotaRules_ListByVolume</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetAppVolumeQuotaRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetAppVolumeQuotaRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _netAppVolumeQuotaRuleVolumeQuotaRulesRestClient.CreateListByVolumeRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new NetAppVolumeQuotaRuleResource(Client, NetAppVolumeQuotaRuleData.DeserializeNetAppVolumeQuotaRuleData(e)), _netAppVolumeQuotaRuleVolumeQuotaRulesClientDiagnostics, Pipeline, "NetAppVolumeQuotaRuleCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// List all quota rules associated with the volume
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/volumeQuotaRules</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeQuotaRules_ListByVolume</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetAppVolumeQuotaRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetAppVolumeQuotaRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _netAppVolumeQuotaRuleVolumeQuotaRulesRestClient.CreateListByVolumeRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new NetAppVolumeQuotaRuleResource(Client, NetAppVolumeQuotaRuleData.DeserializeNetAppVolumeQuotaRuleData(e)), _netAppVolumeQuotaRuleVolumeQuotaRulesClientDiagnostics, Pipeline, "NetAppVolumeQuotaRuleCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/volumeQuotaRules/{volumeQuotaRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeQuotaRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeQuotaRuleName"> The name of volume quota rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeQuotaRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeQuotaRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string volumeQuotaRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeQuotaRuleName, nameof(volumeQuotaRuleName));

            using var scope = _netAppVolumeQuotaRuleVolumeQuotaRulesClientDiagnostics.CreateScope("NetAppVolumeQuotaRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _netAppVolumeQuotaRuleVolumeQuotaRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, volumeQuotaRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/volumeQuotaRules/{volumeQuotaRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeQuotaRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeQuotaRuleName"> The name of volume quota rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeQuotaRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeQuotaRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string volumeQuotaRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeQuotaRuleName, nameof(volumeQuotaRuleName));

            using var scope = _netAppVolumeQuotaRuleVolumeQuotaRulesClientDiagnostics.CreateScope("NetAppVolumeQuotaRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _netAppVolumeQuotaRuleVolumeQuotaRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, volumeQuotaRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/volumeQuotaRules/{volumeQuotaRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeQuotaRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeQuotaRuleName"> The name of volume quota rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeQuotaRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeQuotaRuleName"/> is null. </exception>
        public virtual async Task<NullableResponse<NetAppVolumeQuotaRuleResource>> GetIfExistsAsync(string volumeQuotaRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeQuotaRuleName, nameof(volumeQuotaRuleName));

            using var scope = _netAppVolumeQuotaRuleVolumeQuotaRulesClientDiagnostics.CreateScope("NetAppVolumeQuotaRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _netAppVolumeQuotaRuleVolumeQuotaRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, volumeQuotaRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<NetAppVolumeQuotaRuleResource>(response.GetRawResponse());
                return Response.FromValue(new NetAppVolumeQuotaRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/volumeQuotaRules/{volumeQuotaRuleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VolumeQuotaRules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="volumeQuotaRuleName"> The name of volume quota rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeQuotaRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeQuotaRuleName"/> is null. </exception>
        public virtual NullableResponse<NetAppVolumeQuotaRuleResource> GetIfExists(string volumeQuotaRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeQuotaRuleName, nameof(volumeQuotaRuleName));

            using var scope = _netAppVolumeQuotaRuleVolumeQuotaRulesClientDiagnostics.CreateScope("NetAppVolumeQuotaRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _netAppVolumeQuotaRuleVolumeQuotaRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, volumeQuotaRuleName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<NetAppVolumeQuotaRuleResource>(response.GetRawResponse());
                return Response.FromValue(new NetAppVolumeQuotaRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetAppVolumeQuotaRuleResource> IEnumerable<NetAppVolumeQuotaRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetAppVolumeQuotaRuleResource> IAsyncEnumerable<NetAppVolumeQuotaRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
