// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class AS2ValidationSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("overrideMessageProperties"u8);
            writer.WriteBooleanValue(OverrideMessageProperties);
            writer.WritePropertyName("encryptMessage"u8);
            writer.WriteBooleanValue(EncryptMessage);
            writer.WritePropertyName("signMessage"u8);
            writer.WriteBooleanValue(SignMessage);
            writer.WritePropertyName("compressMessage"u8);
            writer.WriteBooleanValue(CompressMessage);
            writer.WritePropertyName("checkDuplicateMessage"u8);
            writer.WriteBooleanValue(CheckDuplicateMessage);
            writer.WritePropertyName("interchangeDuplicatesValidityDays"u8);
            writer.WriteNumberValue(InterchangeDuplicatesValidityDays);
            writer.WritePropertyName("checkCertificateRevocationListOnSend"u8);
            writer.WriteBooleanValue(CheckCertificateRevocationListOnSend);
            writer.WritePropertyName("checkCertificateRevocationListOnReceive"u8);
            writer.WriteBooleanValue(CheckCertificateRevocationListOnReceive);
            writer.WritePropertyName("encryptionAlgorithm"u8);
            writer.WriteStringValue(EncryptionAlgorithm.ToString());
            if (Optional.IsDefined(SigningAlgorithm))
            {
                writer.WritePropertyName("signingAlgorithm"u8);
                writer.WriteStringValue(SigningAlgorithm.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static AS2ValidationSettings DeserializeAS2ValidationSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool overrideMessageProperties = default;
            bool encryptMessage = default;
            bool signMessage = default;
            bool compressMessage = default;
            bool checkDuplicateMessage = default;
            int interchangeDuplicatesValidityDays = default;
            bool checkCertificateRevocationListOnSend = default;
            bool checkCertificateRevocationListOnReceive = default;
            AS2EncryptionAlgorithm encryptionAlgorithm = default;
            Optional<AS2SigningAlgorithm> signingAlgorithm = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("overrideMessageProperties"u8))
                {
                    overrideMessageProperties = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("encryptMessage"u8))
                {
                    encryptMessage = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("signMessage"u8))
                {
                    signMessage = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("compressMessage"u8))
                {
                    compressMessage = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("checkDuplicateMessage"u8))
                {
                    checkDuplicateMessage = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("interchangeDuplicatesValidityDays"u8))
                {
                    interchangeDuplicatesValidityDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("checkCertificateRevocationListOnSend"u8))
                {
                    checkCertificateRevocationListOnSend = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("checkCertificateRevocationListOnReceive"u8))
                {
                    checkCertificateRevocationListOnReceive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("encryptionAlgorithm"u8))
                {
                    encryptionAlgorithm = new AS2EncryptionAlgorithm(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("signingAlgorithm"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    signingAlgorithm = new AS2SigningAlgorithm(property.Value.GetString());
                    continue;
                }
            }
            return new AS2ValidationSettings(overrideMessageProperties, encryptMessage, signMessage, compressMessage, checkDuplicateMessage, interchangeDuplicatesValidityDays, checkCertificateRevocationListOnSend, checkCertificateRevocationListOnReceive, encryptionAlgorithm, Optional.ToNullable(signingAlgorithm));
        }
    }
}
