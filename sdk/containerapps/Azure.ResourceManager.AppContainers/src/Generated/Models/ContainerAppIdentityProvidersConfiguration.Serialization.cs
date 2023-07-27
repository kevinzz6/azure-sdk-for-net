// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppIdentityProvidersConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AzureActiveDirectory))
            {
                writer.WritePropertyName("azureActiveDirectory"u8);
                writer.WriteObjectValue(AzureActiveDirectory);
            }
            if (Optional.IsDefined(Facebook))
            {
                writer.WritePropertyName("facebook"u8);
                writer.WriteObjectValue(Facebook);
            }
            if (Optional.IsDefined(GitHub))
            {
                writer.WritePropertyName("gitHub"u8);
                writer.WriteObjectValue(GitHub);
            }
            if (Optional.IsDefined(Google))
            {
                writer.WritePropertyName("google"u8);
                writer.WriteObjectValue(Google);
            }
            if (Optional.IsDefined(Twitter))
            {
                writer.WritePropertyName("twitter"u8);
                writer.WriteObjectValue(Twitter);
            }
            if (Optional.IsDefined(Apple))
            {
                writer.WritePropertyName("apple"u8);
                writer.WriteObjectValue(Apple);
            }
            if (Optional.IsDefined(AzureStaticWebApps))
            {
                writer.WritePropertyName("azureStaticWebApps"u8);
                writer.WriteObjectValue(AzureStaticWebApps);
            }
            if (Optional.IsCollectionDefined(CustomOpenIdConnectProviders))
            {
                writer.WritePropertyName("customOpenIdConnectProviders"u8);
                writer.WriteStartObject();
                foreach (var item in CustomOpenIdConnectProviders)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static ContainerAppIdentityProvidersConfiguration DeserializeContainerAppIdentityProvidersConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ContainerAppAzureActiveDirectoryConfiguration> azureActiveDirectory = default;
            Optional<ContainerAppFacebookConfiguration> facebook = default;
            Optional<ContainerAppGitHubConfiguration> gitHub = default;
            Optional<ContainerAppGoogleConfiguration> google = default;
            Optional<ContainerAppTwitterConfiguration> twitter = default;
            Optional<ContainerAppAppleConfiguration> apple = default;
            Optional<ContainerAppAzureStaticWebAppsConfiguration> azureStaticWebApps = default;
            Optional<IDictionary<string, ContainerAppCustomOpenIdConnectProviderConfiguration>> customOpenIdConnectProviders = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureActiveDirectory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureActiveDirectory = ContainerAppAzureActiveDirectoryConfiguration.DeserializeContainerAppAzureActiveDirectoryConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("facebook"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    facebook = ContainerAppFacebookConfiguration.DeserializeContainerAppFacebookConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("gitHub"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    gitHub = ContainerAppGitHubConfiguration.DeserializeContainerAppGitHubConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("google"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    google = ContainerAppGoogleConfiguration.DeserializeContainerAppGoogleConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("twitter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    twitter = ContainerAppTwitterConfiguration.DeserializeContainerAppTwitterConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("apple"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    apple = ContainerAppAppleConfiguration.DeserializeContainerAppAppleConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("azureStaticWebApps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureStaticWebApps = ContainerAppAzureStaticWebAppsConfiguration.DeserializeContainerAppAzureStaticWebAppsConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("customOpenIdConnectProviders"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ContainerAppCustomOpenIdConnectProviderConfiguration> dictionary = new Dictionary<string, ContainerAppCustomOpenIdConnectProviderConfiguration>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ContainerAppCustomOpenIdConnectProviderConfiguration.DeserializeContainerAppCustomOpenIdConnectProviderConfiguration(property0.Value));
                    }
                    customOpenIdConnectProviders = dictionary;
                    continue;
                }
            }
            return new ContainerAppIdentityProvidersConfiguration(azureActiveDirectory.Value, facebook.Value, gitHub.Value, google.Value, twitter.Value, apple.Value, azureStaticWebApps.Value, Optional.ToDictionary(customOpenIdConnectProviders));
        }
    }
}
