// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class JavaScriptFunctionRetrieveDefaultDefinitionContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("bindingType"u8);
            writer.WriteStringValue(BindingType);
            writer.WritePropertyName("bindingRetrievalProperties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Script))
            {
                writer.WritePropertyName("script"u8);
                writer.WriteStringValue(Script);
            }
            if (Optional.IsDefined(UdfType))
            {
                writer.WritePropertyName("udfType"u8);
                writer.WriteStringValue(UdfType.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
