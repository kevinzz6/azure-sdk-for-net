// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.IoT.Hub.Service.Models;

namespace Azure.IoT.Hub.Service
{
    internal partial class QueryRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of QueryRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public QueryRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null, string apiVersion = "2020-03-13")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://fully-qualified-iothubname.azure-devices.net");
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateGetTwinsRequest(QuerySpecification querySpecification, string xMsContinuation, string xMsMaxItemCount)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/devices/query", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            if (xMsContinuation != null)
            {
                request.Headers.Add("x-ms-continuation", xMsContinuation);
            }
            if (xMsMaxItemCount != null)
            {
                request.Headers.Add("x-ms-max-item-count", xMsMaxItemCount);
            }
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(querySpecification);
            request.Content = content;
            return message;
        }

        /// <summary> Query an IoT Hub to retrieve information regarding device twins using a SQL-like language. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language for more information. Pagination is supported. This returns information about device twins only. </summary>
        /// <param name="querySpecification"> The query string. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language for more information. </param>
        /// <param name="xMsContinuation"> The continuation token used to get the next page of results. </param>
        /// <param name="xMsMaxItemCount"> The maximum number of items returned per page. The service may use a different value if the value specified is not acceptable. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="querySpecification"/> is null. </exception>
        public async Task<ResponseWithHeaders<IReadOnlyList<TwinData>, QueryGetTwinsHeaders>> GetTwinsAsync(QuerySpecification querySpecification, string xMsContinuation = null, string xMsMaxItemCount = null, CancellationToken cancellationToken = default)
        {
            if (querySpecification == null)
            {
                throw new ArgumentNullException(nameof(querySpecification));
            }

            using var message = CreateGetTwinsRequest(querySpecification, xMsContinuation, xMsMaxItemCount);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            var headers = new QueryGetTwinsHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<TwinData> value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        List<TwinData> array = new List<TwinData>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(TwinData.DeserializeTwinData(item));
                        }
                        value = array;
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw await ClientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Query an IoT Hub to retrieve information regarding device twins using a SQL-like language. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language for more information. Pagination is supported. This returns information about device twins only. </summary>
        /// <param name="querySpecification"> The query string. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language for more information. </param>
        /// <param name="xMsContinuation"> The continuation token used to get the next page of results. </param>
        /// <param name="xMsMaxItemCount"> The maximum number of items returned per page. The service may use a different value if the value specified is not acceptable. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="querySpecification"/> is null. </exception>
        public ResponseWithHeaders<IReadOnlyList<TwinData>, QueryGetTwinsHeaders> GetTwins(QuerySpecification querySpecification, string xMsContinuation = null, string xMsMaxItemCount = null, CancellationToken cancellationToken = default)
        {
            if (querySpecification == null)
            {
                throw new ArgumentNullException(nameof(querySpecification));
            }

            using var message = CreateGetTwinsRequest(querySpecification, xMsContinuation, xMsMaxItemCount);
            _pipeline.Send(message, cancellationToken);
            var headers = new QueryGetTwinsHeaders(message.Response);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        IReadOnlyList<TwinData> value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        List<TwinData> array = new List<TwinData>();
                        foreach (var item in document.RootElement.EnumerateArray())
                        {
                            array.Add(TwinData.DeserializeTwinData(item));
                        }
                        value = array;
                        return ResponseWithHeaders.FromValue(value, headers, message.Response);
                    }
                default:
                    throw ClientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
