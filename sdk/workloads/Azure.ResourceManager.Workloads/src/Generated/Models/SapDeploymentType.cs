// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The type of SAP deployment, single server or Three tier. </summary>
    public readonly partial struct SapDeploymentType : IEquatable<SapDeploymentType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SapDeploymentType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SapDeploymentType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SingleServerValue = "SingleServer";
        private const string ThreeTierValue = "ThreeTier";

        /// <summary> SingleServer. </summary>
        public static SapDeploymentType SingleServer { get; } = new SapDeploymentType(SingleServerValue);
        /// <summary> ThreeTier. </summary>
        public static SapDeploymentType ThreeTier { get; } = new SapDeploymentType(ThreeTierValue);
        /// <summary> Determines if two <see cref="SapDeploymentType"/> values are the same. </summary>
        public static bool operator ==(SapDeploymentType left, SapDeploymentType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SapDeploymentType"/> values are not the same. </summary>
        public static bool operator !=(SapDeploymentType left, SapDeploymentType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SapDeploymentType"/>. </summary>
        public static implicit operator SapDeploymentType(string value) => new SapDeploymentType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SapDeploymentType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SapDeploymentType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
