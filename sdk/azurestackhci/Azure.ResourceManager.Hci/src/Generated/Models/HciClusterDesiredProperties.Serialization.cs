// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class HciClusterDesiredProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(WindowsServerSubscription))
            {
                writer.WritePropertyName("windowsServerSubscription"u8);
                writer.WriteStringValue(WindowsServerSubscription.Value.ToString());
            }
            if (Optional.IsDefined(DiagnosticLevel))
            {
                writer.WritePropertyName("diagnosticLevel"u8);
                writer.WriteStringValue(DiagnosticLevel.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static HciClusterDesiredProperties DeserializeHciClusterDesiredProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<WindowsServerSubscription> windowsServerSubscription = default;
            Optional<HciClusterDiagnosticLevel> diagnosticLevel = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("windowsServerSubscription"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    windowsServerSubscription = new WindowsServerSubscription(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diagnosticLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diagnosticLevel = new HciClusterDiagnosticLevel(property.Value.GetString());
                    continue;
                }
            }
            return new HciClusterDesiredProperties(Optional.ToNullable(windowsServerSubscription), Optional.ToNullable(diagnosticLevel));
        }
    }
}
