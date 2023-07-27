// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderForServersGcpOffering : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DefenderForServers))
            {
                writer.WritePropertyName("defenderForServers"u8);
                writer.WriteObjectValue(DefenderForServers);
            }
            if (Optional.IsDefined(ArcAutoProvisioning))
            {
                writer.WritePropertyName("arcAutoProvisioning"u8);
                writer.WriteObjectValue(ArcAutoProvisioning);
            }
            if (Optional.IsDefined(VulnerabilityAssessmentAutoProvisioning))
            {
                writer.WritePropertyName("vaAutoProvisioning"u8);
                writer.WriteObjectValue(VulnerabilityAssessmentAutoProvisioning);
            }
            if (Optional.IsDefined(MdeAutoProvisioning))
            {
                writer.WritePropertyName("mdeAutoProvisioning"u8);
                writer.WriteObjectValue(MdeAutoProvisioning);
            }
            if (Optional.IsDefined(SubPlan))
            {
                writer.WritePropertyName("subPlan"u8);
                writer.WriteObjectValue(SubPlan);
            }
            writer.WritePropertyName("offeringType"u8);
            writer.WriteStringValue(OfferingType.ToString());
            writer.WriteEndObject();
        }

        internal static DefenderForServersGcpOffering DeserializeDefenderForServersGcpOffering(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<GcpDefenderForServersInfo> defenderForServers = default;
            Optional<DefenderForServersGcpOfferingArcAutoProvisioning> arcAutoProvisioning = default;
            Optional<DefenderForServersGcpOfferingVulnerabilityAssessmentAutoProvisioning> vaAutoProvisioning = default;
            Optional<DefenderForServersGcpOfferingMdeAutoProvisioning> mdeAutoProvisioning = default;
            Optional<DefenderForServersGcpOfferingSubPlan> subPlan = default;
            OfferingType offeringType = default;
            Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defenderForServers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defenderForServers = GcpDefenderForServersInfo.DeserializeGcpDefenderForServersInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("arcAutoProvisioning"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    arcAutoProvisioning = DefenderForServersGcpOfferingArcAutoProvisioning.DeserializeDefenderForServersGcpOfferingArcAutoProvisioning(property.Value);
                    continue;
                }
                if (property.NameEquals("vaAutoProvisioning"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vaAutoProvisioning = DefenderForServersGcpOfferingVulnerabilityAssessmentAutoProvisioning.DeserializeDefenderForServersGcpOfferingVulnerabilityAssessmentAutoProvisioning(property.Value);
                    continue;
                }
                if (property.NameEquals("mdeAutoProvisioning"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mdeAutoProvisioning = DefenderForServersGcpOfferingMdeAutoProvisioning.DeserializeDefenderForServersGcpOfferingMdeAutoProvisioning(property.Value);
                    continue;
                }
                if (property.NameEquals("subPlan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subPlan = DefenderForServersGcpOfferingSubPlan.DeserializeDefenderForServersGcpOfferingSubPlan(property.Value);
                    continue;
                }
                if (property.NameEquals("offeringType"u8))
                {
                    offeringType = new OfferingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new DefenderForServersGcpOffering(offeringType, description.Value, defenderForServers.Value, arcAutoProvisioning.Value, vaAutoProvisioning.Value, mdeAutoProvisioning.Value, subPlan.Value);
        }
    }
}
