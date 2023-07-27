// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.IotCentral.Models
{
    /// <summary> Input values. </summary>
    public partial class IotCentralAppNameAvailabilityContent
    {
        /// <summary> Initializes a new instance of IotCentralAppNameAvailabilityContent. </summary>
        /// <param name="name"> The name of the IoT Central application instance to check. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public IotCentralAppNameAvailabilityContent(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> The name of the IoT Central application instance to check. </summary>
        public string Name { get; }
        /// <summary> The type of the IoT Central resource to query. </summary>
        public string ResourceType { get; set; }
    }
}
