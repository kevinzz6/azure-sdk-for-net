// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class WindowsParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ClassificationsToInclude))
            {
                writer.WritePropertyName("classificationsToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in ClassificationsToInclude)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(KbNumbersToInclude))
            {
                writer.WritePropertyName("kbNumbersToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in KbNumbersToInclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(KbNumbersToExclude))
            {
                writer.WritePropertyName("kbNumbersToExclude"u8);
                writer.WriteStartArray();
                foreach (var item in KbNumbersToExclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ExcludeKbsRequiringReboot))
            {
                writer.WritePropertyName("excludeKbsRequiringReboot"u8);
                writer.WriteBooleanValue(ExcludeKbsRequiringReboot.Value);
            }
            if (Optional.IsDefined(MaxPatchPublishOn))
            {
                writer.WritePropertyName("maxPatchPublishDate"u8);
                writer.WriteStringValue(MaxPatchPublishOn.Value, "O");
            }
            writer.WriteEndObject();
        }
    }
}
