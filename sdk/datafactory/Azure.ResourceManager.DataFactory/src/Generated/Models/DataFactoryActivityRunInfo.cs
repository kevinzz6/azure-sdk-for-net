// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Information about an activity run in a pipeline. </summary>
    public partial class DataFactoryActivityRunInfo
    {
        /// <summary> Initializes a new instance of DataFactoryActivityRunInfo. </summary>
        internal DataFactoryActivityRunInfo()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of DataFactoryActivityRunInfo. </summary>
        /// <param name="pipelineName"> The name of the pipeline. </param>
        /// <param name="pipelineRunId"> The id of the pipeline run. </param>
        /// <param name="activityName"> The name of the activity. </param>
        /// <param name="activityType"> The type of the activity. </param>
        /// <param name="activityRunId"> The id of the activity run. </param>
        /// <param name="linkedServiceName"> The name of the compute linked service. </param>
        /// <param name="status"> The status of the activity run. </param>
        /// <param name="activityRunStart"> The start time of the activity run in 'ISO 8601' format. </param>
        /// <param name="endOn"> The end time of the activity run in 'ISO 8601' format. </param>
        /// <param name="durationInMs"> The duration of the activity run. </param>
        /// <param name="input"> The input for the activity. </param>
        /// <param name="output"> The output for the activity. </param>
        /// <param name="error"> The error if any from the activity run. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal DataFactoryActivityRunInfo(string pipelineName, Guid? pipelineRunId, string activityName, string activityType, Guid? activityRunId, string linkedServiceName, string status, DateTimeOffset? activityRunStart, DateTimeOffset? endOn, int? durationInMs, BinaryData input, BinaryData output, BinaryData error, IReadOnlyDictionary<string, BinaryData> additionalProperties)
        {
            PipelineName = pipelineName;
            PipelineRunId = pipelineRunId;
            ActivityName = activityName;
            ActivityType = activityType;
            ActivityRunId = activityRunId;
            LinkedServiceName = linkedServiceName;
            Status = status;
            ActivityRunStart = activityRunStart;
            EndOn = endOn;
            DurationInMs = durationInMs;
            Input = input;
            Output = output;
            Error = error;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The name of the pipeline. </summary>
        public string PipelineName { get; }
        /// <summary> The id of the pipeline run. </summary>
        public Guid? PipelineRunId { get; }
        /// <summary> The name of the activity. </summary>
        public string ActivityName { get; }
        /// <summary> The type of the activity. </summary>
        public string ActivityType { get; }
        /// <summary> The id of the activity run. </summary>
        public Guid? ActivityRunId { get; }
        /// <summary> The name of the compute linked service. </summary>
        public string LinkedServiceName { get; }
        /// <summary> The status of the activity run. </summary>
        public string Status { get; }
        /// <summary> The start time of the activity run in 'ISO 8601' format. </summary>
        public DateTimeOffset? ActivityRunStart { get; }
        /// <summary> The end time of the activity run in 'ISO 8601' format. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> The duration of the activity run. </summary>
        public int? DurationInMs { get; }
        /// <summary>
        /// The input for the activity.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData Input { get; }
        /// <summary>
        /// The output for the activity.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData Output { get; }
        /// <summary>
        /// The error if any from the activity run.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData Error { get; }
        /// <summary>
        /// Additional Properties
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public IReadOnlyDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
