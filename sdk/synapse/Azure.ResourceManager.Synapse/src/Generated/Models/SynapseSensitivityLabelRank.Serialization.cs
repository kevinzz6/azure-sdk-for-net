// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Synapse.Models
{
    internal static partial class SynapseSensitivityLabelRankExtensions
    {
        public static string ToSerialString(this SynapseSensitivityLabelRank value) => value switch
        {
            SynapseSensitivityLabelRank.None => "None",
            SynapseSensitivityLabelRank.Low => "Low",
            SynapseSensitivityLabelRank.Medium => "Medium",
            SynapseSensitivityLabelRank.High => "High",
            SynapseSensitivityLabelRank.Critical => "Critical",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SynapseSensitivityLabelRank value.")
        };

        public static SynapseSensitivityLabelRank ToSynapseSensitivityLabelRank(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "None")) return SynapseSensitivityLabelRank.None;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Low")) return SynapseSensitivityLabelRank.Low;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Medium")) return SynapseSensitivityLabelRank.Medium;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "High")) return SynapseSensitivityLabelRank.High;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Critical")) return SynapseSensitivityLabelRank.Critical;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SynapseSensitivityLabelRank value.");
        }
    }
}
