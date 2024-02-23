// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class AzureDatabricksLinkedService : IUtf8JsonSerializable, IJsonModel<AzureDatabricksLinkedService>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureDatabricksLinkedService>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureDatabricksLinkedService>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDatabricksLinkedService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureDatabricksLinkedService)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(LinkedServiceType);
            if (ConnectVia != null)
            {
                writer.WritePropertyName("connectVia"u8);
                writer.WriteObjectValue(ConnectVia);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (!(Parameters is ChangeTrackingDictionary<string, EntityParameterSpecification> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(Annotations is ChangeTrackingList<BinaryData> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("domain"u8);
            JsonSerializer.Serialize(writer, Domain);
            if (AccessToken != null)
            {
                writer.WritePropertyName("accessToken"u8);
                JsonSerializer.Serialize(writer, AccessToken);
            }
            if (Authentication != null)
            {
                writer.WritePropertyName("authentication"u8);
                JsonSerializer.Serialize(writer, Authentication);
            }
            if (WorkspaceResourceId != null)
            {
                writer.WritePropertyName("workspaceResourceId"u8);
                JsonSerializer.Serialize(writer, WorkspaceResourceId);
            }
            if (ExistingClusterId != null)
            {
                writer.WritePropertyName("existingClusterId"u8);
                JsonSerializer.Serialize(writer, ExistingClusterId);
            }
            if (InstancePoolId != null)
            {
                writer.WritePropertyName("instancePoolId"u8);
                JsonSerializer.Serialize(writer, InstancePoolId);
            }
            if (NewClusterVersion != null)
            {
                writer.WritePropertyName("newClusterVersion"u8);
                JsonSerializer.Serialize(writer, NewClusterVersion);
            }
            if (NewClusterNumOfWorker != null)
            {
                writer.WritePropertyName("newClusterNumOfWorker"u8);
                JsonSerializer.Serialize(writer, NewClusterNumOfWorker);
            }
            if (NewClusterNodeType != null)
            {
                writer.WritePropertyName("newClusterNodeType"u8);
                JsonSerializer.Serialize(writer, NewClusterNodeType);
            }
            if (!(NewClusterSparkConf is ChangeTrackingDictionary<string, BinaryData> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("newClusterSparkConf"u8);
                writer.WriteStartObject();
                foreach (var item in NewClusterSparkConf)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (!(NewClusterSparkEnvVars is ChangeTrackingDictionary<string, BinaryData> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("newClusterSparkEnvVars"u8);
                writer.WriteStartObject();
                foreach (var item in NewClusterSparkEnvVars)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (!(NewClusterCustomTags is ChangeTrackingDictionary<string, BinaryData> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("newClusterCustomTags"u8);
                writer.WriteStartObject();
                foreach (var item in NewClusterCustomTags)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (NewClusterLogDestination != null)
            {
                writer.WritePropertyName("newClusterLogDestination"u8);
                JsonSerializer.Serialize(writer, NewClusterLogDestination);
            }
            if (NewClusterDriverNodeType != null)
            {
                writer.WritePropertyName("newClusterDriverNodeType"u8);
                JsonSerializer.Serialize(writer, NewClusterDriverNodeType);
            }
            if (NewClusterInitScripts != null)
            {
                writer.WritePropertyName("newClusterInitScripts"u8);
                JsonSerializer.Serialize(writer, NewClusterInitScripts);
            }
            if (NewClusterEnableElasticDisk != null)
            {
                writer.WritePropertyName("newClusterEnableElasticDisk"u8);
                JsonSerializer.Serialize(writer, NewClusterEnableElasticDisk);
            }
            if (EncryptedCredential != null)
            {
                writer.WritePropertyName("encryptedCredential"u8);
                writer.WriteStringValue(EncryptedCredential);
            }
            if (PolicyId != null)
            {
                writer.WritePropertyName("policyId"u8);
                JsonSerializer.Serialize(writer, PolicyId);
            }
            if (Credential != null)
            {
                writer.WritePropertyName("credential"u8);
                writer.WriteObjectValue(Credential);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                using (JsonDocument document = JsonDocument.Parse(item.Value))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WriteEndObject();
        }

        AzureDatabricksLinkedService IJsonModel<AzureDatabricksLinkedService>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDatabricksLinkedService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureDatabricksLinkedService)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureDatabricksLinkedService(document.RootElement, options);
        }

        internal static AzureDatabricksLinkedService DeserializeAzureDatabricksLinkedService(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<IntegrationRuntimeReference> connectVia = default;
            Optional<string> description = default;
            Optional<IDictionary<string, EntityParameterSpecification>> parameters = default;
            IList<BinaryData> annotations = default;
            DataFactoryElement<string> domain = default;
            Optional<DataFactorySecretBaseDefinition> accessToken = default;
            Optional<DataFactoryElement<string>> authentication = default;
            Optional<DataFactoryElement<string>> workspaceResourceId = default;
            Optional<DataFactoryElement<string>> existingClusterId = default;
            Optional<DataFactoryElement<string>> instancePoolId = default;
            Optional<DataFactoryElement<string>> newClusterVersion = default;
            Optional<DataFactoryElement<string>> newClusterNumOfWorker = default;
            Optional<DataFactoryElement<string>> newClusterNodeType = default;
            Optional<IDictionary<string, BinaryData>> newClusterSparkConf = default;
            Optional<IDictionary<string, BinaryData>> newClusterSparkEnvVars = default;
            Optional<IDictionary<string, BinaryData>> newClusterCustomTags = default;
            Optional<DataFactoryElement<string>> newClusterLogDestination = default;
            Optional<DataFactoryElement<string>> newClusterDriverNodeType = default;
            Optional<DataFactoryElement<IList<string>>> newClusterInitScripts = default;
            Optional<DataFactoryElement<bool>> newClusterEnableElasticDisk = default;
            Optional<string> encryptedCredential = default;
            Optional<DataFactoryElement<string>> policyId = default;
            Optional<DataFactoryCredentialReference> credential = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, EntityParameterSpecification> dictionary = new Dictionary<string, EntityParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, EntityParameterSpecification.DeserializeEntityParameterSpecification(property0.Value, options));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("domain"u8))
                        {
                            domain = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("accessToken"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accessToken = JsonSerializer.Deserialize<DataFactorySecretBaseDefinition>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("authentication"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authentication = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("workspaceResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            workspaceResourceId = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("existingClusterId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            existingClusterId = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("instancePoolId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            instancePoolId = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("newClusterVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            newClusterVersion = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("newClusterNumOfWorker"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            newClusterNumOfWorker = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("newClusterNodeType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            newClusterNodeType = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("newClusterSparkConf"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            newClusterSparkConf = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("newClusterSparkEnvVars"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            newClusterSparkEnvVars = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("newClusterCustomTags"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            newClusterCustomTags = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("newClusterLogDestination"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            newClusterLogDestination = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("newClusterDriverNodeType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            newClusterDriverNodeType = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("newClusterInitScripts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            newClusterInitScripts = JsonSerializer.Deserialize<DataFactoryElement<IList<string>>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("newClusterEnableElasticDisk"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            newClusterEnableElasticDisk = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"u8))
                        {
                            encryptedCredential = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("policyId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            policyId = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("credential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            credential = DataFactoryCredentialReference.DeserializeDataFactoryCredentialReference(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureDatabricksLinkedService(type, connectVia.Value, description.Value, Optional.ToDictionary(parameters), annotations ?? new ChangeTrackingList<BinaryData>(), additionalProperties, domain, accessToken, authentication.Value, workspaceResourceId.Value, existingClusterId.Value, instancePoolId.Value, newClusterVersion.Value, newClusterNumOfWorker.Value, newClusterNodeType.Value, Optional.ToDictionary(newClusterSparkConf), Optional.ToDictionary(newClusterSparkEnvVars), Optional.ToDictionary(newClusterCustomTags), newClusterLogDestination.Value, newClusterDriverNodeType.Value, newClusterInitScripts.Value, newClusterEnableElasticDisk.Value, encryptedCredential.Value, policyId.Value, credential.Value);
        }

        BinaryData IPersistableModel<AzureDatabricksLinkedService>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDatabricksLinkedService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureDatabricksLinkedService)} does not support '{options.Format}' format.");
            }
        }

        AzureDatabricksLinkedService IPersistableModel<AzureDatabricksLinkedService>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDatabricksLinkedService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureDatabricksLinkedService(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureDatabricksLinkedService)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureDatabricksLinkedService>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
