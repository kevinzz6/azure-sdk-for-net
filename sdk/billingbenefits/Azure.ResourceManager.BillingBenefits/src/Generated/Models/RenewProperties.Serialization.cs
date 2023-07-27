// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    internal partial class RenewProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PurchaseProperties))
            {
                writer.WritePropertyName("purchaseProperties"u8);
                writer.WriteObjectValue(PurchaseProperties);
            }
            writer.WriteEndObject();
        }

        internal static RenewProperties DeserializeRenewProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BillingBenefitsPurchaseContent> purchaseProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("purchaseProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    purchaseProperties = BillingBenefitsPurchaseContent.DeserializeBillingBenefitsPurchaseContent(property.Value);
                    continue;
                }
            }
            return new RenewProperties(purchaseProperties.Value);
        }
    }
}
