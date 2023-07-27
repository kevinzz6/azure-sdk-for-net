// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Diagnostics data returned from a detector. </summary>
    public partial class ContainerAppDiagnosticsDataApiResult
    {
        /// <summary> Initializes a new instance of ContainerAppDiagnosticsDataApiResult. </summary>
        public ContainerAppDiagnosticsDataApiResult()
        {
        }

        /// <summary> Initializes a new instance of ContainerAppDiagnosticsDataApiResult. </summary>
        /// <param name="table"> Table response. </param>
        /// <param name="renderingProperties"> Details of the table response. </param>
        internal ContainerAppDiagnosticsDataApiResult(ContainerAppDiagnosticDataTableResult table, ContainerAppDiagnosticRendering renderingProperties)
        {
            Table = table;
            RenderingProperties = renderingProperties;
        }

        /// <summary> Table response. </summary>
        public ContainerAppDiagnosticDataTableResult Table { get; set; }
        /// <summary> Details of the table response. </summary>
        public ContainerAppDiagnosticRendering RenderingProperties { get; set; }
    }
}
