// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    internal static partial class DataLakeStoreCommitmentTierTypeExtensions
    {
        public static string ToSerialString(this DataLakeStoreCommitmentTierType value) => value switch
        {
            DataLakeStoreCommitmentTierType.Consumption => "Consumption",
            DataLakeStoreCommitmentTierType.Commitment1TB => "Commitment_1TB",
            DataLakeStoreCommitmentTierType.Commitment10TB => "Commitment_10TB",
            DataLakeStoreCommitmentTierType.Commitment100TB => "Commitment_100TB",
            DataLakeStoreCommitmentTierType.Commitment500TB => "Commitment_500TB",
            DataLakeStoreCommitmentTierType.Commitment1PB => "Commitment_1PB",
            DataLakeStoreCommitmentTierType.Commitment5PB => "Commitment_5PB",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DataLakeStoreCommitmentTierType value.")
        };

        public static DataLakeStoreCommitmentTierType ToDataLakeStoreCommitmentTierType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Consumption")) return DataLakeStoreCommitmentTierType.Consumption;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Commitment_1TB")) return DataLakeStoreCommitmentTierType.Commitment1TB;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Commitment_10TB")) return DataLakeStoreCommitmentTierType.Commitment10TB;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Commitment_100TB")) return DataLakeStoreCommitmentTierType.Commitment100TB;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Commitment_500TB")) return DataLakeStoreCommitmentTierType.Commitment500TB;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Commitment_1PB")) return DataLakeStoreCommitmentTierType.Commitment1PB;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Commitment_5PB")) return DataLakeStoreCommitmentTierType.Commitment5PB;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DataLakeStoreCommitmentTierType value.");
        }
    }
}
