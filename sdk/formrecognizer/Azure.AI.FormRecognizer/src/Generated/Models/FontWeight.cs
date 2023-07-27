// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Font weight. </summary>
    public readonly partial struct FontWeight : IEquatable<FontWeight>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FontWeight"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FontWeight(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NormalValue = "normal";
        private const string BoldValue = "bold";

        /// <summary> Characters are represented normally. </summary>
        public static FontWeight Normal { get; } = new FontWeight(NormalValue);
        /// <summary> Characters are represented with thicker strokes. </summary>
        public static FontWeight Bold { get; } = new FontWeight(BoldValue);
        /// <summary> Determines if two <see cref="FontWeight"/> values are the same. </summary>
        public static bool operator ==(FontWeight left, FontWeight right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FontWeight"/> values are not the same. </summary>
        public static bool operator !=(FontWeight left, FontWeight right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FontWeight"/>. </summary>
        public static implicit operator FontWeight(string value) => new FontWeight(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FontWeight other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FontWeight other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
