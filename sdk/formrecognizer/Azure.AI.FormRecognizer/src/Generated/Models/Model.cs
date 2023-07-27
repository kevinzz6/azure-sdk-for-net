// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.FormRecognizer.Training;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Response to the get custom model operation. </summary>
    internal partial class Model
    {
        /// <summary> Initializes a new instance of Model. </summary>
        /// <param name="modelInfo"> Basic custom model information. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelInfo"/> is null. </exception>
        internal Model(CustomFormModelInfo modelInfo)
        {
            Argument.AssertNotNull(modelInfo, nameof(modelInfo));

            ModelInfo = modelInfo;
            ComposedTrainResults = new ChangeTrackingList<TrainResult>();
        }

        /// <summary> Initializes a new instance of Model. </summary>
        /// <param name="modelInfo"> Basic custom model information. </param>
        /// <param name="keys"> Keys extracted by the custom model. </param>
        /// <param name="trainResult"> Training result for custom model. </param>
        /// <param name="composedTrainResults"> Training result for composed model. </param>
        internal Model(CustomFormModelInfo modelInfo, KeysResult keys, TrainResult trainResult, IReadOnlyList<TrainResult> composedTrainResults)
        {
            ModelInfo = modelInfo;
            Keys = keys;
            TrainResult = trainResult;
            ComposedTrainResults = composedTrainResults;
        }

        /// <summary> Basic custom model information. </summary>
        public CustomFormModelInfo ModelInfo { get; }
        /// <summary> Keys extracted by the custom model. </summary>
        public KeysResult Keys { get; }
        /// <summary> Training result for custom model. </summary>
        public TrainResult TrainResult { get; }
        /// <summary> Training result for composed model. </summary>
        public IReadOnlyList<TrainResult> ComposedTrainResults { get; }
    }
}
