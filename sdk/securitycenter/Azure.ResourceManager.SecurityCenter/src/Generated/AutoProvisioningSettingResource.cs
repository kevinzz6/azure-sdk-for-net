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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing an AutoProvisioningSetting along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="AutoProvisioningSettingResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetAutoProvisioningSettingResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource" /> using the GetAutoProvisioningSetting method.
    /// </summary>
    public partial class AutoProvisioningSettingResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AutoProvisioningSettingResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string settingName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Security/autoProvisioningSettings/{settingName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _autoProvisioningSettingClientDiagnostics;
        private readonly AutoProvisioningSettingsRestOperations _autoProvisioningSettingRestClient;
        private readonly AutoProvisioningSettingData _data;

        /// <summary> Initializes a new instance of the <see cref="AutoProvisioningSettingResource"/> class for mocking. </summary>
        protected AutoProvisioningSettingResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "AutoProvisioningSettingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AutoProvisioningSettingResource(ArmClient client, AutoProvisioningSettingData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AutoProvisioningSettingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AutoProvisioningSettingResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _autoProvisioningSettingClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string autoProvisioningSettingApiVersion);
            _autoProvisioningSettingRestClient = new AutoProvisioningSettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, autoProvisioningSettingApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/autoProvisioningSettings";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AutoProvisioningSettingData Data
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
        /// Details of a specific setting
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/autoProvisioningSettings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoProvisioningSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AutoProvisioningSettingResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _autoProvisioningSettingClientDiagnostics.CreateScope("AutoProvisioningSettingResource.Get");
            scope.Start();
            try
            {
                var response = await _autoProvisioningSettingRestClient.GetAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutoProvisioningSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Details of a specific setting
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/autoProvisioningSettings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoProvisioningSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AutoProvisioningSettingResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _autoProvisioningSettingClientDiagnostics.CreateScope("AutoProvisioningSettingResource.Get");
            scope.Start();
            try
            {
                var response = _autoProvisioningSettingRestClient.Get(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutoProvisioningSettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Details of a specific setting
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/autoProvisioningSettings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoProvisioningSettings_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Auto provisioning setting key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AutoProvisioningSettingResource>> UpdateAsync(WaitUntil waitUntil, AutoProvisioningSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _autoProvisioningSettingClientDiagnostics.CreateScope("AutoProvisioningSettingResource.Update");
            scope.Start();
            try
            {
                var response = await _autoProvisioningSettingRestClient.CreateAsync(Id.SubscriptionId, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<AutoProvisioningSettingResource>(Response.FromValue(new AutoProvisioningSettingResource(Client, response), response.GetRawResponse()));
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
        /// Details of a specific setting
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/autoProvisioningSettings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AutoProvisioningSettings_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Auto provisioning setting key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AutoProvisioningSettingResource> Update(WaitUntil waitUntil, AutoProvisioningSettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _autoProvisioningSettingClientDiagnostics.CreateScope("AutoProvisioningSettingResource.Update");
            scope.Start();
            try
            {
                var response = _autoProvisioningSettingRestClient.Create(Id.SubscriptionId, Id.Name, data, cancellationToken);
                var operation = new SecurityCenterArmOperation<AutoProvisioningSettingResource>(Response.FromValue(new AutoProvisioningSettingResource(Client, response), response.GetRawResponse()));
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
