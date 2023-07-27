// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MarketplaceOrdering
{
    /// <summary>
    /// A class representing the MarketplaceAgreementTerm data model.
    /// Terms properties for provided Publisher/Offer/Plan tuple
    /// </summary>
    public partial class MarketplaceAgreementTermData : ResourceData
    {
        /// <summary> Initializes a new instance of MarketplaceAgreementTermData. </summary>
        public MarketplaceAgreementTermData()
        {
        }

        /// <summary> Initializes a new instance of MarketplaceAgreementTermData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="publisher"> Publisher identifier string of image being deployed. </param>
        /// <param name="product"> Offer identifier string of image being deployed. </param>
        /// <param name="plan"> Plan identifier string of image being deployed. </param>
        /// <param name="licenseTextLink"> Link to HTML with Microsoft and Publisher terms. </param>
        /// <param name="privacyPolicyLink"> Link to the privacy policy of the publisher. </param>
        /// <param name="marketplaceTermsLink"> Link to HTML with Azure Marketplace terms. </param>
        /// <param name="retrievedOn"> Date and time in UTC of when the terms were accepted. This is empty if Accepted is false. </param>
        /// <param name="signature"> Terms signature. </param>
        /// <param name="isAccepted"> If any version of the terms have been accepted, otherwise false. </param>
        internal MarketplaceAgreementTermData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string publisher, string product, string plan, Uri licenseTextLink, Uri privacyPolicyLink, Uri marketplaceTermsLink, DateTimeOffset? retrievedOn, string signature, bool? isAccepted) : base(id, name, resourceType, systemData)
        {
            Publisher = publisher;
            Product = product;
            Plan = plan;
            LicenseTextLink = licenseTextLink;
            PrivacyPolicyLink = privacyPolicyLink;
            MarketplaceTermsLink = marketplaceTermsLink;
            RetrievedOn = retrievedOn;
            Signature = signature;
            IsAccepted = isAccepted;
        }

        /// <summary> Publisher identifier string of image being deployed. </summary>
        public string Publisher { get; set; }
        /// <summary> Offer identifier string of image being deployed. </summary>
        public string Product { get; set; }
        /// <summary> Plan identifier string of image being deployed. </summary>
        public string Plan { get; set; }
        /// <summary> Link to HTML with Microsoft and Publisher terms. </summary>
        public Uri LicenseTextLink { get; set; }
        /// <summary> Link to the privacy policy of the publisher. </summary>
        public Uri PrivacyPolicyLink { get; set; }
        /// <summary> Link to HTML with Azure Marketplace terms. </summary>
        public Uri MarketplaceTermsLink { get; set; }
        /// <summary> Date and time in UTC of when the terms were accepted. This is empty if Accepted is false. </summary>
        public DateTimeOffset? RetrievedOn { get; set; }
        /// <summary> Terms signature. </summary>
        public string Signature { get; set; }
        /// <summary> If any version of the terms have been accepted, otherwise false. </summary>
        public bool? IsAccepted { get; set; }
    }
}
