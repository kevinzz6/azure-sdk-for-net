// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class KubernetesGitRepository : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Uri))
            {
                if (Uri != null)
                {
                    writer.WritePropertyName("url"u8);
                    writer.WriteStringValue(Uri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("url");
                }
            }
            if (Optional.IsDefined(TimeoutInSeconds))
            {
                if (TimeoutInSeconds != null)
                {
                    writer.WritePropertyName("timeoutInSeconds"u8);
                    writer.WriteNumberValue(TimeoutInSeconds.Value);
                }
                else
                {
                    writer.WriteNull("timeoutInSeconds");
                }
            }
            if (Optional.IsDefined(SyncIntervalInSeconds))
            {
                if (SyncIntervalInSeconds != null)
                {
                    writer.WritePropertyName("syncIntervalInSeconds"u8);
                    writer.WriteNumberValue(SyncIntervalInSeconds.Value);
                }
                else
                {
                    writer.WriteNull("syncIntervalInSeconds");
                }
            }
            if (Optional.IsDefined(RepositoryRef))
            {
                if (RepositoryRef != null)
                {
                    writer.WritePropertyName("repositoryRef"u8);
                    writer.WriteObjectValue(RepositoryRef);
                }
                else
                {
                    writer.WriteNull("repositoryRef");
                }
            }
            if (Optional.IsDefined(SshKnownHosts))
            {
                if (SshKnownHosts != null)
                {
                    writer.WritePropertyName("sshKnownHosts"u8);
                    writer.WriteStringValue(SshKnownHosts);
                }
                else
                {
                    writer.WriteNull("sshKnownHosts");
                }
            }
            if (Optional.IsDefined(HttpsUser))
            {
                if (HttpsUser != null)
                {
                    writer.WritePropertyName("httpsUser"u8);
                    writer.WriteStringValue(HttpsUser);
                }
                else
                {
                    writer.WriteNull("httpsUser");
                }
            }
            if (Optional.IsDefined(HttpsCACert))
            {
                if (HttpsCACert != null)
                {
                    writer.WritePropertyName("httpsCACert"u8);
                    writer.WriteStringValue(HttpsCACert);
                }
                else
                {
                    writer.WriteNull("httpsCACert");
                }
            }
            if (Optional.IsDefined(LocalAuthRef))
            {
                if (LocalAuthRef != null)
                {
                    writer.WritePropertyName("localAuthRef"u8);
                    writer.WriteStringValue(LocalAuthRef);
                }
                else
                {
                    writer.WriteNull("localAuthRef");
                }
            }
            writer.WriteEndObject();
        }

        internal static KubernetesGitRepository DeserializeKubernetesGitRepository(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> url = default;
            Optional<long?> timeoutInSeconds = default;
            Optional<long?> syncIntervalInSeconds = default;
            Optional<KubernetesGitRepositoryRef> repositoryRef = default;
            Optional<string> sshKnownHosts = default;
            Optional<string> httpsUser = default;
            Optional<string> httpsCACert = default;
            Optional<string> localAuthRef = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        url = null;
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeoutInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        timeoutInSeconds = null;
                        continue;
                    }
                    timeoutInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("syncIntervalInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        syncIntervalInSeconds = null;
                        continue;
                    }
                    syncIntervalInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("repositoryRef"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        repositoryRef = null;
                        continue;
                    }
                    repositoryRef = KubernetesGitRepositoryRef.DeserializeKubernetesGitRepositoryRef(property.Value);
                    continue;
                }
                if (property.NameEquals("sshKnownHosts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sshKnownHosts = null;
                        continue;
                    }
                    sshKnownHosts = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpsUser"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        httpsUser = null;
                        continue;
                    }
                    httpsUser = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpsCACert"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        httpsCACert = null;
                        continue;
                    }
                    httpsCACert = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("localAuthRef"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        localAuthRef = null;
                        continue;
                    }
                    localAuthRef = property.Value.GetString();
                    continue;
                }
            }
            return new KubernetesGitRepository(url.Value, Optional.ToNullable(timeoutInSeconds), Optional.ToNullable(syncIntervalInSeconds), repositoryRef.Value, sshKnownHosts.Value, httpsUser.Value, httpsCACert.Value, localAuthRef.Value);
        }
    }
}
