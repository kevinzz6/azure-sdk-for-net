// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class IaasVmIlrRegistrationContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryPointId))
            {
                writer.WritePropertyName("recoveryPointId"u8);
                writer.WriteStringValue(RecoveryPointId);
            }
            if (Optional.IsDefined(VirtualMachineId))
            {
                writer.WritePropertyName("virtualMachineId"u8);
                writer.WriteStringValue(VirtualMachineId);
            }
            if (Optional.IsDefined(InitiatorName))
            {
                writer.WritePropertyName("initiatorName"u8);
                writer.WriteStringValue(InitiatorName);
            }
            if (Optional.IsDefined(RenewExistingRegistration))
            {
                writer.WritePropertyName("renewExistingRegistration"u8);
                writer.WriteBooleanValue(RenewExistingRegistration.Value);
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
            writer.WriteEndObject();
        }

        internal static IaasVmIlrRegistrationContent DeserializeIaasVmIlrRegistrationContent(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> recoveryPointId = default;
            Optional<ResourceIdentifier> virtualMachineId = default;
            Optional<string> initiatorName = default;
            Optional<bool> renewExistingRegistration = default;
            string objectType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointId"u8))
                {
                    recoveryPointId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("virtualMachineId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualMachineId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("initiatorName"u8))
                {
                    initiatorName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("renewExistingRegistration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    renewExistingRegistration = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
            }
            return new IaasVmIlrRegistrationContent(objectType, recoveryPointId.Value, virtualMachineId.Value, initiatorName.Value, Optional.ToNullable(renewExistingRegistration));
        }
    }
}
