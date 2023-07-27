// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A Class representing a NetworkFabricSku along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="NetworkFabricSkuResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetNetworkFabricSkuResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource" /> using the GetNetworkFabricSku method.
    /// </summary>
    public partial class NetworkFabricSkuResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="NetworkFabricSkuResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string networkFabricSkuName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.ManagedNetworkFabric/networkFabricSkus/{networkFabricSkuName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _networkFabricSkuClientDiagnostics;
        private readonly NetworkFabricSkusRestOperations _networkFabricSkuRestClient;
        private readonly NetworkFabricSkuData _data;

        /// <summary> Initializes a new instance of the <see cref="NetworkFabricSkuResource"/> class for mocking. </summary>
        protected NetworkFabricSkuResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "NetworkFabricSkuResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal NetworkFabricSkuResource(ArmClient client, NetworkFabricSkuData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkFabricSkuResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal NetworkFabricSkuResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkFabricSkuClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedNetworkFabric", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string networkFabricSkuApiVersion);
            _networkFabricSkuRestClient = new NetworkFabricSkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkFabricSkuApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ManagedNetworkFabric/networkFabricSkus";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual NetworkFabricSkuData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Implements Network Fabric Sku GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ManagedNetworkFabric/networkFabricSkus/{networkFabricSkuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFabricSkus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<NetworkFabricSkuResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _networkFabricSkuClientDiagnostics.CreateScope("NetworkFabricSkuResource.Get");
            scope.Start();
            try
            {
                var response = await _networkFabricSkuRestClient.GetAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements Network Fabric Sku GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ManagedNetworkFabric/networkFabricSkus/{networkFabricSkuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkFabricSkus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<NetworkFabricSkuResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _networkFabricSkuClientDiagnostics.CreateScope("NetworkFabricSkuResource.Get");
            scope.Start();
            try
            {
                var response = _networkFabricSkuRestClient.Get(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkFabricSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
