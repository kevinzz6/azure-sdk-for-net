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
    [JsonConverter(typeof(SqlSourceConverter))]
    public partial class SqlSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SqlReaderQuery))
            {
                writer.WritePropertyName("sqlReaderQuery"u8);
                writer.WriteObjectValue(SqlReaderQuery);
            }
            if (Optional.IsDefined(SqlReaderStoredProcedureName))
            {
                writer.WritePropertyName("sqlReaderStoredProcedureName"u8);
                writer.WriteObjectValue(SqlReaderStoredProcedureName);
            }
            if (Optional.IsDefined(StoredProcedureParameters))
            {
                writer.WritePropertyName("storedProcedureParameters"u8);
                writer.WriteObjectValue(StoredProcedureParameters);
            }
            if (Optional.IsDefined(IsolationLevel))
            {
                writer.WritePropertyName("isolationLevel"u8);
                writer.WriteObjectValue(IsolationLevel);
            }
            if (Optional.IsDefined(PartitionOption))
            {
                writer.WritePropertyName("partitionOption"u8);
                writer.WriteObjectValue(PartitionOption);
            }
            if (Optional.IsDefined(PartitionSettings))
            {
                writer.WritePropertyName("partitionSettings"u8);
                writer.WriteObjectValue(PartitionSettings);
            }
            if (Optional.IsDefined(QueryTimeout))
            {
                writer.WritePropertyName("queryTimeout"u8);
                writer.WriteObjectValue(QueryTimeout);
            }
            if (Optional.IsDefined(AdditionalColumns))
            {
                writer.WritePropertyName("additionalColumns"u8);
                writer.WriteObjectValue(AdditionalColumns);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(SourceRetryCount))
            {
                writer.WritePropertyName("sourceRetryCount"u8);
                writer.WriteObjectValue(SourceRetryCount);
            }
            if (Optional.IsDefined(SourceRetryWait))
            {
                writer.WritePropertyName("sourceRetryWait"u8);
                writer.WriteObjectValue(SourceRetryWait);
            }
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static SqlSource DeserializeSqlSource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> sqlReaderQuery = default;
            Optional<object> sqlReaderStoredProcedureName = default;
            Optional<object> storedProcedureParameters = default;
            Optional<object> isolationLevel = default;
            Optional<object> partitionOption = default;
            Optional<SqlPartitionSettings> partitionSettings = default;
            Optional<object> queryTimeout = default;
            Optional<object> additionalColumns = default;
            string type = default;
            Optional<object> sourceRetryCount = default;
            Optional<object> sourceRetryWait = default;
            Optional<object> maxConcurrentConnections = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sqlReaderQuery"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlReaderQuery = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sqlReaderStoredProcedureName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlReaderStoredProcedureName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("storedProcedureParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storedProcedureParameters = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("isolationLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isolationLevel = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("partitionOption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionOption = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("partitionSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionSettings = SqlPartitionSettings.DeserializeSqlPartitionSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("queryTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryTimeout = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("additionalColumns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    additionalColumns = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRetryCount = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("sourceRetryWait"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceRetryWait = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SqlSource(type, sourceRetryCount.Value, sourceRetryWait.Value, maxConcurrentConnections.Value, additionalProperties, queryTimeout.Value, additionalColumns.Value, sqlReaderQuery.Value, sqlReaderStoredProcedureName.Value, storedProcedureParameters.Value, isolationLevel.Value, partitionOption.Value, partitionSettings.Value);
        }

        internal partial class SqlSourceConverter : JsonConverter<SqlSource>
        {
            public override void Write(Utf8JsonWriter writer, SqlSource model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SqlSource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSqlSource(document.RootElement);
            }
        }
    }
}
