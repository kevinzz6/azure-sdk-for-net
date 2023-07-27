// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The provisioned state of the resource. </summary>
    public readonly partial struct KustoProvisioningState : IEquatable<KustoProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="KustoProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public KustoProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RunningValue = "Running";
        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string MovingValue = "Moving";
        private const string CanceledValue = "Canceled";

        /// <summary> Running. </summary>
        public static KustoProvisioningState Running { get; } = new KustoProvisioningState(RunningValue);
        /// <summary> Creating. </summary>
        public static KustoProvisioningState Creating { get; } = new KustoProvisioningState(CreatingValue);
        /// <summary> Deleting. </summary>
        public static KustoProvisioningState Deleting { get; } = new KustoProvisioningState(DeletingValue);
        /// <summary> Succeeded. </summary>
        public static KustoProvisioningState Succeeded { get; } = new KustoProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static KustoProvisioningState Failed { get; } = new KustoProvisioningState(FailedValue);
        /// <summary> Moving. </summary>
        public static KustoProvisioningState Moving { get; } = new KustoProvisioningState(MovingValue);
        /// <summary> Canceled. </summary>
        public static KustoProvisioningState Canceled { get; } = new KustoProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="KustoProvisioningState"/> values are the same. </summary>
        public static bool operator ==(KustoProvisioningState left, KustoProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="KustoProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(KustoProvisioningState left, KustoProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="KustoProvisioningState"/>. </summary>
        public static implicit operator KustoProvisioningState(string value) => new KustoProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is KustoProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(KustoProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
