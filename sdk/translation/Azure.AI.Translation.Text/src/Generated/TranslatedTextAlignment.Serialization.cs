// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.Translation.Text
{
    public partial class TranslatedTextAlignment
    {
        internal static TranslatedTextAlignment DeserializeTranslatedTextAlignment(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string proj = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("proj"u8))
                {
                    proj = property.Value.GetString();
                    continue;
                }
            }
            return new TranslatedTextAlignment(proj);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static TranslatedTextAlignment FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeTranslatedTextAlignment(document.RootElement);
        }
    }
}
