// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Represents applicable recovery vm sizes properties. </summary>
    public partial class TargetComputeSizeProperties
    {
        /// <summary> Initializes a new instance of TargetComputeSizeProperties. </summary>
        internal TargetComputeSizeProperties()
        {
            Errors = new ChangeTrackingList<SiteRecoveryComputeSizeErrorDetails>();
            HyperVGenerations = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of TargetComputeSizeProperties. </summary>
        /// <param name="name"> Target compute size name. </param>
        /// <param name="friendlyName"> Target compute size display name. </param>
        /// <param name="cpuCoresCount"> The maximum cpu cores count supported by target compute size. </param>
        /// <param name="vCpusAvailable"> The Available vCPUs supported by target compute size. </param>
        /// <param name="memoryInGB"> The maximum memory in GB supported by target compute size. </param>
        /// <param name="maxDataDiskCount"> The maximum data disks count supported by target compute size. </param>
        /// <param name="maxNicsCount"> The maximum Nics count supported by target compute size. </param>
        /// <param name="errors"> The reasons why the target compute size is not applicable for the protected item. </param>
        /// <param name="highIopsSupported"> The value indicating whether the target compute size supports high Iops. </param>
        /// <param name="hyperVGenerations"> The supported HyperV Generations. </param>
        internal TargetComputeSizeProperties(string name, string friendlyName, int? cpuCoresCount, int? vCpusAvailable, double? memoryInGB, int? maxDataDiskCount, int? maxNicsCount, IReadOnlyList<SiteRecoveryComputeSizeErrorDetails> errors, string highIopsSupported, IReadOnlyList<string> hyperVGenerations)
        {
            Name = name;
            FriendlyName = friendlyName;
            CpuCoresCount = cpuCoresCount;
            VCpusAvailable = vCpusAvailable;
            MemoryInGB = memoryInGB;
            MaxDataDiskCount = maxDataDiskCount;
            MaxNicsCount = maxNicsCount;
            Errors = errors;
            HighIopsSupported = highIopsSupported;
            HyperVGenerations = hyperVGenerations;
        }

        /// <summary> Target compute size name. </summary>
        public string Name { get; }
        /// <summary> Target compute size display name. </summary>
        public string FriendlyName { get; }
        /// <summary> The maximum cpu cores count supported by target compute size. </summary>
        public int? CpuCoresCount { get; }
        /// <summary> The Available vCPUs supported by target compute size. </summary>
        public int? VCpusAvailable { get; }
        /// <summary> The maximum memory in GB supported by target compute size. </summary>
        public double? MemoryInGB { get; }
        /// <summary> The maximum data disks count supported by target compute size. </summary>
        public int? MaxDataDiskCount { get; }
        /// <summary> The maximum Nics count supported by target compute size. </summary>
        public int? MaxNicsCount { get; }
        /// <summary> The reasons why the target compute size is not applicable for the protected item. </summary>
        public IReadOnlyList<SiteRecoveryComputeSizeErrorDetails> Errors { get; }
        /// <summary> The value indicating whether the target compute size supports high Iops. </summary>
        public string HighIopsSupported { get; }
        /// <summary> The supported HyperV Generations. </summary>
        public IReadOnlyList<string> HyperVGenerations { get; }
    }
}
