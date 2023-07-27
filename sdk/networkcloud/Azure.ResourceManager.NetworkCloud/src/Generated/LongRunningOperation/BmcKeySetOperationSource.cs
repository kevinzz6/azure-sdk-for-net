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
    internal class BmcKeySetOperationSource : IOperationSource<BmcKeySetResource>
    {
        private readonly ArmClient _client;

        internal BmcKeySetOperationSource(ArmClient client)
        {
            _client = client;
        }

        BmcKeySetResource IOperationSource<BmcKeySetResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = BmcKeySetData.DeserializeBmcKeySetData(document.RootElement);
            return new BmcKeySetResource(_client, data);
        }

        async ValueTask<BmcKeySetResource> IOperationSource<BmcKeySetResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = BmcKeySetData.DeserializeBmcKeySetData(document.RootElement);
            return new BmcKeySetResource(_client, data);
        }
    }
}
