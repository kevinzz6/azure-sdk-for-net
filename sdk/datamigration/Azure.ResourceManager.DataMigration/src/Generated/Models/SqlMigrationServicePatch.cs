// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> An update to a SQL Migration Service. </summary>
    public partial class SqlMigrationServicePatch
    {
        /// <summary> Initializes a new instance of SqlMigrationServicePatch. </summary>
        public SqlMigrationServicePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
