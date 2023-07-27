// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class LanguageDetectionTaskResult
    {
        internal static LanguageDetectionTaskResult DeserializeLanguageDetectionTaskResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LanguageDetectionResult results = default;
            AnalyzeTextTaskResultsKind kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"u8))
                {
                    results = LanguageDetectionResult.DeserializeLanguageDetectionResult(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new AnalyzeTextTaskResultsKind(property.Value.GetString());
                    continue;
                }
            }
            return new LanguageDetectionTaskResult(kind, results);
        }
    }
}
