// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The CapacityReservationGroupInstanceViewType. </summary>
    public readonly partial struct CapacityReservationGroupInstanceViewType : IEquatable<CapacityReservationGroupInstanceViewType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CapacityReservationGroupInstanceViewType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CapacityReservationGroupInstanceViewType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InstanceViewValue = "instanceView";

        /// <summary> instanceView. </summary>
        public static CapacityReservationGroupInstanceViewType InstanceView { get; } = new CapacityReservationGroupInstanceViewType(InstanceViewValue);
        /// <summary> Determines if two <see cref="CapacityReservationGroupInstanceViewType"/> values are the same. </summary>
        public static bool operator ==(CapacityReservationGroupInstanceViewType left, CapacityReservationGroupInstanceViewType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CapacityReservationGroupInstanceViewType"/> values are not the same. </summary>
        public static bool operator !=(CapacityReservationGroupInstanceViewType left, CapacityReservationGroupInstanceViewType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CapacityReservationGroupInstanceViewType"/>. </summary>
        public static implicit operator CapacityReservationGroupInstanceViewType(string value) => new CapacityReservationGroupInstanceViewType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CapacityReservationGroupInstanceViewType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CapacityReservationGroupInstanceViewType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
