// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class AvsManagementCluster : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ClusterSize))
            {
                writer.WritePropertyName("clusterSize"u8);
                writer.WriteNumberValue(ClusterSize.Value);
            }
            if (Optional.IsCollectionDefined(Hosts))
            {
                writer.WritePropertyName("hosts"u8);
                writer.WriteStartArray();
                foreach (var item in Hosts)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static AvsManagementCluster DeserializeAvsManagementCluster(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> clusterSize = default;
            Optional<AvsPrivateCloudClusterProvisioningState> provisioningState = default;
            Optional<int> clusterId = default;
            Optional<IList<string>> hosts = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clusterSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AvsPrivateCloudClusterProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("clusterId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("hosts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    hosts = array;
                    continue;
                }
            }
            return new AvsManagementCluster(Optional.ToNullable(clusterSize), Optional.ToNullable(provisioningState), Optional.ToNullable(clusterId), Optional.ToList(hosts));
        }
    }
}
