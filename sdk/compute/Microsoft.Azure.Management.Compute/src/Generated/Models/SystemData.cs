// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The system meta data relating to this resource.
    /// </summary>
    public partial class SystemData
    {
        /// <summary>
        /// Initializes a new instance of the SystemData class.
        /// </summary>
        public SystemData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SystemData class.
        /// </summary>
        /// <param name="createdAt">Specifies the time in UTC at which the
        /// Cloud Service (extended support) resource was created. &lt;br
        /// /&gt;Minimum api-version: 2022-04-04.</param>
        /// <param name="lastModifiedAt">Specifies the time in UTC at which the
        /// Cloud Service (extended support) resource was last modified. &lt;br
        /// /&gt;Minimum api-version: 2022-04-04.</param>
        public SystemData(System.DateTime? createdAt = default(System.DateTime?), System.DateTime? lastModifiedAt = default(System.DateTime?))
        {
            CreatedAt = createdAt;
            LastModifiedAt = lastModifiedAt;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets specifies the time in UTC at which the Cloud Service (extended
        /// support) resource was created. &amp;lt;br /&amp;gt;Minimum
        /// api-version: 2022-04-04.
        /// </summary>
        [JsonProperty(PropertyName = "createdAt")]
        public System.DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Gets specifies the time in UTC at which the Cloud Service (extended
        /// support) resource was last modified. &amp;lt;br /&amp;gt;Minimum
        /// api-version: 2022-04-04.
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedAt")]
        public System.DateTime? LastModifiedAt { get; private set; }

    }
}
