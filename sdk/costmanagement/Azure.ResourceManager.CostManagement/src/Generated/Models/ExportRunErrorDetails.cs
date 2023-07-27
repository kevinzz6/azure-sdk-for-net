// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The details of the error. </summary>
    public partial class ExportRunErrorDetails
    {
        /// <summary> Initializes a new instance of ExportRunErrorDetails. </summary>
        public ExportRunErrorDetails()
        {
        }

        /// <summary> Initializes a new instance of ExportRunErrorDetails. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error message indicating why the operation failed. </param>
        internal ExportRunErrorDetails(string code, string message)
        {
            Code = code;
            Message = message;
        }

        /// <summary> Error code. </summary>
        public string Code { get; }
        /// <summary> Error message indicating why the operation failed. </summary>
        public string Message { get; }
    }
}
