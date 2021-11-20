// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallingServer
{
    /// <summary> The add participant result event. </summary>
    public partial class AddParticipantResultEvent
    {
        /// <summary> Initializes a new instance of AddParticipantResultEvent. </summary>
        /// <param name="status"> The status of the operation. </param>
        internal AddParticipantResultEvent(CallingOperationStatus status)
        {
            Status = status;
        }

        /// <summary> Initializes a new instance of AddParticipantResultEvent. </summary>
        /// <param name="resultDetails"> The result details. </param>
        /// <param name="operationContext"> The operation context. </param>
        /// <param name="status"> The status of the operation. </param>
        internal AddParticipantResultEvent(CallingOperationResultDetails resultDetails, string operationContext, CallingOperationStatus status)
        {
            ResultDetails = resultDetails;
            OperationContext = operationContext;
            Status = status;
        }

        /// <summary> The result details. </summary>
        public CallingOperationResultDetails ResultDetails { get; }
        /// <summary> The operation context. </summary>
        public string OperationContext { get; }
        /// <summary> The status of the operation. </summary>
        public CallingOperationStatus Status { get; }
    }
}
