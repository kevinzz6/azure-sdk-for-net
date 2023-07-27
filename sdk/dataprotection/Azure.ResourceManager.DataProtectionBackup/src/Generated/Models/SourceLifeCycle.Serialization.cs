// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class SourceLifeCycle : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("deleteAfter"u8);
            writer.WriteObjectValue(DeleteAfter);
            writer.WritePropertyName("sourceDataStore"u8);
            writer.WriteObjectValue(SourceDataStore);
            if (Optional.IsCollectionDefined(TargetDataStoreCopySettings))
            {
                writer.WritePropertyName("targetDataStoreCopySettings"u8);
                writer.WriteStartArray();
                foreach (var item in TargetDataStoreCopySettings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static SourceLifeCycle DeserializeSourceLifeCycle(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataProtectionBackupDeleteSetting deleteAfter = default;
            DataStoreInfoBase sourceDataStore = default;
            Optional<IList<TargetCopySetting>> targetDataStoreCopySettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deleteAfter"u8))
                {
                    deleteAfter = DataProtectionBackupDeleteSetting.DeserializeDataProtectionBackupDeleteSetting(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceDataStore"u8))
                {
                    sourceDataStore = DataStoreInfoBase.DeserializeDataStoreInfoBase(property.Value);
                    continue;
                }
                if (property.NameEquals("targetDataStoreCopySettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TargetCopySetting> array = new List<TargetCopySetting>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TargetCopySetting.DeserializeTargetCopySetting(item));
                    }
                    targetDataStoreCopySettings = array;
                    continue;
                }
            }
            return new SourceLifeCycle(deleteAfter, sourceDataStore, Optional.ToList(targetDataStoreCopySettings));
        }
    }
}
