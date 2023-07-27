// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.DataShare.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare
{
    /// <summary>
    /// A class representing the ProviderShareSubscription data model.
    /// A provider side share subscription data transfer object.
    /// </summary>
    public partial class ProviderShareSubscriptionData : ResourceData
    {
        /// <summary> Initializes a new instance of ProviderShareSubscriptionData. </summary>
        public ProviderShareSubscriptionData()
        {
        }

        /// <summary> Initializes a new instance of ProviderShareSubscriptionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="consumerEmail"> Email of the consumer who created the share subscription. </param>
        /// <param name="consumerName"> Name of the consumer who created the share subscription. </param>
        /// <param name="consumerTenantName"> Tenant name of the consumer who created the share subscription. </param>
        /// <param name="createdOn"> created at. </param>
        /// <param name="expireOn"> Expiration date of the share subscription in UTC format. </param>
        /// <param name="providerEmail"> Email of the provider who created the share. </param>
        /// <param name="providerName"> Name of the provider who created the share. </param>
        /// <param name="sharedOn"> Shared at. </param>
        /// <param name="shareSubscriptionObjectId"> share Subscription Object Id. </param>
        /// <param name="shareSubscriptionStatus"> Gets the status of share subscription. </param>
        internal ProviderShareSubscriptionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string consumerEmail, string consumerName, string consumerTenantName, DateTimeOffset? createdOn, DateTimeOffset? expireOn, string providerEmail, string providerName, DateTimeOffset? sharedOn, string shareSubscriptionObjectId, ShareSubscriptionStatus? shareSubscriptionStatus) : base(id, name, resourceType, systemData)
        {
            ConsumerEmail = consumerEmail;
            ConsumerName = consumerName;
            ConsumerTenantName = consumerTenantName;
            CreatedOn = createdOn;
            ExpireOn = expireOn;
            ProviderEmail = providerEmail;
            ProviderName = providerName;
            SharedOn = sharedOn;
            ShareSubscriptionObjectId = shareSubscriptionObjectId;
            ShareSubscriptionStatus = shareSubscriptionStatus;
        }

        /// <summary> Email of the consumer who created the share subscription. </summary>
        public string ConsumerEmail { get; }
        /// <summary> Name of the consumer who created the share subscription. </summary>
        public string ConsumerName { get; }
        /// <summary> Tenant name of the consumer who created the share subscription. </summary>
        public string ConsumerTenantName { get; }
        /// <summary> created at. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Expiration date of the share subscription in UTC format. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
        /// <summary> Email of the provider who created the share. </summary>
        public string ProviderEmail { get; }
        /// <summary> Name of the provider who created the share. </summary>
        public string ProviderName { get; }
        /// <summary> Shared at. </summary>
        public DateTimeOffset? SharedOn { get; }
        /// <summary> share Subscription Object Id. </summary>
        public string ShareSubscriptionObjectId { get; }
        /// <summary> Gets the status of share subscription. </summary>
        public ShareSubscriptionStatus? ShareSubscriptionStatus { get; }
    }
}
