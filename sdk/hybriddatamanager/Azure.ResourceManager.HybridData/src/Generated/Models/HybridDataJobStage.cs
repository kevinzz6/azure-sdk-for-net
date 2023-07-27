// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridData.Models
{
    /// <summary> Job stages. </summary>
    public partial class HybridDataJobStage
    {
        /// <summary> Initializes a new instance of HybridDataJobStage. </summary>
        /// <param name="stageStatus"> Status of the job stage. </param>
        public HybridDataJobStage(HybridDataJobStatus stageStatus)
        {
            StageStatus = stageStatus;
            ErrorDetails = new ChangeTrackingList<HybridDataJobErrorDetails>();
        }

        /// <summary> Initializes a new instance of HybridDataJobStage. </summary>
        /// <param name="stageName"> Name of the job stage. </param>
        /// <param name="stageStatus"> Status of the job stage. </param>
        /// <param name="jobStageDetails"> Job Stage Details. </param>
        /// <param name="errorDetails"> Error details for the stage. This is optional. </param>
        internal HybridDataJobStage(string stageName, HybridDataJobStatus stageStatus, BinaryData jobStageDetails, IList<HybridDataJobErrorDetails> errorDetails)
        {
            StageName = stageName;
            StageStatus = stageStatus;
            JobStageDetails = jobStageDetails;
            ErrorDetails = errorDetails;
        }

        /// <summary> Name of the job stage. </summary>
        public string StageName { get; set; }
        /// <summary> Status of the job stage. </summary>
        public HybridDataJobStatus StageStatus { get; set; }
        /// <summary>
        /// Job Stage Details
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
        public BinaryData JobStageDetails { get; set; }
        /// <summary> Error details for the stage. This is optional. </summary>
        public IList<HybridDataJobErrorDetails> ErrorDetails { get; }
    }
}
