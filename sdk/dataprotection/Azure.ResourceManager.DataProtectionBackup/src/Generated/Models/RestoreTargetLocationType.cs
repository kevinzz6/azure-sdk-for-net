// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary>
    /// Denotes the target location where the data will be restored,
    /// string value for the enum {Microsoft.Internal.AzureBackup.DataProtection.Common.Interface.RestoreTargetLocationType}
    /// </summary>
    public readonly partial struct RestoreTargetLocationType : IEquatable<RestoreTargetLocationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RestoreTargetLocationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RestoreTargetLocationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string AzureBlobsValue = "AzureBlobs";
        private const string AzureFilesValue = "AzureFiles";

        /// <summary> Invalid. </summary>
        public static RestoreTargetLocationType Invalid { get; } = new RestoreTargetLocationType(InvalidValue);
        /// <summary> AzureBlobs. </summary>
        public static RestoreTargetLocationType AzureBlobs { get; } = new RestoreTargetLocationType(AzureBlobsValue);
        /// <summary> AzureFiles. </summary>
        public static RestoreTargetLocationType AzureFiles { get; } = new RestoreTargetLocationType(AzureFilesValue);
        /// <summary> Determines if two <see cref="RestoreTargetLocationType"/> values are the same. </summary>
        public static bool operator ==(RestoreTargetLocationType left, RestoreTargetLocationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RestoreTargetLocationType"/> values are not the same. </summary>
        public static bool operator !=(RestoreTargetLocationType left, RestoreTargetLocationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RestoreTargetLocationType"/>. </summary>
        public static implicit operator RestoreTargetLocationType(string value) => new RestoreTargetLocationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RestoreTargetLocationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RestoreTargetLocationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
