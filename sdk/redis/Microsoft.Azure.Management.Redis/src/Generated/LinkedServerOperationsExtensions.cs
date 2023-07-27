// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Redis
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for LinkedServerOperations.
    /// </summary>
    public static partial class LinkedServerOperationsExtensions
    {
            /// <summary>
            /// Adds a linked server to the Redis cache (requires Premium SKU).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the Redis cache.
            /// </param>
            /// <param name='linkedServerName'>
            /// The name of the linked server that is being added to the Redis cache.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create Linked server operation.
            /// </param>
            public static RedisLinkedServerWithProperties Create(this ILinkedServerOperations operations, string resourceGroupName, string name, string linkedServerName, RedisLinkedServerCreateParameters parameters)
            {
                return operations.CreateAsync(resourceGroupName, name, linkedServerName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds a linked server to the Redis cache (requires Premium SKU).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the Redis cache.
            /// </param>
            /// <param name='linkedServerName'>
            /// The name of the linked server that is being added to the Redis cache.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create Linked server operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RedisLinkedServerWithProperties> CreateAsync(this ILinkedServerOperations operations, string resourceGroupName, string name, string linkedServerName, RedisLinkedServerCreateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, name, linkedServerName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the linked server from a redis cache (requires Premium SKU).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the redis cache.
            /// </param>
            /// <param name='linkedServerName'>
            /// The name of the linked server that is being added to the Redis cache.
            /// </param>
            public static void Delete(this ILinkedServerOperations operations, string resourceGroupName, string name, string linkedServerName)
            {
                operations.DeleteAsync(resourceGroupName, name, linkedServerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the linked server from a redis cache (requires Premium SKU).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the redis cache.
            /// </param>
            /// <param name='linkedServerName'>
            /// The name of the linked server that is being added to the Redis cache.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ILinkedServerOperations operations, string resourceGroupName, string name, string linkedServerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, name, linkedServerName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the detailed information about a linked server of a redis cache
            /// (requires Premium SKU).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the redis cache.
            /// </param>
            /// <param name='linkedServerName'>
            /// The name of the linked server.
            /// </param>
            public static RedisLinkedServerWithProperties Get(this ILinkedServerOperations operations, string resourceGroupName, string name, string linkedServerName)
            {
                return operations.GetAsync(resourceGroupName, name, linkedServerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the detailed information about a linked server of a redis cache
            /// (requires Premium SKU).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the redis cache.
            /// </param>
            /// <param name='linkedServerName'>
            /// The name of the linked server.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RedisLinkedServerWithProperties> GetAsync(this ILinkedServerOperations operations, string resourceGroupName, string name, string linkedServerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, name, linkedServerName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of linked servers associated with this redis cache (requires
            /// Premium SKU).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the redis cache.
            /// </param>
            public static IPage<RedisLinkedServerWithProperties> List(this ILinkedServerOperations operations, string resourceGroupName, string name)
            {
                return operations.ListAsync(resourceGroupName, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of linked servers associated with this redis cache (requires
            /// Premium SKU).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the redis cache.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RedisLinkedServerWithProperties>> ListAsync(this ILinkedServerOperations operations, string resourceGroupName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Adds a linked server to the Redis cache (requires Premium SKU).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the Redis cache.
            /// </param>
            /// <param name='linkedServerName'>
            /// The name of the linked server that is being added to the Redis cache.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create Linked server operation.
            /// </param>
            public static RedisLinkedServerWithProperties BeginCreate(this ILinkedServerOperations operations, string resourceGroupName, string name, string linkedServerName, RedisLinkedServerCreateParameters parameters)
            {
                return operations.BeginCreateAsync(resourceGroupName, name, linkedServerName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds a linked server to the Redis cache (requires Premium SKU).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the Redis cache.
            /// </param>
            /// <param name='linkedServerName'>
            /// The name of the linked server that is being added to the Redis cache.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create Linked server operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RedisLinkedServerWithProperties> BeginCreateAsync(this ILinkedServerOperations operations, string resourceGroupName, string name, string linkedServerName, RedisLinkedServerCreateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, name, linkedServerName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the linked server from a redis cache (requires Premium SKU).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the redis cache.
            /// </param>
            /// <param name='linkedServerName'>
            /// The name of the linked server that is being added to the Redis cache.
            /// </param>
            public static void BeginDelete(this ILinkedServerOperations operations, string resourceGroupName, string name, string linkedServerName)
            {
                operations.BeginDeleteAsync(resourceGroupName, name, linkedServerName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the linked server from a redis cache (requires Premium SKU).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the redis cache.
            /// </param>
            /// <param name='linkedServerName'>
            /// The name of the linked server that is being added to the Redis cache.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this ILinkedServerOperations operations, string resourceGroupName, string name, string linkedServerName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, name, linkedServerName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the list of linked servers associated with this redis cache (requires
            /// Premium SKU).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RedisLinkedServerWithProperties> ListNext(this ILinkedServerOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of linked servers associated with this redis cache (requires
            /// Premium SKU).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RedisLinkedServerWithProperties>> ListNextAsync(this ILinkedServerOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
