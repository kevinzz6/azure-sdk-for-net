// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial class DocumentTypeDetails
    {
        internal static DocumentTypeDetails DeserializeDocumentTypeDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> description = default;
            Optional<DocumentBuildMode> buildMode = default;
            IReadOnlyDictionary<string, DocumentFieldSchema> fieldSchema = default;
            Optional<IReadOnlyDictionary<string, float>> fieldConfidence = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("buildMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    buildMode = new DocumentBuildMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fieldSchema"u8))
                {
                    Dictionary<string, DocumentFieldSchema> dictionary = new Dictionary<string, DocumentFieldSchema>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, DocumentFieldSchema.DeserializeDocumentFieldSchema(property0.Value));
                    }
                    fieldSchema = dictionary;
                    continue;
                }
                if (property.NameEquals("fieldConfidence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, float> dictionary = new Dictionary<string, float>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetSingle());
                    }
                    fieldConfidence = dictionary;
                    continue;
                }
            }
            return new DocumentTypeDetails(description.Value, Optional.ToNullable(buildMode), fieldSchema, Optional.ToDictionary(fieldConfidence));
        }
    }
}
