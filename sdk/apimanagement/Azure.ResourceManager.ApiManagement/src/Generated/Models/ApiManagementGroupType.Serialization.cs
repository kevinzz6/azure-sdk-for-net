// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ApiManagement.Models
{
    internal static partial class ApiManagementGroupTypeExtensions
    {
        public static string ToSerialString(this ApiManagementGroupType value) => value switch
        {
            ApiManagementGroupType.Custom => "custom",
            ApiManagementGroupType.System => "system",
            ApiManagementGroupType.External => "external",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ApiManagementGroupType value.")
        };

        public static ApiManagementGroupType ToApiManagementGroupType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "custom")) return ApiManagementGroupType.Custom;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "system")) return ApiManagementGroupType.System;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "external")) return ApiManagementGroupType.External;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ApiManagementGroupType value.");
        }
    }
}
