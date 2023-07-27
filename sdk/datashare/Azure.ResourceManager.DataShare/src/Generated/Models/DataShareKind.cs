// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> Share kind. </summary>
    public readonly partial struct DataShareKind : IEquatable<DataShareKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataShareKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataShareKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CopyBasedValue = "CopyBased";
        private const string InPlaceValue = "InPlace";

        /// <summary> CopyBased. </summary>
        public static DataShareKind CopyBased { get; } = new DataShareKind(CopyBasedValue);
        /// <summary> InPlace. </summary>
        public static DataShareKind InPlace { get; } = new DataShareKind(InPlaceValue);
        /// <summary> Determines if two <see cref="DataShareKind"/> values are the same. </summary>
        public static bool operator ==(DataShareKind left, DataShareKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataShareKind"/> values are not the same. </summary>
        public static bool operator !=(DataShareKind left, DataShareKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataShareKind"/>. </summary>
        public static implicit operator DataShareKind(string value) => new DataShareKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataShareKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataShareKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
