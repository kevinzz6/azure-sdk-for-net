// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Dynamic Executor Allocation Properties. </summary>
    public partial class SynapseDynamicExecutorAllocation
    {
        /// <summary> Initializes a new instance of SynapseDynamicExecutorAllocation. </summary>
        public SynapseDynamicExecutorAllocation()
        {
        }

        /// <summary> Initializes a new instance of SynapseDynamicExecutorAllocation. </summary>
        /// <param name="isEnabled"> Indicates whether Dynamic Executor Allocation is enabled or not. </param>
        /// <param name="minExecutors"> The minimum number of executors alloted. </param>
        /// <param name="maxExecutors"> The maximum number of executors alloted. </param>
        internal SynapseDynamicExecutorAllocation(bool? isEnabled, int? minExecutors, int? maxExecutors)
        {
            IsEnabled = isEnabled;
            MinExecutors = minExecutors;
            MaxExecutors = maxExecutors;
        }

        /// <summary> Indicates whether Dynamic Executor Allocation is enabled or not. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> The minimum number of executors alloted. </summary>
        public int? MinExecutors { get; set; }
        /// <summary> The maximum number of executors alloted. </summary>
        public int? MaxExecutors { get; set; }
    }
}
