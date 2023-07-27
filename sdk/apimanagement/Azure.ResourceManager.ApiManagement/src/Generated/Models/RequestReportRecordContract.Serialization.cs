// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class RequestReportRecordContract
    {
        internal static RequestReportRecordContract DeserializeRequestReportRecordContract(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> apiId = default;
            Optional<string> operationId = default;
            Optional<string> productId = default;
            Optional<string> userId = default;
            Optional<RequestMethod> method = default;
            Optional<Uri> uri = default;
            Optional<IPAddress> ipAddress = default;
            Optional<string> backendResponseCode = default;
            Optional<int> responseCode = default;
            Optional<int> responseSize = default;
            Optional<DateTimeOffset> timestamp = default;
            Optional<string> cache = default;
            Optional<double> apiTime = default;
            Optional<double> serviceTime = default;
            Optional<string> apiRegion = default;
            Optional<ResourceIdentifier> subscriptionId = default;
            Optional<string> requestId = default;
            Optional<int> requestSize = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("apiId"u8))
                {
                    apiId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("productId"u8))
                {
                    productId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userId"u8))
                {
                    userId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("method"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    method = new RequestMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("backendResponseCode"u8))
                {
                    backendResponseCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("responseCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    responseCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("responseSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    responseSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("cache"u8))
                {
                    cache = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("apiTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    apiTime = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("serviceTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceTime = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("apiRegion"u8))
                {
                    apiRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subscriptionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("requestId"u8))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestSize = property.Value.GetInt32();
                    continue;
                }
            }
            return new RequestReportRecordContract(apiId.Value, operationId.Value, productId.Value, userId.Value, Optional.ToNullable(method), uri.Value, ipAddress.Value, backendResponseCode.Value, Optional.ToNullable(responseCode), Optional.ToNullable(responseSize), Optional.ToNullable(timestamp), cache.Value, Optional.ToNullable(apiTime), Optional.ToNullable(serviceTime), apiRegion.Value, subscriptionId.Value, requestId.Value, Optional.ToNullable(requestSize));
        }
    }
}
