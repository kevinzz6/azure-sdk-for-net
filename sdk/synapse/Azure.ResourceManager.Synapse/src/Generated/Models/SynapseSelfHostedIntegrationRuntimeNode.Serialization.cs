// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseSelfHostedIntegrationRuntimeNode
    {
        internal static SynapseSelfHostedIntegrationRuntimeNode DeserializeSynapseSelfHostedIntegrationRuntimeNode(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nodeName = default;
            Optional<string> machineName = default;
            Optional<Uri> hostServiceUri = default;
            Optional<SynapseSelfHostedIntegrationRuntimeNodeStatus> status = default;
            Optional<IReadOnlyDictionary<string, string>> capabilities = default;
            Optional<string> versionStatus = default;
            Optional<string> version = default;
            Optional<DateTimeOffset> registerTime = default;
            Optional<DateTimeOffset> lastConnectTime = default;
            Optional<DateTimeOffset> expiryTime = default;
            Optional<DateTimeOffset> lastStartTime = default;
            Optional<DateTimeOffset> lastStopTime = default;
            Optional<SynapseIntegrationRuntimeUpdateResult> lastUpdateResult = default;
            Optional<DateTimeOffset> lastStartUpdateTime = default;
            Optional<DateTimeOffset> lastEndUpdateTime = default;
            Optional<bool> isActiveDispatcher = default;
            Optional<int> concurrentJobsLimit = default;
            Optional<int> maxConcurrentJobs = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nodeName"u8))
                {
                    nodeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("machineName"u8))
                {
                    machineName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostServiceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostServiceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new SynapseSelfHostedIntegrationRuntimeNodeStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    capabilities = dictionary;
                    continue;
                }
                if (property.NameEquals("versionStatus"u8))
                {
                    versionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registerTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    registerTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastConnectTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastConnectTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expiryTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiryTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastStartTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastStopTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastStopTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdateResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdateResult = new SynapseIntegrationRuntimeUpdateResult(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastStartUpdateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastStartUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastEndUpdateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastEndUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isActiveDispatcher"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isActiveDispatcher = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("concurrentJobsLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    concurrentJobsLimit = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxConcurrentJobs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentJobs = property.Value.GetInt32();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SynapseSelfHostedIntegrationRuntimeNode(nodeName.Value, machineName.Value, hostServiceUri.Value, Optional.ToNullable(status), Optional.ToDictionary(capabilities), versionStatus.Value, version.Value, Optional.ToNullable(registerTime), Optional.ToNullable(lastConnectTime), Optional.ToNullable(expiryTime), Optional.ToNullable(lastStartTime), Optional.ToNullable(lastStopTime), Optional.ToNullable(lastUpdateResult), Optional.ToNullable(lastStartUpdateTime), Optional.ToNullable(lastEndUpdateTime), Optional.ToNullable(isActiveDispatcher), Optional.ToNullable(concurrentJobsLimit), Optional.ToNullable(maxConcurrentJobs), additionalProperties);
        }
    }
}
