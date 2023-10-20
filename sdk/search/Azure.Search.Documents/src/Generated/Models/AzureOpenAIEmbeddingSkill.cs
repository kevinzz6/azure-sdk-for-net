// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Allows you to generate a vector embedding for a given text input using the Azure Open AI service. </summary>
    public partial class AzureOpenAIEmbeddingSkill : SearchIndexerSkill
    {
        /// <summary> Initializes a new instance of AzureOpenAIEmbeddingSkill. </summary>
        /// <param name="inputs"> Inputs of the skills could be a column in the source data set, or the output of an upstream skill. </param>
        /// <param name="outputs"> The output of a skill is either a field in a search index, or a value that can be consumed as an input by another skill. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inputs"/> or <paramref name="outputs"/> is null. </exception>
        public AzureOpenAIEmbeddingSkill(IEnumerable<InputFieldMappingEntry> inputs, IEnumerable<OutputFieldMappingEntry> outputs) : base(inputs, outputs)
        {
            Argument.AssertNotNull(inputs, nameof(inputs));
            Argument.AssertNotNull(outputs, nameof(outputs));

            ODataType = "#Microsoft.Skills.Text.AzureOpenAIEmbeddingSkill";
        }

        /// <summary> Initializes a new instance of AzureOpenAIEmbeddingSkill. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the skill. </param>
        /// <param name="name"> The name of the skill which uniquely identifies it within the skillset. A skill with no name defined will be given a default name of its 1-based index in the skills array, prefixed with the character '#'. </param>
        /// <param name="description"> The description of the skill which describes the inputs, outputs, and usage of the skill. </param>
        /// <param name="context"> Represents the level at which operations take place, such as the document root or document content (for example, /document or /document/content). The default is /document. </param>
        /// <param name="inputs"> Inputs of the skills could be a column in the source data set, or the output of an upstream skill. </param>
        /// <param name="outputs"> The output of a skill is either a field in a search index, or a value that can be consumed as an input by another skill. </param>
        /// <param name="resourceUri"> The resource uri for your Azure Open AI resource. </param>
        /// <param name="deploymentId"> ID of your Azure Open AI model deployment on the designated resource. </param>
        /// <param name="apiKey"> API key for the designated Azure Open AI resource. </param>
        /// <param name="authIdentity">
        /// The user-assigned managed identity used for outbound connections.
        /// Please note <see cref="SearchIndexerDataIdentity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SearchIndexerDataNoneIdentity"/> and <see cref="SearchIndexerDataUserAssignedIdentity"/>.
        /// </param>
        internal AzureOpenAIEmbeddingSkill(string oDataType, string name, string description, string context, IList<InputFieldMappingEntry> inputs, IList<OutputFieldMappingEntry> outputs, Uri resourceUri, string deploymentId, string apiKey, SearchIndexerDataIdentity authIdentity) : base(oDataType, name, description, context, inputs, outputs)
        {
            ResourceUri = resourceUri;
            DeploymentId = deploymentId;
            ApiKey = apiKey;
            AuthIdentity = authIdentity;
            ODataType = oDataType ?? "#Microsoft.Skills.Text.AzureOpenAIEmbeddingSkill";
        }

        /// <summary> The resource uri for your Azure Open AI resource. </summary>
        public Uri ResourceUri { get; set; }
        /// <summary> ID of your Azure Open AI model deployment on the designated resource. </summary>
        public string DeploymentId { get; set; }
        /// <summary> API key for the designated Azure Open AI resource. </summary>
        public string ApiKey { get; set; }
        /// <summary>
        /// The user-assigned managed identity used for outbound connections.
        /// Please note <see cref="SearchIndexerDataIdentity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SearchIndexerDataNoneIdentity"/> and <see cref="SearchIndexerDataUserAssignedIdentity"/>.
        /// </summary>
        public SearchIndexerDataIdentity AuthIdentity { get; set; }
    }
}
