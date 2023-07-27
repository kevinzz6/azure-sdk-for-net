// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Data.Tables.Models
{
    internal partial class TableServiceError
    {
        internal static TableServiceError DeserializeTableServiceError(XElement element)
        {
            string message = default;
            if (element.Element("Message") is XElement messageElement)
            {
                message = (string)messageElement;
            }
            return new TableServiceError(message);
        }

        internal static TableServiceError DeserializeTableServiceError(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> message = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
            }
            return new TableServiceError(message.Value);
        }
    }
}
