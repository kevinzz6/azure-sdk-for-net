// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> The list of cognitive services accounts operation response. </summary>
    internal partial class CognitiveServicesAccountSkuListResult
    {
        /// <summary> Initializes a new instance of CognitiveServicesAccountSkuListResult. </summary>
        internal CognitiveServicesAccountSkuListResult()
        {
            Value = new ChangeTrackingList<CognitiveServicesAccountSku>();
        }

        /// <summary> Initializes a new instance of CognitiveServicesAccountSkuListResult. </summary>
        /// <param name="value"> Gets the list of Cognitive Services accounts and their properties. </param>
        internal CognitiveServicesAccountSkuListResult(IReadOnlyList<CognitiveServicesAccountSku> value)
        {
            Value = value;
        }

        /// <summary> Gets the list of Cognitive Services accounts and their properties. </summary>
        public IReadOnlyList<CognitiveServicesAccountSku> Value { get; }
    }
}
