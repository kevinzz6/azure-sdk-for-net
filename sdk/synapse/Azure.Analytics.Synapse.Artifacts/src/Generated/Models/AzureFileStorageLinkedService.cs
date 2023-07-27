// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Azure File Storage linked service. </summary>
    public partial class AzureFileStorageLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of AzureFileStorageLinkedService. </summary>
        /// <param name="host"> Host name of the server. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="host"/> is null. </exception>
        public AzureFileStorageLinkedService(object host)
        {
            Argument.AssertNotNull(host, nameof(host));

            Host = host;
            Type = "AzureFileStorage";
        }

        /// <summary> Initializes a new instance of AzureFileStorageLinkedService. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="host"> Host name of the server. Type: string (or Expression with resultType string). </param>
        /// <param name="userId"> User ID to logon the server. Type: string (or Expression with resultType string). </param>
        /// <param name="password">
        /// Password to logon the server.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="connectionString"> The connection string. It is mutually exclusive with sasUri property. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="accountKey"> The Azure key vault secret reference of accountKey in connection string. </param>
        /// <param name="sasUri"> SAS URI of the Azure File resource. It is mutually exclusive with connectionString property. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="sasToken"> The Azure key vault secret reference of sasToken in sas uri. </param>
        /// <param name="fileShare"> The azure file share name. It is required when auth with accountKey/sasToken. Type: string (or Expression with resultType string). </param>
        /// <param name="snapshot"> The azure file share snapshot version. Type: string (or Expression with resultType string). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal AzureFileStorageLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object host, object userId, SecretBase password, object connectionString, AzureKeyVaultSecretReference accountKey, object sasUri, AzureKeyVaultSecretReference sasToken, object fileShare, object snapshot, object encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            Host = host;
            UserId = userId;
            Password = password;
            ConnectionString = connectionString;
            AccountKey = accountKey;
            SasUri = sasUri;
            SasToken = sasToken;
            FileShare = fileShare;
            Snapshot = snapshot;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "AzureFileStorage";
        }

        /// <summary> Host name of the server. Type: string (or Expression with resultType string). </summary>
        public object Host { get; set; }
        /// <summary> User ID to logon the server. Type: string (or Expression with resultType string). </summary>
        public object UserId { get; set; }
        /// <summary>
        /// Password to logon the server.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase Password { get; set; }
        /// <summary> The connection string. It is mutually exclusive with sasUri property. Type: string, SecureString or AzureKeyVaultSecretReference. </summary>
        public object ConnectionString { get; set; }
        /// <summary> The Azure key vault secret reference of accountKey in connection string. </summary>
        public AzureKeyVaultSecretReference AccountKey { get; set; }
        /// <summary> SAS URI of the Azure File resource. It is mutually exclusive with connectionString property. Type: string, SecureString or AzureKeyVaultSecretReference. </summary>
        public object SasUri { get; set; }
        /// <summary> The Azure key vault secret reference of sasToken in sas uri. </summary>
        public AzureKeyVaultSecretReference SasToken { get; set; }
        /// <summary> The azure file share name. It is required when auth with accountKey/sasToken. Type: string (or Expression with resultType string). </summary>
        public object FileShare { get; set; }
        /// <summary> The azure file share snapshot version. Type: string (or Expression with resultType string). </summary>
        public object Snapshot { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
