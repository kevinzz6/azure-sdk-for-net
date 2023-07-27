// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.BillingBenefits.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.BillingBenefits
{
    /// <summary>
    /// A Class representing a BillingBenefitsSavingsPlanOrder along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="BillingBenefitsSavingsPlanOrderResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetBillingBenefitsSavingsPlanOrderResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource" /> using the GetBillingBenefitsSavingsPlanOrder method.
    /// </summary>
    public partial class BillingBenefitsSavingsPlanOrderResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="BillingBenefitsSavingsPlanOrderResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string savingsPlanOrderId)
        {
            var resourceId = $"/providers/Microsoft.BillingBenefits/savingsPlanOrders/{savingsPlanOrderId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _billingBenefitsSavingsPlanOrderSavingsPlanOrderClientDiagnostics;
        private readonly SavingsPlanOrderRestOperations _billingBenefitsSavingsPlanOrderSavingsPlanOrderRestClient;
        private readonly BillingBenefitsSavingsPlanOrderData _data;

        /// <summary> Initializes a new instance of the <see cref="BillingBenefitsSavingsPlanOrderResource"/> class for mocking. </summary>
        protected BillingBenefitsSavingsPlanOrderResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "BillingBenefitsSavingsPlanOrderResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BillingBenefitsSavingsPlanOrderResource(ArmClient client, BillingBenefitsSavingsPlanOrderData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BillingBenefitsSavingsPlanOrderResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BillingBenefitsSavingsPlanOrderResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _billingBenefitsSavingsPlanOrderSavingsPlanOrderClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.BillingBenefits", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string billingBenefitsSavingsPlanOrderSavingsPlanOrderApiVersion);
            _billingBenefitsSavingsPlanOrderSavingsPlanOrderRestClient = new SavingsPlanOrderRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, billingBenefitsSavingsPlanOrderSavingsPlanOrderApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.BillingBenefits/savingsPlanOrders";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual BillingBenefitsSavingsPlanOrderData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of BillingBenefitsSavingsPlanResources in the BillingBenefitsSavingsPlanOrder. </summary>
        /// <returns> An object representing collection of BillingBenefitsSavingsPlanResources and their operations over a BillingBenefitsSavingsPlanResource. </returns>
        public virtual BillingBenefitsSavingsPlanCollection GetBillingBenefitsSavingsPlans()
        {
            return GetCachedClient(Client => new BillingBenefitsSavingsPlanCollection(Client, Id));
        }

        /// <summary>
        /// Get savings plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlan_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="savingsPlanId"> ID of the savings plan. </param>
        /// <param name="expand"> May be used to expand the detail information of some properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="savingsPlanId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="savingsPlanId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<BillingBenefitsSavingsPlanResource>> GetBillingBenefitsSavingsPlanAsync(string savingsPlanId, string expand = null, CancellationToken cancellationToken = default)
        {
            return await GetBillingBenefitsSavingsPlans().GetAsync(savingsPlanId, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get savings plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlanOrders/{savingsPlanOrderId}/savingsPlans/{savingsPlanId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlan_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="savingsPlanId"> ID of the savings plan. </param>
        /// <param name="expand"> May be used to expand the detail information of some properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="savingsPlanId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="savingsPlanId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<BillingBenefitsSavingsPlanResource> GetBillingBenefitsSavingsPlan(string savingsPlanId, string expand = null, CancellationToken cancellationToken = default)
        {
            return GetBillingBenefitsSavingsPlans().Get(savingsPlanId, expand, cancellationToken);
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
        /// </summary>
        /// <param name="expand"> May be used to expand the detail information of some properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BillingBenefitsSavingsPlanOrderResource>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _billingBenefitsSavingsPlanOrderSavingsPlanOrderClientDiagnostics.CreateScope("BillingBenefitsSavingsPlanOrderResource.Get");
            scope.Start();
            try
            {
                var response = await _billingBenefitsSavingsPlanOrderSavingsPlanOrderRestClient.GetAsync(Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingBenefitsSavingsPlanOrderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
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
        /// </summary>
        /// <param name="expand"> May be used to expand the detail information of some properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BillingBenefitsSavingsPlanOrderResource> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _billingBenefitsSavingsPlanOrderSavingsPlanOrderClientDiagnostics.CreateScope("BillingBenefitsSavingsPlanOrderResource.Get");
            scope.Start();
            try
            {
                var response = _billingBenefitsSavingsPlanOrderSavingsPlanOrderRestClient.Get(Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingBenefitsSavingsPlanOrderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Elevate as owner on savings plan order based on billing permissions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlanOrders/{savingsPlanOrderId}/elevate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlanOrder_Elevate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BillingBenefitsRoleAssignmentEntity>> ElevateAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _billingBenefitsSavingsPlanOrderSavingsPlanOrderClientDiagnostics.CreateScope("BillingBenefitsSavingsPlanOrderResource.Elevate");
            scope.Start();
            try
            {
                var response = await _billingBenefitsSavingsPlanOrderSavingsPlanOrderRestClient.ElevateAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Elevate as owner on savings plan order based on billing permissions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BillingBenefits/savingsPlanOrders/{savingsPlanOrderId}/elevate</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SavingsPlanOrder_Elevate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BillingBenefitsRoleAssignmentEntity> Elevate(CancellationToken cancellationToken = default)
        {
            using var scope = _billingBenefitsSavingsPlanOrderSavingsPlanOrderClientDiagnostics.CreateScope("BillingBenefitsSavingsPlanOrderResource.Elevate");
            scope.Start();
            try
            {
                var response = _billingBenefitsSavingsPlanOrderSavingsPlanOrderRestClient.Elevate(Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
