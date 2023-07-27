// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The result of the last integration runtime node update. </summary>
    public readonly partial struct SynapseIntegrationRuntimeUpdateResult : IEquatable<SynapseIntegrationRuntimeUpdateResult>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SynapseIntegrationRuntimeUpdateResult"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SynapseIntegrationRuntimeUpdateResult(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string SucceedValue = "Succeed";
        private const string FailValue = "Fail";

        /// <summary> None. </summary>
        public static SynapseIntegrationRuntimeUpdateResult None { get; } = new SynapseIntegrationRuntimeUpdateResult(NoneValue);
        /// <summary> Succeed. </summary>
        public static SynapseIntegrationRuntimeUpdateResult Succeed { get; } = new SynapseIntegrationRuntimeUpdateResult(SucceedValue);
        /// <summary> Fail. </summary>
        public static SynapseIntegrationRuntimeUpdateResult Fail { get; } = new SynapseIntegrationRuntimeUpdateResult(FailValue);
        /// <summary> Determines if two <see cref="SynapseIntegrationRuntimeUpdateResult"/> values are the same. </summary>
        public static bool operator ==(SynapseIntegrationRuntimeUpdateResult left, SynapseIntegrationRuntimeUpdateResult right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SynapseIntegrationRuntimeUpdateResult"/> values are not the same. </summary>
        public static bool operator !=(SynapseIntegrationRuntimeUpdateResult left, SynapseIntegrationRuntimeUpdateResult right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SynapseIntegrationRuntimeUpdateResult"/>. </summary>
        public static implicit operator SynapseIntegrationRuntimeUpdateResult(string value) => new SynapseIntegrationRuntimeUpdateResult(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SynapseIntegrationRuntimeUpdateResult other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SynapseIntegrationRuntimeUpdateResult other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
