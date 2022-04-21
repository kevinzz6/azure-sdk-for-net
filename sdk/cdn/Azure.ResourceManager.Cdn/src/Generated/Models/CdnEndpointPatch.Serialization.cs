// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class CdnEndpointPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(OriginPath))
            {
                writer.WritePropertyName("originPath");
                writer.WriteStringValue(OriginPath);
            }
            if (Optional.IsCollectionDefined(ContentTypesToCompress))
            {
                writer.WritePropertyName("contentTypesToCompress");
                writer.WriteStartArray();
                foreach (var item in ContentTypesToCompress)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OriginHostHeader))
            {
                writer.WritePropertyName("originHostHeader");
                writer.WriteStringValue(OriginHostHeader);
            }
            if (Optional.IsDefined(IsCompressionEnabled))
            {
                writer.WritePropertyName("isCompressionEnabled");
                writer.WriteBooleanValue(IsCompressionEnabled.Value);
            }
            if (Optional.IsDefined(IsHttpAllowed))
            {
                writer.WritePropertyName("isHttpAllowed");
                writer.WriteBooleanValue(IsHttpAllowed.Value);
            }
            if (Optional.IsDefined(IsHttpsAllowed))
            {
                writer.WritePropertyName("isHttpsAllowed");
                writer.WriteBooleanValue(IsHttpsAllowed.Value);
            }
            if (Optional.IsDefined(QueryStringCachingBehavior))
            {
                writer.WritePropertyName("queryStringCachingBehavior");
                writer.WriteStringValue(QueryStringCachingBehavior.Value.ToSerialString());
            }
            if (Optional.IsDefined(OptimizationType))
            {
                if (OptimizationType != null)
                {
                    writer.WritePropertyName("optimizationType");
                    writer.WriteStringValue(OptimizationType.Value.ToString());
                }
                else
                {
                    writer.WriteNull("optimizationType");
                }
            }
            if (Optional.IsDefined(ProbePath))
            {
                writer.WritePropertyName("probePath");
                writer.WriteStringValue(ProbePath);
            }
            if (Optional.IsCollectionDefined(GeoFilters))
            {
                writer.WritePropertyName("geoFilters");
                writer.WriteStartArray();
                foreach (var item in GeoFilters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultOriginGroup))
            {
                if (DefaultOriginGroup != null)
                {
                    writer.WritePropertyName("defaultOriginGroup");
                    writer.WriteObjectValue(DefaultOriginGroup);
                }
                else
                {
                    writer.WriteNull("defaultOriginGroup");
                }
            }
            if (Optional.IsCollectionDefined(UrlSigningKeys))
            {
                if (UrlSigningKeys != null)
                {
                    writer.WritePropertyName("urlSigningKeys");
                    writer.WriteStartArray();
                    foreach (var item in UrlSigningKeys)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("urlSigningKeys");
                }
            }
            if (Optional.IsDefined(DeliveryPolicy))
            {
                if (DeliveryPolicy != null)
                {
                    writer.WritePropertyName("deliveryPolicy");
                    writer.WriteObjectValue(DeliveryPolicy);
                }
                else
                {
                    writer.WriteNull("deliveryPolicy");
                }
            }
            if (Optional.IsDefined(WebApplicationFirewallPolicyLink))
            {
                if (WebApplicationFirewallPolicyLink != null)
                {
                    writer.WritePropertyName("webApplicationFirewallPolicyLink");
                    writer.WriteObjectValue(WebApplicationFirewallPolicyLink);
                }
                else
                {
                    writer.WriteNull("webApplicationFirewallPolicyLink");
                }
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
