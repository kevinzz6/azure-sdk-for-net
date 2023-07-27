// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Allocation state of the compute. Possible values are: steady - Indicates that the compute is not resizing. There are no changes to the number of compute nodes in the compute in progress. A compute enters this state when it is created and when no operations are being performed on the compute to change the number of compute nodes. resizing - Indicates that the compute is resizing; that is, compute nodes are being added to or removed from the compute. </summary>
    public readonly partial struct MachineLearningAllocationState : IEquatable<MachineLearningAllocationState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningAllocationState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningAllocationState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SteadyValue = "Steady";
        private const string ResizingValue = "Resizing";

        /// <summary> Steady. </summary>
        public static MachineLearningAllocationState Steady { get; } = new MachineLearningAllocationState(SteadyValue);
        /// <summary> Resizing. </summary>
        public static MachineLearningAllocationState Resizing { get; } = new MachineLearningAllocationState(ResizingValue);
        /// <summary> Determines if two <see cref="MachineLearningAllocationState"/> values are the same. </summary>
        public static bool operator ==(MachineLearningAllocationState left, MachineLearningAllocationState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningAllocationState"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningAllocationState left, MachineLearningAllocationState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MachineLearningAllocationState"/>. </summary>
        public static implicit operator MachineLearningAllocationState(string value) => new MachineLearningAllocationState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningAllocationState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningAllocationState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
