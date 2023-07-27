// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The IdpsSignatureResult. </summary>
    public partial class IdpsSignatureResult
    {
        /// <summary> Initializes a new instance of IdpsSignatureResult. </summary>
        internal IdpsSignatureResult()
        {
            SourcePorts = new ChangeTrackingList<string>();
            DestinationPorts = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of IdpsSignatureResult. </summary>
        /// <param name="signatureId"> The ID of the signature. </param>
        /// <param name="mode"> The current mode enforced, 0 - Disabled, 1 - Alert, 2 -Deny. </param>
        /// <param name="severity"> Describes the severity of signature: 1 - Low, 2 - Medium, 3 - High. </param>
        /// <param name="direction"> Describes in which direction signature is being enforced: 0 - Inbound, 1 - OutBound, 2 - Bidirectional. </param>
        /// <param name="group"> Describes the groups the signature belongs to. </param>
        /// <param name="description"> Describes what is the signature enforces. </param>
        /// <param name="protocol"> Describes the protocol the signatures is being enforced in. </param>
        /// <param name="sourcePorts"> Describes the list of source ports related to this signature. </param>
        /// <param name="destinationPorts"> Describes the list of destination ports related to this signature. </param>
        /// <param name="lastUpdated"> Describes the last updated time of the signature (provided from 3rd party vendor). </param>
        /// <param name="inheritedFromParentPolicy"> Describes if this override is inherited from base policy or not. </param>
        internal IdpsSignatureResult(int? signatureId, FirewallPolicyIdpsSignatureMode? mode, FirewallPolicyIdpsSignatureSeverity? severity, FirewallPolicyIdpsSignatureDirection? direction, string group, string description, string protocol, IReadOnlyList<string> sourcePorts, IReadOnlyList<string> destinationPorts, string lastUpdated, bool? inheritedFromParentPolicy)
        {
            SignatureId = signatureId;
            Mode = mode;
            Severity = severity;
            Direction = direction;
            Group = group;
            Description = description;
            Protocol = protocol;
            SourcePorts = sourcePorts;
            DestinationPorts = destinationPorts;
            LastUpdated = lastUpdated;
            InheritedFromParentPolicy = inheritedFromParentPolicy;
        }

        /// <summary> The ID of the signature. </summary>
        public int? SignatureId { get; }
        /// <summary> The current mode enforced, 0 - Disabled, 1 - Alert, 2 -Deny. </summary>
        public FirewallPolicyIdpsSignatureMode? Mode { get; }
        /// <summary> Describes the severity of signature: 1 - Low, 2 - Medium, 3 - High. </summary>
        public FirewallPolicyIdpsSignatureSeverity? Severity { get; }
        /// <summary> Describes in which direction signature is being enforced: 0 - Inbound, 1 - OutBound, 2 - Bidirectional. </summary>
        public FirewallPolicyIdpsSignatureDirection? Direction { get; }
        /// <summary> Describes the groups the signature belongs to. </summary>
        public string Group { get; }
        /// <summary> Describes what is the signature enforces. </summary>
        public string Description { get; }
        /// <summary> Describes the protocol the signatures is being enforced in. </summary>
        public string Protocol { get; }
        /// <summary> Describes the list of source ports related to this signature. </summary>
        public IReadOnlyList<string> SourcePorts { get; }
        /// <summary> Describes the list of destination ports related to this signature. </summary>
        public IReadOnlyList<string> DestinationPorts { get; }
        /// <summary> Describes the last updated time of the signature (provided from 3rd party vendor). </summary>
        public string LastUpdated { get; }
        /// <summary> Describes if this override is inherited from base policy or not. </summary>
        public bool? InheritedFromParentPolicy { get; }
    }
}
