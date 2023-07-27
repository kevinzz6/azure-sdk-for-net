// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing the StaticSiteCustomDomainOverview data model.
    /// Static Site Custom Domain Overview ARM resource.
    /// </summary>
    public partial class StaticSiteCustomDomainOverviewData : ResourceData
    {
        /// <summary> Initializes a new instance of StaticSiteCustomDomainOverviewData. </summary>
        public StaticSiteCustomDomainOverviewData()
        {
        }

        /// <summary> Initializes a new instance of StaticSiteCustomDomainOverviewData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="domainName"> The domain name for the static site custom domain. </param>
        /// <param name="createdOn"> The date and time on which the custom domain was created for the static site. </param>
        /// <param name="status"> The status of the custom domain. </param>
        /// <param name="validationToken"> The TXT record validation token. </param>
        /// <param name="errorMessage"></param>
        /// <param name="kind"> Kind of resource. </param>
        internal StaticSiteCustomDomainOverviewData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string domainName, DateTimeOffset? createdOn, CustomDomainStatus? status, string validationToken, string errorMessage, string kind) : base(id, name, resourceType, systemData)
        {
            DomainName = domainName;
            CreatedOn = createdOn;
            Status = status;
            ValidationToken = validationToken;
            ErrorMessage = errorMessage;
            Kind = kind;
        }

        /// <summary> The domain name for the static site custom domain. </summary>
        public string DomainName { get; }
        /// <summary> The date and time on which the custom domain was created for the static site. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The status of the custom domain. </summary>
        public CustomDomainStatus? Status { get; }
        /// <summary> The TXT record validation token. </summary>
        public string ValidationToken { get; }
        /// <summary> Gets the error message. </summary>
        public string ErrorMessage { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
