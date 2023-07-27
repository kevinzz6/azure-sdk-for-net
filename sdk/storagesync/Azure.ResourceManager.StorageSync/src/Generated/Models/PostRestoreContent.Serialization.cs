// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class PostRestoreContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Partition))
            {
                writer.WritePropertyName("partition"u8);
                writer.WriteStringValue(Partition);
            }
            if (Optional.IsDefined(ReplicaGroup))
            {
                writer.WritePropertyName("replicaGroup"u8);
                writer.WriteStringValue(ReplicaGroup);
            }
            if (Optional.IsDefined(RequestId))
            {
                writer.WritePropertyName("requestId"u8);
                writer.WriteStringValue(RequestId);
            }
            if (Optional.IsDefined(AzureFileShareUri))
            {
                writer.WritePropertyName("azureFileShareUri"u8);
                writer.WriteStringValue(AzureFileShareUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(SourceAzureFileShareUri))
            {
                writer.WritePropertyName("sourceAzureFileShareUri"u8);
                writer.WriteStringValue(SourceAzureFileShareUri.AbsoluteUri);
            }
            if (Optional.IsDefined(FailedFileList))
            {
                writer.WritePropertyName("failedFileList"u8);
                writer.WriteStringValue(FailedFileList);
            }
            if (Optional.IsCollectionDefined(RestoreFileSpec))
            {
                writer.WritePropertyName("restoreFileSpec"u8);
                writer.WriteStartArray();
                foreach (var item in RestoreFileSpec)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
