// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Health.Insights.ClinicalMatching
{
    /// <summary> Possible sources of a clinical trial. </summary>
    public readonly partial struct ClinicalTrialSource : IEquatable<ClinicalTrialSource>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClinicalTrialSource"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClinicalTrialSource(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CustomValue = "custom";
        private const string ClinicaltrialsGovValue = "clinicaltrials.gov";

        /// <summary> custom. </summary>
        public static ClinicalTrialSource Custom { get; } = new ClinicalTrialSource(CustomValue);
        /// <summary> clinicaltrials.gov. </summary>
        public static ClinicalTrialSource ClinicaltrialsGov { get; } = new ClinicalTrialSource(ClinicaltrialsGovValue);
        /// <summary> Determines if two <see cref="ClinicalTrialSource"/> values are the same. </summary>
        public static bool operator ==(ClinicalTrialSource left, ClinicalTrialSource right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClinicalTrialSource"/> values are not the same. </summary>
        public static bool operator !=(ClinicalTrialSource left, ClinicalTrialSource right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ClinicalTrialSource"/>. </summary>
        public static implicit operator ClinicalTrialSource(string value) => new ClinicalTrialSource(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClinicalTrialSource other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClinicalTrialSource other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
