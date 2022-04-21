// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Network
{
    internal class VirtualHubRouteTableV2OperationSource : IOperationSource<VirtualHubRouteTableV2Resource>
    {
        private readonly ArmClient _client;

        internal VirtualHubRouteTableV2OperationSource(ArmClient client)
        {
            _client = client;
        }

        VirtualHubRouteTableV2Resource IOperationSource<VirtualHubRouteTableV2Resource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VirtualHubRouteTableV2Data.DeserializeVirtualHubRouteTableV2Data(document.RootElement);
            return new VirtualHubRouteTableV2Resource(_client, data);
        }

        async ValueTask<VirtualHubRouteTableV2Resource> IOperationSource<VirtualHubRouteTableV2Resource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VirtualHubRouteTableV2Data.DeserializeVirtualHubRouteTableV2Data(document.RootElement);
            return new VirtualHubRouteTableV2Resource(_client, data);
        }
    }
}
