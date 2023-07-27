// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The provisioning state. </summary>
    public readonly partial struct WorkloadNetworkSegmentProvisioningState : IEquatable<WorkloadNetworkSegmentProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WorkloadNetworkSegmentProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WorkloadNetworkSegmentProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string BuildingValue = "Building";
        private const string DeletingValue = "Deleting";
        private const string UpdatingValue = "Updating";
        private const string CanceledValue = "Canceled";

        /// <summary> Succeeded. </summary>
        public static WorkloadNetworkSegmentProvisioningState Succeeded { get; } = new WorkloadNetworkSegmentProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static WorkloadNetworkSegmentProvisioningState Failed { get; } = new WorkloadNetworkSegmentProvisioningState(FailedValue);
        /// <summary> Building. </summary>
        public static WorkloadNetworkSegmentProvisioningState Building { get; } = new WorkloadNetworkSegmentProvisioningState(BuildingValue);
        /// <summary> Deleting. </summary>
        public static WorkloadNetworkSegmentProvisioningState Deleting { get; } = new WorkloadNetworkSegmentProvisioningState(DeletingValue);
        /// <summary> Updating. </summary>
        public static WorkloadNetworkSegmentProvisioningState Updating { get; } = new WorkloadNetworkSegmentProvisioningState(UpdatingValue);
        /// <summary> Canceled. </summary>
        public static WorkloadNetworkSegmentProvisioningState Canceled { get; } = new WorkloadNetworkSegmentProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="WorkloadNetworkSegmentProvisioningState"/> values are the same. </summary>
        public static bool operator ==(WorkloadNetworkSegmentProvisioningState left, WorkloadNetworkSegmentProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WorkloadNetworkSegmentProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(WorkloadNetworkSegmentProvisioningState left, WorkloadNetworkSegmentProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WorkloadNetworkSegmentProvisioningState"/>. </summary>
        public static implicit operator WorkloadNetworkSegmentProvisioningState(string value) => new WorkloadNetworkSegmentProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WorkloadNetworkSegmentProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WorkloadNetworkSegmentProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
