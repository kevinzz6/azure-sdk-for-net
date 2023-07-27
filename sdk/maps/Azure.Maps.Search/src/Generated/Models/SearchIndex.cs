// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Maps.Search
{
    /// <summary> The SearchIndexes. </summary>
    public readonly partial struct SearchIndex : IEquatable<SearchIndex>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SearchIndex"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SearchIndex(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AddressesValue = "Addr";
        private const string GeographiesValue = "Geo";
        private const string PointAddressesValue = "PAD";
        private const string PointsOfInterestValue = "POI";
        private const string StreetsValue = "Str";
        private const string CrossStreetsValue = "Xstr";
        /// <summary> Geographies. </summary>
        public static SearchIndex Geographies { get; } = new SearchIndex(GeographiesValue);
        /// <summary> Point Addresses. </summary>
        public static SearchIndex PointAddresses { get; } = new SearchIndex(PointAddressesValue);
        /// <summary> Points of interest. </summary>
        public static SearchIndex PointsOfInterest { get; } = new SearchIndex(PointsOfInterestValue);
        /// <summary> Streets. </summary>
        public static SearchIndex Streets { get; } = new SearchIndex(StreetsValue);
        /// <summary> Cross Streets (Intersections). </summary>
        public static SearchIndex CrossStreets { get; } = new SearchIndex(CrossStreetsValue);
        /// <summary> Determines if two <see cref="SearchIndex"/> values are the same. </summary>
        public static bool operator ==(SearchIndex left, SearchIndex right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SearchIndex"/> values are not the same. </summary>
        public static bool operator !=(SearchIndex left, SearchIndex right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SearchIndex"/>. </summary>
        public static implicit operator SearchIndex(string value) => new SearchIndex(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SearchIndex other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SearchIndex other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
