// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> A principal assignment check name availability request. </summary>
    public partial class KustoPoolDatabasePrincipalAssignmentNameAvailabilityContent
    {
        /// <summary> Initializes a new instance of KustoPoolDatabasePrincipalAssignmentNameAvailabilityContent. </summary>
        /// <param name="name"> Principal Assignment resource name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public KustoPoolDatabasePrincipalAssignmentNameAvailabilityContent(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            ResourceType = SynapseDatabasePrincipalAssignmentType.MicrosoftSynapseWorkspacesKustoPoolsDatabasesPrincipalAssignments;
        }

        /// <summary> Principal Assignment resource name. </summary>
        public string Name { get; }
        /// <summary> The type of resource, Microsoft.Synapse/workspaces/kustoPools/databases/principalAssignments. </summary>
        public SynapseDatabasePrincipalAssignmentType ResourceType { get; }
    }
}
