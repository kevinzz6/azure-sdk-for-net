// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Files.DataLake.Models
{
    internal partial class FileSystem
    {
        internal static FileSystem DeserializeFileSystem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> lastModified = default;
            Optional<string> eTag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastModified"u8))
                {
                    lastModified = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("eTag"u8))
                {
                    eTag = property.Value.GetString();
                    continue;
                }
            }
            return new FileSystem(name.Value, lastModified.Value, eTag.Value);
        }
    }
}
