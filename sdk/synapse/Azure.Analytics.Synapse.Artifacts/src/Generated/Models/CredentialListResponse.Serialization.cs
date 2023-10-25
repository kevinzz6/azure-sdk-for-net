// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(CredentialListResponseConverter))]
    internal partial class CredentialListResponse
    {
        internal static CredentialListResponse DeserializeCredentialListResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ManagedIdentityCredentialResource> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<ManagedIdentityCredentialResource> array = new List<ManagedIdentityCredentialResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedIdentityCredentialResource.DeserializeManagedIdentityCredentialResource(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new CredentialListResponse(value, nextLink.Value);
        }

        internal partial class CredentialListResponseConverter : JsonConverter<CredentialListResponse>
        {
            public override void Write(Utf8JsonWriter writer, CredentialListResponse model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override CredentialListResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeCredentialListResponse(document.RootElement);
            }
        }
    }
}
