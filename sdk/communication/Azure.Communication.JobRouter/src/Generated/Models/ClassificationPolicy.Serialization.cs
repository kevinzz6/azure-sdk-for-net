// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Communication.JobRouter;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    public partial class ClassificationPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(FallbackQueueId))
            {
                writer.WritePropertyName("fallbackQueueId"u8);
                writer.WriteStringValue(FallbackQueueId);
            }
            if (Optional.IsCollectionDefined(_queueSelectors))
            {
                writer.WritePropertyName("queueSelectors"u8);
                writer.WriteStartArray();
                foreach (var item in _queueSelectors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PrioritizationRule))
            {
                writer.WritePropertyName("prioritizationRule"u8);
                writer.WriteObjectValue(PrioritizationRule);
            }
            if (Optional.IsCollectionDefined(_workerSelectors))
            {
                writer.WritePropertyName("workerSelectors"u8);
                writer.WriteStartArray();
                foreach (var item in _workerSelectors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ClassificationPolicy DeserializeClassificationPolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> fallbackQueueId = default;
            Optional<IList<QueueSelectorAttachment>> queueSelectors = default;
            Optional<RouterRule> prioritizationRule = default;
            Optional<IList<WorkerSelectorAttachment>> workerSelectors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fallbackQueueId"u8))
                {
                    fallbackQueueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queueSelectors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<QueueSelectorAttachment> array = new List<QueueSelectorAttachment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QueueSelectorAttachment.DeserializeQueueSelectorAttachment(item));
                    }
                    queueSelectors = array;
                    continue;
                }
                if (property.NameEquals("prioritizationRule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    prioritizationRule = RouterRule.DeserializeRouterRule(property.Value);
                    continue;
                }
                if (property.NameEquals("workerSelectors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WorkerSelectorAttachment> array = new List<WorkerSelectorAttachment>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WorkerSelectorAttachment.DeserializeWorkerSelectorAttachment(item));
                    }
                    workerSelectors = array;
                    continue;
                }
            }
            return new ClassificationPolicy(id.Value, name.Value, fallbackQueueId.Value, Optional.ToList(queueSelectors), prioritizationRule.Value, Optional.ToList(workerSelectors));
        }
    }
}
