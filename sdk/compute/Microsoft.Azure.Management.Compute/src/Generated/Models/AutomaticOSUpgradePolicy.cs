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
    /// The configuration parameters used for performing automatic OS upgrade.
    /// </summary>
    public partial class AutomaticOSUpgradePolicy
    {
        /// <summary>
        /// Initializes a new instance of the AutomaticOSUpgradePolicy class.
        /// </summary>
        public AutomaticOSUpgradePolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutomaticOSUpgradePolicy class.
        /// </summary>
        /// <param name="enableAutomaticOSUpgrade">Indicates whether OS
        /// upgrades should automatically be applied to scale set instances in
        /// a rolling fashion when a newer version of the OS image becomes
        /// available. Default value is false. If this is set to true for
        /// Windows based scale sets,
        /// [enableAutomaticUpdates](https://docs.microsoft.com/dotnet/api/microsoft.azure.management.compute.models.windowsconfiguration.enableautomaticupdates?view=azure-dotnet)
        /// is automatically set to false and cannot be set to true.</param>
        /// <param name="disableAutomaticRollback">Whether OS image rollback
        /// feature should be disabled. Default value is false.</param>
        /// <param name="useRollingUpgradePolicy">Indicates whether rolling
        /// upgrade policy should be used during Auto OS Upgrade. Default value
        /// is false. Auto OS Upgrade will fallback to the default policy if no
        /// policy is defined on the VMSS.</param>
        public AutomaticOSUpgradePolicy(bool? enableAutomaticOSUpgrade = default(bool?), bool? disableAutomaticRollback = default(bool?), bool? useRollingUpgradePolicy = default(bool?))
        {
            EnableAutomaticOSUpgrade = enableAutomaticOSUpgrade;
            DisableAutomaticRollback = disableAutomaticRollback;
            UseRollingUpgradePolicy = useRollingUpgradePolicy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates whether OS upgrades should automatically be
        /// applied to scale set instances in a rolling fashion when a newer
        /// version of the OS image becomes available. Default value is false.
        /// If this is set to true for Windows based scale sets,
        /// [enableAutomaticUpdates](https://docs.microsoft.com/dotnet/api/microsoft.azure.management.compute.models.windowsconfiguration.enableautomaticupdates?view=azure-dotnet)
        /// is automatically set to false and cannot be set to true.
        /// </summary>
        [JsonProperty(PropertyName = "enableAutomaticOSUpgrade")]
        public bool? EnableAutomaticOSUpgrade { get; set; }

        /// <summary>
        /// Gets or sets whether OS image rollback feature should be disabled.
        /// Default value is false.
        /// </summary>
        [JsonProperty(PropertyName = "disableAutomaticRollback")]
        public bool? DisableAutomaticRollback { get; set; }

        /// <summary>
        /// Gets or sets indicates whether rolling upgrade policy should be
        /// used during Auto OS Upgrade. Default value is false. Auto OS
        /// Upgrade will fallback to the default policy if no policy is defined
        /// on the VMSS.
        /// </summary>
        [JsonProperty(PropertyName = "useRollingUpgradePolicy")]
        public bool? UseRollingUpgradePolicy { get; set; }

    }
}
