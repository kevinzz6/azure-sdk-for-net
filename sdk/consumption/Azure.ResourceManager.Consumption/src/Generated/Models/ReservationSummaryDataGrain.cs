// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> The ReservationSummaryDataGrain. </summary>
    public readonly partial struct ReservationSummaryDataGrain : IEquatable<ReservationSummaryDataGrain>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ReservationSummaryDataGrain"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ReservationSummaryDataGrain(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DailyGrainValue = "daily";
        private const string MonthlyGrainValue = "monthly";

        /// <summary> Daily grain of data. </summary>
        public static ReservationSummaryDataGrain DailyGrain { get; } = new ReservationSummaryDataGrain(DailyGrainValue);
        /// <summary> Monthly grain of data. </summary>
        public static ReservationSummaryDataGrain MonthlyGrain { get; } = new ReservationSummaryDataGrain(MonthlyGrainValue);
        /// <summary> Determines if two <see cref="ReservationSummaryDataGrain"/> values are the same. </summary>
        public static bool operator ==(ReservationSummaryDataGrain left, ReservationSummaryDataGrain right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ReservationSummaryDataGrain"/> values are not the same. </summary>
        public static bool operator !=(ReservationSummaryDataGrain left, ReservationSummaryDataGrain right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ReservationSummaryDataGrain"/>. </summary>
        public static implicit operator ReservationSummaryDataGrain(string value) => new ReservationSummaryDataGrain(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ReservationSummaryDataGrain other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ReservationSummaryDataGrain other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
