// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Search.Documents.Models
{
    /// <summary> The way the field was used for the semantic enrichment process. </summary>
    public readonly partial struct SemanticFieldState : IEquatable<SemanticFieldState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SemanticFieldState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SemanticFieldState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UsedValue = "used";
        private const string UnusedValue = "unused";
        private const string PartialValue = "partial";

        /// <summary> The field was fully used for semantic enrichment. </summary>
        public static SemanticFieldState Used { get; } = new SemanticFieldState(UsedValue);
        /// <summary> The field was not used for semantic enrichment. </summary>
        public static SemanticFieldState Unused { get; } = new SemanticFieldState(UnusedValue);
        /// <summary> The field was partially used for semantic enrichment. </summary>
        public static SemanticFieldState Partial { get; } = new SemanticFieldState(PartialValue);
        /// <summary> Determines if two <see cref="SemanticFieldState"/> values are the same. </summary>
        public static bool operator ==(SemanticFieldState left, SemanticFieldState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SemanticFieldState"/> values are not the same. </summary>
        public static bool operator !=(SemanticFieldState left, SemanticFieldState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SemanticFieldState"/>. </summary>
        public static implicit operator SemanticFieldState(string value) => new SemanticFieldState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SemanticFieldState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SemanticFieldState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
