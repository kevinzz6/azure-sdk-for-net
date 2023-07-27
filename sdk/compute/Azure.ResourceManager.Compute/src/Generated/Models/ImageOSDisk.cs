// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes an Operating System disk. </summary>
    public partial class ImageOSDisk : ImageDisk
    {
        /// <summary> Initializes a new instance of ImageOSDisk. </summary>
        /// <param name="osType"> This property allows you to specify the type of the OS that is included in the disk if creating a VM from a custom image. Possible values are: **Windows,** **Linux.**. </param>
        /// <param name="osState"> The OS State. For managed images, use Generalized. </param>
        public ImageOSDisk(SupportedOperatingSystemType osType, OperatingSystemStateType osState)
        {
            OSType = osType;
            OSState = osState;
        }

        /// <summary> Initializes a new instance of ImageOSDisk. </summary>
        /// <param name="snapshot"> The snapshot. </param>
        /// <param name="managedDisk"> The managedDisk. </param>
        /// <param name="blobUri"> The Virtual Hard Disk. </param>
        /// <param name="caching"> Specifies the caching requirements. Possible values are: **None,** **ReadOnly,** **ReadWrite.** The default values are: **None for Standard storage. ReadOnly for Premium storage.**. </param>
        /// <param name="diskSizeGB"> Specifies the size of empty data disks in gigabytes. This element can be used to overwrite the name of the disk in a virtual machine image. This value cannot be larger than 1023 GB. </param>
        /// <param name="storageAccountType"> Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with data disks, it cannot be used with OS Disk. </param>
        /// <param name="diskEncryptionSet"> Specifies the customer managed disk encryption set resource id for the managed image disk. </param>
        /// <param name="osType"> This property allows you to specify the type of the OS that is included in the disk if creating a VM from a custom image. Possible values are: **Windows,** **Linux.**. </param>
        /// <param name="osState"> The OS State. For managed images, use Generalized. </param>
        internal ImageOSDisk(WritableSubResource snapshot, WritableSubResource managedDisk, Uri blobUri, CachingType? caching, int? diskSizeGB, StorageAccountType? storageAccountType, WritableSubResource diskEncryptionSet, SupportedOperatingSystemType osType, OperatingSystemStateType osState) : base(snapshot, managedDisk, blobUri, caching, diskSizeGB, storageAccountType, diskEncryptionSet)
        {
            OSType = osType;
            OSState = osState;
        }

        /// <summary> This property allows you to specify the type of the OS that is included in the disk if creating a VM from a custom image. Possible values are: **Windows,** **Linux.**. </summary>
        public SupportedOperatingSystemType OSType { get; set; }
        /// <summary> The OS State. For managed images, use Generalized. </summary>
        public OperatingSystemStateType OSState { get; set; }
    }
}
