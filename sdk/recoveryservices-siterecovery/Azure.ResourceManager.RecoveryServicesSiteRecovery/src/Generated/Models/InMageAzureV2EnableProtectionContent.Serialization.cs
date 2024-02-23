// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageAzureV2EnableProtectionContent : IUtf8JsonSerializable, IJsonModel<InMageAzureV2EnableProtectionContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageAzureV2EnableProtectionContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InMageAzureV2EnableProtectionContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageAzureV2EnableProtectionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageAzureV2EnableProtectionContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (MasterTargetId != null)
            {
                writer.WritePropertyName("masterTargetId"u8);
                writer.WriteStringValue(MasterTargetId);
            }
            if (ProcessServerId.HasValue)
            {
                writer.WritePropertyName("processServerId"u8);
                writer.WriteStringValue(ProcessServerId.Value);
            }
            if (StorageAccountId != null)
            {
                writer.WritePropertyName("storageAccountId"u8);
                writer.WriteStringValue(StorageAccountId);
            }
            if (RunAsAccountId != null)
            {
                writer.WritePropertyName("runAsAccountId"u8);
                writer.WriteStringValue(RunAsAccountId);
            }
            if (MultiVmGroupId != null)
            {
                writer.WritePropertyName("multiVmGroupId"u8);
                writer.WriteStringValue(MultiVmGroupId);
            }
            if (MultiVmGroupName != null)
            {
                writer.WritePropertyName("multiVmGroupName"u8);
                writer.WriteStringValue(MultiVmGroupName);
            }
            if (!(DisksToInclude is ChangeTrackingList<InMageAzureV2DiskDetails> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("disksToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in DisksToInclude)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (TargetAzureNetworkId != null)
            {
                writer.WritePropertyName("targetAzureNetworkId"u8);
                writer.WriteStringValue(TargetAzureNetworkId);
            }
            if (TargetAzureSubnetId != null)
            {
                writer.WritePropertyName("targetAzureSubnetId"u8);
                writer.WriteStringValue(TargetAzureSubnetId);
            }
            if (EnableRdpOnTargetOption != null)
            {
                writer.WritePropertyName("enableRdpOnTargetOption"u8);
                writer.WriteStringValue(EnableRdpOnTargetOption);
            }
            if (TargetAzureVmName != null)
            {
                writer.WritePropertyName("targetAzureVmName"u8);
                writer.WriteStringValue(TargetAzureVmName);
            }
            if (LogStorageAccountId != null)
            {
                writer.WritePropertyName("logStorageAccountId"u8);
                writer.WriteStringValue(LogStorageAccountId);
            }
            if (TargetAzureV1ResourceGroupId != null)
            {
                writer.WritePropertyName("targetAzureV1ResourceGroupId"u8);
                writer.WriteStringValue(TargetAzureV1ResourceGroupId);
            }
            if (TargetAzureV2ResourceGroupId != null)
            {
                writer.WritePropertyName("targetAzureV2ResourceGroupId"u8);
                writer.WriteStringValue(TargetAzureV2ResourceGroupId);
            }
            if (DiskType.HasValue)
            {
                writer.WritePropertyName("diskType"u8);
                writer.WriteStringValue(DiskType.Value.ToString());
            }
            if (TargetAvailabilitySetId != null)
            {
                writer.WritePropertyName("targetAvailabilitySetId"u8);
                writer.WriteStringValue(TargetAvailabilitySetId);
            }
            if (TargetAvailabilityZone != null)
            {
                writer.WritePropertyName("targetAvailabilityZone"u8);
                writer.WriteStringValue(TargetAvailabilityZone);
            }
            if (TargetProximityPlacementGroupId != null)
            {
                writer.WritePropertyName("targetProximityPlacementGroupId"u8);
                writer.WriteStringValue(TargetProximityPlacementGroupId);
            }
            if (LicenseType.HasValue)
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (SqlServerLicenseType.HasValue)
            {
                writer.WritePropertyName("sqlServerLicenseType"u8);
                writer.WriteStringValue(SqlServerLicenseType.Value.ToString());
            }
            if (TargetVmSize != null)
            {
                writer.WritePropertyName("targetVmSize"u8);
                writer.WriteStringValue(TargetVmSize);
            }
            if (DiskEncryptionSetId != null)
            {
                writer.WritePropertyName("diskEncryptionSetId"u8);
                writer.WriteStringValue(DiskEncryptionSetId);
            }
            if (!(TargetVmTags is ChangeTrackingDictionary<string, string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("targetVmTags"u8);
                writer.WriteStartObject();
                foreach (var item in TargetVmTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(SeedManagedDiskTags is ChangeTrackingDictionary<string, string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("seedManagedDiskTags"u8);
                writer.WriteStartObject();
                foreach (var item in SeedManagedDiskTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(TargetManagedDiskTags is ChangeTrackingDictionary<string, string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("targetManagedDiskTags"u8);
                writer.WriteStartObject();
                foreach (var item in TargetManagedDiskTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(TargetNicTags is ChangeTrackingDictionary<string, string> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("targetNicTags"u8);
                writer.WriteStartObject();
                foreach (var item in TargetNicTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        InMageAzureV2EnableProtectionContent IJsonModel<InMageAzureV2EnableProtectionContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageAzureV2EnableProtectionContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InMageAzureV2EnableProtectionContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageAzureV2EnableProtectionContent(document.RootElement, options);
        }

        internal static InMageAzureV2EnableProtectionContent DeserializeInMageAzureV2EnableProtectionContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> masterTargetId = default;
            Optional<Guid> processServerId = default;
            Optional<ResourceIdentifier> storageAccountId = default;
            Optional<string> runAsAccountId = default;
            Optional<string> multiVmGroupId = default;
            Optional<string> multiVmGroupName = default;
            IList<InMageAzureV2DiskDetails> disksToInclude = default;
            Optional<ResourceIdentifier> targetAzureNetworkId = default;
            Optional<ResourceIdentifier> targetAzureSubnetId = default;
            Optional<string> enableRdpOnTargetOption = default;
            Optional<string> targetAzureVmName = default;
            Optional<ResourceIdentifier> logStorageAccountId = default;
            Optional<ResourceIdentifier> targetAzureV1ResourceGroupId = default;
            Optional<ResourceIdentifier> targetAzureV2ResourceGroupId = default;
            Optional<SiteRecoveryDiskAccountType> diskType = default;
            Optional<ResourceIdentifier> targetAvailabilitySetId = default;
            Optional<string> targetAvailabilityZone = default;
            Optional<ResourceIdentifier> targetProximityPlacementGroupId = default;
            Optional<SiteRecoveryLicenseType> licenseType = default;
            Optional<SiteRecoverySqlServerLicenseType> sqlServerLicenseType = default;
            Optional<string> targetVmSize = default;
            Optional<ResourceIdentifier> diskEncryptionSetId = default;
            Optional<IDictionary<string, string>> targetVmTags = default;
            Optional<IDictionary<string, string>> seedManagedDiskTags = default;
            Optional<IDictionary<string, string>> targetManagedDiskTags = default;
            Optional<IDictionary<string, string>> targetNicTags = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("masterTargetId"u8))
                {
                    masterTargetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("processServerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    processServerId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("storageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("runAsAccountId"u8))
                {
                    runAsAccountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("multiVmGroupId"u8))
                {
                    multiVmGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("multiVmGroupName"u8))
                {
                    multiVmGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disksToInclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InMageAzureV2DiskDetails> array = new List<InMageAzureV2DiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InMageAzureV2DiskDetails.DeserializeInMageAzureV2DiskDetails(item, options));
                    }
                    disksToInclude = array;
                    continue;
                }
                if (property.NameEquals("targetAzureNetworkId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetAzureNetworkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetAzureSubnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetAzureSubnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enableRdpOnTargetOption"u8))
                {
                    enableRdpOnTargetOption = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetAzureVmName"u8))
                {
                    targetAzureVmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logStorageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logStorageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetAzureV1ResourceGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetAzureV1ResourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetAzureV2ResourceGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetAzureV2ResourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diskType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskType = new SiteRecoveryDiskAccountType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetAvailabilitySetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetAvailabilitySetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetAvailabilityZone"u8))
                {
                    targetAvailabilityZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetProximityPlacementGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetProximityPlacementGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("licenseType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    licenseType = new SiteRecoveryLicenseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sqlServerLicenseType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlServerLicenseType = new SiteRecoverySqlServerLicenseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetVmSize"u8))
                {
                    targetVmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskEncryptionSetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskEncryptionSetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetVmTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    targetVmTags = dictionary;
                    continue;
                }
                if (property.NameEquals("seedManagedDiskTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    seedManagedDiskTags = dictionary;
                    continue;
                }
                if (property.NameEquals("targetManagedDiskTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    targetManagedDiskTags = dictionary;
                    continue;
                }
                if (property.NameEquals("targetNicTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    targetNicTags = dictionary;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InMageAzureV2EnableProtectionContent(instanceType, serializedAdditionalRawData, masterTargetId.Value, Optional.ToNullable(processServerId), storageAccountId.Value, runAsAccountId.Value, multiVmGroupId.Value, multiVmGroupName.Value, disksToInclude ?? new ChangeTrackingList<InMageAzureV2DiskDetails>(), targetAzureNetworkId.Value, targetAzureSubnetId.Value, enableRdpOnTargetOption.Value, targetAzureVmName.Value, logStorageAccountId.Value, targetAzureV1ResourceGroupId.Value, targetAzureV2ResourceGroupId.Value, Optional.ToNullable(diskType), targetAvailabilitySetId.Value, targetAvailabilityZone.Value, targetProximityPlacementGroupId.Value, Optional.ToNullable(licenseType), Optional.ToNullable(sqlServerLicenseType), targetVmSize.Value, diskEncryptionSetId.Value, Optional.ToDictionary(targetVmTags), Optional.ToDictionary(seedManagedDiskTags), Optional.ToDictionary(targetManagedDiskTags), Optional.ToDictionary(targetNicTags));
        }

        BinaryData IPersistableModel<InMageAzureV2EnableProtectionContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageAzureV2EnableProtectionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InMageAzureV2EnableProtectionContent)} does not support '{options.Format}' format.");
            }
        }

        InMageAzureV2EnableProtectionContent IPersistableModel<InMageAzureV2EnableProtectionContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InMageAzureV2EnableProtectionContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInMageAzureV2EnableProtectionContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InMageAzureV2EnableProtectionContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InMageAzureV2EnableProtectionContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
