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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies information about the capacity reservation.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CapacityReservation : Resource
    {
        /// <summary>
        /// Initializes a new instance of the CapacityReservation class.
        /// </summary>
        public CapacityReservation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CapacityReservation class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="sku">SKU of the resource for which capacity needs be
        /// reserved. The SKU name and capacity is required to be set.
        /// Currently VM Skus with the capability called
        /// 'CapacityReservationSupported' set to true are supported. Refer to
        /// List Microsoft.Compute SKUs in a region
        /// (https://docs.microsoft.com/rest/api/compute/resourceskus/list) for
        /// supported values.</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="reservationId">A unique id generated and assigned to
        /// the capacity reservation by the platform which does not change
        /// throughout the lifetime of the resource.</param>
        /// <param name="platformFaultDomainCount">Specifies the value of fault
        /// domain count that Capacity Reservation supports for requested VM
        /// size. **Note:** The fault domain count specified for a resource
        /// (like virtual machines scale set) must be less than or equal to
        /// this value if it deploys using capacity reservation. Minimum
        /// api-version: 2022-08-01.</param>
        /// <param name="virtualMachinesAssociated">A list of all virtual
        /// machine resource ids that are associated with the capacity
        /// reservation.</param>
        /// <param name="provisioningTime">The date time when the capacity
        /// reservation was last updated.</param>
        /// <param name="provisioningState">The provisioning state, which only
        /// appears in the response.</param>
        /// <param name="instanceView">The Capacity reservation instance
        /// view.</param>
        /// <param name="timeCreated">Specifies the time at which the Capacity
        /// Reservation resource was created. Minimum api-version:
        /// 2021-11-01.</param>
        /// <param name="zones">Availability Zone to use for this capacity
        /// reservation. The zone has to be single value and also should be
        /// part for the list of zones specified during the capacity
        /// reservation group creation. The zone can be assigned only during
        /// creation. If not provided, the reservation supports only non-zonal
        /// deployments. If provided, enforces VM/VMSS using this capacity
        /// reservation to be in same zone.</param>
        public CapacityReservation(string location, Sku sku, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string reservationId = default(string), int? platformFaultDomainCount = default(int?), IList<SubResourceReadOnly> virtualMachinesAssociated = default(IList<SubResourceReadOnly>), System.DateTime? provisioningTime = default(System.DateTime?), string provisioningState = default(string), CapacityReservationInstanceView instanceView = default(CapacityReservationInstanceView), System.DateTime? timeCreated = default(System.DateTime?), IList<string> zones = default(IList<string>))
            : base(location, id, name, type, tags)
        {
            ReservationId = reservationId;
            PlatformFaultDomainCount = platformFaultDomainCount;
            VirtualMachinesAssociated = virtualMachinesAssociated;
            ProvisioningTime = provisioningTime;
            ProvisioningState = provisioningState;
            InstanceView = instanceView;
            TimeCreated = timeCreated;
            Sku = sku;
            Zones = zones;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets a unique id generated and assigned to the capacity reservation
        /// by the platform which does not change throughout the lifetime of
        /// the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.reservationId")]
        public string ReservationId { get; private set; }

        /// <summary>
        /// Gets specifies the value of fault domain count that Capacity
        /// Reservation supports for requested VM size. **Note:** The fault
        /// domain count specified for a resource (like virtual machines scale
        /// set) must be less than or equal to this value if it deploys using
        /// capacity reservation. Minimum api-version: 2022-08-01.
        /// </summary>
        [JsonProperty(PropertyName = "properties.platformFaultDomainCount")]
        public int? PlatformFaultDomainCount { get; private set; }

        /// <summary>
        /// Gets a list of all virtual machine resource ids that are associated
        /// with the capacity reservation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualMachinesAssociated")]
        public IList<SubResourceReadOnly> VirtualMachinesAssociated { get; private set; }

        /// <summary>
        /// Gets the date time when the capacity reservation was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningTime")]
        public System.DateTime? ProvisioningTime { get; private set; }

        /// <summary>
        /// Gets the provisioning state, which only appears in the response.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the Capacity reservation instance view.
        /// </summary>
        [JsonProperty(PropertyName = "properties.instanceView")]
        public CapacityReservationInstanceView InstanceView { get; private set; }

        /// <summary>
        /// Gets specifies the time at which the Capacity Reservation resource
        /// was created. Minimum api-version: 2021-11-01.
        /// </summary>
        [JsonProperty(PropertyName = "properties.timeCreated")]
        public System.DateTime? TimeCreated { get; private set; }

        /// <summary>
        /// Gets or sets SKU of the resource for which capacity needs be
        /// reserved. The SKU name and capacity is required to be set.
        /// Currently VM Skus with the capability called
        /// 'CapacityReservationSupported' set to true are supported. Refer to
        /// List Microsoft.Compute SKUs in a region
        /// (https://docs.microsoft.com/rest/api/compute/resourceskus/list) for
        /// supported values.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets availability Zone to use for this capacity
        /// reservation. The zone has to be single value and also should be
        /// part for the list of zones specified during the capacity
        /// reservation group creation. The zone can be assigned only during
        /// creation. If not provided, the reservation supports only non-zonal
        /// deployments. If provided, enforces VM/VMSS using this capacity
        /// reservation to be in same zone.
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public IList<string> Zones { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Sku == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sku");
            }
        }
    }
}
