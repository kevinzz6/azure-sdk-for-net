// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    public partial class ArmApplicationDefinitionData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ManagedBy))
            {
                writer.WritePropertyName("managedBy"u8);
                writer.WriteStringValue(ManagedBy);
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
            writer.WritePropertyName("lockLevel"u8);
            writer.WriteStringValue(LockLevel.ToSerialString());
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("isEnabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsCollectionDefined(Authorizations))
            {
                writer.WritePropertyName("authorizations"u8);
                writer.WriteStartArray();
                foreach (var item in Authorizations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Artifacts))
            {
                writer.WritePropertyName("artifacts"u8);
                writer.WriteStartArray();
                foreach (var item in Artifacts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(PackageFileUri))
            {
                writer.WritePropertyName("packageFileUri"u8);
                writer.WriteStringValue(PackageFileUri.AbsoluteUri);
            }
            if (Optional.IsDefined(MainTemplate))
            {
                writer.WritePropertyName("mainTemplate"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(MainTemplate);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(MainTemplate.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(CreateUiDefinition))
            {
                writer.WritePropertyName("createUiDefinition"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(CreateUiDefinition);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(CreateUiDefinition.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(NotificationPolicy))
            {
                writer.WritePropertyName("notificationPolicy"u8);
                writer.WriteObjectValue(NotificationPolicy);
            }
            if (Optional.IsDefined(LockingPolicy))
            {
                writer.WritePropertyName("lockingPolicy"u8);
                writer.WriteObjectValue(LockingPolicy);
            }
            if (Optional.IsDefined(DeploymentPolicy))
            {
                writer.WritePropertyName("deploymentPolicy"u8);
                writer.WriteObjectValue(DeploymentPolicy);
            }
            if (Optional.IsDefined(ManagementPolicy))
            {
                writer.WritePropertyName("managementPolicy"u8);
                writer.WriteObjectValue(ManagementPolicy);
            }
            if (Optional.IsCollectionDefined(Policies))
            {
                writer.WritePropertyName("policies"u8);
                writer.WriteStartArray();
                foreach (var item in Policies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ArmApplicationDefinitionData DeserializeArmApplicationDefinitionData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> managedBy = default;
            Optional<ArmApplicationSku> sku = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            ArmApplicationLockLevel lockLevel = default;
            Optional<string> displayName = default;
            Optional<bool> isEnabled = default;
            Optional<IList<ArmApplicationAuthorization>> authorizations = default;
            Optional<IList<ArmApplicationDefinitionArtifact>> artifacts = default;
            Optional<string> description = default;
            Optional<Uri> packageFileUri = default;
            Optional<BinaryData> mainTemplate = default;
            Optional<BinaryData> createUiDefinition = default;
            Optional<ArmApplicationNotificationPolicy> notificationPolicy = default;
            Optional<ArmApplicationPackageLockingPolicy> lockingPolicy = default;
            Optional<ArmApplicationDeploymentPolicy> deploymentPolicy = default;
            Optional<ArmApplicationManagementPolicy> managementPolicy = default;
            Optional<IList<ArmApplicationPolicy>> policies = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managedBy"u8))
                {
                    managedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = ArmApplicationSku.DeserializeArmApplicationSku(property.Value);
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
                        if (property0.NameEquals("lockLevel"u8))
                        {
                            lockLevel = property0.Value.GetString().ToArmApplicationLockLevel();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("authorizations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ArmApplicationAuthorization> array = new List<ArmApplicationAuthorization>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ArmApplicationAuthorization.DeserializeArmApplicationAuthorization(item));
                            }
                            authorizations = array;
                            continue;
                        }
                        if (property0.NameEquals("artifacts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ArmApplicationDefinitionArtifact> array = new List<ArmApplicationDefinitionArtifact>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ArmApplicationDefinitionArtifact.DeserializeArmApplicationDefinitionArtifact(item));
                            }
                            artifacts = array;
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("packageFileUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            packageFileUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("mainTemplate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mainTemplate = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("createUiDefinition"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createUiDefinition = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("notificationPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            notificationPolicy = ArmApplicationNotificationPolicy.DeserializeArmApplicationNotificationPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("lockingPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lockingPolicy = ArmApplicationPackageLockingPolicy.DeserializeArmApplicationPackageLockingPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("deploymentPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deploymentPolicy = ArmApplicationDeploymentPolicy.DeserializeArmApplicationDeploymentPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("managementPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managementPolicy = ArmApplicationManagementPolicy.DeserializeArmApplicationManagementPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("policies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ArmApplicationPolicy> array = new List<ArmApplicationPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ArmApplicationPolicy.DeserializeArmApplicationPolicy(item));
                            }
                            policies = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ArmApplicationDefinitionData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, managedBy.Value, sku.Value, lockLevel, displayName.Value, Optional.ToNullable(isEnabled), Optional.ToList(authorizations), Optional.ToList(artifacts), description.Value, packageFileUri.Value, mainTemplate.Value, createUiDefinition.Value, notificationPolicy.Value, lockingPolicy.Value, deploymentPolicy.Value, managementPolicy.Value, Optional.ToList(policies));
        }
    }
}
