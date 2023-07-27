// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    internal static partial class DataMaskingFunctionExtensions
    {
        public static string ToSerialString(this DataMaskingFunction value) => value switch
        {
            DataMaskingFunction.Default => "Default",
            DataMaskingFunction.Ccn => "CCN",
            DataMaskingFunction.Email => "Email",
            DataMaskingFunction.Number => "Number",
            DataMaskingFunction.Ssn => "SSN",
            DataMaskingFunction.Text => "Text",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DataMaskingFunction value.")
        };

        public static DataMaskingFunction ToDataMaskingFunction(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Default")) return DataMaskingFunction.Default;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "CCN")) return DataMaskingFunction.Ccn;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Email")) return DataMaskingFunction.Email;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Number")) return DataMaskingFunction.Number;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "SSN")) return DataMaskingFunction.Ssn;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Text")) return DataMaskingFunction.Text;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DataMaskingFunction value.");
        }
    }
}
