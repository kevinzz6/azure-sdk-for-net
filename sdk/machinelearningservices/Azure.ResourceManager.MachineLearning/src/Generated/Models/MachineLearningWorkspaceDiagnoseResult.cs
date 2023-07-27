// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningWorkspaceDiagnoseResult. </summary>
    public partial class MachineLearningWorkspaceDiagnoseResult
    {
        /// <summary> Initializes a new instance of MachineLearningWorkspaceDiagnoseResult. </summary>
        internal MachineLearningWorkspaceDiagnoseResult()
        {
        }

        /// <summary> Initializes a new instance of MachineLearningWorkspaceDiagnoseResult. </summary>
        /// <param name="value"></param>
        internal MachineLearningWorkspaceDiagnoseResult(MachineLearningDiagnoseResultValue value)
        {
            Value = value;
        }

        /// <summary> Gets the value. </summary>
        public MachineLearningDiagnoseResultValue Value { get; }
    }
}
