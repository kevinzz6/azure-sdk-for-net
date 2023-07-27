// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.DataShare;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> A Synapse Workspace Sql Pool Table data set. </summary>
    public partial class SynapseWorkspaceSqlPoolTableDataSet : ShareDataSetData
    {
        /// <summary> Initializes a new instance of SynapseWorkspaceSqlPoolTableDataSet. </summary>
        /// <param name="synapseWorkspaceSqlPoolTableResourceId"> Resource id of the Synapse Workspace SQL Pool Table. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="synapseWorkspaceSqlPoolTableResourceId"/> is null. </exception>
        public SynapseWorkspaceSqlPoolTableDataSet(ResourceIdentifier synapseWorkspaceSqlPoolTableResourceId)
        {
            Argument.AssertNotNull(synapseWorkspaceSqlPoolTableResourceId, nameof(synapseWorkspaceSqlPoolTableResourceId));

            SynapseWorkspaceSqlPoolTableResourceId = synapseWorkspaceSqlPoolTableResourceId;
            Kind = DataSetKind.SynapseWorkspaceSqlPoolTable;
        }

        /// <summary> Initializes a new instance of SynapseWorkspaceSqlPoolTableDataSet. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of data set. </param>
        /// <param name="dataSetId"> Unique id for identifying a data set resource. </param>
        /// <param name="synapseWorkspaceSqlPoolTableResourceId"> Resource id of the Synapse Workspace SQL Pool Table. </param>
        internal SynapseWorkspaceSqlPoolTableDataSet(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataSetKind kind, Guid? dataSetId, ResourceIdentifier synapseWorkspaceSqlPoolTableResourceId) : base(id, name, resourceType, systemData, kind)
        {
            DataSetId = dataSetId;
            SynapseWorkspaceSqlPoolTableResourceId = synapseWorkspaceSqlPoolTableResourceId;
            Kind = kind;
        }

        /// <summary> Unique id for identifying a data set resource. </summary>
        public Guid? DataSetId { get; }
        /// <summary> Resource id of the Synapse Workspace SQL Pool Table. </summary>
        public ResourceIdentifier SynapseWorkspaceSqlPoolTableResourceId { get; set; }
    }
}
