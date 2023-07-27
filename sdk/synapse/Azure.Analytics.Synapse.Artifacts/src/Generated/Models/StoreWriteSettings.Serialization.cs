// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(StoreWriteSettingsConverter))]
    public partial class StoreWriteSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            if (Optional.IsDefined(CopyBehavior))
            {
                writer.WritePropertyName("copyBehavior"u8);
                writer.WriteObjectValue(CopyBehavior);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static StoreWriteSettings DeserializeStoreWriteSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureBlobFSWriteSettings": return AzureBlobFSWriteSettings.DeserializeAzureBlobFSWriteSettings(element);
                    case "AzureBlobStorageWriteSettings": return AzureBlobStorageWriteSettings.DeserializeAzureBlobStorageWriteSettings(element);
                    case "AzureDataLakeStoreWriteSettings": return AzureDataLakeStoreWriteSettings.DeserializeAzureDataLakeStoreWriteSettings(element);
                    case "AzureFileStorageWriteSettings": return AzureFileStorageWriteSettings.DeserializeAzureFileStorageWriteSettings(element);
                    case "FileServerWriteSettings": return FileServerWriteSettings.DeserializeFileServerWriteSettings(element);
                    case "SftpWriteSettings": return SftpWriteSettings.DeserializeSftpWriteSettings(element);
                }
            }
            return UnknownStoreWriteSettings.DeserializeUnknownStoreWriteSettings(element);
        }

        internal partial class StoreWriteSettingsConverter : JsonConverter<StoreWriteSettings>
        {
            public override void Write(Utf8JsonWriter writer, StoreWriteSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override StoreWriteSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeStoreWriteSettings(document.RootElement);
            }
        }
    }
}
