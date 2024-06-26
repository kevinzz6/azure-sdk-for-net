// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    public partial class ProfileType : IUtf8JsonSerializable, IJsonModel<ProfileType>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProfileType>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ProfileType>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProfileType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProfileType)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ConsumerGroup))
            {
                writer.WritePropertyName("consumerGroup"u8);
                writer.WriteStringValue(ConsumerGroup.Value.ToString());
            }
            writer.WritePropertyName("displayName"u8);
            writer.WriteStringValue(DisplayName);
            writer.WritePropertyName("hostFormat"u8);
            writer.WriteStringValue(HostFormat.ToString());
            if (Optional.IsDefined(IsRegional))
            {
                writer.WritePropertyName("isRegional"u8);
                writer.WriteBooleanValue(IsRegional.Value);
            }
            writer.WritePropertyName("protocol"u8);
            writer.WriteStringValue(Protocol.ToString());
            writer.WritePropertyName("sessionMode"u8);
            writer.WriteStringValue(SessionMode.ToString());
            writer.WritePropertyName("syntaxFormat"u8);
            writer.WriteStringValue(SyntaxFormat.ToString());
            if (Optional.IsDefined(TlsAuthentication))
            {
                writer.WritePropertyName("tlsAuthentication"u8);
                writer.WriteStringValue(TlsAuthentication.Value.ToString());
            }
            writer.WritePropertyName("value"u8);
            writer.WriteStringValue(Value);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ProfileType IJsonModel<ProfileType>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProfileType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProfileType)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProfileType(document.RootElement, options);
        }

        internal static ProfileType DeserializeProfileType(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ConsumerGroup? consumerGroup = default;
            string displayName = default;
            HostFormatType hostFormat = default;
            bool? isRegional = default;
            ProtocolType protocol = default;
            SessionModeType sessionMode = default;
            SyntaxFormatType syntaxFormat = default;
            TlsAuthenticationType? tlsAuthentication = default;
            string value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("consumerGroup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    consumerGroup = new ConsumerGroup(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostFormat"u8))
                {
                    hostFormat = new HostFormatType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isRegional"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isRegional = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    protocol = new ProtocolType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sessionMode"u8))
                {
                    sessionMode = new SessionModeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("syntaxFormat"u8))
                {
                    syntaxFormat = new SyntaxFormatType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tlsAuthentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tlsAuthentication = new TlsAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ProfileType(
                consumerGroup,
                displayName,
                hostFormat,
                isRegional,
                protocol,
                sessionMode,
                syntaxFormat,
                tlsAuthentication,
                value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProfileType>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProfileType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProfileType)} does not support writing '{options.Format}' format.");
            }
        }

        ProfileType IPersistableModel<ProfileType>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProfileType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProfileType(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProfileType)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProfileType>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
