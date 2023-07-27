// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Communication.MediaComposition;
using Azure.Core;

namespace Azure.Communication.MediaComposition.Models
{
    public partial class ImageInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("uri"u8);
            writer.WriteStringValue(Uri);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(PlaceholderImageUri))
            {
                writer.WritePropertyName("placeholderImageUri"u8);
                writer.WriteStringValue(PlaceholderImageUri);
            }
            writer.WriteEndObject();
        }

        internal static ImageInput DeserializeImageInput(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string uri = default;
            MediaInputType kind = default;
            Optional<string> placeholderImageUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uri"u8))
                {
                    uri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new MediaInputType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("placeholderImageUri"u8))
                {
                    placeholderImageUri = property.Value.GetString();
                    continue;
                }
            }
            return new ImageInput(kind, placeholderImageUri.Value, uri);
        }
    }
}
