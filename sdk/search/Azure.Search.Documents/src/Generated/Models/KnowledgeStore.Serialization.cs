// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class KnowledgeStore : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("storageConnectionString"u8);
            writer.WriteStringValue(StorageConnectionString);
            writer.WritePropertyName("projections"u8);
            writer.WriteStartArray();
            foreach (var item in Projections)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Identity))
            {
                if (Identity != null)
                {
                    writer.WritePropertyName("identity"u8);
                    writer.WriteObjectValue(Identity);
                }
                else
                {
                    writer.WriteNull("identity");
                }
            }
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteObjectValue(Parameters);
            }
            writer.WriteEndObject();
        }

        internal static KnowledgeStore DeserializeKnowledgeStore(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string storageConnectionString = default;
            IList<KnowledgeStoreProjection> projections = default;
            Optional<SearchIndexerDataIdentity> identity = default;
            Optional<SearchIndexerKnowledgeStoreParameters> parameters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageConnectionString"u8))
                {
                    storageConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("projections"u8))
                {
                    List<KnowledgeStoreProjection> array = new List<KnowledgeStoreProjection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KnowledgeStoreProjection.DeserializeKnowledgeStoreProjection(item));
                    }
                    projections = array;
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        identity = null;
                        continue;
                    }
                    identity = SearchIndexerDataIdentity.DeserializeSearchIndexerDataIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parameters = SearchIndexerKnowledgeStoreParameters.DeserializeSearchIndexerKnowledgeStoreParameters(property.Value);
                    continue;
                }
            }
            return new KnowledgeStore(storageConnectionString, projections, identity.Value, parameters.Value);
        }
    }
}
