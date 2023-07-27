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
using Azure.ResourceManager.Avs.Models;

namespace Azure.ResourceManager.Avs
{
    internal partial class ScriptCmdletsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ScriptCmdletsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ScriptCmdletsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2022-05-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string privateCloudName, string scriptPackageName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.AVS/privateClouds/", false);
            uri.AppendPath(privateCloudName, true);
            uri.AppendPath("/scriptPackages/", false);
            uri.AppendPath(scriptPackageName, true);
            uri.AppendPath("/scriptCmdlets", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List script cmdlet resources available for a private cloud to create a script execution resource on a private cloud. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="scriptPackageName"> Name of the script package in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="scriptPackageName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="scriptPackageName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ScriptCmdletsList>> ListAsync(string subscriptionId, string resourceGroupName, string privateCloudName, string scriptPackageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));
            Argument.AssertNotNullOrEmpty(scriptPackageName, nameof(scriptPackageName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, privateCloudName, scriptPackageName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ScriptCmdletsList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ScriptCmdletsList.DeserializeScriptCmdletsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List script cmdlet resources available for a private cloud to create a script execution resource on a private cloud. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="scriptPackageName"> Name of the script package in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="scriptPackageName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="scriptPackageName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ScriptCmdletsList> List(string subscriptionId, string resourceGroupName, string privateCloudName, string scriptPackageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));
            Argument.AssertNotNullOrEmpty(scriptPackageName, nameof(scriptPackageName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, privateCloudName, scriptPackageName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ScriptCmdletsList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ScriptCmdletsList.DeserializeScriptCmdletsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string privateCloudName, string scriptPackageName, string scriptCmdletName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.AVS/privateClouds/", false);
            uri.AppendPath(privateCloudName, true);
            uri.AppendPath("/scriptPackages/", false);
            uri.AppendPath(scriptPackageName, true);
            uri.AppendPath("/scriptCmdlets/", false);
            uri.AppendPath(scriptCmdletName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Return information about a script cmdlet resource in a specific package on a private cloud. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="scriptPackageName"> Name of the script package in the private cloud. </param>
        /// <param name="scriptCmdletName"> Name of the script cmdlet resource in the script package in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/>, <paramref name="scriptPackageName"/> or <paramref name="scriptCmdletName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/>, <paramref name="scriptPackageName"/> or <paramref name="scriptCmdletName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ScriptCmdletData>> GetAsync(string subscriptionId, string resourceGroupName, string privateCloudName, string scriptPackageName, string scriptCmdletName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));
            Argument.AssertNotNullOrEmpty(scriptPackageName, nameof(scriptPackageName));
            Argument.AssertNotNullOrEmpty(scriptCmdletName, nameof(scriptCmdletName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, privateCloudName, scriptPackageName, scriptCmdletName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ScriptCmdletData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ScriptCmdletData.DeserializeScriptCmdletData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ScriptCmdletData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Return information about a script cmdlet resource in a specific package on a private cloud. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="scriptPackageName"> Name of the script package in the private cloud. </param>
        /// <param name="scriptCmdletName"> Name of the script cmdlet resource in the script package in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/>, <paramref name="scriptPackageName"/> or <paramref name="scriptCmdletName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/>, <paramref name="scriptPackageName"/> or <paramref name="scriptCmdletName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ScriptCmdletData> Get(string subscriptionId, string resourceGroupName, string privateCloudName, string scriptPackageName, string scriptCmdletName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));
            Argument.AssertNotNullOrEmpty(scriptPackageName, nameof(scriptPackageName));
            Argument.AssertNotNullOrEmpty(scriptCmdletName, nameof(scriptCmdletName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, privateCloudName, scriptPackageName, scriptCmdletName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ScriptCmdletData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ScriptCmdletData.DeserializeScriptCmdletData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ScriptCmdletData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string privateCloudName, string scriptPackageName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List script cmdlet resources available for a private cloud to create a script execution resource on a private cloud. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="scriptPackageName"> Name of the script package in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="scriptPackageName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="scriptPackageName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ScriptCmdletsList>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string privateCloudName, string scriptPackageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));
            Argument.AssertNotNullOrEmpty(scriptPackageName, nameof(scriptPackageName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, privateCloudName, scriptPackageName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ScriptCmdletsList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ScriptCmdletsList.DeserializeScriptCmdletsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List script cmdlet resources available for a private cloud to create a script execution resource on a private cloud. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="privateCloudName"> Name of the private cloud. </param>
        /// <param name="scriptPackageName"> Name of the script package in the private cloud. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="scriptPackageName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="privateCloudName"/> or <paramref name="scriptPackageName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ScriptCmdletsList> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string privateCloudName, string scriptPackageName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(privateCloudName, nameof(privateCloudName));
            Argument.AssertNotNullOrEmpty(scriptPackageName, nameof(scriptPackageName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, privateCloudName, scriptPackageName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ScriptCmdletsList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ScriptCmdletsList.DeserializeScriptCmdletsList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
