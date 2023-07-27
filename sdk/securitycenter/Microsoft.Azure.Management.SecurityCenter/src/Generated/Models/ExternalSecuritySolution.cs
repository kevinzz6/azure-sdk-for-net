// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a security solution external to Microsoft Defender for Cloud
    /// which sends information to an OMS workspace and whose data is displayed
    /// by Microsoft Defender for Cloud.
    /// </summary>
    public partial class ExternalSecuritySolution
    {
        /// <summary>
        /// Initializes a new instance of the ExternalSecuritySolution class.
        /// </summary>
        public ExternalSecuritySolution()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExternalSecuritySolution class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="location">Location where the resource is
        /// stored</param>
        public ExternalSecuritySolution(string id = default(string), string name = default(string), string type = default(string), string location = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
            Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets resource Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets resource name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets resource type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets location where the resource is stored
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

    }
}
