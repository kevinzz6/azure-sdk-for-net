// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Request body to create a composed document model from component document models. </summary>
    internal partial class ComposeDocumentModelRequest
    {
        /// <summary> Initializes a new instance of ComposeDocumentModelRequest. </summary>
        /// <param name="modelId"> Unique document model name. </param>
        /// <param name="componentModels"> List of component document models to compose. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/> or <paramref name="componentModels"/> is null. </exception>
        public ComposeDocumentModelRequest(string modelId, IEnumerable<ComponentDocumentModelDetails> componentModels)
        {
            Argument.AssertNotNull(modelId, nameof(modelId));
            Argument.AssertNotNull(componentModels, nameof(componentModels));

            ModelId = modelId;
            ComponentModels = componentModels.ToList();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Unique document model name. </summary>
        public string ModelId { get; }
        /// <summary> Document model description. </summary>
        public string Description { get; set; }
        /// <summary> List of component document models to compose. </summary>
        public IList<ComponentDocumentModelDetails> ComponentModels { get; }
        /// <summary> List of key-value tag attributes associated with the document model. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
