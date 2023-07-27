// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class MabBackupJobExtendedInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(TasksList))
            {
                writer.WritePropertyName("tasksList"u8);
                writer.WriteStartArray();
                foreach (var item in TasksList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PropertyBag))
            {
                writer.WritePropertyName("propertyBag"u8);
                writer.WriteStartObject();
                foreach (var item in PropertyBag)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(DynamicErrorMessage))
            {
                writer.WritePropertyName("dynamicErrorMessage"u8);
                writer.WriteStringValue(DynamicErrorMessage);
            }
            writer.WriteEndObject();
        }

        internal static MabBackupJobExtendedInfo DeserializeMabBackupJobExtendedInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<MabBackupJobTaskDetails>> tasksList = default;
            Optional<IDictionary<string, string>> propertyBag = default;
            Optional<string> dynamicErrorMessage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tasksList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MabBackupJobTaskDetails> array = new List<MabBackupJobTaskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MabBackupJobTaskDetails.DeserializeMabBackupJobTaskDetails(item));
                    }
                    tasksList = array;
                    continue;
                }
                if (property.NameEquals("propertyBag"u8))
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
                    propertyBag = dictionary;
                    continue;
                }
                if (property.NameEquals("dynamicErrorMessage"u8))
                {
                    dynamicErrorMessage = property.Value.GetString();
                    continue;
                }
            }
            return new MabBackupJobExtendedInfo(Optional.ToList(tasksList), Optional.ToDictionary(propertyBag), dynamicErrorMessage.Value);
        }
    }
}
