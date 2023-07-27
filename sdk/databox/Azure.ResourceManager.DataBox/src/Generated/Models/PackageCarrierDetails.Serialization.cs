// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class PackageCarrierDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CarrierAccountNumber))
            {
                writer.WritePropertyName("carrierAccountNumber"u8);
                writer.WriteStringValue(CarrierAccountNumber);
            }
            if (Optional.IsDefined(CarrierName))
            {
                writer.WritePropertyName("carrierName"u8);
                writer.WriteStringValue(CarrierName);
            }
            if (Optional.IsDefined(TrackingId))
            {
                writer.WritePropertyName("trackingId"u8);
                writer.WriteStringValue(TrackingId);
            }
            writer.WriteEndObject();
        }

        internal static PackageCarrierDetails DeserializePackageCarrierDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> carrierAccountNumber = default;
            Optional<string> carrierName = default;
            Optional<string> trackingId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("carrierAccountNumber"u8))
                {
                    carrierAccountNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("carrierName"u8))
                {
                    carrierName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trackingId"u8))
                {
                    trackingId = property.Value.GetString();
                    continue;
                }
            }
            return new PackageCarrierDetails(carrierAccountNumber.Value, carrierName.Value, trackingId.Value);
        }
    }
}
