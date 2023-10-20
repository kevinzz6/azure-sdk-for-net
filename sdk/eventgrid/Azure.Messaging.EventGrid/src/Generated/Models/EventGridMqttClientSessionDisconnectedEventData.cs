// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Event data for Microsoft.EventGrid.MQTTClientSessionDisconnected event. </summary>
    public partial class EventGridMqttClientSessionDisconnectedEventData : EventGridMqttClientEventData
    {
        /// <summary> Initializes a new instance of EventGridMqttClientSessionDisconnectedEventData. </summary>
        internal EventGridMqttClientSessionDisconnectedEventData()
        {
        }

        /// <summary> Initializes a new instance of EventGridMqttClientSessionDisconnectedEventData. </summary>
        /// <param name="clientAuthenticationName"> Unique identifier for the MQTT client that the client presents to the service for authentication. This case-sensitive string can be up to 128 characters long, and supports UTF-8 characters. </param>
        /// <param name="clientName"> Name of the client resource in the Event Grid namespace. </param>
        /// <param name="namespaceName"> Name of the Event Grid namespace where the MQTT client was created or updated. </param>
        /// <param name="clientSessionName"> Unique identifier for the MQTT client's session. This case-sensitive string can be up to 128 characters long, and supports UTF-8 characters. </param>
        /// <param name="sequenceNumber"> A number that helps indicate order of MQTT client session connected or disconnected events. Latest event will have a sequence number that is higher than the previous event. </param>
        /// <param name="disconnectionReason"> Reason for the disconnection of the MQTT client's session. The value could be one of the values in the disconnection reasons table. </param>
        internal EventGridMqttClientSessionDisconnectedEventData(string clientAuthenticationName, string clientName, string namespaceName, string clientSessionName, long? sequenceNumber, EventGridMqttClientDisconnectionReason? disconnectionReason) : base(clientAuthenticationName, clientName, namespaceName)
        {
            ClientSessionName = clientSessionName;
            SequenceNumber = sequenceNumber;
            DisconnectionReason = disconnectionReason;
        }

        /// <summary> Unique identifier for the MQTT client's session. This case-sensitive string can be up to 128 characters long, and supports UTF-8 characters. </summary>
        public string ClientSessionName { get; }
        /// <summary> A number that helps indicate order of MQTT client session connected or disconnected events. Latest event will have a sequence number that is higher than the previous event. </summary>
        public long? SequenceNumber { get; }
        /// <summary> Reason for the disconnection of the MQTT client's session. The value could be one of the values in the disconnection reasons table. </summary>
        public EventGridMqttClientDisconnectionReason? DisconnectionReason { get; }
    }
}
