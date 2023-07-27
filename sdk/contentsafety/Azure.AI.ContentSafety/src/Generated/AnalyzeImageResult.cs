// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.ContentSafety
{
    /// <summary> The analysis response of the image. </summary>
    public partial class AnalyzeImageResult
    {
        /// <summary> Initializes a new instance of AnalyzeImageResult. </summary>
        internal AnalyzeImageResult()
        {
        }

        /// <summary> Initializes a new instance of AnalyzeImageResult. </summary>
        /// <param name="hateResult"> Analysis result for Hate category. </param>
        /// <param name="selfHarmResult"> Analysis result for SelfHarm category. </param>
        /// <param name="sexualResult"> Analysis result for Sexual category. </param>
        /// <param name="violenceResult"> Analysis result for Violence category. </param>
        internal AnalyzeImageResult(ImageAnalyzeSeverityResult hateResult, ImageAnalyzeSeverityResult selfHarmResult, ImageAnalyzeSeverityResult sexualResult, ImageAnalyzeSeverityResult violenceResult)
        {
            HateResult = hateResult;
            SelfHarmResult = selfHarmResult;
            SexualResult = sexualResult;
            ViolenceResult = violenceResult;
        }

        /// <summary> Analysis result for Hate category. </summary>
        public ImageAnalyzeSeverityResult HateResult { get; }
        /// <summary> Analysis result for SelfHarm category. </summary>
        public ImageAnalyzeSeverityResult SelfHarmResult { get; }
        /// <summary> Analysis result for Sexual category. </summary>
        public ImageAnalyzeSeverityResult SexualResult { get; }
        /// <summary> Analysis result for Violence category. </summary>
        public ImageAnalyzeSeverityResult ViolenceResult { get; }
    }
}
