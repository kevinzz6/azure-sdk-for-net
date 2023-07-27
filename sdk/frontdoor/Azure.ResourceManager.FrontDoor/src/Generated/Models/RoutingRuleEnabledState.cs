// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Whether to enable use of this rule. Permitted values are 'Enabled' or 'Disabled'. </summary>
    public readonly partial struct RoutingRuleEnabledState : IEquatable<RoutingRuleEnabledState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RoutingRuleEnabledState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RoutingRuleEnabledState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static RoutingRuleEnabledState Enabled { get; } = new RoutingRuleEnabledState(EnabledValue);
        /// <summary> Disabled. </summary>
        public static RoutingRuleEnabledState Disabled { get; } = new RoutingRuleEnabledState(DisabledValue);
        /// <summary> Determines if two <see cref="RoutingRuleEnabledState"/> values are the same. </summary>
        public static bool operator ==(RoutingRuleEnabledState left, RoutingRuleEnabledState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RoutingRuleEnabledState"/> values are not the same. </summary>
        public static bool operator !=(RoutingRuleEnabledState left, RoutingRuleEnabledState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RoutingRuleEnabledState"/>. </summary>
        public static implicit operator RoutingRuleEnabledState(string value) => new RoutingRuleEnabledState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RoutingRuleEnabledState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RoutingRuleEnabledState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
