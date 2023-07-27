// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    public partial class CheckPolicyRestrictionsResult
    {
        internal static CheckPolicyRestrictionsResult DeserializeCheckPolicyRestrictionsResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<FieldRestrictions>> fieldRestrictions = default;
            Optional<CheckRestrictionsResultContentEvaluationResult> contentEvaluationResult = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fieldRestrictions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FieldRestrictions> array = new List<FieldRestrictions>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.FieldRestrictions.DeserializeFieldRestrictions(item));
                    }
                    fieldRestrictions = array;
                    continue;
                }
                if (property.NameEquals("contentEvaluationResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentEvaluationResult = CheckRestrictionsResultContentEvaluationResult.DeserializeCheckRestrictionsResultContentEvaluationResult(property.Value);
                    continue;
                }
            }
            return new CheckPolicyRestrictionsResult(Optional.ToList(fieldRestrictions), contentEvaluationResult.Value);
        }
    }
}
