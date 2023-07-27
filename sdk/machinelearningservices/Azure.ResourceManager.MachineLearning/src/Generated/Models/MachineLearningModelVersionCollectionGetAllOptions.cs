// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningModelVersionCollectionGetAllOptions. </summary>
    public partial class MachineLearningModelVersionCollectionGetAllOptions
    {
        /// <summary> Initializes a new instance of MachineLearningModelVersionCollectionGetAllOptions. </summary>
        public MachineLearningModelVersionCollectionGetAllOptions()
        {
        }

        /// <summary> Continuation token for pagination. </summary>
        public string Skip { get; set; }
        /// <summary> Ordering of list. </summary>
        public string OrderBy { get; set; }
        /// <summary> Maximum number of records to return. </summary>
        public int? Top { get; set; }
        /// <summary> Model version. </summary>
        public string Version { get; set; }
        /// <summary> Model description. </summary>
        public string Description { get; set; }
        /// <summary> Number of initial results to skip. </summary>
        public int? Offset { get; set; }
        /// <summary> Comma-separated list of tag names (and optionally values). Example: tag1,tag2=value2. </summary>
        public string Tags { get; set; }
        /// <summary> Comma-separated list of property names (and optionally values). Example: prop1,prop2=value2. </summary>
        public string Properties { get; set; }
        /// <summary> Name of the feed. </summary>
        public string Feed { get; set; }
        /// <summary> View type for including/excluding (for example) archived entities. </summary>
        public MachineLearningListViewType? ListViewType { get; set; }
    }
}
