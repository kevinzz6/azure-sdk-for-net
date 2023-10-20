// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Properties of a labeling job
    /// Please note <see cref="LabelingJobMediaProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="LabelingJobImageProperties"/> and <see cref="LabelingJobTextProperties"/>.
    /// </summary>
    public abstract partial class LabelingJobMediaProperties
    {
        /// <summary> Initializes a new instance of LabelingJobMediaProperties. </summary>
        protected LabelingJobMediaProperties()
        {
        }

        /// <summary> Initializes a new instance of LabelingJobMediaProperties. </summary>
        /// <param name="mediaType"> [Required] Media type of the job. </param>
        internal LabelingJobMediaProperties(MediaType mediaType)
        {
            MediaType = mediaType;
        }

        /// <summary> [Required] Media type of the job. </summary>
        internal MediaType MediaType { get; set; }
    }
}
