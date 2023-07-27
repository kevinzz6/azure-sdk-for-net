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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Automanage
{
    /// <summary>
    /// A class representing a collection of <see cref="AutomanageBestPracticeResource" /> and their operations.
    /// Each <see cref="AutomanageBestPracticeResource" /> in the collection will belong to the same instance of <see cref="TenantResource" />.
    /// To get an <see cref="AutomanageBestPracticeCollection" /> instance call the GetAutomanageBestPractices method from an instance of <see cref="TenantResource" />.
    /// </summary>
    public partial class AutomanageBestPracticeCollection : ArmCollection, IEnumerable<AutomanageBestPracticeResource>, IAsyncEnumerable<AutomanageBestPracticeResource>
    {
        private readonly ClientDiagnostics _automanageBestPracticeBestPracticesClientDiagnostics;
        private readonly BestPracticesRestOperations _automanageBestPracticeBestPracticesRestClient;

        /// <summary> Initializes a new instance of the <see cref="AutomanageBestPracticeCollection"/> class for mocking. </summary>
        protected AutomanageBestPracticeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomanageBestPracticeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AutomanageBestPracticeCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automanageBestPracticeBestPracticesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automanage", AutomanageBestPracticeResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutomanageBestPracticeResource.ResourceType, out string automanageBestPracticeBestPracticesApiVersion);
            _automanageBestPracticeBestPracticesRestClient = new BestPracticesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automanageBestPracticeBestPracticesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get information about a Automanage best practice
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Automanage/bestPractices/{bestPracticeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BestPractices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bestPracticeName"> The Automanage best practice name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bestPracticeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bestPracticeName"/> is null. </exception>
        public virtual async Task<Response<AutomanageBestPracticeResource>> GetAsync(string bestPracticeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bestPracticeName, nameof(bestPracticeName));

            using var scope = _automanageBestPracticeBestPracticesClientDiagnostics.CreateScope("AutomanageBestPracticeCollection.Get");
            scope.Start();
            try
            {
                var response = await _automanageBestPracticeBestPracticesRestClient.GetAsync(bestPracticeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomanageBestPracticeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information about a Automanage best practice
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Automanage/bestPractices/{bestPracticeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BestPractices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bestPracticeName"> The Automanage best practice name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bestPracticeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bestPracticeName"/> is null. </exception>
        public virtual Response<AutomanageBestPracticeResource> Get(string bestPracticeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bestPracticeName, nameof(bestPracticeName));

            using var scope = _automanageBestPracticeBestPracticesClientDiagnostics.CreateScope("AutomanageBestPracticeCollection.Get");
            scope.Start();
            try
            {
                var response = _automanageBestPracticeBestPracticesRestClient.Get(bestPracticeName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomanageBestPracticeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve a list of Automanage best practices
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Automanage/bestPractices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BestPractices_ListByTenant</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomanageBestPracticeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutomanageBestPracticeResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automanageBestPracticeBestPracticesRestClient.CreateListByTenantRequest();
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new AutomanageBestPracticeResource(Client, AutomanageBestPracticeData.DeserializeAutomanageBestPracticeData(e)), _automanageBestPracticeBestPracticesClientDiagnostics, Pipeline, "AutomanageBestPracticeCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Retrieve a list of Automanage best practices
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Automanage/bestPractices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BestPractices_ListByTenant</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomanageBestPracticeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutomanageBestPracticeResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automanageBestPracticeBestPracticesRestClient.CreateListByTenantRequest();
            return PageableHelpers.CreatePageable(FirstPageRequest, null, e => new AutomanageBestPracticeResource(Client, AutomanageBestPracticeData.DeserializeAutomanageBestPracticeData(e)), _automanageBestPracticeBestPracticesClientDiagnostics, Pipeline, "AutomanageBestPracticeCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Automanage/bestPractices/{bestPracticeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BestPractices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bestPracticeName"> The Automanage best practice name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bestPracticeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bestPracticeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string bestPracticeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bestPracticeName, nameof(bestPracticeName));

            using var scope = _automanageBestPracticeBestPracticesClientDiagnostics.CreateScope("AutomanageBestPracticeCollection.Exists");
            scope.Start();
            try
            {
                var response = await _automanageBestPracticeBestPracticesRestClient.GetAsync(bestPracticeName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.Automanage/bestPractices/{bestPracticeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BestPractices_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bestPracticeName"> The Automanage best practice name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bestPracticeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bestPracticeName"/> is null. </exception>
        public virtual Response<bool> Exists(string bestPracticeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bestPracticeName, nameof(bestPracticeName));

            using var scope = _automanageBestPracticeBestPracticesClientDiagnostics.CreateScope("AutomanageBestPracticeCollection.Exists");
            scope.Start();
            try
            {
                var response = _automanageBestPracticeBestPracticesRestClient.Get(bestPracticeName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AutomanageBestPracticeResource> IEnumerable<AutomanageBestPracticeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutomanageBestPracticeResource> IAsyncEnumerable<AutomanageBestPracticeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
