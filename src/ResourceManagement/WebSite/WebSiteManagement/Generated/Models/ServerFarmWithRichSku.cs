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
    /// App Service Plan Model
    /// </summary>
    public partial class ServerFarmWithRichSku : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ServerFarmWithRichSku class.
        /// </summary>
        public ServerFarmWithRichSku() { }

        /// <summary>
        /// Initializes a new instance of the ServerFarmWithRichSku class.
        /// </summary>
        public ServerFarmWithRichSku(SkuDescription sku = default(SkuDescription), string serverFarmWithRichSkuName = default(string), StatusOptions? status = default(StatusOptions?), string subscription = default(string), string adminSiteName = default(string), HostingEnvironmentProfile hostingEnvironmentProfile = default(HostingEnvironmentProfile), int? maximumNumberOfWorkers = default(int?), string geoRegion = default(string), bool? perSiteScaling = default(bool?), int? numberOfSites = default(int?), string resourceGroup = default(string))
        {
            Sku = sku;
            ServerFarmWithRichSkuName = serverFarmWithRichSkuName;
            Status = status;
            Subscription = subscription;
            AdminSiteName = adminSiteName;
            HostingEnvironmentProfile = hostingEnvironmentProfile;
            MaximumNumberOfWorkers = maximumNumberOfWorkers;
            GeoRegion = geoRegion;
            PerSiteScaling = perSiteScaling;
            NumberOfSites = numberOfSites;
            ResourceGroup = resourceGroup;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public SkuDescription Sku { get; set; }

        /// <summary>
        /// Name for the App Service Plan
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string ServerFarmWithRichSkuName { get; set; }

        /// <summary>
        /// App Service Plan Status. Possible values for this property
        /// include: 'Ready', 'Pending'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public StatusOptions? Status { get; private set; }

        /// <summary>
        /// App Service Plan Subscription
        /// </summary>
        [JsonProperty(PropertyName = "properties.subscription")]
        public string Subscription { get; private set; }

        /// <summary>
        /// App Service Plan administration site
        /// </summary>
        [JsonProperty(PropertyName = "properties.adminSiteName")]
        public string AdminSiteName { get; set; }

        /// <summary>
        /// Specification for the hosting environment (App Service
        /// Environment) to use for the App Service Plan
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostingEnvironmentProfile")]
        public HostingEnvironmentProfile HostingEnvironmentProfile { get; set; }

        /// <summary>
        /// Maximum number of instances that can be assigned to this App
        /// Service Plan
        /// </summary>
        [JsonProperty(PropertyName = "properties.maximumNumberOfWorkers")]
        public int? MaximumNumberOfWorkers { get; set; }

        /// <summary>
        /// Geographical location for the App Service Plan
        /// </summary>
        [JsonProperty(PropertyName = "properties.geoRegion")]
        public string GeoRegion { get; private set; }

        /// <summary>
        /// If True apps assigned to this App Service Plan can be scaled
        /// independently
        /// If False apps assigned to this App Service Plan will
        /// scale to all instances of the plan
        /// </summary>
        [JsonProperty(PropertyName = "properties.perSiteScaling")]
        public bool? PerSiteScaling { get; set; }

        /// <summary>
        /// Number of web apps assigned to this App Service Plan
        /// </summary>
        [JsonProperty(PropertyName = "properties.numberOfSites")]
        public int? NumberOfSites { get; private set; }

        /// <summary>
        /// Resource group of the serverfarm
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGroup")]
        public string ResourceGroup { get; private set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
