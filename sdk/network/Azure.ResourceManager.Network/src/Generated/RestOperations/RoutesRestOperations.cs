// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    internal partial class RoutesRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;
        private readonly string _userAgent;

        /// <summary> Initializes a new instance of RoutesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="options"> The client options used to construct the current client. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public RoutesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, ClientOptions options, string subscriptionId, Uri endpoint = null, string apiVersion = "2021-02-01")
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _userAgent = HttpMessageUtilities.GetUserAgentName(this, options);
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string routeTableName, string routeName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/routeTables/", false);
            uri.AppendPath(routeTableName, true);
            uri.AppendPath("/routes/", false);
            uri.AppendPath(routeName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Deletes the specified route from a route table. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="routeTableName"/>, or <paramref name="routeName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string resourceGroupName, string routeTableName, string routeName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (routeTableName == null)
            {
                throw new ArgumentNullException(nameof(routeTableName));
            }
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, routeTableName, routeName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes the specified route from a route table. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="routeTableName"/>, or <paramref name="routeName"/> is null. </exception>
        public Response Delete(string resourceGroupName, string routeTableName, string routeName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (routeTableName == null)
            {
                throw new ArgumentNullException(nameof(routeTableName));
            }
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, routeTableName, routeName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string routeTableName, string routeName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/routeTables/", false);
            uri.AppendPath(routeTableName, true);
            uri.AppendPath("/routes/", false);
            uri.AppendPath(routeName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets the specified route from a route table. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="routeTableName"/>, or <paramref name="routeName"/> is null. </exception>
        public async Task<Response<RouteData>> GetAsync(string resourceGroupName, string routeTableName, string routeName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (routeTableName == null)
            {
                throw new ArgumentNullException(nameof(routeTableName));
            }
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }

            using var message = CreateGetRequest(resourceGroupName, routeTableName, routeName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RouteData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RouteData.DeserializeRouteData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((RouteData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets the specified route from a route table. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="routeTableName"/>, or <paramref name="routeName"/> is null. </exception>
        public Response<RouteData> Get(string resourceGroupName, string routeTableName, string routeName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (routeTableName == null)
            {
                throw new ArgumentNullException(nameof(routeTableName));
            }
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }

            using var message = CreateGetRequest(resourceGroupName, routeTableName, routeName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RouteData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RouteData.DeserializeRouteData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((RouteData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string routeTableName, string routeName, RouteData routeParameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/routeTables/", false);
            uri.AppendPath(routeTableName, true);
            uri.AppendPath("/routes/", false);
            uri.AppendPath(routeName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(routeParameters);
            request.Content = content;
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Creates or updates a route in the specified route table. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="routeParameters"> Parameters supplied to the create or update route operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="routeTableName"/>, <paramref name="routeName"/>, or <paramref name="routeParameters"/> is null. </exception>
        public async Task<Response> CreateOrUpdateAsync(string resourceGroupName, string routeTableName, string routeName, RouteData routeParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (routeTableName == null)
            {
                throw new ArgumentNullException(nameof(routeTableName));
            }
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }
            if (routeParameters == null)
            {
                throw new ArgumentNullException(nameof(routeParameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, routeTableName, routeName, routeParameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates or updates a route in the specified route table. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="routeParameters"> Parameters supplied to the create or update route operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="routeTableName"/>, <paramref name="routeName"/>, or <paramref name="routeParameters"/> is null. </exception>
        public Response CreateOrUpdate(string resourceGroupName, string routeTableName, string routeName, RouteData routeParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (routeTableName == null)
            {
                throw new ArgumentNullException(nameof(routeTableName));
            }
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }
            if (routeParameters == null)
            {
                throw new ArgumentNullException(nameof(routeParameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, routeTableName, routeName, routeParameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAllRequest(string resourceGroupName, string routeTableName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/routeTables/", false);
            uri.AppendPath(routeTableName, true);
            uri.AppendPath("/routes", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets all routes in a route table. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="routeTableName"/> is null. </exception>
        public async Task<Response<RouteListResult>> GetAllAsync(string resourceGroupName, string routeTableName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (routeTableName == null)
            {
                throw new ArgumentNullException(nameof(routeTableName));
            }

            using var message = CreateGetAllRequest(resourceGroupName, routeTableName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RouteListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RouteListResult.DeserializeRouteListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all routes in a route table. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="routeTableName"/> is null. </exception>
        public Response<RouteListResult> GetAll(string resourceGroupName, string routeTableName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (routeTableName == null)
            {
                throw new ArgumentNullException(nameof(routeTableName));
            }

            using var message = CreateGetAllRequest(resourceGroupName, routeTableName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RouteListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RouteListResult.DeserializeRouteListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAllNextPageRequest(string nextLink, string resourceGroupName, string routeTableName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.SetProperty("UserAgentOverride", _userAgent);
            return message;
        }

        /// <summary> Gets all routes in a route table. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="routeTableName"/> is null. </exception>
        public async Task<Response<RouteListResult>> GetAllNextPageAsync(string nextLink, string resourceGroupName, string routeTableName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (routeTableName == null)
            {
                throw new ArgumentNullException(nameof(routeTableName));
            }

            using var message = CreateGetAllNextPageRequest(nextLink, resourceGroupName, routeTableName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RouteListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RouteListResult.DeserializeRouteListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets all routes in a route table. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="routeTableName"> The name of the route table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="resourceGroupName"/>, or <paramref name="routeTableName"/> is null. </exception>
        public Response<RouteListResult> GetAllNextPage(string nextLink, string resourceGroupName, string routeTableName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (routeTableName == null)
            {
                throw new ArgumentNullException(nameof(routeTableName));
            }

            using var message = CreateGetAllNextPageRequest(nextLink, resourceGroupName, routeTableName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RouteListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RouteListResult.DeserializeRouteListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
