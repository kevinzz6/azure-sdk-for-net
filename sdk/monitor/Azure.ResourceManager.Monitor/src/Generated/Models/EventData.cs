// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The Azure event log entries are of type EventData. </summary>
    public partial class EventData
    {
        /// <summary> Initializes a new instance of EventData. </summary>
        internal EventData()
        {
            Claims = new ChangeTrackingDictionary<string, string>();
            Properties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of EventData. </summary>
        /// <param name="authorization"> The sender authorization information. </param>
        /// <param name="claims"> key value pairs to identify ARM permissions. </param>
        /// <param name="caller"> the email address of the user who has performed the operation, the UPN claim or SPN claim based on availability. </param>
        /// <param name="description"> the description of the event. </param>
        /// <param name="id"> the Id of this event as required by ARM for RBAC. It contains the EventDataID and a timestamp information. </param>
        /// <param name="eventDataId"> the event data Id. This is a unique identifier for an event. </param>
        /// <param name="correlationId"> the correlation Id, usually a GUID in the string format. The correlation Id is shared among the events that belong to the same uber operation. </param>
        /// <param name="eventName"> the event name. This value should not be confused with OperationName. For practical purposes, OperationName might be more appealing to end users. </param>
        /// <param name="category"> the event category. </param>
        /// <param name="httpRequest"> the HTTP request info. Usually includes the &apos;clientRequestId&apos;, &apos;clientIpAddress&apos; (IP address of the user who initiated the event) and &apos;method&apos; (HTTP method e.g. PUT). </param>
        /// <param name="level"> the event level. </param>
        /// <param name="resourceGroupName"> the resource group name of the impacted resource. </param>
        /// <param name="resourceProviderName"> the resource provider name of the impacted resource. </param>
        /// <param name="resourceId"> the resource uri that uniquely identifies the resource that caused this event. </param>
        /// <param name="resourceType"> the resource type. </param>
        /// <param name="operationId"> It is usually a GUID shared among the events corresponding to single operation. This value should not be confused with EventName. </param>
        /// <param name="operationName"> the operation name. </param>
        /// <param name="properties"> the set of &lt;Key, Value&gt; pairs (usually a Dictionary&lt;String, String&gt;) that includes details about the event. </param>
        /// <param name="status"> a string describing the status of the operation. Some typical values are: Started, In progress, Succeeded, Failed, Resolved. </param>
        /// <param name="subStatus"> the event sub status. Most of the time, when included, this captures the HTTP status code of the REST call. Common values are: OK (HTTP Status Code: 200), Created (HTTP Status Code: 201), Accepted (HTTP Status Code: 202), No Content (HTTP Status Code: 204), Bad Request(HTTP Status Code: 400), Not Found (HTTP Status Code: 404), Conflict (HTTP Status Code: 409), Internal Server Error (HTTP Status Code: 500), Service Unavailable (HTTP Status Code:503), Gateway Timeout (HTTP Status Code: 504). </param>
        /// <param name="eventTimestamp"> the timestamp of when the event was generated by the Azure service processing the request corresponding the event. It in ISO 8601 format. </param>
        /// <param name="submissionTimestamp"> the timestamp of when the event became available for querying via this API. It is in ISO 8601 format. This value should not be confused eventTimestamp. As there might be a delay between the occurrence time of the event, and the time that the event is submitted to the Azure logging infrastructure. </param>
        /// <param name="subscriptionId"> the Azure subscription Id usually a GUID. </param>
        /// <param name="tenantId"> the Azure tenant Id. </param>
        internal EventData(SenderAuthorization authorization, IReadOnlyDictionary<string, string> claims, string caller, string description, string id, string eventDataId, string correlationId, LocalizableString eventName, LocalizableString category, HttpRequestInfo httpRequest, EventLevel? level, string resourceGroupName, LocalizableString resourceProviderName, string resourceId, LocalizableString resourceType, string operationId, LocalizableString operationName, IReadOnlyDictionary<string, string> properties, LocalizableString status, LocalizableString subStatus, DateTimeOffset? eventTimestamp, DateTimeOffset? submissionTimestamp, string subscriptionId, Guid? tenantId)
        {
            Authorization = authorization;
            Claims = claims;
            Caller = caller;
            Description = description;
            Id = id;
            EventDataId = eventDataId;
            CorrelationId = correlationId;
            EventName = eventName;
            Category = category;
            HttpRequest = httpRequest;
            Level = level;
            ResourceGroupName = resourceGroupName;
            ResourceProviderName = resourceProviderName;
            ResourceId = resourceId;
            ResourceType = resourceType;
            OperationId = operationId;
            OperationName = operationName;
            Properties = properties;
            Status = status;
            SubStatus = subStatus;
            EventTimestamp = eventTimestamp;
            SubmissionTimestamp = submissionTimestamp;
            SubscriptionId = subscriptionId;
            TenantId = tenantId;
        }

        /// <summary> The sender authorization information. </summary>
        public SenderAuthorization Authorization { get; }
        /// <summary> key value pairs to identify ARM permissions. </summary>
        public IReadOnlyDictionary<string, string> Claims { get; }
        /// <summary> the email address of the user who has performed the operation, the UPN claim or SPN claim based on availability. </summary>
        public string Caller { get; }
        /// <summary> the description of the event. </summary>
        public string Description { get; }
        /// <summary> the Id of this event as required by ARM for RBAC. It contains the EventDataID and a timestamp information. </summary>
        public string Id { get; }
        /// <summary> the event data Id. This is a unique identifier for an event. </summary>
        public string EventDataId { get; }
        /// <summary> the correlation Id, usually a GUID in the string format. The correlation Id is shared among the events that belong to the same uber operation. </summary>
        public string CorrelationId { get; }
        /// <summary> the event name. This value should not be confused with OperationName. For practical purposes, OperationName might be more appealing to end users. </summary>
        public LocalizableString EventName { get; }
        /// <summary> the event category. </summary>
        public LocalizableString Category { get; }
        /// <summary> the HTTP request info. Usually includes the &apos;clientRequestId&apos;, &apos;clientIpAddress&apos; (IP address of the user who initiated the event) and &apos;method&apos; (HTTP method e.g. PUT). </summary>
        public HttpRequestInfo HttpRequest { get; }
        /// <summary> the event level. </summary>
        public EventLevel? Level { get; }
        /// <summary> the resource group name of the impacted resource. </summary>
        public string ResourceGroupName { get; }
        /// <summary> the resource provider name of the impacted resource. </summary>
        public LocalizableString ResourceProviderName { get; }
        /// <summary> the resource uri that uniquely identifies the resource that caused this event. </summary>
        public string ResourceId { get; }
        /// <summary> the resource type. </summary>
        public LocalizableString ResourceType { get; }
        /// <summary> It is usually a GUID shared among the events corresponding to single operation. This value should not be confused with EventName. </summary>
        public string OperationId { get; }
        /// <summary> the operation name. </summary>
        public LocalizableString OperationName { get; }
        /// <summary> the set of &lt;Key, Value&gt; pairs (usually a Dictionary&lt;String, String&gt;) that includes details about the event. </summary>
        public IReadOnlyDictionary<string, string> Properties { get; }
        /// <summary> a string describing the status of the operation. Some typical values are: Started, In progress, Succeeded, Failed, Resolved. </summary>
        public LocalizableString Status { get; }
        /// <summary> the event sub status. Most of the time, when included, this captures the HTTP status code of the REST call. Common values are: OK (HTTP Status Code: 200), Created (HTTP Status Code: 201), Accepted (HTTP Status Code: 202), No Content (HTTP Status Code: 204), Bad Request(HTTP Status Code: 400), Not Found (HTTP Status Code: 404), Conflict (HTTP Status Code: 409), Internal Server Error (HTTP Status Code: 500), Service Unavailable (HTTP Status Code:503), Gateway Timeout (HTTP Status Code: 504). </summary>
        public LocalizableString SubStatus { get; }
        /// <summary> the timestamp of when the event was generated by the Azure service processing the request corresponding the event. It in ISO 8601 format. </summary>
        public DateTimeOffset? EventTimestamp { get; }
        /// <summary> the timestamp of when the event became available for querying via this API. It is in ISO 8601 format. This value should not be confused eventTimestamp. As there might be a delay between the occurrence time of the event, and the time that the event is submitted to the Azure logging infrastructure. </summary>
        public DateTimeOffset? SubmissionTimestamp { get; }
        /// <summary> the Azure subscription Id usually a GUID. </summary>
        public string SubscriptionId { get; }
        /// <summary> the Azure tenant Id. </summary>
        public Guid? TenantId { get; }
    }
}
