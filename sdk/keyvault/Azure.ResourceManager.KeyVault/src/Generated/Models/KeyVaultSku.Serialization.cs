// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.KeyVault.Models
{
    public partial class KeyVaultSku : IUtf8JsonSerializable, IModelJsonSerializable<KeyVaultSku>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        private void Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("family"u8);
            writer.WriteStringValue(Family.ToString());
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name.ToSerialString());
            writer.WriteEndObject();
        }

        internal static KeyVaultSku DeserializeKeyVaultSku(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            KeyVaultSkuFamily family = default;
            KeyVaultSkuName name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("family"u8))
                {
                    family = new KeyVaultSkuFamily(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString().ToKeyVaultSkuName();
                    continue;
                }
            }
            return new KeyVaultSku(family, name);
        }

        void IModelJsonSerializable<KeyVaultSku>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options) => Serialize(writer, options);

        KeyVaultSku IModelJsonSerializable<KeyVaultSku>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            using var document = JsonDocument.ParseValue(ref reader);
            return DeserializeKeyVaultSku(document.RootElement, options);
        }

        BinaryData IModelSerializable<KeyVaultSku>.Serialize(ModelSerializerOptions options) => (options.Format.ToString()) switch
        {
            "J" or "W" => ModelSerializer.SerializeCore(this, options),
            "bicep" => SerializeBicep(options),
            _ => throw new FormatException($"Unsupported format {options.Format}")
        };

        KeyVaultSku IModelSerializable<KeyVaultSku>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            using var document = JsonDocument.Parse(data);
            return DeserializeKeyVaultSku(document.RootElement, options);
        }

        private BinaryData SerializeBicep(ModelSerializerOptions options)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{{");
            sb.AppendLine($"  family: '{Family}'");
            sb.AppendLine($"  name: '{Name.ToSerialString()}'");
            sb.AppendLine($"}}");
            return BinaryData.FromString(sb.ToString());
        }
    }
}
