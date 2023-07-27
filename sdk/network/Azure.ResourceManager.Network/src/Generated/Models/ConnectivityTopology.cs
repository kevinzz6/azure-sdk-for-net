// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Connectivity topology type. </summary>
    public readonly partial struct ConnectivityTopology : IEquatable<ConnectivityTopology>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ConnectivityTopology"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ConnectivityTopology(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HubAndSpokeValue = "HubAndSpoke";
        private const string MeshValue = "Mesh";

        /// <summary> HubAndSpoke. </summary>
        public static ConnectivityTopology HubAndSpoke { get; } = new ConnectivityTopology(HubAndSpokeValue);
        /// <summary> Mesh. </summary>
        public static ConnectivityTopology Mesh { get; } = new ConnectivityTopology(MeshValue);
        /// <summary> Determines if two <see cref="ConnectivityTopology"/> values are the same. </summary>
        public static bool operator ==(ConnectivityTopology left, ConnectivityTopology right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ConnectivityTopology"/> values are not the same. </summary>
        public static bool operator !=(ConnectivityTopology left, ConnectivityTopology right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ConnectivityTopology"/>. </summary>
        public static implicit operator ConnectivityTopology(string value) => new ConnectivityTopology(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConnectivityTopology other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ConnectivityTopology other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
