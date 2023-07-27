// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    public partial class SecurityInsightsWatchlistData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(WatchlistId))
            {
                writer.WritePropertyName("watchlistId"u8);
                writer.WriteStringValue(WatchlistId.Value);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Provider))
            {
                writer.WritePropertyName("provider"u8);
                writer.WriteStringValue(Provider);
            }
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source.Value.ToString());
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("created"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(UpdatedOn))
            {
                writer.WritePropertyName("updated"u8);
                writer.WriteStringValue(UpdatedOn.Value, "O");
            }
            if (Optional.IsDefined(CreatedBy))
            {
                writer.WritePropertyName("createdBy"u8);
                writer.WriteObjectValue(CreatedBy);
            }
            if (Optional.IsDefined(UpdatedBy))
            {
                writer.WritePropertyName("updatedBy"u8);
                writer.WriteObjectValue(UpdatedBy);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(WatchlistType))
            {
                writer.WritePropertyName("watchlistType"u8);
                writer.WriteStringValue(WatchlistType);
            }
            if (Optional.IsDefined(WatchlistAlias))
            {
                writer.WritePropertyName("watchlistAlias"u8);
                writer.WriteStringValue(WatchlistAlias);
            }
            if (Optional.IsDefined(IsDeleted))
            {
                writer.WritePropertyName("isDeleted"u8);
                writer.WriteBooleanValue(IsDeleted.Value);
            }
            if (Optional.IsCollectionDefined(Labels))
            {
                writer.WritePropertyName("labels"u8);
                writer.WriteStartArray();
                foreach (var item in Labels)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultDuration))
            {
                writer.WritePropertyName("defaultDuration"u8);
                writer.WriteStringValue(DefaultDuration.Value, "P");
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(NumberOfLinesToSkip))
            {
                writer.WritePropertyName("numberOfLinesToSkip"u8);
                writer.WriteNumberValue(NumberOfLinesToSkip.Value);
            }
            if (Optional.IsDefined(RawContent))
            {
                writer.WritePropertyName("rawContent"u8);
                writer.WriteStringValue(RawContent);
            }
            if (Optional.IsDefined(ItemsSearchKey))
            {
                writer.WritePropertyName("itemsSearchKey"u8);
                writer.WriteStringValue(ItemsSearchKey);
            }
            if (Optional.IsDefined(ContentType))
            {
                writer.WritePropertyName("contentType"u8);
                writer.WriteStringValue(ContentType);
            }
            if (Optional.IsDefined(UploadStatus))
            {
                writer.WritePropertyName("uploadStatus"u8);
                writer.WriteStringValue(UploadStatus);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SecurityInsightsWatchlistData DeserializeSecurityInsightsWatchlistData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Guid> watchlistId = default;
            Optional<string> displayName = default;
            Optional<string> provider = default;
            Optional<Source> source = default;
            Optional<DateTimeOffset> created = default;
            Optional<DateTimeOffset> updated = default;
            Optional<SecurityInsightsUserInfo> createdBy = default;
            Optional<SecurityInsightsUserInfo> updatedBy = default;
            Optional<string> description = default;
            Optional<string> watchlistType = default;
            Optional<string> watchlistAlias = default;
            Optional<bool> isDeleted = default;
            Optional<IList<string>> labels = default;
            Optional<TimeSpan> defaultDuration = default;
            Optional<Guid> tenantId = default;
            Optional<int> numberOfLinesToSkip = default;
            Optional<string> rawContent = default;
            Optional<string> itemsSearchKey = default;
            Optional<string> contentType = default;
            Optional<string> uploadStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("watchlistId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            watchlistId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provider"u8))
                        {
                            provider = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("source"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            source = new Source(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("created"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            created = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updated"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updated = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("createdBy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdBy = SecurityInsightsUserInfo.DeserializeSecurityInsightsUserInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("updatedBy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updatedBy = SecurityInsightsUserInfo.DeserializeSecurityInsightsUserInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("watchlistType"u8))
                        {
                            watchlistType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("watchlistAlias"u8))
                        {
                            watchlistAlias = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isDeleted"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isDeleted = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("labels"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            labels = array;
                            continue;
                        }
                        if (property0.NameEquals("defaultDuration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultDuration = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("tenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("numberOfLinesToSkip"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfLinesToSkip = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("rawContent"u8))
                        {
                            rawContent = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("itemsSearchKey"u8))
                        {
                            itemsSearchKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("contentType"u8))
                        {
                            contentType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("uploadStatus"u8))
                        {
                            uploadStatus = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SecurityInsightsWatchlistData(id, name, type, systemData.Value, Optional.ToNullable(watchlistId), displayName.Value, provider.Value, Optional.ToNullable(source), Optional.ToNullable(created), Optional.ToNullable(updated), createdBy.Value, updatedBy.Value, description.Value, watchlistType.Value, watchlistAlias.Value, Optional.ToNullable(isDeleted), Optional.ToList(labels), Optional.ToNullable(defaultDuration), Optional.ToNullable(tenantId), Optional.ToNullable(numberOfLinesToSkip), rawContent.Value, itemsSearchKey.Value, contentType.Value, uploadStatus.Value, Optional.ToNullable(etag));
        }
    }
}
