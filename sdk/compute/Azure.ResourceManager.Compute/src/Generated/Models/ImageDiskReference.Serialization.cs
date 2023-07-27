// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class ImageDiskReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(SharedGalleryImageId))
            {
                writer.WritePropertyName("sharedGalleryImageId"u8);
                writer.WriteStringValue(SharedGalleryImageId);
            }
            if (Optional.IsDefined(CommunityGalleryImageId))
            {
                writer.WritePropertyName("communityGalleryImageId"u8);
                writer.WriteStringValue(CommunityGalleryImageId);
            }
            if (Optional.IsDefined(Lun))
            {
                writer.WritePropertyName("lun"u8);
                writer.WriteNumberValue(Lun.Value);
            }
            writer.WriteEndObject();
        }

        internal static ImageDiskReference DeserializeImageDiskReference(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<string> sharedGalleryImageId = default;
            Optional<string> communityGalleryImageId = default;
            Optional<int> lun = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sharedGalleryImageId"u8))
                {
                    sharedGalleryImageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("communityGalleryImageId"u8))
                {
                    communityGalleryImageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lun"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lun = property.Value.GetInt32();
                    continue;
                }
            }
            return new ImageDiskReference(id.Value, sharedGalleryImageId.Value, communityGalleryImageId.Value, Optional.ToNullable(lun));
        }
    }
}
