// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Describes either the current operation (if the pool AllocationState is Resizing) or the previously completed operation (if the AllocationState is Steady). </summary>
    public partial class BatchResizeOperationStatus
    {
        /// <summary> Initializes a new instance of BatchResizeOperationStatus. </summary>
        internal BatchResizeOperationStatus()
        {
            Errors = new ChangeTrackingList<ResponseError>();
        }

        /// <summary> Initializes a new instance of BatchResizeOperationStatus. </summary>
        /// <param name="targetDedicatedNodes"> The desired number of dedicated compute nodes in the pool. </param>
        /// <param name="targetLowPriorityNodes"> The desired number of Spot/low-priority compute nodes in the pool. </param>
        /// <param name="resizeTimeout"> The default value is 15 minutes. The minimum value is 5 minutes. If you specify a value less than 5 minutes, the Batch service returns an error; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). </param>
        /// <param name="nodeDeallocationOption"> The default value is requeue. </param>
        /// <param name="startOn"> The time when this resize operation was started. </param>
        /// <param name="errors"> This property is set only if an error occurred during the last pool resize, and only when the pool allocationState is Steady. </param>
        internal BatchResizeOperationStatus(int? targetDedicatedNodes, int? targetLowPriorityNodes, TimeSpan? resizeTimeout, BatchNodeDeallocationOption? nodeDeallocationOption, DateTimeOffset? startOn, IReadOnlyList<ResponseError> errors)
        {
            TargetDedicatedNodes = targetDedicatedNodes;
            TargetLowPriorityNodes = targetLowPriorityNodes;
            ResizeTimeout = resizeTimeout;
            NodeDeallocationOption = nodeDeallocationOption;
            StartOn = startOn;
            Errors = errors;
        }

        /// <summary> The desired number of dedicated compute nodes in the pool. </summary>
        public int? TargetDedicatedNodes { get; }
        /// <summary> The desired number of Spot/low-priority compute nodes in the pool. </summary>
        public int? TargetLowPriorityNodes { get; }
        /// <summary> The default value is 15 minutes. The minimum value is 5 minutes. If you specify a value less than 5 minutes, the Batch service returns an error; if you are calling the REST API directly, the HTTP status code is 400 (Bad Request). </summary>
        public TimeSpan? ResizeTimeout { get; }
        /// <summary> The default value is requeue. </summary>
        public BatchNodeDeallocationOption? NodeDeallocationOption { get; }
        /// <summary> The time when this resize operation was started. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> This property is set only if an error occurred during the last pool resize, and only when the pool allocationState is Steady. </summary>
        public IReadOnlyList<ResponseError> Errors { get; }
    }
}
