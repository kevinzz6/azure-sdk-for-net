// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Workloads.Models;

namespace Azure.ResourceManager.Workloads
{
    /// <summary>
    /// A class representing the SapApplicationServerInstance data model.
    /// Define the SAP Application Server Instance resource.
    /// </summary>
    public partial class SapApplicationServerInstanceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of SapApplicationServerInstanceData. </summary>
        /// <param name="location"> The location. </param>
        public SapApplicationServerInstanceData(AzureLocation location) : base(location)
        {
            VmDetails = new ChangeTrackingList<ApplicationServerVmDetails>();
        }

        /// <summary> Initializes a new instance of SapApplicationServerInstanceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="instanceNo"> Application server Instance Number. </param>
        /// <param name="subnetId"> Application server Subnet. </param>
        /// <param name="hostname"> Application server instance SAP hostname. </param>
        /// <param name="kernelVersion"> Application server instance SAP Kernel Version. </param>
        /// <param name="kernelPatch"> Application server instance SAP Kernel Patch level. </param>
        /// <param name="ipAddress"> Application server instance SAP IP Address. </param>
        /// <param name="gatewayPort"> Application server instance gateway Port. </param>
        /// <param name="icmHttpPort"> Application server instance ICM HTTP Port. </param>
        /// <param name="icmHttpsPort"> Application server instance ICM HTTPS Port. </param>
        /// <param name="loadBalancerDetails"> The Load Balancer details such as LoadBalancer ID attached to Application Server Virtual Machines. </param>
        /// <param name="vmDetails"> The list of virtual machines. </param>
        /// <param name="status"> Defines the SAP Instance status. </param>
        /// <param name="health"> Defines the health of SAP Instances. </param>
        /// <param name="provisioningState"> Defines the provisioning states. </param>
        /// <param name="errors"> Defines the Application Instance errors. </param>
        internal SapApplicationServerInstanceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string instanceNo, ResourceIdentifier subnetId, string hostname, string kernelVersion, string kernelPatch, string ipAddress, long? gatewayPort, long? icmHttpPort, long? icmHttpsPort, SubResource loadBalancerDetails, IReadOnlyList<ApplicationServerVmDetails> vmDetails, SapVirtualInstanceStatus? status, SapHealthState? health, SapVirtualInstanceProvisioningState? provisioningState, SapVirtualInstanceError errors) : base(id, name, resourceType, systemData, tags, location)
        {
            InstanceNo = instanceNo;
            SubnetId = subnetId;
            Hostname = hostname;
            KernelVersion = kernelVersion;
            KernelPatch = kernelPatch;
            IPAddress = ipAddress;
            GatewayPort = gatewayPort;
            IcmHttpPort = icmHttpPort;
            IcmHttpsPort = icmHttpsPort;
            LoadBalancerDetails = loadBalancerDetails;
            VmDetails = vmDetails;
            Status = status;
            Health = health;
            ProvisioningState = provisioningState;
            Errors = errors;
        }

        /// <summary> Application server Instance Number. </summary>
        public string InstanceNo { get; }
        /// <summary> Application server Subnet. </summary>
        public ResourceIdentifier SubnetId { get; }
        /// <summary> Application server instance SAP hostname. </summary>
        public string Hostname { get; }
        /// <summary> Application server instance SAP Kernel Version. </summary>
        public string KernelVersion { get; }
        /// <summary> Application server instance SAP Kernel Patch level. </summary>
        public string KernelPatch { get; }
        /// <summary> Application server instance SAP IP Address. </summary>
        public string IPAddress { get; }
        /// <summary> Application server instance gateway Port. </summary>
        public long? GatewayPort { get; }
        /// <summary> Application server instance ICM HTTP Port. </summary>
        public long? IcmHttpPort { get; }
        /// <summary> Application server instance ICM HTTPS Port. </summary>
        public long? IcmHttpsPort { get; }
        /// <summary> The Load Balancer details such as LoadBalancer ID attached to Application Server Virtual Machines. </summary>
        internal SubResource LoadBalancerDetails { get; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier LoadBalancerDetailsId
        {
            get => LoadBalancerDetails?.Id;
        }

        /// <summary> The list of virtual machines. </summary>
        public IReadOnlyList<ApplicationServerVmDetails> VmDetails { get; }
        /// <summary> Defines the SAP Instance status. </summary>
        public SapVirtualInstanceStatus? Status { get; }
        /// <summary> Defines the health of SAP Instances. </summary>
        public SapHealthState? Health { get; }
        /// <summary> Defines the provisioning states. </summary>
        public SapVirtualInstanceProvisioningState? ProvisioningState { get; }
        /// <summary> Defines the Application Instance errors. </summary>
        internal SapVirtualInstanceError Errors { get; }
        /// <summary> The Virtual Instance for SAP error body. </summary>
        public SapVirtualInstanceErrorDetail ErrorsProperties
        {
            get => Errors?.Properties;
        }
    }
}
