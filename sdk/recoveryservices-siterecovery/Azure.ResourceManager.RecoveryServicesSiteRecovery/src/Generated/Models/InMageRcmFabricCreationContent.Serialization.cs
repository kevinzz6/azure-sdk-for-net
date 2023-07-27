// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageRcmFabricCreationContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("vmwareSiteId"u8);
            writer.WriteStringValue(VMwareSiteId);
            writer.WritePropertyName("physicalSiteId"u8);
            writer.WriteStringValue(PhysicalSiteId);
            writer.WritePropertyName("sourceAgentIdentity"u8);
            writer.WriteObjectValue(SourceAgentIdentity);
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            writer.WriteEndObject();
        }
    }
}
