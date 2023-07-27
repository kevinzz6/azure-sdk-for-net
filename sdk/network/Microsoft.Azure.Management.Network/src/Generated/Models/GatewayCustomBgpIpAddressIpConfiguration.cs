// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// GatewayCustomBgpIpAddressIpConfiguration for a virtual network gateway
    /// connection.
    /// </summary>
    public partial class GatewayCustomBgpIpAddressIpConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// GatewayCustomBgpIpAddressIpConfiguration class.
        /// </summary>
        public GatewayCustomBgpIpAddressIpConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// GatewayCustomBgpIpAddressIpConfiguration class.
        /// </summary>
        /// <param name="ipConfigurationId">The IpconfigurationId of
        /// ipconfiguration which belongs to gateway.</param>
        /// <param name="customBgpIpAddress">The custom BgpPeeringAddress which
        /// belongs to IpconfigurationId.</param>
        public GatewayCustomBgpIpAddressIpConfiguration(string ipConfigurationId, string customBgpIpAddress)
        {
            IpConfigurationId = ipConfigurationId;
            CustomBgpIpAddress = customBgpIpAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the IpconfigurationId of ipconfiguration which belongs
        /// to gateway.
        /// </summary>
        [JsonProperty(PropertyName = "ipConfigurationId")]
        public string IpConfigurationId { get; set; }

        /// <summary>
        /// Gets or sets the custom BgpPeeringAddress which belongs to
        /// IpconfigurationId.
        /// </summary>
        [JsonProperty(PropertyName = "customBgpIpAddress")]
        public string CustomBgpIpAddress { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (IpConfigurationId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "IpConfigurationId");
            }
            if (CustomBgpIpAddress == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CustomBgpIpAddress");
            }
        }
    }
}
