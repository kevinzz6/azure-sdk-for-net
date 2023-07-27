// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The UnknownDataFlow. </summary>
    internal partial class UnknownDataFlow : DataFactoryDataFlowDefinition
    {
        /// <summary> Initializes a new instance of UnknownDataFlow. </summary>
        /// <param name="dataFlowType"> Type of data flow. </param>
        /// <param name="description"> The description of the data flow. </param>
        /// <param name="annotations"> List of tags that can be used for describing the data flow. </param>
        /// <param name="folder"> The folder that this data flow is in. If not specified, Data flow will appear at the root level. </param>
        internal UnknownDataFlow(string dataFlowType, string description, IList<BinaryData> annotations, DataFlowFolder folder) : base(dataFlowType, description, annotations, folder)
        {
            DataFlowType = dataFlowType ?? "Unknown";
        }
    }
}
