// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class ApplicationUpgradePolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ApplicationHealthPolicy))
            {
                writer.WritePropertyName("applicationHealthPolicy"u8);
                writer.WriteObjectValue(ApplicationHealthPolicy);
            }
            if (Optional.IsDefined(ForceRestart))
            {
                writer.WritePropertyName("forceRestart"u8);
                writer.WriteBooleanValue(ForceRestart.Value);
            }
            if (Optional.IsDefined(RollingUpgradeMonitoringPolicy))
            {
                writer.WritePropertyName("rollingUpgradeMonitoringPolicy"u8);
                writer.WriteObjectValue(RollingUpgradeMonitoringPolicy);
            }
            if (Optional.IsDefined(InstanceCloseDelayDurationInSeconds))
            {
                writer.WritePropertyName("instanceCloseDelayDuration"u8);
                writer.WriteNumberValue(InstanceCloseDelayDurationInSeconds.Value);
            }
            if (Optional.IsDefined(UpgradeMode))
            {
                writer.WritePropertyName("upgradeMode"u8);
                writer.WriteStringValue(UpgradeMode.Value.ToString());
            }
            if (Optional.IsDefined(UpgradeReplicaSetCheckTimeout))
            {
                writer.WritePropertyName("upgradeReplicaSetCheckTimeout"u8);
                writer.WriteNumberValue(UpgradeReplicaSetCheckTimeout.Value);
            }
            if (Optional.IsDefined(RecreateApplication))
            {
                writer.WritePropertyName("recreateApplication"u8);
                writer.WriteBooleanValue(RecreateApplication.Value);
            }
            writer.WriteEndObject();
        }

        internal static ApplicationUpgradePolicy DeserializeApplicationUpgradePolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ApplicationHealthPolicy> applicationHealthPolicy = default;
            Optional<bool> forceRestart = default;
            Optional<RollingUpgradeMonitoringPolicy> rollingUpgradeMonitoringPolicy = default;
            Optional<long> instanceCloseDelayDuration = default;
            Optional<RollingUpgradeMode> upgradeMode = default;
            Optional<long> upgradeReplicaSetCheckTimeout = default;
            Optional<bool> recreateApplication = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("applicationHealthPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applicationHealthPolicy = ApplicationHealthPolicy.DeserializeApplicationHealthPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("forceRestart"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    forceRestart = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("rollingUpgradeMonitoringPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rollingUpgradeMonitoringPolicy = RollingUpgradeMonitoringPolicy.DeserializeRollingUpgradeMonitoringPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("instanceCloseDelayDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instanceCloseDelayDuration = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("upgradeMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upgradeMode = new RollingUpgradeMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("upgradeReplicaSetCheckTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upgradeReplicaSetCheckTimeout = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("recreateApplication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recreateApplication = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ApplicationUpgradePolicy(applicationHealthPolicy.Value, Optional.ToNullable(forceRestart), rollingUpgradeMonitoringPolicy.Value, Optional.ToNullable(instanceCloseDelayDuration), Optional.ToNullable(upgradeMode), Optional.ToNullable(upgradeReplicaSetCheckTimeout), Optional.ToNullable(recreateApplication));
        }
    }
}
