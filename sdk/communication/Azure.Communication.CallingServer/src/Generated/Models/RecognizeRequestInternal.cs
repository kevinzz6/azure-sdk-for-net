// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    /// <summary> The RecognizeRequest. </summary>
    internal partial class RecognizeRequestInternal
    {
        /// <summary> Initializes a new instance of RecognizeRequestInternal. </summary>
        /// <param name="recognizeInputType"> Determines the type of the recognition. </param>
        /// <param name="recognizeOptions"> Defines options for recognition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="recognizeOptions"/> is null. </exception>
        public RecognizeRequestInternal(RecognizeInputType recognizeInputType, RecognizeOptionsInternal recognizeOptions)
        {
            Argument.AssertNotNull(recognizeOptions, nameof(recognizeOptions));

            RecognizeInputType = recognizeInputType;
            RecognizeOptions = recognizeOptions;
        }

        /// <summary> Determines the type of the recognition. </summary>
        public RecognizeInputType RecognizeInputType { get; }
        /// <summary> The source of the audio to be played for recognition. </summary>
        public PlaySourceInternal PlayPrompt { get; set; }
        /// <summary> If set recognize can barge into other existing queued-up/currently-processing requests. </summary>
        public bool? InterruptCallMediaOperation { get; set; }
        /// <summary> Defines options for recognition. </summary>
        public RecognizeOptionsInternal RecognizeOptions { get; }
        /// <summary> The value to identify context of the operation. </summary>
        public string OperationContext { get; set; }
    }
}
