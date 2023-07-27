// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> The base virtual machine configuration for a lab. </summary>
    public partial class LabVirtualMachineProfile
    {
        /// <summary> Initializes a new instance of LabVirtualMachineProfile. </summary>
        /// <param name="createOption"> Indicates what lab virtual machines are created from. </param>
        /// <param name="imageReference"> The image configuration for lab virtual machines. </param>
        /// <param name="sku"> The SKU for the lab. Defines the type of virtual machines used in the lab. </param>
        /// <param name="usageQuota"> The initial quota alloted to each lab user. Must be a time span between 0 and 9999 hours. </param>
        /// <param name="adminUser"> Credentials for the admin user on the VM. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="imageReference"/>, <paramref name="sku"/> or <paramref name="adminUser"/> is null. </exception>
        public LabVirtualMachineProfile(LabVirtualMachineCreateOption createOption, LabVirtualMachineImageReference imageReference, LabServicesSku sku, TimeSpan usageQuota, LabVirtualMachineCredential adminUser)
        {
            Argument.AssertNotNull(imageReference, nameof(imageReference));
            Argument.AssertNotNull(sku, nameof(sku));
            Argument.AssertNotNull(adminUser, nameof(adminUser));

            CreateOption = createOption;
            ImageReference = imageReference;
            Sku = sku;
            UsageQuota = usageQuota;
            AdminUser = adminUser;
        }

        /// <summary> Initializes a new instance of LabVirtualMachineProfile. </summary>
        /// <param name="createOption"> Indicates what lab virtual machines are created from. </param>
        /// <param name="imageReference"> The image configuration for lab virtual machines. </param>
        /// <param name="osType"> The OS type of the image. </param>
        /// <param name="sku"> The SKU for the lab. Defines the type of virtual machines used in the lab. </param>
        /// <param name="additionalCapabilities"> Additional VM capabilities. </param>
        /// <param name="usageQuota"> The initial quota alloted to each lab user. Must be a time span between 0 and 9999 hours. </param>
        /// <param name="useSharedPassword"> Enabling this option will use the same password for all user VMs. </param>
        /// <param name="adminUser"> Credentials for the admin user on the VM. </param>
        /// <param name="nonAdminUser"> Credentials for the non-admin user on the VM, if one exists. </param>
        internal LabVirtualMachineProfile(LabVirtualMachineCreateOption createOption, LabVirtualMachineImageReference imageReference, LabVirtualMachineImageOSType? osType, LabServicesSku sku, LabVirtualMachineAdditionalCapability additionalCapabilities, TimeSpan usageQuota, LabServicesEnableState? useSharedPassword, LabVirtualMachineCredential adminUser, LabVirtualMachineCredential nonAdminUser)
        {
            CreateOption = createOption;
            ImageReference = imageReference;
            OSType = osType;
            Sku = sku;
            AdditionalCapabilities = additionalCapabilities;
            UsageQuota = usageQuota;
            UseSharedPassword = useSharedPassword;
            AdminUser = adminUser;
            NonAdminUser = nonAdminUser;
        }

        /// <summary> Indicates what lab virtual machines are created from. </summary>
        public LabVirtualMachineCreateOption CreateOption { get; set; }
        /// <summary> The image configuration for lab virtual machines. </summary>
        public LabVirtualMachineImageReference ImageReference { get; set; }
        /// <summary> The OS type of the image. </summary>
        public LabVirtualMachineImageOSType? OSType { get; }
        /// <summary> The SKU for the lab. Defines the type of virtual machines used in the lab. </summary>
        public LabServicesSku Sku { get; set; }
        /// <summary> Additional VM capabilities. </summary>
        internal LabVirtualMachineAdditionalCapability AdditionalCapabilities { get; set; }
        /// <summary> Flag to pre-install dedicated GPU drivers. </summary>
        public LabServicesEnableState? AdditionalCapabilitiesInstallGpuDrivers
        {
            get => AdditionalCapabilities is null ? default : AdditionalCapabilities.InstallGpuDrivers;
            set
            {
                if (AdditionalCapabilities is null)
                    AdditionalCapabilities = new LabVirtualMachineAdditionalCapability();
                AdditionalCapabilities.InstallGpuDrivers = value;
            }
        }

        /// <summary> The initial quota alloted to each lab user. Must be a time span between 0 and 9999 hours. </summary>
        public TimeSpan UsageQuota { get; set; }
        /// <summary> Enabling this option will use the same password for all user VMs. </summary>
        public LabServicesEnableState? UseSharedPassword { get; set; }
        /// <summary> Credentials for the admin user on the VM. </summary>
        public LabVirtualMachineCredential AdminUser { get; set; }
        /// <summary> Credentials for the non-admin user on the VM, if one exists. </summary>
        public LabVirtualMachineCredential NonAdminUser { get; set; }
    }
}
