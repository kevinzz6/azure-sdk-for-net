// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class BillingInformation
    {
        internal static BillingInformation DeserializeBillingInformation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PurchasePrice> billingCurrencyTotalPaidAmount = default;
            Optional<PurchasePrice> billingCurrencyProratedAmount = default;
            Optional<PurchasePrice> billingCurrencyRemainingCommitmentAmount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("billingCurrencyTotalPaidAmount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingCurrencyTotalPaidAmount = PurchasePrice.DeserializePurchasePrice(property.Value);
                    continue;
                }
                if (property.NameEquals("billingCurrencyProratedAmount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingCurrencyProratedAmount = PurchasePrice.DeserializePurchasePrice(property.Value);
                    continue;
                }
                if (property.NameEquals("billingCurrencyRemainingCommitmentAmount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingCurrencyRemainingCommitmentAmount = PurchasePrice.DeserializePurchasePrice(property.Value);
                    continue;
                }
            }
            return new BillingInformation(billingCurrencyTotalPaidAmount.Value, billingCurrencyProratedAmount.Value, billingCurrencyRemainingCommitmentAmount.Value);
        }
    }
}
