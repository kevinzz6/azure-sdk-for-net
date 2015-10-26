// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// String dictionary resource
    /// </summary>
    public partial class ConnectionStringDictionary : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionStringDictionary class.
        /// </summary>
        public ConnectionStringDictionary() { }

        /// <summary>
        /// Initializes a new instance of the ConnectionStringDictionary class.
        /// </summary>
        public ConnectionStringDictionary(IDictionary<string, ConnStringValueTypePair> properties = default(IDictionary<string, ConnStringValueTypePair>))
        {
            Properties = properties;
        }

        /// <summary>
        /// Connection strings
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, ConnStringValueTypePair> Properties { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
            if (this.Properties != null)
            {
                foreach (var valueElement in this.Properties.Values)
                {
                    if (valueElement != null)
                    {
                        valueElement.Validate();
                    }
                }
            }
        }
    }
}
