// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The UnknownMetricAlertCriteria. </summary>
    internal partial class UnknownMetricAlertCriteria : MetricAlertCriteria
    {
        /// <summary> Initializes a new instance of UnknownMetricAlertCriteria. </summary>
        /// <param name="odataType"> specifies the type of the alert criteria. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal UnknownMetricAlertCriteria(MonitorOdataType odataType, IDictionary<string, BinaryData> additionalProperties) : base(odataType, additionalProperties)
        {
            OdataType = odataType;
        }
    }
}
