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

namespace Azure.ResourceManager.Monitor
{
    /// <summary>
    /// A Class representing a DataCollectionRuleAssociation along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="DataCollectionRuleAssociationResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetDataCollectionRuleAssociationResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource" /> using the GetDataCollectionRuleAssociation method.
    /// </summary>
    public partial class DataCollectionRuleAssociationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DataCollectionRuleAssociationResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string resourceUri, string associationName)
        {
            var resourceId = $"{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations/{associationName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _dataCollectionRuleAssociationClientDiagnostics;
        private readonly DataCollectionRuleAssociationsRestOperations _dataCollectionRuleAssociationRestClient;
        private readonly DataCollectionRuleAssociationData _data;

        /// <summary> Initializes a new instance of the <see cref="DataCollectionRuleAssociationResource"/> class for mocking. </summary>
        protected DataCollectionRuleAssociationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DataCollectionRuleAssociationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DataCollectionRuleAssociationResource(ArmClient client, DataCollectionRuleAssociationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DataCollectionRuleAssociationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DataCollectionRuleAssociationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataCollectionRuleAssociationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Monitor", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string dataCollectionRuleAssociationApiVersion);
            _dataCollectionRuleAssociationRestClient = new DataCollectionRuleAssociationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataCollectionRuleAssociationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Insights/dataCollectionRuleAssociations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DataCollectionRuleAssociationData Data
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

        /// <summary>
        /// Returns the specified association.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations/{associationName}
        /// Operation Id: DataCollectionRuleAssociations_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataCollectionRuleAssociationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _dataCollectionRuleAssociationClientDiagnostics.CreateScope("DataCollectionRuleAssociationResource.Get");
            scope.Start();
            try
            {
                var response = await _dataCollectionRuleAssociationRestClient.GetAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataCollectionRuleAssociationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the specified association.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations/{associationName}
        /// Operation Id: DataCollectionRuleAssociations_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataCollectionRuleAssociationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _dataCollectionRuleAssociationClientDiagnostics.CreateScope("DataCollectionRuleAssociationResource.Get");
            scope.Start();
            try
            {
                var response = _dataCollectionRuleAssociationRestClient.Get(Id.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataCollectionRuleAssociationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an association.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations/{associationName}
        /// Operation Id: DataCollectionRuleAssociations_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _dataCollectionRuleAssociationClientDiagnostics.CreateScope("DataCollectionRuleAssociationResource.Delete");
            scope.Start();
            try
            {
                var response = await _dataCollectionRuleAssociationRestClient.DeleteAsync(Id.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MonitorArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes an association.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations/{associationName}
        /// Operation Id: DataCollectionRuleAssociations_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _dataCollectionRuleAssociationClientDiagnostics.CreateScope("DataCollectionRuleAssociationResource.Delete");
            scope.Start();
            try
            {
                var response = _dataCollectionRuleAssociationRestClient.Delete(Id.Parent, Id.Name, cancellationToken);
                var operation = new MonitorArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates an association.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations/{associationName}
        /// Operation Id: DataCollectionRuleAssociations_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<DataCollectionRuleAssociationResource>> UpdateAsync(WaitUntil waitUntil, DataCollectionRuleAssociationData data = null, CancellationToken cancellationToken = default)
        {
            using var scope = _dataCollectionRuleAssociationClientDiagnostics.CreateScope("DataCollectionRuleAssociationResource.Update");
            scope.Start();
            try
            {
                var response = await _dataCollectionRuleAssociationRestClient.CreateAsync(Id.Parent, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MonitorArmOperation<DataCollectionRuleAssociationResource>(Response.FromValue(new DataCollectionRuleAssociationResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates an association.
        /// Request Path: /{resourceUri}/providers/Microsoft.Insights/dataCollectionRuleAssociations/{associationName}
        /// Operation Id: DataCollectionRuleAssociations_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<DataCollectionRuleAssociationResource> Update(WaitUntil waitUntil, DataCollectionRuleAssociationData data = null, CancellationToken cancellationToken = default)
        {
            using var scope = _dataCollectionRuleAssociationClientDiagnostics.CreateScope("DataCollectionRuleAssociationResource.Update");
            scope.Start();
            try
            {
                var response = _dataCollectionRuleAssociationRestClient.Create(Id.Parent, Id.Name, data, cancellationToken);
                var operation = new MonitorArmOperation<DataCollectionRuleAssociationResource>(Response.FromValue(new DataCollectionRuleAssociationResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
