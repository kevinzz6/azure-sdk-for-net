// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics
{
    public partial struct TextDocumentStatistics : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("charactersCount"u8);
            writer.WriteNumberValue(CharacterCount);
            writer.WritePropertyName("transactionsCount"u8);
            writer.WriteNumberValue(TransactionCount);
            writer.WriteEndObject();
        }

        internal static TextDocumentStatistics DeserializeTextDocumentStatistics(JsonElement element)
        {
            int charactersCount = default;
            int transactionsCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("charactersCount"u8))
                {
                    charactersCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("transactionsCount"u8))
                {
                    transactionsCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new TextDocumentStatistics(charactersCount, transactionsCount);
        }
    }
}
