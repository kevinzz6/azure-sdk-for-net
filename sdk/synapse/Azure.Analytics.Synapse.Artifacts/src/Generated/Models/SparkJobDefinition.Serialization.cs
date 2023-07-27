// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SparkJobDefinitionConverter))]
    public partial class SparkJobDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("targetBigDataPool"u8);
            writer.WriteObjectValue(TargetBigDataPool);
            if (Optional.IsDefined(TargetSparkConfiguration))
            {
                writer.WritePropertyName("targetSparkConfiguration"u8);
                writer.WriteObjectValue(TargetSparkConfiguration);
            }
            if (Optional.IsDefined(RequiredSparkVersion))
            {
                writer.WritePropertyName("requiredSparkVersion"u8);
                writer.WriteStringValue(RequiredSparkVersion);
            }
            if (Optional.IsDefined(Language))
            {
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(Language);
            }
            writer.WritePropertyName("jobProperties"u8);
            writer.WriteObjectValue(JobProperties);
            if (Optional.IsDefined(Folder))
            {
                if (Folder != null)
                {
                    writer.WritePropertyName("folder"u8);
                    writer.WriteObjectValue(Folder);
                }
                else
                {
                    writer.WriteNull("folder");
                }
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static SparkJobDefinition DeserializeSparkJobDefinition(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> description = default;
            BigDataPoolReference targetBigDataPool = default;
            Optional<SparkConfigurationReference> targetSparkConfiguration = default;
            Optional<string> requiredSparkVersion = default;
            Optional<string> language = default;
            SparkJobProperties jobProperties = default;
            Optional<SparkJobDefinitionFolder> folder = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetBigDataPool"u8))
                {
                    targetBigDataPool = BigDataPoolReference.DeserializeBigDataPoolReference(property.Value);
                    continue;
                }
                if (property.NameEquals("targetSparkConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetSparkConfiguration = SparkConfigurationReference.DeserializeSparkConfigurationReference(property.Value);
                    continue;
                }
                if (property.NameEquals("requiredSparkVersion"u8))
                {
                    requiredSparkVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("language"u8))
                {
                    language = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobProperties"u8))
                {
                    jobProperties = SparkJobProperties.DeserializeSparkJobProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("folder"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        folder = null;
                        continue;
                    }
                    folder = SparkJobDefinitionFolder.DeserializeSparkJobDefinitionFolder(property.Value);
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SparkJobDefinition(description.Value, targetBigDataPool, targetSparkConfiguration.Value, requiredSparkVersion.Value, language.Value, jobProperties, folder.Value, additionalProperties);
        }

        internal partial class SparkJobDefinitionConverter : JsonConverter<SparkJobDefinition>
        {
            public override void Write(Utf8JsonWriter writer, SparkJobDefinition model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SparkJobDefinition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSparkJobDefinition(document.RootElement);
            }
        }
    }
}
