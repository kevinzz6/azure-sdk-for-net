// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="SecurityInsightsThreatIntelligenceIndicatorResource" /> and their operations.
    /// Each <see cref="SecurityInsightsThreatIntelligenceIndicatorResource" /> in the collection will belong to the same instance of <see cref="OperationalInsightsWorkspaceSecurityInsightsResource" />.
    /// To get a <see cref="SecurityInsightsThreatIntelligenceIndicatorCollection" /> instance call the GetSecurityInsightsThreatIntelligenceIndicators method from an instance of <see cref="OperationalInsightsWorkspaceSecurityInsightsResource" />.
    /// </summary>
    public partial class SecurityInsightsThreatIntelligenceIndicatorCollection : ArmCollection, IEnumerable<SecurityInsightsThreatIntelligenceIndicatorResource>, IAsyncEnumerable<SecurityInsightsThreatIntelligenceIndicatorResource>
    {
        private readonly ClientDiagnostics _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsClientDiagnostics;
        private readonly ThreatIntelligenceIndicatorsRestOperations _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsThreatIntelligenceIndicatorCollection"/> class for mocking. </summary>
        protected SecurityInsightsThreatIntelligenceIndicatorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsThreatIntelligenceIndicatorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SecurityInsightsThreatIntelligenceIndicatorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityInsights", SecurityInsightsThreatIntelligenceIndicatorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SecurityInsightsThreatIntelligenceIndicatorResource.ResourceType, out string securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsApiVersion);
            _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsRestClient = new ThreatIntelligenceIndicatorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != OperationalInsightsWorkspaceSecurityInsightsResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, OperationalInsightsWorkspaceSecurityInsightsResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// View a threat intelligence indicator by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/threatIntelligence/main/indicators/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ThreatIntelligenceIndicators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Threat intelligence indicator name field. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<SecurityInsightsThreatIntelligenceIndicatorResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsClientDiagnostics.CreateScope("SecurityInsightsThreatIntelligenceIndicatorCollection.Get");
            scope.Start();
            try
            {
                var response = await _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsThreatIntelligenceIndicatorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// View a threat intelligence indicator by name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/threatIntelligence/main/indicators/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ThreatIntelligenceIndicators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Threat intelligence indicator name field. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<SecurityInsightsThreatIntelligenceIndicatorResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsClientDiagnostics.CreateScope("SecurityInsightsThreatIntelligenceIndicatorCollection.Get");
            scope.Start();
            try
            {
                var response = _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsThreatIntelligenceIndicatorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get all threat intelligence indicators.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/threatIntelligence/main/indicators</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ThreatIntelligenceIndicators_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Filters the results, based on a Boolean condition. Optional. </param>
        /// <param name="top"> Returns only the first n results. Optional. </param>
        /// <param name="skipToken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. Optional. </param>
        /// <param name="orderBy"> Sorts the results. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecurityInsightsThreatIntelligenceIndicatorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecurityInsightsThreatIntelligenceIndicatorResource> GetAllAsync(string filter = null, int? top = null, string skipToken = null, string orderBy = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skipToken, orderBy);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skipToken, orderBy);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SecurityInsightsThreatIntelligenceIndicatorResource(Client, SecurityInsightsThreatIntelligenceIndicatorBaseData.DeserializeSecurityInsightsThreatIntelligenceIndicatorBaseData(e)), _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsClientDiagnostics, Pipeline, "SecurityInsightsThreatIntelligenceIndicatorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get all threat intelligence indicators.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/threatIntelligence/main/indicators</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ThreatIntelligenceIndicators_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Filters the results, based on a Boolean condition. Optional. </param>
        /// <param name="top"> Returns only the first n results. Optional. </param>
        /// <param name="skipToken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. Optional. </param>
        /// <param name="orderBy"> Sorts the results. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecurityInsightsThreatIntelligenceIndicatorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecurityInsightsThreatIntelligenceIndicatorResource> GetAll(string filter = null, int? top = null, string skipToken = null, string orderBy = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skipToken, orderBy);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skipToken, orderBy);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SecurityInsightsThreatIntelligenceIndicatorResource(Client, SecurityInsightsThreatIntelligenceIndicatorBaseData.DeserializeSecurityInsightsThreatIntelligenceIndicatorBaseData(e)), _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsClientDiagnostics, Pipeline, "SecurityInsightsThreatIntelligenceIndicatorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/threatIntelligence/main/indicators/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ThreatIntelligenceIndicators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Threat intelligence indicator name field. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsClientDiagnostics.CreateScope("SecurityInsightsThreatIntelligenceIndicatorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/threatIntelligence/main/indicators/{name}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ThreatIntelligenceIndicators_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="name"> Threat intelligence indicator name field. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsClientDiagnostics.CreateScope("SecurityInsightsThreatIntelligenceIndicatorCollection.Exists");
            scope.Start();
            try
            {
                var response = _securityInsightsThreatIntelligenceIndicatorThreatIntelligenceIndicatorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SecurityInsightsThreatIntelligenceIndicatorResource> IEnumerable<SecurityInsightsThreatIntelligenceIndicatorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SecurityInsightsThreatIntelligenceIndicatorResource> IAsyncEnumerable<SecurityInsightsThreatIntelligenceIndicatorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
