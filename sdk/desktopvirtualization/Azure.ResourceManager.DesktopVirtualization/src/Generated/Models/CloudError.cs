// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> The CloudError. </summary>
    internal partial class CloudError
    {
        /// <summary> Initializes a new instance of CloudError. </summary>
        internal CloudError()
        {
        }

        /// <summary> Initializes a new instance of CloudError. </summary>
        /// <param name="error"></param>
        internal CloudError(CloudErrorProperties error)
        {
            Error = error;
        }

        /// <summary> Gets the error. </summary>
        public CloudErrorProperties Error { get; }
    }
}
