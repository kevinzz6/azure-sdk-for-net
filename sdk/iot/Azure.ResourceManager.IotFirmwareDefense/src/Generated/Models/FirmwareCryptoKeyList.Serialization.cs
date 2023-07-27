// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    internal partial class FirmwareCryptoKeyList
    {
        internal static FirmwareCryptoKeyList DeserializeFirmwareCryptoKeyList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<FirmwareCryptoKey>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FirmwareCryptoKey> array = new List<FirmwareCryptoKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FirmwareCryptoKey.DeserializeFirmwareCryptoKey(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new FirmwareCryptoKeyList(Optional.ToList(value), nextLink.Value);
        }
    }
}
