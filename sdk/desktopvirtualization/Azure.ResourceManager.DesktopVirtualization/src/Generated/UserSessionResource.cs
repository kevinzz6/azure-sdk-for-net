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
using Azure.ResourceManager.DesktopVirtualization.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary>
    /// A Class representing an UserSession along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="UserSessionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetUserSessionResource method.
    /// Otherwise you can get one from its parent resource <see cref="SessionHostResource" /> using the GetUserSession method.
    /// </summary>
    public partial class UserSessionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="UserSessionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string hostPoolName, string sessionHostName, string userSessionId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}/userSessions/{userSessionId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _userSessionClientDiagnostics;
        private readonly UserSessionsRestOperations _userSessionRestClient;
        private readonly UserSessionData _data;

        /// <summary> Initializes a new instance of the <see cref="UserSessionResource"/> class for mocking. </summary>
        protected UserSessionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "UserSessionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal UserSessionResource(ArmClient client, UserSessionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="UserSessionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal UserSessionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _userSessionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string userSessionApiVersion);
            _userSessionRestClient = new UserSessionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, userSessionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DesktopVirtualization/hostPools/sessionHosts/userSessions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual UserSessionData Data
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
        /// Get a userSession.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}/userSessions/{userSessionId}
        /// Operation Id: UserSessions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<UserSessionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _userSessionClientDiagnostics.CreateScope("UserSessionResource.Get");
            scope.Start();
            try
            {
                var response = await _userSessionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new UserSessionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a userSession.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}/userSessions/{userSessionId}
        /// Operation Id: UserSessions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<UserSessionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _userSessionClientDiagnostics.CreateScope("UserSessionResource.Get");
            scope.Start();
            try
            {
                var response = _userSessionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new UserSessionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Remove a userSession.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}/userSessions/{userSessionId}
        /// Operation Id: UserSessions_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="force"> Force flag to login off userSession. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, bool? force = null, CancellationToken cancellationToken = default)
        {
            using var scope = _userSessionClientDiagnostics.CreateScope("UserSessionResource.Delete");
            scope.Start();
            try
            {
                var response = await _userSessionRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, force, cancellationToken).ConfigureAwait(false);
                var operation = new DesktopVirtualizationArmOperation(response);
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
        /// Remove a userSession.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}/userSessions/{userSessionId}
        /// Operation Id: UserSessions_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="force"> Force flag to login off userSession. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, bool? force = null, CancellationToken cancellationToken = default)
        {
            using var scope = _userSessionClientDiagnostics.CreateScope("UserSessionResource.Delete");
            scope.Start();
            try
            {
                var response = _userSessionRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, force, cancellationToken);
                var operation = new DesktopVirtualizationArmOperation(response);
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
        /// Disconnect a userSession.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}/userSessions/{userSessionId}/disconnect
        /// Operation Id: UserSessions_Disconnect
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DisconnectAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _userSessionClientDiagnostics.CreateScope("UserSessionResource.Disconnect");
            scope.Start();
            try
            {
                var response = await _userSessionRestClient.DisconnectAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Disconnect a userSession.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}/userSessions/{userSessionId}/disconnect
        /// Operation Id: UserSessions_Disconnect
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Disconnect(CancellationToken cancellationToken = default)
        {
            using var scope = _userSessionClientDiagnostics.CreateScope("UserSessionResource.Disconnect");
            scope.Start();
            try
            {
                var response = _userSessionRestClient.Disconnect(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Send a message to a user.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}/userSessions/{userSessionId}/sendMessage
        /// Operation Id: UserSessions_SendMessage
        /// </summary>
        /// <param name="sendMessage"> Object containing message includes title and message body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> SendMessageAsync(SendMessage sendMessage = null, CancellationToken cancellationToken = default)
        {
            using var scope = _userSessionClientDiagnostics.CreateScope("UserSessionResource.SendMessage");
            scope.Start();
            try
            {
                var response = await _userSessionRestClient.SendMessageAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, sendMessage, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Send a message to a user.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}/userSessions/{userSessionId}/sendMessage
        /// Operation Id: UserSessions_SendMessage
        /// </summary>
        /// <param name="sendMessage"> Object containing message includes title and message body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response SendMessage(SendMessage sendMessage = null, CancellationToken cancellationToken = default)
        {
            using var scope = _userSessionClientDiagnostics.CreateScope("UserSessionResource.SendMessage");
            scope.Start();
            try
            {
                var response = _userSessionRestClient.SendMessage(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, sendMessage, cancellationToken);
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
