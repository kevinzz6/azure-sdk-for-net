// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppTemplate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RevisionSuffix))
            {
                writer.WritePropertyName("revisionSuffix"u8);
                writer.WriteStringValue(RevisionSuffix);
            }
            if (Optional.IsCollectionDefined(InitContainers))
            {
                writer.WritePropertyName("initContainers"u8);
                writer.WriteStartArray();
                foreach (var item in InitContainers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Containers))
            {
                writer.WritePropertyName("containers"u8);
                writer.WriteStartArray();
                foreach (var item in Containers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Scale))
            {
                writer.WritePropertyName("scale"u8);
                writer.WriteObjectValue(Scale);
            }
            if (Optional.IsCollectionDefined(Volumes))
            {
                writer.WritePropertyName("volumes"u8);
                writer.WriteStartArray();
                foreach (var item in Volumes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ContainerAppTemplate DeserializeContainerAppTemplate(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> revisionSuffix = default;
            Optional<IList<ContainerAppInitContainer>> initContainers = default;
            Optional<IList<ContainerAppContainer>> containers = default;
            Optional<ContainerAppScale> scale = default;
            Optional<IList<ContainerAppVolume>> volumes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("revisionSuffix"u8))
                {
                    revisionSuffix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initContainers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppInitContainer> array = new List<ContainerAppInitContainer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppInitContainer.DeserializeContainerAppInitContainer(item));
                    }
                    initContainers = array;
                    continue;
                }
                if (property.NameEquals("containers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppContainer> array = new List<ContainerAppContainer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppContainer.DeserializeContainerAppContainer(item));
                    }
                    containers = array;
                    continue;
                }
                if (property.NameEquals("scale"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scale = ContainerAppScale.DeserializeContainerAppScale(property.Value);
                    continue;
                }
                if (property.NameEquals("volumes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerAppVolume> array = new List<ContainerAppVolume>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppVolume.DeserializeContainerAppVolume(item));
                    }
                    volumes = array;
                    continue;
                }
            }
            return new ContainerAppTemplate(revisionSuffix.Value, Optional.ToList(initContainers), Optional.ToList(containers), scale.Value, Optional.ToList(volumes));
        }
    }
}
