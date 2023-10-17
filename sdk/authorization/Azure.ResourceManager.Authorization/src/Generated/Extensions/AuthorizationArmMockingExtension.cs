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
using Azure.ResourceManager.Authorization;

namespace Azure.ResourceManager.Authorization.Mocking
{
    /// <summary> A class to add extension methods to ArmResource. </summary>
    public partial class AuthorizationArmMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="AuthorizationArmMockingExtension"/> class for mocking. </summary>
        protected AuthorizationArmMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AuthorizationArmMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AuthorizationArmMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DenyAssignmentResources in the ArmResource. </summary>
        /// <returns> An object representing collection of DenyAssignmentResources and their operations over a DenyAssignmentResource. </returns>
        public virtual DenyAssignmentCollection GetDenyAssignments()
        {
            return GetCachedClient(client => new DenyAssignmentCollection(client, Id));
        }

        /// <summary>
        /// Get the specified deny assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/denyAssignments/{denyAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DenyAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="denyAssignmentId"> The ID of the deny assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="denyAssignmentId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="denyAssignmentId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DenyAssignmentResource>> GetDenyAssignmentAsync(string denyAssignmentId, CancellationToken cancellationToken = default)
        {
            return await GetDenyAssignments().GetAsync(denyAssignmentId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the specified deny assignment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/denyAssignments/{denyAssignmentId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DenyAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="denyAssignmentId"> The ID of the deny assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="denyAssignmentId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="denyAssignmentId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DenyAssignmentResource> GetDenyAssignment(string denyAssignmentId, CancellationToken cancellationToken = default)
        {
            return GetDenyAssignments().Get(denyAssignmentId, cancellationToken);
        }

        /// <summary> Gets a collection of RoleAssignmentResources in the ArmResource. </summary>
        /// <returns> An object representing collection of RoleAssignmentResources and their operations over a RoleAssignmentResource. </returns>
        public virtual RoleAssignmentCollection GetRoleAssignments()
        {
            return GetCachedClient(client => new RoleAssignmentCollection(client, Id));
        }

        /// <summary>
        /// Get a role assignment by scope and name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignments/{roleAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentName"> The name of the role assignment. It can be any valid GUID. </param>
        /// <param name="tenantId"> Tenant ID for cross-tenant request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<RoleAssignmentResource>> GetRoleAssignmentAsync(string roleAssignmentName, string tenantId = null, CancellationToken cancellationToken = default)
        {
            return await GetRoleAssignments().GetAsync(roleAssignmentName, tenantId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a role assignment by scope and name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignments/{roleAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentName"> The name of the role assignment. It can be any valid GUID. </param>
        /// <param name="tenantId"> Tenant ID for cross-tenant request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<RoleAssignmentResource> GetRoleAssignment(string roleAssignmentName, string tenantId = null, CancellationToken cancellationToken = default)
        {
            return GetRoleAssignments().Get(roleAssignmentName, tenantId, cancellationToken);
        }

        /// <summary> Gets a collection of AuthorizationRoleDefinitionResources in the ArmResource. </summary>
        /// <returns> An object representing collection of AuthorizationRoleDefinitionResources and their operations over a AuthorizationRoleDefinitionResource. </returns>
        public virtual AuthorizationRoleDefinitionCollection GetAuthorizationRoleDefinitions()
        {
            return GetCachedClient(client => new AuthorizationRoleDefinitionCollection(client, Id));
        }

        /// <summary>
        /// Get role definition by name (GUID).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleDefinitions/{roleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleDefinitions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleDefinitionId"> The ID of the role definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AuthorizationRoleDefinitionResource>> GetAuthorizationRoleDefinitionAsync(ResourceIdentifier roleDefinitionId, CancellationToken cancellationToken = default)
        {
            return await GetAuthorizationRoleDefinitions().GetAsync(roleDefinitionId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get role definition by name (GUID).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleDefinitions/{roleDefinitionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleDefinitions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleDefinitionId"> The ID of the role definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<AuthorizationRoleDefinitionResource> GetAuthorizationRoleDefinition(ResourceIdentifier roleDefinitionId, CancellationToken cancellationToken = default)
        {
            return GetAuthorizationRoleDefinitions().Get(roleDefinitionId, cancellationToken);
        }

        /// <summary> Gets a collection of RoleAssignmentScheduleResources in the ArmResource. </summary>
        /// <returns> An object representing collection of RoleAssignmentScheduleResources and their operations over a RoleAssignmentScheduleResource. </returns>
        public virtual RoleAssignmentScheduleCollection GetRoleAssignmentSchedules()
        {
            return GetCachedClient(client => new RoleAssignmentScheduleCollection(client, Id));
        }

        /// <summary>
        /// Get the specified role assignment schedule for a resource scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentSchedules/{roleAssignmentScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentSchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentScheduleName"> The name (guid) of the role assignment schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<RoleAssignmentScheduleResource>> GetRoleAssignmentScheduleAsync(string roleAssignmentScheduleName, CancellationToken cancellationToken = default)
        {
            return await GetRoleAssignmentSchedules().GetAsync(roleAssignmentScheduleName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the specified role assignment schedule for a resource scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentSchedules/{roleAssignmentScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentSchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentScheduleName"> The name (guid) of the role assignment schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<RoleAssignmentScheduleResource> GetRoleAssignmentSchedule(string roleAssignmentScheduleName, CancellationToken cancellationToken = default)
        {
            return GetRoleAssignmentSchedules().Get(roleAssignmentScheduleName, cancellationToken);
        }

        /// <summary> Gets a collection of RoleAssignmentScheduleInstanceResources in the ArmResource. </summary>
        /// <returns> An object representing collection of RoleAssignmentScheduleInstanceResources and their operations over a RoleAssignmentScheduleInstanceResource. </returns>
        public virtual RoleAssignmentScheduleInstanceCollection GetRoleAssignmentScheduleInstances()
        {
            return GetCachedClient(client => new RoleAssignmentScheduleInstanceCollection(client, Id));
        }

        /// <summary>
        /// Gets the specified role assignment schedule instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleInstances/{roleAssignmentScheduleInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentScheduleInstances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentScheduleInstanceName"> The name (hash of schedule name + time) of the role assignment schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleInstanceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<RoleAssignmentScheduleInstanceResource>> GetRoleAssignmentScheduleInstanceAsync(string roleAssignmentScheduleInstanceName, CancellationToken cancellationToken = default)
        {
            return await GetRoleAssignmentScheduleInstances().GetAsync(roleAssignmentScheduleInstanceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified role assignment schedule instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleInstances/{roleAssignmentScheduleInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentScheduleInstances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentScheduleInstanceName"> The name (hash of schedule name + time) of the role assignment schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleInstanceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<RoleAssignmentScheduleInstanceResource> GetRoleAssignmentScheduleInstance(string roleAssignmentScheduleInstanceName, CancellationToken cancellationToken = default)
        {
            return GetRoleAssignmentScheduleInstances().Get(roleAssignmentScheduleInstanceName, cancellationToken);
        }

        /// <summary> Gets a collection of RoleAssignmentScheduleRequestResources in the ArmResource. </summary>
        /// <returns> An object representing collection of RoleAssignmentScheduleRequestResources and their operations over a RoleAssignmentScheduleRequestResource. </returns>
        public virtual RoleAssignmentScheduleRequestCollection GetRoleAssignmentScheduleRequests()
        {
            return GetCachedClient(client => new RoleAssignmentScheduleRequestCollection(client, Id));
        }

        /// <summary>
        /// Get the specified role assignment schedule request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleRequests/{roleAssignmentScheduleRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentScheduleRequests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentScheduleRequestName"> The name (guid) of the role assignment schedule request to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleRequestName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<RoleAssignmentScheduleRequestResource>> GetRoleAssignmentScheduleRequestAsync(string roleAssignmentScheduleRequestName, CancellationToken cancellationToken = default)
        {
            return await GetRoleAssignmentScheduleRequests().GetAsync(roleAssignmentScheduleRequestName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the specified role assignment schedule request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleAssignmentScheduleRequests/{roleAssignmentScheduleRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleAssignmentScheduleRequests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleAssignmentScheduleRequestName"> The name (guid) of the role assignment schedule request to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleAssignmentScheduleRequestName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleAssignmentScheduleRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<RoleAssignmentScheduleRequestResource> GetRoleAssignmentScheduleRequest(string roleAssignmentScheduleRequestName, CancellationToken cancellationToken = default)
        {
            return GetRoleAssignmentScheduleRequests().Get(roleAssignmentScheduleRequestName, cancellationToken);
        }

        /// <summary> Gets a collection of RoleEligibilityScheduleResources in the ArmResource. </summary>
        /// <returns> An object representing collection of RoleEligibilityScheduleResources and their operations over a RoleEligibilityScheduleResource. </returns>
        public virtual RoleEligibilityScheduleCollection GetRoleEligibilitySchedules()
        {
            return GetCachedClient(client => new RoleEligibilityScheduleCollection(client, Id));
        }

        /// <summary>
        /// Get the specified role eligibility schedule for a resource scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilitySchedules/{roleEligibilityScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilitySchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleEligibilityScheduleName"> The name (guid) of the role eligibility schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleEligibilityScheduleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleEligibilityScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<RoleEligibilityScheduleResource>> GetRoleEligibilityScheduleAsync(string roleEligibilityScheduleName, CancellationToken cancellationToken = default)
        {
            return await GetRoleEligibilitySchedules().GetAsync(roleEligibilityScheduleName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the specified role eligibility schedule for a resource scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilitySchedules/{roleEligibilityScheduleName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilitySchedules_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleEligibilityScheduleName"> The name (guid) of the role eligibility schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleEligibilityScheduleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleEligibilityScheduleName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<RoleEligibilityScheduleResource> GetRoleEligibilitySchedule(string roleEligibilityScheduleName, CancellationToken cancellationToken = default)
        {
            return GetRoleEligibilitySchedules().Get(roleEligibilityScheduleName, cancellationToken);
        }

        /// <summary> Gets a collection of RoleEligibilityScheduleInstanceResources in the ArmResource. </summary>
        /// <returns> An object representing collection of RoleEligibilityScheduleInstanceResources and their operations over a RoleEligibilityScheduleInstanceResource. </returns>
        public virtual RoleEligibilityScheduleInstanceCollection GetRoleEligibilityScheduleInstances()
        {
            return GetCachedClient(client => new RoleEligibilityScheduleInstanceCollection(client, Id));
        }

        /// <summary>
        /// Gets the specified role eligibility schedule instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleInstances/{roleEligibilityScheduleInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleInstances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleEligibilityScheduleInstanceName"> The name (hash of schedule name + time) of the role eligibility schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleEligibilityScheduleInstanceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleEligibilityScheduleInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<RoleEligibilityScheduleInstanceResource>> GetRoleEligibilityScheduleInstanceAsync(string roleEligibilityScheduleInstanceName, CancellationToken cancellationToken = default)
        {
            return await GetRoleEligibilityScheduleInstances().GetAsync(roleEligibilityScheduleInstanceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified role eligibility schedule instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleInstances/{roleEligibilityScheduleInstanceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleInstances_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleEligibilityScheduleInstanceName"> The name (hash of schedule name + time) of the role eligibility schedule to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleEligibilityScheduleInstanceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleEligibilityScheduleInstanceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<RoleEligibilityScheduleInstanceResource> GetRoleEligibilityScheduleInstance(string roleEligibilityScheduleInstanceName, CancellationToken cancellationToken = default)
        {
            return GetRoleEligibilityScheduleInstances().Get(roleEligibilityScheduleInstanceName, cancellationToken);
        }

        /// <summary> Gets a collection of RoleEligibilityScheduleRequestResources in the ArmResource. </summary>
        /// <returns> An object representing collection of RoleEligibilityScheduleRequestResources and their operations over a RoleEligibilityScheduleRequestResource. </returns>
        public virtual RoleEligibilityScheduleRequestCollection GetRoleEligibilityScheduleRequests()
        {
            return GetCachedClient(client => new RoleEligibilityScheduleRequestCollection(client, Id));
        }

        /// <summary>
        /// Get the specified role eligibility schedule request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleRequests/{roleEligibilityScheduleRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleRequests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleEligibilityScheduleRequestName"> The name (guid) of the role eligibility schedule request to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleEligibilityScheduleRequestName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleEligibilityScheduleRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<RoleEligibilityScheduleRequestResource>> GetRoleEligibilityScheduleRequestAsync(string roleEligibilityScheduleRequestName, CancellationToken cancellationToken = default)
        {
            return await GetRoleEligibilityScheduleRequests().GetAsync(roleEligibilityScheduleRequestName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the specified role eligibility schedule request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleRequests/{roleEligibilityScheduleRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleRequests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleEligibilityScheduleRequestName"> The name (guid) of the role eligibility schedule request to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleEligibilityScheduleRequestName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleEligibilityScheduleRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<RoleEligibilityScheduleRequestResource> GetRoleEligibilityScheduleRequest(string roleEligibilityScheduleRequestName, CancellationToken cancellationToken = default)
        {
            return GetRoleEligibilityScheduleRequests().Get(roleEligibilityScheduleRequestName, cancellationToken);
        }

        /// <summary> Gets a collection of RoleManagementPolicyResources in the ArmResource. </summary>
        /// <returns> An object representing collection of RoleManagementPolicyResources and their operations over a RoleManagementPolicyResource. </returns>
        public virtual RoleManagementPolicyCollection GetRoleManagementPolicies()
        {
            return GetCachedClient(client => new RoleManagementPolicyCollection(client, Id));
        }

        /// <summary>
        /// Get the specified role management policy for a resource scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleManagementPolicies/{roleManagementPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleManagementPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleManagementPolicyName"> The name (guid) of the role management policy to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleManagementPolicyName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleManagementPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<RoleManagementPolicyResource>> GetRoleManagementPolicyAsync(string roleManagementPolicyName, CancellationToken cancellationToken = default)
        {
            return await GetRoleManagementPolicies().GetAsync(roleManagementPolicyName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the specified role management policy for a resource scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleManagementPolicies/{roleManagementPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleManagementPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleManagementPolicyName"> The name (guid) of the role management policy to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleManagementPolicyName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleManagementPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<RoleManagementPolicyResource> GetRoleManagementPolicy(string roleManagementPolicyName, CancellationToken cancellationToken = default)
        {
            return GetRoleManagementPolicies().Get(roleManagementPolicyName, cancellationToken);
        }

        /// <summary> Gets a collection of RoleManagementPolicyAssignmentResources in the ArmResource. </summary>
        /// <returns> An object representing collection of RoleManagementPolicyAssignmentResources and their operations over a RoleManagementPolicyAssignmentResource. </returns>
        public virtual RoleManagementPolicyAssignmentCollection GetRoleManagementPolicyAssignments()
        {
            return GetCachedClient(client => new RoleManagementPolicyAssignmentCollection(client, Id));
        }

        /// <summary>
        /// Get the specified role management policy assignment for a resource scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleManagementPolicyAssignments/{roleManagementPolicyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleManagementPolicyAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleManagementPolicyAssignmentName"> The name of format {guid_guid} the role management policy assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleManagementPolicyAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleManagementPolicyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<RoleManagementPolicyAssignmentResource>> GetRoleManagementPolicyAssignmentAsync(string roleManagementPolicyAssignmentName, CancellationToken cancellationToken = default)
        {
            return await GetRoleManagementPolicyAssignments().GetAsync(roleManagementPolicyAssignmentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the specified role management policy assignment for a resource scope
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleManagementPolicyAssignments/{roleManagementPolicyAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleManagementPolicyAssignments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleManagementPolicyAssignmentName"> The name of format {guid_guid} the role management policy assignment to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleManagementPolicyAssignmentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="roleManagementPolicyAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<RoleManagementPolicyAssignmentResource> GetRoleManagementPolicyAssignment(string roleManagementPolicyAssignmentName, CancellationToken cancellationToken = default)
        {
            return GetRoleManagementPolicyAssignments().Get(roleManagementPolicyAssignmentName, cancellationToken);
        }
    }
}
