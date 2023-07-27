// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication
{
    /// <summary> The CommunicationIdentifierModel. </summary>
    internal partial class CommunicationIdentifierModel
    {
        /// <summary> Initializes a new instance of CommunicationIdentifierModel. </summary>
        public CommunicationIdentifierModel()
        {
        }

        /// <summary> Initializes a new instance of CommunicationIdentifierModel. </summary>
        /// <param name="rawId"> Full ID of the identifier. </param>
        /// <param name="kind"> Type of CommunicationIdentifierModel. </param>
        /// <param name="communicationUser"> The communication user. </param>
        /// <param name="phoneNumber"> The phone number. </param>
        /// <param name="microsoftTeamsUser"> The Microsoft Teams user. </param>
        internal CommunicationIdentifierModel(string rawId, CommunicationIdentifierModelKind? kind, CommunicationUserIdentifierModel communicationUser, PhoneNumberIdentifierModel phoneNumber, MicrosoftTeamsUserIdentifierModel microsoftTeamsUser)
        {
            RawId = rawId;
            Kind = kind;
            CommunicationUser = communicationUser;
            PhoneNumber = phoneNumber;
            MicrosoftTeamsUser = microsoftTeamsUser;
        }

        /// <summary> Full ID of the identifier. </summary>
        public string RawId { get; set; }
        /// <summary> Type of CommunicationIdentifierModel. </summary>
        public CommunicationIdentifierModelKind? Kind { get; set; }
        /// <summary> The communication user. </summary>
        public CommunicationUserIdentifierModel CommunicationUser { get; set; }
        /// <summary> The phone number. </summary>
        public PhoneNumberIdentifierModel PhoneNumber { get; set; }
        /// <summary> The Microsoft Teams user. </summary>
        public MicrosoftTeamsUserIdentifierModel MicrosoftTeamsUser { get; set; }
    }
}
