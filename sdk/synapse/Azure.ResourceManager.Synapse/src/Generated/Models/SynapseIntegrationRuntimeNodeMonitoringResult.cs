// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Monitoring data for integration runtime node. </summary>
    public partial class SynapseIntegrationRuntimeNodeMonitoringResult
    {
        /// <summary> Initializes a new instance of SynapseIntegrationRuntimeNodeMonitoringResult. </summary>
        internal SynapseIntegrationRuntimeNodeMonitoringResult()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of SynapseIntegrationRuntimeNodeMonitoringResult. </summary>
        /// <param name="nodeName"> Name of the integration runtime node. </param>
        /// <param name="availableMemoryInMB"> Available memory (MB) on the integration runtime node. </param>
        /// <param name="cpuUtilization"> CPU percentage on the integration runtime node. </param>
        /// <param name="concurrentJobsLimit"> Maximum concurrent jobs on the integration runtime node. </param>
        /// <param name="concurrentJobsRunning"> The number of jobs currently running on the integration runtime node. </param>
        /// <param name="maxConcurrentJobs"> The maximum concurrent jobs in this integration runtime. </param>
        /// <param name="sentBytes"> Sent bytes on the integration runtime node. </param>
        /// <param name="receivedBytes"> Received bytes on the integration runtime node. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal SynapseIntegrationRuntimeNodeMonitoringResult(string nodeName, int? availableMemoryInMB, int? cpuUtilization, int? concurrentJobsLimit, int? concurrentJobsRunning, int? maxConcurrentJobs, float? sentBytes, float? receivedBytes, IReadOnlyDictionary<string, BinaryData> additionalProperties)
        {
            NodeName = nodeName;
            AvailableMemoryInMB = availableMemoryInMB;
            CpuUtilization = cpuUtilization;
            ConcurrentJobsLimit = concurrentJobsLimit;
            ConcurrentJobsRunning = concurrentJobsRunning;
            MaxConcurrentJobs = maxConcurrentJobs;
            SentBytes = sentBytes;
            ReceivedBytes = receivedBytes;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Name of the integration runtime node. </summary>
        public string NodeName { get; }
        /// <summary> Available memory (MB) on the integration runtime node. </summary>
        public int? AvailableMemoryInMB { get; }
        /// <summary> CPU percentage on the integration runtime node. </summary>
        public int? CpuUtilization { get; }
        /// <summary> Maximum concurrent jobs on the integration runtime node. </summary>
        public int? ConcurrentJobsLimit { get; }
        /// <summary> The number of jobs currently running on the integration runtime node. </summary>
        public int? ConcurrentJobsRunning { get; }
        /// <summary> The maximum concurrent jobs in this integration runtime. </summary>
        public int? MaxConcurrentJobs { get; }
        /// <summary> Sent bytes on the integration runtime node. </summary>
        public float? SentBytes { get; }
        /// <summary> Received bytes on the integration runtime node. </summary>
        public float? ReceivedBytes { get; }
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
