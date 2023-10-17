// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.BillingBenefits.Mocking;
using Azure.ResourceManager.BillingBenefits.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.BillingBenefits
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.BillingBenefits. </summary>
    public static partial class BillingBenefitsExtensions
    {
        private static BillingBenefitsArmClientMockingExtension GetBillingBenefitsArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client0 => new BillingBenefitsArmClientMockingExtension(client0));
        }

        private static BillingBenefitsTenantMockingExtension GetBillingBenefitsTenantMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client => new BillingBenefitsTenantMockingExtension(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="BillingBenefitsSavingsPlanOrderAliasResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BillingBenefitsSavingsPlanOrderAliasResource.CreateResourceIdentifier" /> to create a <see cref="BillingBenefitsSavingsPlanOrderAliasResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="BillingBenefitsArmClientMockingExtension.GetBillingBenefitsSavingsPlanOrderAliasResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BillingBenefitsSavingsPlanOrderAliasResource" /> object. </returns>
        public static BillingBenefitsSavingsPlanOrderAliasResource GetBillingBenefitsSavingsPlanOrderAliasResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetBillingBenefitsArmClientMockingExtension(client).GetBillingBenefitsSavingsPlanOrderAliasResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="BillingBenefitsSavingsPlanOrderResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BillingBenefitsSavingsPlanOrderResource.CreateResourceIdentifier" /> to create a <see cref="BillingBenefitsSavingsPlanOrderResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="BillingBenefitsArmClientMockingExtension.GetBillingBenefitsSavingsPlanOrderResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BillingBenefitsSavingsPlanOrderResource" /> object. </returns>
        public static BillingBenefitsSavingsPlanOrderResource GetBillingBenefitsSavingsPlanOrderResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetBillingBenefitsArmClientMockingExtension(client).GetBillingBenefitsSavingsPlanOrderResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="BillingBenefitsSavingsPlanResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BillingBenefitsSavingsPlanResource.CreateResourceIdentifier" /> to create a <see cref="BillingBenefitsSavingsPlanResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="BillingBenefitsArmClientMockingExtension.GetBillingBenefitsSavingsPlanResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BillingBenefitsSavingsPlanResource" /> object. </returns>
        public static BillingBenefitsSavingsPlanResource GetBillingBenefitsSavingsPlanResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetBillingBenefitsArmClientMockingExtension(client).GetBillingBenefitsSavingsPlanResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="BillingBenefitsReservationOrderAliasResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BillingBenefitsReservationOrderAliasResource.CreateResourceIdentifier" /> to create a <see cref="BillingBenefitsReservationOrderAliasResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="BillingBenefitsArmClientMockingExtension.GetBillingBenefitsReservationOrderAliasResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BillingBenefitsReservationOrderAliasResource" /> object. </returns>
        public static BillingBenefitsReservationOrderAliasResource GetBillingBenefitsReservationOrderAliasResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetBillingBenefitsArmClientMockingExtension(client).GetBillingBenefitsReservationOrderAliasResource(id);
        }

        /// <summary>
        /// Gets a collection of BillingBenefitsSavingsPlanOrderAliasResources in the TenantResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="BillingBenefitsTenantMockingExtension.GetBillingBenefitsSavingsPlanOrderAliases()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of BillingBenefitsSavingsPlanOrderAliasResources and their operations over a BillingBenefitsSavingsPlanOrderAliasResource. </returns>
        public static BillingBenefitsSavingsPlanOrderAliasCollection GetBillingBenefitsSavingsPlanOrderAliases(this TenantResource tenantResource)
        {
            return GetBillingBenefitsTenantMockingExtension(tenantResource).GetBillingBenefitsSavingsPlanOrderAliases();
        }

        /// <summary>
        /// Get a savings plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlanOrderAliases/{savingsPlanOrderAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlanOrderAlias_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="BillingBenefitsTenantMockingExtension.GetBillingBenefitsSavingsPlanOrderAliasAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="savingsPlanOrderAliasName"> Name of the savings plan order alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="savingsPlanOrderAliasName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="savingsPlanOrderAliasName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<BillingBenefitsSavingsPlanOrderAliasResource>> GetBillingBenefitsSavingsPlanOrderAliasAsync(this TenantResource tenantResource, string savingsPlanOrderAliasName, CancellationToken cancellationToken = default)
        {
            return await GetBillingBenefitsTenantMockingExtension(tenantResource).GetBillingBenefitsSavingsPlanOrderAliasAsync(savingsPlanOrderAliasName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a savings plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlanOrderAliases/{savingsPlanOrderAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlanOrderAlias_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="BillingBenefitsTenantMockingExtension.GetBillingBenefitsSavingsPlanOrderAlias(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="savingsPlanOrderAliasName"> Name of the savings plan order alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="savingsPlanOrderAliasName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="savingsPlanOrderAliasName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<BillingBenefitsSavingsPlanOrderAliasResource> GetBillingBenefitsSavingsPlanOrderAlias(this TenantResource tenantResource, string savingsPlanOrderAliasName, CancellationToken cancellationToken = default)
        {
            return GetBillingBenefitsTenantMockingExtension(tenantResource).GetBillingBenefitsSavingsPlanOrderAlias(savingsPlanOrderAliasName, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of BillingBenefitsSavingsPlanOrderResources in the TenantResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="BillingBenefitsTenantMockingExtension.GetBillingBenefitsSavingsPlanOrders()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of BillingBenefitsSavingsPlanOrderResources and their operations over a BillingBenefitsSavingsPlanOrderResource. </returns>
        public static BillingBenefitsSavingsPlanOrderCollection GetBillingBenefitsSavingsPlanOrders(this TenantResource tenantResource)
        {
            return GetBillingBenefitsTenantMockingExtension(tenantResource).GetBillingBenefitsSavingsPlanOrders();
        }

        /// <summary>
        /// Get a savings plan order.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlanOrders/{savingsPlanOrderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlanOrder_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="BillingBenefitsTenantMockingExtension.GetBillingBenefitsSavingsPlanOrderAsync(string,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="savingsPlanOrderId"> Order ID of the savings plan. </param>
        /// <param name="expand"> May be used to expand the detail information of some properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="savingsPlanOrderId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="savingsPlanOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<BillingBenefitsSavingsPlanOrderResource>> GetBillingBenefitsSavingsPlanOrderAsync(this TenantResource tenantResource, string savingsPlanOrderId, string expand = null, CancellationToken cancellationToken = default)
        {
            return await GetBillingBenefitsTenantMockingExtension(tenantResource).GetBillingBenefitsSavingsPlanOrderAsync(savingsPlanOrderId, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a savings plan order.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlanOrders/{savingsPlanOrderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlanOrder_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="BillingBenefitsTenantMockingExtension.GetBillingBenefitsSavingsPlanOrder(string,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="savingsPlanOrderId"> Order ID of the savings plan. </param>
        /// <param name="expand"> May be used to expand the detail information of some properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="savingsPlanOrderId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="savingsPlanOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<BillingBenefitsSavingsPlanOrderResource> GetBillingBenefitsSavingsPlanOrder(this TenantResource tenantResource, string savingsPlanOrderId, string expand = null, CancellationToken cancellationToken = default)
        {
            return GetBillingBenefitsTenantMockingExtension(tenantResource).GetBillingBenefitsSavingsPlanOrder(savingsPlanOrderId, expand, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of BillingBenefitsReservationOrderAliasResources in the TenantResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="BillingBenefitsTenantMockingExtension.GetBillingBenefitsReservationOrderAliases()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of BillingBenefitsReservationOrderAliasResources and their operations over a BillingBenefitsReservationOrderAliasResource. </returns>
        public static BillingBenefitsReservationOrderAliasCollection GetBillingBenefitsReservationOrderAliases(this TenantResource tenantResource)
        {
            return GetBillingBenefitsTenantMockingExtension(tenantResource).GetBillingBenefitsReservationOrderAliases();
        }

        /// <summary>
        /// Get a reservation order alias.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/reservationOrderAliases/{reservationOrderAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationOrderAlias_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="BillingBenefitsTenantMockingExtension.GetBillingBenefitsReservationOrderAliasAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="reservationOrderAliasName"> Name of the reservation order alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationOrderAliasName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderAliasName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<BillingBenefitsReservationOrderAliasResource>> GetBillingBenefitsReservationOrderAliasAsync(this TenantResource tenantResource, string reservationOrderAliasName, CancellationToken cancellationToken = default)
        {
            return await GetBillingBenefitsTenantMockingExtension(tenantResource).GetBillingBenefitsReservationOrderAliasAsync(reservationOrderAliasName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a reservation order alias.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/reservationOrderAliases/{reservationOrderAliasName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationOrderAlias_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="BillingBenefitsTenantMockingExtension.GetBillingBenefitsReservationOrderAlias(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="reservationOrderAliasName"> Name of the reservation order alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationOrderAliasName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderAliasName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<BillingBenefitsReservationOrderAliasResource> GetBillingBenefitsReservationOrderAlias(this TenantResource tenantResource, string reservationOrderAliasName, CancellationToken cancellationToken = default)
        {
            return GetBillingBenefitsTenantMockingExtension(tenantResource).GetBillingBenefitsReservationOrderAlias(reservationOrderAliasName, cancellationToken);
        }

        /// <summary>
        /// List savings plans.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlan_ListAll</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="BillingBenefitsTenantMockingExtension.GetBillingBenefitsSavingsPlans(TenantResourceGetBillingBenefitsSavingsPlansOptions,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BillingBenefitsSavingsPlanResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<BillingBenefitsSavingsPlanResource> GetBillingBenefitsSavingsPlansAsync(this TenantResource tenantResource, TenantResourceGetBillingBenefitsSavingsPlansOptions options, CancellationToken cancellationToken = default)
        {
            return GetBillingBenefitsTenantMockingExtension(tenantResource).GetBillingBenefitsSavingsPlansAsync(options, cancellationToken);
        }

        /// <summary>
        /// List savings plans.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlans</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlan_ListAll</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="BillingBenefitsTenantMockingExtension.GetBillingBenefitsSavingsPlans(TenantResourceGetBillingBenefitsSavingsPlansOptions,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="options"> A property bag which contains all the parameters of this method except the LRO qualifier and request context parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BillingBenefitsSavingsPlanResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<BillingBenefitsSavingsPlanResource> GetBillingBenefitsSavingsPlans(this TenantResource tenantResource, TenantResourceGetBillingBenefitsSavingsPlansOptions options, CancellationToken cancellationToken = default)
        {
            return GetBillingBenefitsTenantMockingExtension(tenantResource).GetBillingBenefitsSavingsPlans(options, cancellationToken);
        }

        /// <summary>
        /// Validate savings plan purchase.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/validate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ValidatePurchase</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="BillingBenefitsTenantMockingExtension.ValidatePurchase(SavingsPlanPurchaseValidateContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="content"> Request body for validating the purchase of a savings plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <returns> An async collection of <see cref="SavingsPlanValidateResult" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<SavingsPlanValidateResult> ValidatePurchaseAsync(this TenantResource tenantResource, SavingsPlanPurchaseValidateContent content, CancellationToken cancellationToken = default)
        {
            return GetBillingBenefitsTenantMockingExtension(tenantResource).ValidatePurchaseAsync(content, cancellationToken);
        }

        /// <summary>
        /// Validate savings plan purchase.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/validate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ValidatePurchase</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="BillingBenefitsTenantMockingExtension.ValidatePurchase(SavingsPlanPurchaseValidateContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="content"> Request body for validating the purchase of a savings plan. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <returns> A collection of <see cref="SavingsPlanValidateResult" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<SavingsPlanValidateResult> ValidatePurchase(this TenantResource tenantResource, SavingsPlanPurchaseValidateContent content, CancellationToken cancellationToken = default)
        {
            return GetBillingBenefitsTenantMockingExtension(tenantResource).ValidatePurchase(content, cancellationToken);
        }
    }
}
