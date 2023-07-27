// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Sap Business Warehouse Open Hub Destination Table properties. </summary>
    public partial class SapOpenHubTableDataset : Dataset
    {
        /// <summary> Initializes a new instance of SapOpenHubTableDataset. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="openHubDestinationName"> The name of the Open Hub Destination with destination type as Database Table. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> or <paramref name="openHubDestinationName"/> is null. </exception>
        public SapOpenHubTableDataset(LinkedServiceReference linkedServiceName, object openHubDestinationName) : base(linkedServiceName)
        {
            Argument.AssertNotNull(linkedServiceName, nameof(linkedServiceName));
            Argument.AssertNotNull(openHubDestinationName, nameof(openHubDestinationName));

            OpenHubDestinationName = openHubDestinationName;
            Type = "SapOpenHubTable";
        }

        /// <summary> Initializes a new instance of SapOpenHubTableDataset. </summary>
        /// <param name="type"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="openHubDestinationName"> The name of the Open Hub Destination with destination type as Database Table. Type: string (or Expression with resultType string). </param>
        /// <param name="excludeLastRequest"> Whether to exclude the records of the last request. The default value is true. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="baseRequestId"> The ID of request for delta loading. Once it is set, only data with requestId larger than the value of this property will be retrieved. The default value is 0. Type: integer (or Expression with resultType integer ). </param>
        internal SapOpenHubTableDataset(string type, string description, object structure, object schema, LinkedServiceReference linkedServiceName, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, DatasetFolder folder, IDictionary<string, object> additionalProperties, object openHubDestinationName, object excludeLastRequest, object baseRequestId) : base(type, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            OpenHubDestinationName = openHubDestinationName;
            ExcludeLastRequest = excludeLastRequest;
            BaseRequestId = baseRequestId;
            Type = type ?? "SapOpenHubTable";
        }

        /// <summary> The name of the Open Hub Destination with destination type as Database Table. Type: string (or Expression with resultType string). </summary>
        public object OpenHubDestinationName { get; set; }
        /// <summary> Whether to exclude the records of the last request. The default value is true. Type: boolean (or Expression with resultType boolean). </summary>
        public object ExcludeLastRequest { get; set; }
        /// <summary> The ID of request for delta loading. Once it is set, only data with requestId larger than the value of this property will be retrieved. The default value is 0. Type: integer (or Expression with resultType integer ). </summary>
        public object BaseRequestId { get; set; }
    }
}
