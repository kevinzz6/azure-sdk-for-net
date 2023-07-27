// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Detailed errors. </summary>
    public partial class ContainerAppCustomDomainVerificationFailureInfoDetailsItem
    {
        /// <summary> Initializes a new instance of ContainerAppCustomDomainVerificationFailureInfoDetailsItem. </summary>
        internal ContainerAppCustomDomainVerificationFailureInfoDetailsItem()
        {
        }

        /// <summary> Initializes a new instance of ContainerAppCustomDomainVerificationFailureInfoDetailsItem. </summary>
        /// <param name="code"> Standardized string to programmatically identify the error. </param>
        /// <param name="message"> Detailed error description and debugging information. </param>
        /// <param name="target"> Detailed error description and debugging information. </param>
        internal ContainerAppCustomDomainVerificationFailureInfoDetailsItem(string code, string message, string target)
        {
            Code = code;
            Message = message;
            Target = target;
        }

        /// <summary> Standardized string to programmatically identify the error. </summary>
        public string Code { get; }
        /// <summary> Detailed error description and debugging information. </summary>
        public string Message { get; }
        /// <summary> Detailed error description and debugging information. </summary>
        public string Target { get; }
    }
}
