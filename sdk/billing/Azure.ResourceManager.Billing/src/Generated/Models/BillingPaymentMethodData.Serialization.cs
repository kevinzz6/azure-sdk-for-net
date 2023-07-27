// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Billing.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Billing
{
    public partial class BillingPaymentMethodData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Family))
            {
                writer.WritePropertyName("family"u8);
                writer.WriteStringValue(Family.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Logos))
            {
                writer.WritePropertyName("logos"u8);
                writer.WriteStartArray();
                foreach (var item in Logos)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static BillingPaymentMethodData DeserializeBillingPaymentMethodData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<PaymentMethodFamily> family = default;
            Optional<string> type0 = default;
            Optional<string> accountHolderName = default;
            Optional<string> expiration = default;
            Optional<string> lastFourDigits = default;
            Optional<string> displayName = default;
            Optional<IList<PaymentMethodLogo>> logos = default;
            Optional<PaymentMethodStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("family"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            family = new PaymentMethodFamily(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("type"u8))
                        {
                            type0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accountHolderName"u8))
                        {
                            accountHolderName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("expiration"u8))
                        {
                            expiration = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastFourDigits"u8))
                        {
                            lastFourDigits = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("logos"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PaymentMethodLogo> array = new List<PaymentMethodLogo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PaymentMethodLogo.DeserializePaymentMethodLogo(item));
                            }
                            logos = array;
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new PaymentMethodStatus(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new BillingPaymentMethodData(id, name, type, systemData.Value, Optional.ToNullable(family), type0.Value, accountHolderName.Value, expiration.Value, lastFourDigits.Value, displayName.Value, Optional.ToList(logos), Optional.ToNullable(status));
        }
    }
}
