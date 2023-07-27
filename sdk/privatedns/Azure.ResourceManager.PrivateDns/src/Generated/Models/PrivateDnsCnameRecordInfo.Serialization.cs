// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PrivateDns.Models
{
    internal partial class PrivateDnsCnameRecordInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Cname))
            {
                writer.WritePropertyName("cname"u8);
                writer.WriteStringValue(Cname);
            }
            writer.WriteEndObject();
        }

        internal static PrivateDnsCnameRecordInfo DeserializePrivateDnsCnameRecordInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> cname = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cname"u8))
                {
                    cname = property.Value.GetString();
                    continue;
                }
            }
            return new PrivateDnsCnameRecordInfo(cname.Value);
        }
    }
}
