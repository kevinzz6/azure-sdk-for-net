// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.GuestConfiguration
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for GuestConfigurationAssignmentsVMSSOperations.
    /// </summary>
    public static partial class GuestConfigurationAssignmentsVMSSOperationsExtensions
    {
            /// <summary>
            /// Get information about a guest configuration assignment for VMSS
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='vmssName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='name'>
            /// The guest configuration assignment name.
            /// </param>
            public static GuestConfigurationAssignment Get(this IGuestConfigurationAssignmentsVMSSOperations operations, string resourceGroupName, string vmssName, string name)
            {
                return operations.GetAsync(resourceGroupName, vmssName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get information about a guest configuration assignment for VMSS
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='vmssName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='name'>
            /// The guest configuration assignment name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GuestConfigurationAssignment> GetAsync(this IGuestConfigurationAssignmentsVMSSOperations operations, string resourceGroupName, string vmssName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, vmssName, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a guest configuration assignment for VMSS
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='vmssName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='name'>
            /// The guest configuration assignment name.
            /// </param>
            public static GuestConfigurationAssignment Delete(this IGuestConfigurationAssignmentsVMSSOperations operations, string resourceGroupName, string vmssName, string name)
            {
                return operations.DeleteAsync(resourceGroupName, vmssName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a guest configuration assignment for VMSS
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='vmssName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='name'>
            /// The guest configuration assignment name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GuestConfigurationAssignment> DeleteAsync(this IGuestConfigurationAssignmentsVMSSOperations operations, string resourceGroupName, string vmssName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, vmssName, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all guest configuration assignments for VMSS.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='vmssName'>
            /// The name of the virtual machine scale set.
            /// </param>
            public static IEnumerable<GuestConfigurationAssignment> List(this IGuestConfigurationAssignmentsVMSSOperations operations, string resourceGroupName, string vmssName)
            {
                return operations.ListAsync(resourceGroupName, vmssName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all guest configuration assignments for VMSS.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='vmssName'>
            /// The name of the virtual machine scale set.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<GuestConfigurationAssignment>> ListAsync(this IGuestConfigurationAssignmentsVMSSOperations operations, string resourceGroupName, string vmssName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, vmssName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
