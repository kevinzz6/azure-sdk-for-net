// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    public partial class RecoveryServicesVaultProperties : IUtf8JsonSerializable, IJsonModel<RecoveryServicesVaultProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryServicesVaultProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RecoveryServicesVaultProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryServicesVaultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryServicesVaultProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (UpgradeDetails != null)
            {
                writer.WritePropertyName("upgradeDetails"u8);
                writer.WriteObjectValue(UpgradeDetails);
            }
            if (options.Format != "W" && !(PrivateEndpointConnections is ChangeTrackingList<RecoveryServicesPrivateEndpointConnectionVaultProperties> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && PrivateEndpointStateForBackup.HasValue)
            {
                writer.WritePropertyName("privateEndpointStateForBackup"u8);
                writer.WriteStringValue(PrivateEndpointStateForBackup.Value.ToString());
            }
            if (options.Format != "W" && PrivateEndpointStateForSiteRecovery.HasValue)
            {
                writer.WritePropertyName("privateEndpointStateForSiteRecovery"u8);
                writer.WriteStringValue(PrivateEndpointStateForSiteRecovery.Value.ToString());
            }
            if (Encryption != null)
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption);
            }
            if (MoveDetails != null)
            {
                writer.WritePropertyName("moveDetails"u8);
                writer.WriteObjectValue(MoveDetails);
            }
            if (options.Format != "W" && MoveState.HasValue)
            {
                writer.WritePropertyName("moveState"u8);
                writer.WriteStringValue(MoveState.Value.ToString());
            }
            if (options.Format != "W" && BackupStorageVersion.HasValue)
            {
                writer.WritePropertyName("backupStorageVersion"u8);
                writer.WriteStringValue(BackupStorageVersion.Value.ToString());
            }
            if (PublicNetworkAccess.HasValue)
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (MonitoringSettings != null)
            {
                writer.WritePropertyName("monitoringSettings"u8);
                writer.WriteObjectValue(MonitoringSettings);
            }
            if (RestoreSettings != null)
            {
                writer.WritePropertyName("restoreSettings"u8);
                writer.WriteObjectValue(RestoreSettings);
            }
            if (RedundancySettings != null)
            {
                writer.WritePropertyName("redundancySettings"u8);
                writer.WriteObjectValue(RedundancySettings);
            }
            if (SecuritySettings != null)
            {
                writer.WritePropertyName("securitySettings"u8);
                writer.WriteObjectValue(SecuritySettings);
            }
            if (options.Format != "W" && SecureScore.HasValue)
            {
                writer.WritePropertyName("secureScore"u8);
                writer.WriteStringValue(SecureScore.Value.ToString());
            }
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

        RecoveryServicesVaultProperties IJsonModel<RecoveryServicesVaultProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryServicesVaultProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RecoveryServicesVaultProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryServicesVaultProperties(document.RootElement, options);
        }

        internal static RecoveryServicesVaultProperties DeserializeRecoveryServicesVaultProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> provisioningState = default;
            Optional<VaultUpgradeDetails> upgradeDetails = default;
            IReadOnlyList<RecoveryServicesPrivateEndpointConnectionVaultProperties> privateEndpointConnections = default;
            Optional<VaultPrivateEndpointState> privateEndpointStateForBackup = default;
            Optional<VaultPrivateEndpointState> privateEndpointStateForSiteRecovery = default;
            Optional<VaultPropertiesEncryption> encryption = default;
            Optional<VaultPropertiesMoveDetails> moveDetails = default;
            Optional<ResourceMoveState> moveState = default;
            Optional<BackupStorageVersion> backupStorageVersion = default;
            Optional<VaultPublicNetworkAccess> publicNetworkAccess = default;
            Optional<VaultMonitoringSettings> monitoringSettings = default;
            Optional<RestoreSettings> restoreSettings = default;
            Optional<VaultPropertiesRedundancySettings> redundancySettings = default;
            Optional<RecoveryServicesSecuritySettings> securitySettings = default;
            Optional<SecureScoreLevel> secureScore = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("upgradeDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upgradeDetails = VaultUpgradeDetails.DeserializeVaultUpgradeDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("privateEndpointConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RecoveryServicesPrivateEndpointConnectionVaultProperties> array = new List<RecoveryServicesPrivateEndpointConnectionVaultProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecoveryServicesPrivateEndpointConnectionVaultProperties.DeserializeRecoveryServicesPrivateEndpointConnectionVaultProperties(item, options));
                    }
                    privateEndpointConnections = array;
                    continue;
                }
                if (property.NameEquals("privateEndpointStateForBackup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateEndpointStateForBackup = new VaultPrivateEndpointState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("privateEndpointStateForSiteRecovery"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateEndpointStateForSiteRecovery = new VaultPrivateEndpointState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("encryption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryption = VaultPropertiesEncryption.DeserializeVaultPropertiesEncryption(property.Value, options);
                    continue;
                }
                if (property.NameEquals("moveDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    moveDetails = VaultPropertiesMoveDetails.DeserializeVaultPropertiesMoveDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("moveState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    moveState = new ResourceMoveState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("backupStorageVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupStorageVersion = new BackupStorageVersion(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new VaultPublicNetworkAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("monitoringSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitoringSettings = VaultMonitoringSettings.DeserializeVaultMonitoringSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("restoreSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restoreSettings = RestoreSettings.DeserializeRestoreSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("redundancySettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    redundancySettings = VaultPropertiesRedundancySettings.DeserializeVaultPropertiesRedundancySettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("securitySettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    securitySettings = RecoveryServicesSecuritySettings.DeserializeRecoveryServicesSecuritySettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("secureScore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secureScore = new SecureScoreLevel(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RecoveryServicesVaultProperties(provisioningState.Value, upgradeDetails.Value, privateEndpointConnections ?? new ChangeTrackingList<RecoveryServicesPrivateEndpointConnectionVaultProperties>(), Optional.ToNullable(privateEndpointStateForBackup), Optional.ToNullable(privateEndpointStateForSiteRecovery), encryption.Value, moveDetails.Value, Optional.ToNullable(moveState), Optional.ToNullable(backupStorageVersion), Optional.ToNullable(publicNetworkAccess), monitoringSettings.Value, restoreSettings.Value, redundancySettings.Value, securitySettings.Value, Optional.ToNullable(secureScore), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RecoveryServicesVaultProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryServicesVaultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RecoveryServicesVaultProperties)} does not support '{options.Format}' format.");
            }
        }

        RecoveryServicesVaultProperties IPersistableModel<RecoveryServicesVaultProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RecoveryServicesVaultProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRecoveryServicesVaultProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RecoveryServicesVaultProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RecoveryServicesVaultProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
