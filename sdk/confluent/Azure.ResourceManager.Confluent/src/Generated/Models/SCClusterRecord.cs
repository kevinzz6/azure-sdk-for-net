// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Confluent.Models
{
    /// <summary> Details of cluster record. </summary>
    public partial class SCClusterRecord
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SCClusterRecord"/>. </summary>
        internal SCClusterRecord()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SCClusterRecord"/>. </summary>
        /// <param name="kind"> Type of cluster. </param>
        /// <param name="id"> Id of the cluster. </param>
        /// <param name="name"> Display name of the cluster. </param>
        /// <param name="metadata"> Metadata of the record. </param>
        /// <param name="spec"> Specification of the cluster. </param>
        /// <param name="status"> Specification of the cluster status. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SCClusterRecord(string kind, string id, string name, SCMetadataEntity metadata, SCClusterSpecEntity spec, ClusterStatusEntity status, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Kind = kind;
            Id = id;
            Name = name;
            Metadata = metadata;
            Spec = spec;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Type of cluster. </summary>
        public string Kind { get; }
        /// <summary> Id of the cluster. </summary>
        public string Id { get; }
        /// <summary> Display name of the cluster. </summary>
        public string Name { get; }
        /// <summary> Metadata of the record. </summary>
        public SCMetadataEntity Metadata { get; }
        /// <summary> Specification of the cluster. </summary>
        public SCClusterSpecEntity Spec { get; }
        /// <summary> Specification of the cluster status. </summary>
        public ClusterStatusEntity Status { get; }
    }
}
