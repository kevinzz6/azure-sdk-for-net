// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Billing;

namespace Azure.ResourceManager.Billing.Models
{
    internal partial class PaymentMethodsListResult
    {
        internal static PaymentMethodsListResult DeserializePaymentMethodsListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<BillingPaymentMethodData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BillingPaymentMethodData> array = new List<BillingPaymentMethodData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BillingPaymentMethodData.DeserializeBillingPaymentMethodData(item));
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
            return new PaymentMethodsListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
