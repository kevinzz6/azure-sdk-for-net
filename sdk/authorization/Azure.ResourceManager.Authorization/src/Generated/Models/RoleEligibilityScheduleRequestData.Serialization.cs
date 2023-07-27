// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Authorization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Authorization
{
    public partial class RoleEligibilityScheduleRequestData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(RoleDefinitionId))
            {
                writer.WritePropertyName("roleDefinitionId"u8);
                writer.WriteStringValue(RoleDefinitionId);
            }
            if (Optional.IsDefined(PrincipalId))
            {
                writer.WritePropertyName("principalId"u8);
                writer.WriteStringValue(PrincipalId.Value);
            }
            if (Optional.IsDefined(RequestType))
            {
                writer.WritePropertyName("requestType"u8);
                writer.WriteStringValue(RequestType.Value.ToString());
            }
            if (Optional.IsDefined(TargetRoleEligibilityScheduleId))
            {
                writer.WritePropertyName("targetRoleEligibilityScheduleId"u8);
                writer.WriteStringValue(TargetRoleEligibilityScheduleId);
            }
            if (Optional.IsDefined(TargetRoleEligibilityScheduleInstanceId))
            {
                writer.WritePropertyName("targetRoleEligibilityScheduleInstanceId"u8);
                writer.WriteStringValue(TargetRoleEligibilityScheduleInstanceId);
            }
            if (Optional.IsDefined(Justification))
            {
                writer.WritePropertyName("justification"u8);
                writer.WriteStringValue(Justification);
            }
            if (Optional.IsDefined(TicketInfo))
            {
                writer.WritePropertyName("ticketInfo"u8);
                writer.WriteObjectValue(TicketInfo);
            }
            if (Optional.IsDefined(Condition))
            {
                writer.WritePropertyName("condition"u8);
                writer.WriteStringValue(Condition);
            }
            if (Optional.IsDefined(ConditionVersion))
            {
                writer.WritePropertyName("conditionVersion"u8);
                writer.WriteStringValue(ConditionVersion);
            }
            writer.WritePropertyName("scheduleInfo"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startDateTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            writer.WritePropertyName("expiration"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ExpirationType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ExpirationType.Value.ToString());
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endDateTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteStringValue(Duration.Value, "P");
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RoleEligibilityScheduleRequestData DeserializeRoleEligibilityScheduleRequestData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> scope = default;
            Optional<ResourceIdentifier> roleDefinitionId = default;
            Optional<Guid> principalId = default;
            Optional<RoleManagementPrincipalType> principalType = default;
            Optional<RoleManagementScheduleRequestType> requestType = default;
            Optional<RoleManagementScheduleStatus> status = default;
            Optional<string> approvalId = default;
            Optional<ResourceIdentifier> targetRoleEligibilityScheduleId = default;
            Optional<ResourceIdentifier> targetRoleEligibilityScheduleInstanceId = default;
            Optional<string> justification = default;
            Optional<RoleEligibilityScheduleRequestPropertiesTicketInfo> ticketInfo = default;
            Optional<string> condition = default;
            Optional<string> conditionVersion = default;
            Optional<DateTimeOffset> createdOn = default;
            Optional<Guid> requestorId = default;
            Optional<RoleManagementExpandedProperties> expandedProperties = default;
            Optional<DateTimeOffset> startDateTime = default;
            Optional<RoleManagementScheduleExpirationType> type0 = default;
            Optional<DateTimeOffset> endDateTime = default;
            Optional<TimeSpan> duration = default;
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
                        if (property0.NameEquals("scope"u8))
                        {
                            scope = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("roleDefinitionId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            roleDefinitionId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("principalId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            principalId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("principalType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            principalType = new RoleManagementPrincipalType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("requestType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requestType = new RoleManagementScheduleRequestType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new RoleManagementScheduleStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("approvalId"u8))
                        {
                            approvalId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetRoleEligibilityScheduleId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetRoleEligibilityScheduleId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("targetRoleEligibilityScheduleInstanceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetRoleEligibilityScheduleInstanceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("justification"u8))
                        {
                            justification = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ticketInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ticketInfo = RoleEligibilityScheduleRequestPropertiesTicketInfo.DeserializeRoleEligibilityScheduleRequestPropertiesTicketInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("condition"u8))
                        {
                            condition = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("conditionVersion"u8))
                        {
                            conditionVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdOn = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("requestorId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requestorId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("expandedProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expandedProperties = RoleManagementExpandedProperties.DeserializeRoleManagementExpandedProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("scheduleInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.NameEquals("startDateTime"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        continue;
                                    }
                                    startDateTime = property1.Value.GetDateTimeOffset("O");
                                    continue;
                                }
                                if (property1.NameEquals("expiration"u8))
                                {
                                    if (property1.Value.ValueKind == JsonValueKind.Null)
                                    {
                                        property1.ThrowNonNullablePropertyIsNull();
                                        continue;
                                    }
                                    foreach (var property2 in property1.Value.EnumerateObject())
                                    {
                                        if (property2.NameEquals("type"u8))
                                        {
                                            if (property2.Value.ValueKind == JsonValueKind.Null)
                                            {
                                                continue;
                                            }
                                            type0 = new RoleManagementScheduleExpirationType(property2.Value.GetString());
                                            continue;
                                        }
                                        if (property2.NameEquals("endDateTime"u8))
                                        {
                                            if (property2.Value.ValueKind == JsonValueKind.Null)
                                            {
                                                continue;
                                            }
                                            endDateTime = property2.Value.GetDateTimeOffset("O");
                                            continue;
                                        }
                                        if (property2.NameEquals("duration"u8))
                                        {
                                            if (property2.Value.ValueKind == JsonValueKind.Null)
                                            {
                                                continue;
                                            }
                                            duration = property2.Value.GetTimeSpan("P");
                                            continue;
                                        }
                                    }
                                    continue;
                                }
                            }
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RoleEligibilityScheduleRequestData(id, name, type, systemData.Value, scope.Value, roleDefinitionId.Value, Optional.ToNullable(principalId), Optional.ToNullable(principalType), Optional.ToNullable(requestType), Optional.ToNullable(status), approvalId.Value, targetRoleEligibilityScheduleId.Value, targetRoleEligibilityScheduleInstanceId.Value, justification.Value, ticketInfo.Value, condition.Value, conditionVersion.Value, Optional.ToNullable(createdOn), Optional.ToNullable(requestorId), expandedProperties.Value, Optional.ToNullable(startDateTime), Optional.ToNullable(type0), Optional.ToNullable(endDateTime), Optional.ToNullable(duration));
        }
    }
}
