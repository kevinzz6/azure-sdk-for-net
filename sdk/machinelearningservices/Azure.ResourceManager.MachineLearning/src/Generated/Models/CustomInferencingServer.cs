// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Custom inference server configurations. </summary>
    public partial class CustomInferencingServer : InferencingServer
    {
        /// <summary> Initializes a new instance of CustomInferencingServer. </summary>
        public CustomInferencingServer()
        {
            ServerType = InferencingServerType.Custom;
        }

        /// <summary> Initializes a new instance of CustomInferencingServer. </summary>
        /// <param name="serverType"> [Required] Inferencing server type for various targets. </param>
        /// <param name="inferenceConfiguration"> Inference configuration for custom inferencing. </param>
        internal CustomInferencingServer(InferencingServerType serverType, OnlineInferenceConfiguration inferenceConfiguration) : base(serverType)
        {
            InferenceConfiguration = inferenceConfiguration;
            ServerType = serverType;
        }

        /// <summary> Inference configuration for custom inferencing. </summary>
        public OnlineInferenceConfiguration InferenceConfiguration { get; set; }
    }
}
