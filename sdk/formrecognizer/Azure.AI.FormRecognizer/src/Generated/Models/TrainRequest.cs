// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.AI.FormRecognizer.Training;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Request parameter to train a new custom model. </summary>
    internal partial class TrainRequest
    {
        /// <summary> Initializes a new instance of TrainRequest. </summary>
        /// <param name="source"> Source path containing the training documents. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="source"/> is null. </exception>
        public TrainRequest(string source)
        {
            Argument.AssertNotNull(source, nameof(source));

            Source = source;
        }

        /// <summary> Source path containing the training documents. </summary>
        public string Source { get; }
        /// <summary> Filter to apply to the documents in the source path for training. </summary>
        public TrainingFileFilter SourceFilter { get; set; }
        /// <summary> Use label file for training a model. </summary>
        public bool? UseLabelFile { get; set; }
        /// <summary> Optional user defined model name (max length: 1024). </summary>
        public string ModelName { get; set; }
    }
}
