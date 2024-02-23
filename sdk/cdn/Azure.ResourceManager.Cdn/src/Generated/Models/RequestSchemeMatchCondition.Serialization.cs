// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class RequestSchemeMatchCondition : IUtf8JsonSerializable, IJsonModel<RequestSchemeMatchCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RequestSchemeMatchCondition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RequestSchemeMatchCondition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequestSchemeMatchCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RequestSchemeMatchCondition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("typeName"u8);
            writer.WriteStringValue(ConditionType.ToString());
            writer.WritePropertyName("operator"u8);
            writer.WriteStringValue(RequestSchemeOperator.ToString());
            if (NegateCondition.HasValue)
            {
                writer.WritePropertyName("negateCondition"u8);
                writer.WriteBooleanValue(NegateCondition.Value);
            }
            if (!(Transforms is ChangeTrackingList<PreTransformCategory> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("transforms"u8);
                writer.WriteStartArray();
                foreach (var item in Transforms)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (!(MatchValues is ChangeTrackingList<RequestSchemeMatchConditionMatchValue> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("matchValues"u8);
                writer.WriteStartArray();
                foreach (var item in MatchValues)
                {
                    writer.WriteStringValue(item.ToString());
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

        RequestSchemeMatchCondition IJsonModel<RequestSchemeMatchCondition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequestSchemeMatchCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RequestSchemeMatchCondition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRequestSchemeMatchCondition(document.RootElement, options);
        }

        internal static RequestSchemeMatchCondition DeserializeRequestSchemeMatchCondition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RequestSchemeMatchConditionType typeName = default;
            RequestSchemeOperator @operator = default;
            Optional<bool> negateCondition = default;
            IList<PreTransformCategory> transforms = default;
            IList<RequestSchemeMatchConditionMatchValue> matchValues = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("typeName"u8))
                {
                    typeName = new RequestSchemeMatchConditionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operator"u8))
                {
                    @operator = new RequestSchemeOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("negateCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    negateCondition = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("transforms"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PreTransformCategory> array = new List<PreTransformCategory>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new PreTransformCategory(item.GetString()));
                    }
                    transforms = array;
                    continue;
                }
                if (property.NameEquals("matchValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RequestSchemeMatchConditionMatchValue> array = new List<RequestSchemeMatchConditionMatchValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new RequestSchemeMatchConditionMatchValue(item.GetString()));
                    }
                    matchValues = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RequestSchemeMatchCondition(typeName, @operator, Optional.ToNullable(negateCondition), transforms ?? new ChangeTrackingList<PreTransformCategory>(), matchValues ?? new ChangeTrackingList<RequestSchemeMatchConditionMatchValue>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RequestSchemeMatchCondition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequestSchemeMatchCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RequestSchemeMatchCondition)} does not support '{options.Format}' format.");
            }
        }

        RequestSchemeMatchCondition IPersistableModel<RequestSchemeMatchCondition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequestSchemeMatchCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRequestSchemeMatchCondition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RequestSchemeMatchCondition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RequestSchemeMatchCondition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
