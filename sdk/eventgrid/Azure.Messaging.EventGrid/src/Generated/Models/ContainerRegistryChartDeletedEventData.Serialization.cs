// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ContainerRegistryChartDeletedEventDataConverter))]
    public partial class ContainerRegistryChartDeletedEventData
    {
        internal static ContainerRegistryChartDeletedEventData DeserializeContainerRegistryChartDeletedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<DateTimeOffset> timestamp = default;
            Optional<string> action = default;
            Optional<string> location = default;
            Optional<ContainerRegistryArtifactEventTarget> target = default;
            Optional<ContainerRegistryEventConnectedRegistry> connectedRegistry = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    action = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    target = ContainerRegistryArtifactEventTarget.DeserializeContainerRegistryArtifactEventTarget(property.Value);
                    continue;
                }
                if (property.NameEquals("connectedRegistry"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectedRegistry = ContainerRegistryEventConnectedRegistry.DeserializeContainerRegistryEventConnectedRegistry(property.Value);
                    continue;
                }
            }
            return new ContainerRegistryChartDeletedEventData(id.Value, Optional.ToNullable(timestamp), action.Value, location.Value, target.Value, connectedRegistry.Value);
        }

        internal partial class ContainerRegistryChartDeletedEventDataConverter : JsonConverter<ContainerRegistryChartDeletedEventData>
        {
            public override void Write(Utf8JsonWriter writer, ContainerRegistryChartDeletedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override ContainerRegistryChartDeletedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeContainerRegistryChartDeletedEventData(document.RootElement);
            }
        }
    }
}
