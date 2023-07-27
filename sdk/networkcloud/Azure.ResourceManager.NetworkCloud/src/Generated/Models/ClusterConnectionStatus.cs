// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> The latest heartbeat status between the cluster manager and the cluster. </summary>
    public readonly partial struct ClusterConnectionStatus : IEquatable<ClusterConnectionStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClusterConnectionStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClusterConnectionStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ConnectedValue = "Connected";
        private const string TimeoutValue = "Timeout";
        private const string UndefinedValue = "Undefined";

        /// <summary> Connected. </summary>
        public static ClusterConnectionStatus Connected { get; } = new ClusterConnectionStatus(ConnectedValue);
        /// <summary> Timeout. </summary>
        public static ClusterConnectionStatus Timeout { get; } = new ClusterConnectionStatus(TimeoutValue);
        /// <summary> Undefined. </summary>
        public static ClusterConnectionStatus Undefined { get; } = new ClusterConnectionStatus(UndefinedValue);
        /// <summary> Determines if two <see cref="ClusterConnectionStatus"/> values are the same. </summary>
        public static bool operator ==(ClusterConnectionStatus left, ClusterConnectionStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClusterConnectionStatus"/> values are not the same. </summary>
        public static bool operator !=(ClusterConnectionStatus left, ClusterConnectionStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ClusterConnectionStatus"/>. </summary>
        public static implicit operator ClusterConnectionStatus(string value) => new ClusterConnectionStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClusterConnectionStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClusterConnectionStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
