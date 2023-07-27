// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The kind of the alert rule. </summary>
    internal readonly partial struct AlertRuleKind : IEquatable<AlertRuleKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AlertRuleKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AlertRuleKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ScheduledValue = "Scheduled";
        private const string MicrosoftSecurityIncidentCreationValue = "MicrosoftSecurityIncidentCreation";
        private const string FusionValue = "Fusion";

        /// <summary> Scheduled. </summary>
        public static AlertRuleKind Scheduled { get; } = new AlertRuleKind(ScheduledValue);
        /// <summary> MicrosoftSecurityIncidentCreation. </summary>
        public static AlertRuleKind MicrosoftSecurityIncidentCreation { get; } = new AlertRuleKind(MicrosoftSecurityIncidentCreationValue);
        /// <summary> Fusion. </summary>
        public static AlertRuleKind Fusion { get; } = new AlertRuleKind(FusionValue);
        /// <summary> Determines if two <see cref="AlertRuleKind"/> values are the same. </summary>
        public static bool operator ==(AlertRuleKind left, AlertRuleKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AlertRuleKind"/> values are not the same. </summary>
        public static bool operator !=(AlertRuleKind left, AlertRuleKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AlertRuleKind"/>. </summary>
        public static implicit operator AlertRuleKind(string value) => new AlertRuleKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AlertRuleKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AlertRuleKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
