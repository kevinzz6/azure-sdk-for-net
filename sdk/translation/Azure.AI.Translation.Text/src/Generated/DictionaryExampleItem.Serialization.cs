// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.Translation.Text
{
    public partial class DictionaryExampleItem
    {
        internal static DictionaryExampleItem DeserializeDictionaryExampleItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string normalizedSource = default;
            string normalizedTarget = default;
            IReadOnlyList<DictionaryExample> examples = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("normalizedSource"u8))
                {
                    normalizedSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("normalizedTarget"u8))
                {
                    normalizedTarget = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("examples"u8))
                {
                    List<DictionaryExample> array = new List<DictionaryExample>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DictionaryExample.DeserializeDictionaryExample(item));
                    }
                    examples = array;
                    continue;
                }
            }
            return new DictionaryExampleItem(normalizedSource, normalizedTarget, examples);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DictionaryExampleItem FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDictionaryExampleItem(document.RootElement);
        }
    }
}
