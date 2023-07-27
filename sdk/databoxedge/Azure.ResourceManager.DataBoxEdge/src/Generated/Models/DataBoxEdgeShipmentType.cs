// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The DataBoxEdgeShipmentType. </summary>
    public readonly partial struct DataBoxEdgeShipmentType : IEquatable<DataBoxEdgeShipmentType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeShipmentType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataBoxEdgeShipmentType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotApplicableValue = "NotApplicable";
        private const string ShippedToCustomerValue = "ShippedToCustomer";
        private const string SelfPickupValue = "SelfPickup";

        /// <summary> NotApplicable. </summary>
        public static DataBoxEdgeShipmentType NotApplicable { get; } = new DataBoxEdgeShipmentType(NotApplicableValue);
        /// <summary> ShippedToCustomer. </summary>
        public static DataBoxEdgeShipmentType ShippedToCustomer { get; } = new DataBoxEdgeShipmentType(ShippedToCustomerValue);
        /// <summary> SelfPickup. </summary>
        public static DataBoxEdgeShipmentType SelfPickup { get; } = new DataBoxEdgeShipmentType(SelfPickupValue);
        /// <summary> Determines if two <see cref="DataBoxEdgeShipmentType"/> values are the same. </summary>
        public static bool operator ==(DataBoxEdgeShipmentType left, DataBoxEdgeShipmentType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataBoxEdgeShipmentType"/> values are not the same. </summary>
        public static bool operator !=(DataBoxEdgeShipmentType left, DataBoxEdgeShipmentType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataBoxEdgeShipmentType"/>. </summary>
        public static implicit operator DataBoxEdgeShipmentType(string value) => new DataBoxEdgeShipmentType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataBoxEdgeShipmentType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataBoxEdgeShipmentType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
