// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class RoutingRuleExperiments : IUtf8JsonSerializable, IJsonModel<RoutingRuleExperiments>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RoutingRuleExperiments>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RoutingRuleExperiments>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingRuleExperiments>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoutingRuleExperiments)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(RampUpRules is ChangeTrackingList<RampUpRule> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("rampUpRules"u8);
                writer.WriteStartArray();
                foreach (var item in RampUpRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        RoutingRuleExperiments IJsonModel<RoutingRuleExperiments>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingRuleExperiments>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoutingRuleExperiments)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRoutingRuleExperiments(document.RootElement, options);
        }

        internal static RoutingRuleExperiments DeserializeRoutingRuleExperiments(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<RampUpRule> rampUpRules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rampUpRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RampUpRule> array = new List<RampUpRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RampUpRule.DeserializeRampUpRule(item, options));
                    }
                    rampUpRules = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RoutingRuleExperiments(rampUpRules ?? new ChangeTrackingList<RampUpRule>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RoutingRuleExperiments>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingRuleExperiments>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RoutingRuleExperiments)} does not support '{options.Format}' format.");
            }
        }

        RoutingRuleExperiments IPersistableModel<RoutingRuleExperiments>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingRuleExperiments>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRoutingRuleExperiments(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RoutingRuleExperiments)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RoutingRuleExperiments>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
