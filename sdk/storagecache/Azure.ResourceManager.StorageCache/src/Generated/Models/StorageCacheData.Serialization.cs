// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.StorageCache.Models;

namespace Azure.ResourceManager.StorageCache
{
    public partial class StorageCacheData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(CacheSizeGB))
            {
                writer.WritePropertyName("cacheSizeGB"u8);
                writer.WriteNumberValue(CacheSizeGB.Value);
            }
            if (Optional.IsDefined(Subnet))
            {
                writer.WritePropertyName("subnet"u8);
                writer.WriteStringValue(Subnet);
            }
            if (Optional.IsDefined(UpgradeSettings))
            {
                writer.WritePropertyName("upgradeSettings"u8);
                writer.WriteObjectValue(UpgradeSettings);
            }
            if (Optional.IsDefined(NetworkSettings))
            {
                writer.WritePropertyName("networkSettings"u8);
                writer.WriteObjectValue(NetworkSettings);
            }
            if (Optional.IsDefined(EncryptionSettings))
            {
                writer.WritePropertyName("encryptionSettings"u8);
                writer.WriteObjectValue(EncryptionSettings);
            }
            if (Optional.IsDefined(SecuritySettings))
            {
                writer.WritePropertyName("securitySettings"u8);
                writer.WriteObjectValue(SecuritySettings);
            }
            if (Optional.IsDefined(DirectoryServicesSettings))
            {
                writer.WritePropertyName("directoryServicesSettings"u8);
                writer.WriteObjectValue(DirectoryServicesSettings);
            }
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static StorageCacheData DeserializeStorageCacheData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedServiceIdentity> identity = default;
            Optional<StorageCacheSkuInfo> sku = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<int> cacheSizeGB = default;
            Optional<StorageCacheHealth> health = default;
            Optional<IReadOnlyList<IPAddress>> mountAddresses = default;
            Optional<StorageCacheProvisioningStateType> provisioningState = default;
            Optional<ResourceIdentifier> subnet = default;
            Optional<StorageCacheUpgradeStatus> upgradeStatus = default;
            Optional<StorageCacheUpgradeSettings> upgradeSettings = default;
            Optional<StorageCacheNetworkSettings> networkSettings = default;
            Optional<StorageCacheEncryptionSettings> encryptionSettings = default;
            Optional<StorageCacheSecuritySettings> securitySettings = default;
            Optional<StorageCacheDirectorySettings> directoryServicesSettings = default;
            Optional<IList<string>> zones = default;
            Optional<IReadOnlyList<PrimingJob>> primingJobs = default;
            Optional<IReadOnlyList<StorageTargetSpaceAllocation>> spaceAllocation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = StorageCacheSkuInfo.DeserializeStorageCacheSkuInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("cacheSizeGB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cacheSizeGB = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("health"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            health = StorageCacheHealth.DeserializeStorageCacheHealth(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("mountAddresses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IPAddress> array = new List<IPAddress>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(IPAddress.Parse(item.GetString()));
                                }
                            }
                            mountAddresses = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new StorageCacheProvisioningStateType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("subnet"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subnet = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("upgradeStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            upgradeStatus = StorageCacheUpgradeStatus.DeserializeStorageCacheUpgradeStatus(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("upgradeSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            upgradeSettings = StorageCacheUpgradeSettings.DeserializeStorageCacheUpgradeSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("networkSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkSettings = StorageCacheNetworkSettings.DeserializeStorageCacheNetworkSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("encryptionSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptionSettings = StorageCacheEncryptionSettings.DeserializeStorageCacheEncryptionSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("securitySettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            securitySettings = StorageCacheSecuritySettings.DeserializeStorageCacheSecuritySettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("directoryServicesSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            directoryServicesSettings = StorageCacheDirectorySettings.DeserializeStorageCacheDirectorySettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("zones"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            zones = array;
                            continue;
                        }
                        if (property0.NameEquals("primingJobs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PrimingJob> array = new List<PrimingJob>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PrimingJob.DeserializePrimingJob(item));
                            }
                            primingJobs = array;
                            continue;
                        }
                        if (property0.NameEquals("spaceAllocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<StorageTargetSpaceAllocation> array = new List<StorageTargetSpaceAllocation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StorageTargetSpaceAllocation.DeserializeStorageTargetSpaceAllocation(item));
                            }
                            spaceAllocation = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new StorageCacheData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, identity, sku.Value, Optional.ToNullable(cacheSizeGB), health.Value, Optional.ToList(mountAddresses), Optional.ToNullable(provisioningState), subnet.Value, upgradeStatus.Value, upgradeSettings.Value, networkSettings.Value, encryptionSettings.Value, securitySettings.Value, directoryServicesSettings.Value, Optional.ToList(zones), Optional.ToList(primingJobs), Optional.ToList(spaceAllocation));
        }
    }
}
