// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Linked service for Sybase data source. </summary>
    public partial class SybaseLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of SybaseLinkedService. </summary>
        /// <param name="server"> Server name for connection. Type: string (or Expression with resultType string). </param>
        /// <param name="database"> Database name for connection. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="server"/> or <paramref name="database"/> is null. </exception>
        public SybaseLinkedService(object server, object database)
        {
            Argument.AssertNotNull(server, nameof(server));
            Argument.AssertNotNull(database, nameof(database));

            Server = server;
            Database = database;
            Type = "Sybase";
        }

        /// <summary> Initializes a new instance of SybaseLinkedService. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="server"> Server name for connection. Type: string (or Expression with resultType string). </param>
        /// <param name="database"> Database name for connection. Type: string (or Expression with resultType string). </param>
        /// <param name="schema"> Schema name for connection. Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> AuthenticationType to be used for connection. </param>
        /// <param name="username"> Username for authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="password">
        /// Password for authentication.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal SybaseLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object server, object database, object schema, SybaseAuthenticationType? authenticationType, object username, SecretBase password, object encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            Server = server;
            Database = database;
            Schema = schema;
            AuthenticationType = authenticationType;
            Username = username;
            Password = password;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "Sybase";
        }

        /// <summary> Server name for connection. Type: string (or Expression with resultType string). </summary>
        public object Server { get; set; }
        /// <summary> Database name for connection. Type: string (or Expression with resultType string). </summary>
        public object Database { get; set; }
        /// <summary> Schema name for connection. Type: string (or Expression with resultType string). </summary>
        public object Schema { get; set; }
        /// <summary> AuthenticationType to be used for connection. </summary>
        public SybaseAuthenticationType? AuthenticationType { get; set; }
        /// <summary> Username for authentication. Type: string (or Expression with resultType string). </summary>
        public object Username { get; set; }
        /// <summary>
        /// Password for authentication.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase Password { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
