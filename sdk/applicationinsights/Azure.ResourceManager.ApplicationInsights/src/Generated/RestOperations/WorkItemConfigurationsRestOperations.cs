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
using Azure.ResourceManager.ApplicationInsights.Models;

namespace Azure.ResourceManager.ApplicationInsights
{
    internal partial class WorkItemConfigurationsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of WorkItemConfigurationsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public WorkItemConfigurationsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2015-05-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string resourceName)
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
            uri.AppendPath("/providers/Microsoft.Insights/components/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/WorkItemConfigs", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets the list work item configurations that exist for the application. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<WorkItemConfigurationsListResult>> ListAsync(string subscriptionId, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, resourceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WorkItemConfigurationsListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = WorkItemConfigurationsListResult.DeserializeWorkItemConfigurationsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets the list work item configurations that exist for the application. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<WorkItemConfigurationsListResult> List(string subscriptionId, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, resourceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WorkItemConfigurationsListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = WorkItemConfigurationsListResult.DeserializeWorkItemConfigurationsListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string subscriptionId, string resourceGroupName, string resourceName, WorkItemCreateConfiguration workItemConfigurationProperties)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Insights/components/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/WorkItemConfigs", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(workItemConfigurationProperties);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Create a work item configuration for an Application Insights component. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="workItemConfigurationProperties"> Properties that need to be specified to create a work item configuration of a Application Insights component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="workItemConfigurationProperties"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<WorkItemConfiguration>> CreateAsync(string subscriptionId, string resourceGroupName, string resourceName, WorkItemCreateConfiguration workItemConfigurationProperties, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNull(workItemConfigurationProperties, nameof(workItemConfigurationProperties));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, resourceName, workItemConfigurationProperties);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WorkItemConfiguration value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = WorkItemConfiguration.DeserializeWorkItemConfiguration(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Create a work item configuration for an Application Insights component. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="workItemConfigurationProperties"> Properties that need to be specified to create a work item configuration of a Application Insights component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="workItemConfigurationProperties"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<WorkItemConfiguration> Create(string subscriptionId, string resourceGroupName, string resourceName, WorkItemCreateConfiguration workItemConfigurationProperties, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNull(workItemConfigurationProperties, nameof(workItemConfigurationProperties));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, resourceName, workItemConfigurationProperties);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WorkItemConfiguration value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = WorkItemConfiguration.DeserializeWorkItemConfiguration(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetDefaultRequest(string subscriptionId, string resourceGroupName, string resourceName)
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
            uri.AppendPath("/providers/Microsoft.Insights/components/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/DefaultWorkItemConfig", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets default work item configurations that exist for the application. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<WorkItemConfiguration>> GetDefaultAsync(string subscriptionId, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var message = CreateGetDefaultRequest(subscriptionId, resourceGroupName, resourceName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WorkItemConfiguration value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = WorkItemConfiguration.DeserializeWorkItemConfiguration(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets default work item configurations that exist for the application. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<WorkItemConfiguration> GetDefault(string subscriptionId, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var message = CreateGetDefaultRequest(subscriptionId, resourceGroupName, resourceName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WorkItemConfiguration value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = WorkItemConfiguration.DeserializeWorkItemConfiguration(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string resourceName, string workItemConfigId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Insights/components/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/WorkItemConfigs/", false);
            uri.AppendPath(workItemConfigId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Delete a work item configuration of an Application Insights component. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="workItemConfigId"> The unique work item configuration Id. This can be either friendly name of connector as defined in connector configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="workItemConfigId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="workItemConfigId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string resourceName, string workItemConfigId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(workItemConfigId, nameof(workItemConfigId));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, resourceName, workItemConfigId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Delete a work item configuration of an Application Insights component. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="workItemConfigId"> The unique work item configuration Id. This can be either friendly name of connector as defined in connector configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="workItemConfigId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="workItemConfigId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string resourceName, string workItemConfigId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(workItemConfigId, nameof(workItemConfigId));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, resourceName, workItemConfigId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetItemRequest(string subscriptionId, string resourceGroupName, string resourceName, string workItemConfigId)
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
            uri.AppendPath("/providers/Microsoft.Insights/components/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/WorkItemConfigs/", false);
            uri.AppendPath(workItemConfigId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets specified work item configuration for an Application Insights component. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="workItemConfigId"> The unique work item configuration Id. This can be either friendly name of connector as defined in connector configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="workItemConfigId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="workItemConfigId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<WorkItemConfiguration>> GetItemAsync(string subscriptionId, string resourceGroupName, string resourceName, string workItemConfigId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(workItemConfigId, nameof(workItemConfigId));

            using var message = CreateGetItemRequest(subscriptionId, resourceGroupName, resourceName, workItemConfigId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WorkItemConfiguration value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = WorkItemConfiguration.DeserializeWorkItemConfiguration(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets specified work item configuration for an Application Insights component. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="workItemConfigId"> The unique work item configuration Id. This can be either friendly name of connector as defined in connector configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="workItemConfigId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="workItemConfigId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<WorkItemConfiguration> GetItem(string subscriptionId, string resourceGroupName, string resourceName, string workItemConfigId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(workItemConfigId, nameof(workItemConfigId));

            using var message = CreateGetItemRequest(subscriptionId, resourceGroupName, resourceName, workItemConfigId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WorkItemConfiguration value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = WorkItemConfiguration.DeserializeWorkItemConfiguration(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateItemRequest(string subscriptionId, string resourceGroupName, string resourceName, string workItemConfigId, WorkItemCreateConfiguration workItemConfigurationProperties)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Insights/components/", false);
            uri.AppendPath(resourceName, true);
            uri.AppendPath("/WorkItemConfigs/", false);
            uri.AppendPath(workItemConfigId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(workItemConfigurationProperties);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Update a work item configuration for an Application Insights component. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="workItemConfigId"> The unique work item configuration Id. This can be either friendly name of connector as defined in connector configuration. </param>
        /// <param name="workItemConfigurationProperties"> Properties that need to be specified to update a work item configuration for this Application Insights component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="workItemConfigId"/> or <paramref name="workItemConfigurationProperties"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="workItemConfigId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<WorkItemConfiguration>> UpdateItemAsync(string subscriptionId, string resourceGroupName, string resourceName, string workItemConfigId, WorkItemCreateConfiguration workItemConfigurationProperties, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(workItemConfigId, nameof(workItemConfigId));
            Argument.AssertNotNull(workItemConfigurationProperties, nameof(workItemConfigurationProperties));

            using var message = CreateUpdateItemRequest(subscriptionId, resourceGroupName, resourceName, workItemConfigId, workItemConfigurationProperties);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WorkItemConfiguration value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = WorkItemConfiguration.DeserializeWorkItemConfiguration(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Update a work item configuration for an Application Insights component. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="resourceName"> The name of the Application Insights component resource. </param>
        /// <param name="workItemConfigId"> The unique work item configuration Id. This can be either friendly name of connector as defined in connector configuration. </param>
        /// <param name="workItemConfigurationProperties"> Properties that need to be specified to update a work item configuration for this Application Insights component. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/>, <paramref name="workItemConfigId"/> or <paramref name="workItemConfigurationProperties"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="resourceName"/> or <paramref name="workItemConfigId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<WorkItemConfiguration> UpdateItem(string subscriptionId, string resourceGroupName, string resourceName, string workItemConfigId, WorkItemCreateConfiguration workItemConfigurationProperties, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));
            Argument.AssertNotNullOrEmpty(workItemConfigId, nameof(workItemConfigId));
            Argument.AssertNotNull(workItemConfigurationProperties, nameof(workItemConfigurationProperties));

            using var message = CreateUpdateItemRequest(subscriptionId, resourceGroupName, resourceName, workItemConfigId, workItemConfigurationProperties);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        WorkItemConfiguration value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = WorkItemConfiguration.DeserializeWorkItemConfiguration(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
