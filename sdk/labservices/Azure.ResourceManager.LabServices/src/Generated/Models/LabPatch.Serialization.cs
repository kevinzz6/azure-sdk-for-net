// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    public partial class LabPatch : IUtf8JsonSerializable, IJsonModel<LabPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LabPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LabPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LabPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Tags is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartArray();
                foreach (var item in Tags)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (AutoShutdownProfile != null)
            {
                writer.WritePropertyName("autoShutdownProfile"u8);
                writer.WriteObjectValue(AutoShutdownProfile);
            }
            if (ConnectionProfile != null)
            {
                writer.WritePropertyName("connectionProfile"u8);
                writer.WriteObjectValue(ConnectionProfile);
            }
            if (VirtualMachineProfile != null)
            {
                writer.WritePropertyName("virtualMachineProfile"u8);
                writer.WriteObjectValue(VirtualMachineProfile);
            }
            if (SecurityProfile != null)
            {
                writer.WritePropertyName("securityProfile"u8);
                writer.WriteObjectValue(SecurityProfile);
            }
            if (RosterProfile != null)
            {
                writer.WritePropertyName("rosterProfile"u8);
                writer.WriteObjectValue(RosterProfile);
            }
            if (LabPlanId != null)
            {
                writer.WritePropertyName("labPlanId"u8);
                writer.WriteStringValue(LabPlanId);
            }
            if (Title != null)
            {
                writer.WritePropertyName("title"u8);
                writer.WriteStringValue(Title);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        LabPatch IJsonModel<LabPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LabPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLabPatch(document.RootElement, options);
        }

        internal static LabPatch DeserializeLabPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> tags = default;
            Optional<LabAutoShutdownProfile> autoShutdownProfile = default;
            Optional<LabConnectionProfile> connectionProfile = default;
            Optional<LabVirtualMachineProfile> virtualMachineProfile = default;
            Optional<LabSecurityProfile> securityProfile = default;
            Optional<LabRosterProfile> rosterProfile = default;
            Optional<ResourceIdentifier> labPlanId = default;
            Optional<string> title = default;
            Optional<string> description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    tags = array;
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
                        if (property0.NameEquals("autoShutdownProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoShutdownProfile = LabAutoShutdownProfile.DeserializeLabAutoShutdownProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("connectionProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionProfile = LabConnectionProfile.DeserializeLabConnectionProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("virtualMachineProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualMachineProfile = LabVirtualMachineProfile.DeserializeLabVirtualMachineProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("securityProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            securityProfile = LabSecurityProfile.DeserializeLabSecurityProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("rosterProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rosterProfile = LabRosterProfile.DeserializeLabRosterProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("labPlanId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            labPlanId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("title"u8))
                        {
                            title = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
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
            return new LabPatch(tags ?? new ChangeTrackingList<string>(), serializedAdditionalRawData, autoShutdownProfile.Value, connectionProfile.Value, virtualMachineProfile.Value, securityProfile.Value, rosterProfile.Value, labPlanId.Value, title.Value, description.Value);
        }

        BinaryData IPersistableModel<LabPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LabPatch)} does not support '{options.Format}' format.");
            }
        }

        LabPatch IPersistableModel<LabPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LabPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLabPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LabPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LabPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
