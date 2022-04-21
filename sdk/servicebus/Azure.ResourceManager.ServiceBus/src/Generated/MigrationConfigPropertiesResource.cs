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
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary>
    /// A Class representing a MigrationConfigProperties along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="MigrationConfigPropertiesResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetMigrationConfigPropertiesResource method.
    /// Otherwise you can get one from its parent resource <see cref="ServiceBusNamespaceResource" /> using the GetMigrationConfigProperties method.
    /// </summary>
    public partial class MigrationConfigPropertiesResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MigrationConfigPropertiesResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string namespaceName, string configName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations/{configName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _migrationConfigPropertiesMigrationConfigsClientDiagnostics;
        private readonly MigrationConfigsRestOperations _migrationConfigPropertiesMigrationConfigsRestClient;
        private readonly MigrationConfigPropertiesData _data;

        /// <summary> Initializes a new instance of the <see cref="MigrationConfigPropertiesResource"/> class for mocking. </summary>
        protected MigrationConfigPropertiesResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "MigrationConfigPropertiesResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MigrationConfigPropertiesResource(ArmClient client, MigrationConfigPropertiesData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MigrationConfigPropertiesResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MigrationConfigPropertiesResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _migrationConfigPropertiesMigrationConfigsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceBus", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string migrationConfigPropertiesMigrationConfigsApiVersion);
            _migrationConfigPropertiesMigrationConfigsRestClient = new MigrationConfigsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, migrationConfigPropertiesMigrationConfigsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ServiceBus/namespaces/migrationConfigurations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MigrationConfigPropertiesData Data
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
        /// Retrieves Migration Config
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations/{configName}
        /// Operation Id: MigrationConfigs_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MigrationConfigPropertiesResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _migrationConfigPropertiesMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigPropertiesResource.Get");
            scope.Start();
            try
            {
                var response = await _migrationConfigPropertiesMigrationConfigsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MigrationConfigPropertiesResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves Migration Config
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations/{configName}
        /// Operation Id: MigrationConfigs_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MigrationConfigPropertiesResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _migrationConfigPropertiesMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigPropertiesResource.Get");
            scope.Start();
            try
            {
                var response = _migrationConfigPropertiesMigrationConfigsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MigrationConfigPropertiesResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes a MigrationConfiguration
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations/{configName}
        /// Operation Id: MigrationConfigs_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _migrationConfigPropertiesMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigPropertiesResource.Delete");
            scope.Start();
            try
            {
                var response = await _migrationConfigPropertiesMigrationConfigsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceBusArmOperation(response);
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
        /// Deletes a MigrationConfiguration
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations/{configName}
        /// Operation Id: MigrationConfigs_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _migrationConfigPropertiesMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigPropertiesResource.Delete");
            scope.Start();
            try
            {
                var response = _migrationConfigPropertiesMigrationConfigsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new ServiceBusArmOperation(response);
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
        /// Creates Migration configuration and starts migration of entities from Standard to Premium namespace
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations/{configName}
        /// Operation Id: MigrationConfigs_CreateAndStartMigration
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters required to create Migration Configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MigrationConfigPropertiesResource>> UpdateAsync(WaitUntil waitUntil, MigrationConfigPropertiesData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _migrationConfigPropertiesMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigPropertiesResource.Update");
            scope.Start();
            try
            {
                var response = await _migrationConfigPropertiesMigrationConfigsRestClient.CreateAndStartMigrationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceBusArmOperation<MigrationConfigPropertiesResource>(new MigrationConfigPropertiesOperationSource(Client), _migrationConfigPropertiesMigrationConfigsClientDiagnostics, Pipeline, _migrationConfigPropertiesMigrationConfigsRestClient.CreateCreateAndStartMigrationRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates Migration configuration and starts migration of entities from Standard to Premium namespace
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations/{configName}
        /// Operation Id: MigrationConfigs_CreateAndStartMigration
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters required to create Migration Configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MigrationConfigPropertiesResource> Update(WaitUntil waitUntil, MigrationConfigPropertiesData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _migrationConfigPropertiesMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigPropertiesResource.Update");
            scope.Start();
            try
            {
                var response = _migrationConfigPropertiesMigrationConfigsRestClient.CreateAndStartMigration(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new ServiceBusArmOperation<MigrationConfigPropertiesResource>(new MigrationConfigPropertiesOperationSource(Client), _migrationConfigPropertiesMigrationConfigsClientDiagnostics, Pipeline, _migrationConfigPropertiesMigrationConfigsRestClient.CreateCreateAndStartMigrationRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.Location);
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

        /// <summary>
        /// This operation Completes Migration of entities by pointing the connection strings to Premium namespace and any entities created after the operation will be under Premium Namespace. CompleteMigration operation will fail when entity migration is in-progress.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations/{configName}/upgrade
        /// Operation Id: MigrationConfigs_CompleteMigration
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CompleteMigrationAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _migrationConfigPropertiesMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigPropertiesResource.CompleteMigration");
            scope.Start();
            try
            {
                var response = await _migrationConfigPropertiesMigrationConfigsRestClient.CompleteMigrationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation Completes Migration of entities by pointing the connection strings to Premium namespace and any entities created after the operation will be under Premium Namespace. CompleteMigration operation will fail when entity migration is in-progress.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations/{configName}/upgrade
        /// Operation Id: MigrationConfigs_CompleteMigration
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CompleteMigration(CancellationToken cancellationToken = default)
        {
            using var scope = _migrationConfigPropertiesMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigPropertiesResource.CompleteMigration");
            scope.Start();
            try
            {
                var response = _migrationConfigPropertiesMigrationConfigsRestClient.CompleteMigration(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation reverts Migration
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations/{configName}/revert
        /// Operation Id: MigrationConfigs_Revert
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> RevertAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _migrationConfigPropertiesMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigPropertiesResource.Revert");
            scope.Start();
            try
            {
                var response = await _migrationConfigPropertiesMigrationConfigsRestClient.RevertAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation reverts Migration
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/migrationConfigurations/{configName}/revert
        /// Operation Id: MigrationConfigs_Revert
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Revert(CancellationToken cancellationToken = default)
        {
            using var scope = _migrationConfigPropertiesMigrationConfigsClientDiagnostics.CreateScope("MigrationConfigPropertiesResource.Revert");
            scope.Start();
            try
            {
                var response = _migrationConfigPropertiesMigrationConfigsRestClient.Revert(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
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
