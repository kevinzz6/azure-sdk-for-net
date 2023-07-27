// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class SourceCodeRepoProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sourceControlType"u8);
            writer.WriteStringValue(SourceControlType.ToString());
            writer.WritePropertyName("repositoryUrl"u8);
            writer.WriteStringValue(RepositoryUri.AbsoluteUri);
            if (Optional.IsDefined(Branch))
            {
                writer.WritePropertyName("branch"u8);
                writer.WriteStringValue(Branch);
            }
            if (Optional.IsDefined(SourceControlAuthProperties))
            {
                writer.WritePropertyName("sourceControlAuthProperties"u8);
                writer.WriteObjectValue(SourceControlAuthProperties);
            }
            writer.WriteEndObject();
        }

        internal static SourceCodeRepoProperties DeserializeSourceCodeRepoProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SourceControlType sourceControlType = default;
            Uri repositoryUrl = default;
            Optional<string> branch = default;
            Optional<SourceCodeRepoAuthInfo> sourceControlAuthProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceControlType"u8))
                {
                    sourceControlType = new SourceControlType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("repositoryUrl"u8))
                {
                    repositoryUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("branch"u8))
                {
                    branch = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceControlAuthProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceControlAuthProperties = SourceCodeRepoAuthInfo.DeserializeSourceCodeRepoAuthInfo(property.Value);
                    continue;
                }
            }
            return new SourceCodeRepoProperties(sourceControlType, repositoryUrl, branch.Value, sourceControlAuthProperties.Value);
        }
    }
}
