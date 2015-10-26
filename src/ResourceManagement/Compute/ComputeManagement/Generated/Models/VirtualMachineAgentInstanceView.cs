// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The instance view of the VM Agent running on the virtual machine.
    /// </summary>
    public partial class VirtualMachineAgentInstanceView
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineAgentInstanceView
        /// class.
        /// </summary>
        public VirtualMachineAgentInstanceView() { }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineAgentInstanceView
        /// class.
        /// </summary>
        public VirtualMachineAgentInstanceView(string vmAgentVersion = default(string), IList<VirtualMachineExtensionHandlerInstanceView> extensionHandlers = default(IList<VirtualMachineExtensionHandlerInstanceView>), IList<InstanceViewStatus> statuses = default(IList<InstanceViewStatus>))
        {
            VmAgentVersion = vmAgentVersion;
            ExtensionHandlers = extensionHandlers;
            Statuses = statuses;
        }

        /// <summary>
        /// Gets or sets the VM Agent full version.
        /// </summary>
        [JsonProperty(PropertyName = "vmAgentVersion")]
        public string VmAgentVersion { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine extension handler instance view.
        /// </summary>
        [JsonProperty(PropertyName = "extensionHandlers")]
        public IList<VirtualMachineExtensionHandlerInstanceView> ExtensionHandlers { get; set; }

        /// <summary>
        /// Gets or sets the resource status information.
        /// </summary>
        [JsonProperty(PropertyName = "statuses")]
        public IList<InstanceViewStatus> Statuses { get; set; }

    }
}
