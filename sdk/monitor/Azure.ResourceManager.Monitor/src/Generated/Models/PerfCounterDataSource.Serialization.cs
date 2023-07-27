// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class PerfCounterDataSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Streams))
            {
                writer.WritePropertyName("streams"u8);
                writer.WriteStartArray();
                foreach (var item in Streams)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SamplingFrequencyInSeconds))
            {
                writer.WritePropertyName("samplingFrequencyInSeconds"u8);
                writer.WriteNumberValue(SamplingFrequencyInSeconds.Value);
            }
            if (Optional.IsCollectionDefined(CounterSpecifiers))
            {
                writer.WritePropertyName("counterSpecifiers"u8);
                writer.WriteStartArray();
                foreach (var item in CounterSpecifiers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WriteEndObject();
        }

        internal static PerfCounterDataSource DeserializePerfCounterDataSource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<PerfCounterDataSourceStream>> streams = default;
            Optional<int> samplingFrequencyInSeconds = default;
            Optional<IList<string>> counterSpecifiers = default;
            Optional<string> name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("streams"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PerfCounterDataSourceStream> array = new List<PerfCounterDataSourceStream>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new PerfCounterDataSourceStream(item.GetString()));
                    }
                    streams = array;
                    continue;
                }
                if (property.NameEquals("samplingFrequencyInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    samplingFrequencyInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("counterSpecifiers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    counterSpecifiers = array;
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new PerfCounterDataSource(Optional.ToList(streams), Optional.ToNullable(samplingFrequencyInSeconds), Optional.ToList(counterSpecifiers), name.Value);
        }
    }
}
