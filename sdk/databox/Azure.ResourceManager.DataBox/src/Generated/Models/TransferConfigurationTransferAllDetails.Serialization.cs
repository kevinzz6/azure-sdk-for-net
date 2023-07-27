// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    internal partial class TransferConfigurationTransferAllDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Include))
            {
                writer.WritePropertyName("include"u8);
                writer.WriteObjectValue(Include);
            }
            writer.WriteEndObject();
        }

        internal static TransferConfigurationTransferAllDetails DeserializeTransferConfigurationTransferAllDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TransferAllDetails> include = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("include"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    include = TransferAllDetails.DeserializeTransferAllDetails(property.Value);
                    continue;
                }
            }
            return new TransferConfigurationTransferAllDetails(include.Value);
        }
    }
}
