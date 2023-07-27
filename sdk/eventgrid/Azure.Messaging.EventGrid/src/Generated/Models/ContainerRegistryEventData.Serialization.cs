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
    [JsonConverter(typeof(ContainerRegistryEventDataConverter))]
    public partial class ContainerRegistryEventData
    {
        internal static ContainerRegistryEventData DeserializeContainerRegistryEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<DateTimeOffset> timestamp = default;
            Optional<string> action = default;
            Optional<string> location = default;
            Optional<ContainerRegistryEventTarget> target = default;
            Optional<ContainerRegistryEventRequest> request = default;
            Optional<ContainerRegistryEventActor> actor = default;
            Optional<ContainerRegistryEventSource> source = default;
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
                    target = ContainerRegistryEventTarget.DeserializeContainerRegistryEventTarget(property.Value);
                    continue;
                }
                if (property.NameEquals("request"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    request = ContainerRegistryEventRequest.DeserializeContainerRegistryEventRequest(property.Value);
                    continue;
                }
                if (property.NameEquals("actor"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actor = ContainerRegistryEventActor.DeserializeContainerRegistryEventActor(property.Value);
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    source = ContainerRegistryEventSource.DeserializeContainerRegistryEventSource(property.Value);
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
            return new ContainerRegistryEventData(id.Value, Optional.ToNullable(timestamp), action.Value, location.Value, target.Value, request.Value, actor.Value, source.Value, connectedRegistry.Value);
        }

        internal partial class ContainerRegistryEventDataConverter : JsonConverter<ContainerRegistryEventData>
        {
            public override void Write(Utf8JsonWriter writer, ContainerRegistryEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override ContainerRegistryEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeContainerRegistryEventData(document.RootElement);
            }
        }
    }
}
