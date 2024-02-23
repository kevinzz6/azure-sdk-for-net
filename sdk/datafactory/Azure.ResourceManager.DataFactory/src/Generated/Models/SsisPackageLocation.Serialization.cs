// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SsisPackageLocation : IUtf8JsonSerializable, IJsonModel<SsisPackageLocation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SsisPackageLocation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SsisPackageLocation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SsisPackageLocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SsisPackageLocation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (PackagePath != null)
            {
                writer.WritePropertyName("packagePath"u8);
                JsonSerializer.Serialize(writer, PackagePath);
            }
            if (LocationType.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(LocationType.Value.ToString());
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (PackagePassword != null)
            {
                writer.WritePropertyName("packagePassword"u8);
                JsonSerializer.Serialize(writer, PackagePassword);
            }
            if (AccessCredential != null)
            {
                writer.WritePropertyName("accessCredential"u8);
                writer.WriteObjectValue(AccessCredential);
            }
            if (ConfigurationPath != null)
            {
                writer.WritePropertyName("configurationPath"u8);
                JsonSerializer.Serialize(writer, ConfigurationPath);
            }
            if (ConfigurationAccessCredential != null)
            {
                writer.WritePropertyName("configurationAccessCredential"u8);
                writer.WriteObjectValue(ConfigurationAccessCredential);
            }
            if (PackageName != null)
            {
                writer.WritePropertyName("packageName"u8);
                writer.WriteStringValue(PackageName);
            }
            if (PackageContent != null)
            {
                writer.WritePropertyName("packageContent"u8);
                JsonSerializer.Serialize(writer, PackageContent);
            }
            if (PackageLastModifiedDate != null)
            {
                writer.WritePropertyName("packageLastModifiedDate"u8);
                writer.WriteStringValue(PackageLastModifiedDate);
            }
            if (!(ChildPackages is ChangeTrackingList<SsisChildPackage> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("childPackages"u8);
                writer.WriteStartArray();
                foreach (var item in ChildPackages)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        SsisPackageLocation IJsonModel<SsisPackageLocation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SsisPackageLocation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SsisPackageLocation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSsisPackageLocation(document.RootElement, options);
        }

        internal static SsisPackageLocation DeserializeSsisPackageLocation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataFactoryElement<string>> packagePath = default;
            Optional<SsisPackageLocationType> type = default;
            Optional<DataFactorySecretBaseDefinition> packagePassword = default;
            Optional<SsisAccessCredential> accessCredential = default;
            Optional<DataFactoryElement<string>> configurationPath = default;
            Optional<SsisAccessCredential> configurationAccessCredential = default;
            Optional<string> packageName = default;
            Optional<DataFactoryElement<string>> packageContent = default;
            Optional<string> packageLastModifiedDate = default;
            IList<SsisChildPackage> childPackages = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("packagePath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    packagePath = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new SsisPackageLocationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("packagePassword"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            packagePassword = JsonSerializer.Deserialize<DataFactorySecretBaseDefinition>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("accessCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accessCredential = SsisAccessCredential.DeserializeSsisAccessCredential(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("configurationPath"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configurationPath = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("configurationAccessCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configurationAccessCredential = SsisAccessCredential.DeserializeSsisAccessCredential(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("packageName"u8))
                        {
                            packageName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("packageContent"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            packageContent = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("packageLastModifiedDate"u8))
                        {
                            packageLastModifiedDate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("childPackages"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SsisChildPackage> array = new List<SsisChildPackage>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SsisChildPackage.DeserializeSsisChildPackage(item, options));
                            }
                            childPackages = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SsisPackageLocation(packagePath.Value, Optional.ToNullable(type), packagePassword, accessCredential.Value, configurationPath.Value, configurationAccessCredential.Value, packageName.Value, packageContent.Value, packageLastModifiedDate.Value, childPackages ?? new ChangeTrackingList<SsisChildPackage>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SsisPackageLocation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SsisPackageLocation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SsisPackageLocation)} does not support '{options.Format}' format.");
            }
        }

        SsisPackageLocation IPersistableModel<SsisPackageLocation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SsisPackageLocation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSsisPackageLocation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SsisPackageLocation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SsisPackageLocation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
