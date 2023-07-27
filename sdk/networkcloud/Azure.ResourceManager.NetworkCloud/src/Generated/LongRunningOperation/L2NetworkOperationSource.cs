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

namespace Azure.ResourceManager.NetworkCloud
{
    internal class L2NetworkOperationSource : IOperationSource<L2NetworkResource>
    {
        private readonly ArmClient _client;

        internal L2NetworkOperationSource(ArmClient client)
        {
            _client = client;
        }

        L2NetworkResource IOperationSource<L2NetworkResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = L2NetworkData.DeserializeL2NetworkData(document.RootElement);
            return new L2NetworkResource(_client, data);
        }

        async ValueTask<L2NetworkResource> IOperationSource<L2NetworkResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = L2NetworkData.DeserializeL2NetworkData(document.RootElement);
            return new L2NetworkResource(_client, data);
        }
    }
}
