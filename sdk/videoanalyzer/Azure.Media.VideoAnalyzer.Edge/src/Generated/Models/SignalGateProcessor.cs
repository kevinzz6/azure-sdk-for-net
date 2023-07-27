// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> A signal gate determines when to block (gate) incoming media, and when to allow it through. It gathers input events over the activationEvaluationWindow, and determines whether to open or close the gate. See https://aka.ms/ava-signalgate for more information. </summary>
    public partial class SignalGateProcessor : ProcessorNodeBase
    {
        /// <summary> Initializes a new instance of SignalGateProcessor. </summary>
        /// <param name="name"> Node name. Must be unique within the topology. </param>
        /// <param name="inputs"> An array of upstream node references within the topology to be used as inputs for this node. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="inputs"/> is null. </exception>
        public SignalGateProcessor(string name, IEnumerable<NodeInput> inputs) : base(name, inputs)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(inputs, nameof(inputs));

            Type = "#Microsoft.VideoAnalyzer.SignalGateProcessor";
        }

        /// <summary> Initializes a new instance of SignalGateProcessor. </summary>
        /// <param name="type"> Type discriminator for the derived types. </param>
        /// <param name="name"> Node name. Must be unique within the topology. </param>
        /// <param name="inputs"> An array of upstream node references within the topology to be used as inputs for this node. </param>
        /// <param name="activationEvaluationWindow"> The period of time over which the gate gathers input events before evaluating them. </param>
        /// <param name="activationSignalOffset"> Signal offset once the gate is activated (can be negative). It determines the how much farther behind of after the signal will be let through based on the activation time. A negative offset indicates that data prior the activation time must be included on the signal that is let through, once the gate is activated. When used upstream of a file or video sink, this allows for scenarios such as recording buffered media prior an event, such as: record video 5 seconds prior motions is detected. </param>
        /// <param name="minimumActivationTime"> The minimum period for which the gate remains open in the absence of subsequent triggers (events). When used upstream of a file or video sink, it determines the minimum length of the recorded video clip. </param>
        /// <param name="maximumActivationTime"> The maximum period for which the gate remains open in the presence of subsequent triggers (events). When used upstream of a file or video sink, it determines the maximum length of the recorded video clip. </param>
        internal SignalGateProcessor(string type, string name, IList<NodeInput> inputs, string activationEvaluationWindow, string activationSignalOffset, string minimumActivationTime, string maximumActivationTime) : base(type, name, inputs)
        {
            ActivationEvaluationWindow = activationEvaluationWindow;
            ActivationSignalOffset = activationSignalOffset;
            MinimumActivationTime = minimumActivationTime;
            MaximumActivationTime = maximumActivationTime;
            Type = type ?? "#Microsoft.VideoAnalyzer.SignalGateProcessor";
        }

        /// <summary> The period of time over which the gate gathers input events before evaluating them. </summary>
        public string ActivationEvaluationWindow { get; set; }
        /// <summary> Signal offset once the gate is activated (can be negative). It determines the how much farther behind of after the signal will be let through based on the activation time. A negative offset indicates that data prior the activation time must be included on the signal that is let through, once the gate is activated. When used upstream of a file or video sink, this allows for scenarios such as recording buffered media prior an event, such as: record video 5 seconds prior motions is detected. </summary>
        public string ActivationSignalOffset { get; set; }
        /// <summary> The minimum period for which the gate remains open in the absence of subsequent triggers (events). When used upstream of a file or video sink, it determines the minimum length of the recorded video clip. </summary>
        public string MinimumActivationTime { get; set; }
        /// <summary> The maximum period for which the gate remains open in the presence of subsequent triggers (events). When used upstream of a file or video sink, it determines the maximum length of the recorded video clip. </summary>
        public string MaximumActivationTime { get; set; }
    }
}
