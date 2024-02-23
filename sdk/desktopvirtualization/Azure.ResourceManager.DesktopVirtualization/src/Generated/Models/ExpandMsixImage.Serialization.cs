// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class ExpandMsixImage : IUtf8JsonSerializable, IJsonModel<ExpandMsixImage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExpandMsixImage>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ExpandMsixImage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpandMsixImage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpandMsixImage)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (PackageAlias != null)
            {
                writer.WritePropertyName("packageAlias"u8);
                writer.WriteStringValue(PackageAlias);
            }
            if (ImagePath != null)
            {
                writer.WritePropertyName("imagePath"u8);
                writer.WriteStringValue(ImagePath);
            }
            if (PackageName != null)
            {
                writer.WritePropertyName("packageName"u8);
                writer.WriteStringValue(PackageName);
            }
            if (PackageFamilyName != null)
            {
                writer.WritePropertyName("packageFamilyName"u8);
                writer.WriteStringValue(PackageFamilyName);
            }
            if (PackageFullName != null)
            {
                writer.WritePropertyName("packageFullName"u8);
                writer.WriteStringValue(PackageFullName);
            }
            if (DisplayName != null)
            {
                if (DisplayName != null)
                {
                    writer.WritePropertyName("displayName"u8);
                    writer.WriteStringValue(DisplayName);
                }
                else
                {
                    writer.WriteNull("displayName");
                }
            }
            if (PackageRelativePath != null)
            {
                writer.WritePropertyName("packageRelativePath"u8);
                writer.WriteStringValue(PackageRelativePath);
            }
            if (IsRegularRegistration.HasValue)
            {
                writer.WritePropertyName("isRegularRegistration"u8);
                writer.WriteBooleanValue(IsRegularRegistration.Value);
            }
            if (IsActive.HasValue)
            {
                writer.WritePropertyName("isActive"u8);
                writer.WriteBooleanValue(IsActive.Value);
            }
            if (!(PackageDependencies is ChangeTrackingList<MsixPackageDependencies> collection && collection.IsUndefined))
            {
                if (PackageDependencies != null)
                {
                    writer.WritePropertyName("packageDependencies"u8);
                    writer.WriteStartArray();
                    foreach (var item in PackageDependencies)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("packageDependencies");
                }
            }
            if (Version != null)
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (LastUpdatedOn.HasValue)
            {
                writer.WritePropertyName("lastUpdated"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (!(PackageApplications is ChangeTrackingList<MsixPackageApplications> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("packageApplications"u8);
                writer.WriteStartArray();
                foreach (var item in PackageApplications)
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

        ExpandMsixImage IJsonModel<ExpandMsixImage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpandMsixImage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpandMsixImage)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExpandMsixImage(document.RootElement, options);
        }

        internal static ExpandMsixImage DeserializeExpandMsixImage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> packageAlias = default;
            Optional<string> imagePath = default;
            Optional<string> packageName = default;
            Optional<string> packageFamilyName = default;
            Optional<string> packageFullName = default;
            Optional<string> displayName = default;
            Optional<string> packageRelativePath = default;
            Optional<bool> isRegularRegistration = default;
            Optional<bool> isActive = default;
            IList<MsixPackageDependencies> packageDependencies = default;
            Optional<string> version = default;
            Optional<DateTimeOffset> lastUpdated = default;
            IList<MsixPackageApplications> packageApplications = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("packageAlias"u8))
                        {
                            packageAlias = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("imagePath"u8))
                        {
                            imagePath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("packageName"u8))
                        {
                            packageName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("packageFamilyName"u8))
                        {
                            packageFamilyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("packageFullName"u8))
                        {
                            packageFullName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                displayName = null;
                                continue;
                            }
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("packageRelativePath"u8))
                        {
                            packageRelativePath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isRegularRegistration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isRegularRegistration = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isActive"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isActive = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("packageDependencies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                packageDependencies = null;
                                continue;
                            }
                            List<MsixPackageDependencies> array = new List<MsixPackageDependencies>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MsixPackageDependencies.DeserializeMsixPackageDependencies(item, options));
                            }
                            packageDependencies = array;
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastUpdated"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastUpdated = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("packageApplications"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MsixPackageApplications> array = new List<MsixPackageApplications>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MsixPackageApplications.DeserializeMsixPackageApplications(item, options));
                            }
                            packageApplications = array;
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
            return new ExpandMsixImage(id, name, type, systemData.Value, packageAlias.Value, imagePath.Value, packageName.Value, packageFamilyName.Value, packageFullName.Value, displayName.Value, packageRelativePath.Value, Optional.ToNullable(isRegularRegistration), Optional.ToNullable(isActive), packageDependencies ?? new ChangeTrackingList<MsixPackageDependencies>(), version.Value, Optional.ToNullable(lastUpdated), packageApplications ?? new ChangeTrackingList<MsixPackageApplications>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExpandMsixImage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpandMsixImage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ExpandMsixImage)} does not support '{options.Format}' format.");
            }
        }

        ExpandMsixImage IPersistableModel<ExpandMsixImage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpandMsixImage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeExpandMsixImage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExpandMsixImage)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExpandMsixImage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
