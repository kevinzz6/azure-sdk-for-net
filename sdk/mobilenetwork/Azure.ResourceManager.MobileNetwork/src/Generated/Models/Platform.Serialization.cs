// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class Platform : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PlatformType))
            {
                writer.WritePropertyName("platformType"u8);
                writer.WriteStringValue(PlatformType.Value.ToString());
            }
            if (Optional.IsDefined(VersionState))
            {
                writer.WritePropertyName("versionState"u8);
                writer.WriteStringValue(VersionState.Value.ToString());
            }
            if (Optional.IsDefined(MinimumPlatformSoftwareVersion))
            {
                writer.WritePropertyName("minimumPlatformSoftwareVersion"u8);
                writer.WriteStringValue(MinimumPlatformSoftwareVersion);
            }
            if (Optional.IsDefined(MaximumPlatformSoftwareVersion))
            {
                writer.WritePropertyName("maximumPlatformSoftwareVersion"u8);
                writer.WriteStringValue(MaximumPlatformSoftwareVersion);
            }
            if (Optional.IsDefined(RecommendedVersion))
            {
                writer.WritePropertyName("recommendedVersion"u8);
                writer.WriteStringValue(RecommendedVersion.Value.ToString());
            }
            if (Optional.IsDefined(ObsoleteVersion))
            {
                writer.WritePropertyName("obsoleteVersion"u8);
                writer.WriteStringValue(ObsoleteVersion.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static Platform DeserializePlatform(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PlatformType> platformType = default;
            Optional<VersionState> versionState = default;
            Optional<string> minimumPlatformSoftwareVersion = default;
            Optional<string> maximumPlatformSoftwareVersion = default;
            Optional<RecommendedVersion> recommendedVersion = default;
            Optional<ObsoleteVersion> obsoleteVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("platformType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    platformType = new PlatformType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("versionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    versionState = new VersionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("minimumPlatformSoftwareVersion"u8))
                {
                    minimumPlatformSoftwareVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maximumPlatformSoftwareVersion"u8))
                {
                    maximumPlatformSoftwareVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recommendedVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recommendedVersion = new RecommendedVersion(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("obsoleteVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    obsoleteVersion = new ObsoleteVersion(property.Value.GetString());
                    continue;
                }
            }
            return new Platform(Optional.ToNullable(platformType), Optional.ToNullable(versionState), minimumPlatformSoftwareVersion.Value, maximumPlatformSoftwareVersion.Value, Optional.ToNullable(recommendedVersion), Optional.ToNullable(obsoleteVersion));
        }
    }
}
