// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.Models
{
    public partial class MySqlServerPrivateEndpointConnection
    {
        internal static MySqlServerPrivateEndpointConnection DeserializeMySqlServerPrivateEndpointConnection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<MySqlServerPrivateEndpointConnectionProperties> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = MySqlServerPrivateEndpointConnectionProperties.DeserializeMySqlServerPrivateEndpointConnectionProperties(property.Value);
                    continue;
                }
            }
            return new MySqlServerPrivateEndpointConnection(id.Value, properties.Value);
        }
    }
}
