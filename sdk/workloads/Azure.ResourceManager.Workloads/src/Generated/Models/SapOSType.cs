// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The OS Type. </summary>
    internal readonly partial struct SapOSType : IEquatable<SapOSType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SapOSType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SapOSType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LinuxValue = "Linux";
        private const string WindowsValue = "Windows";

        /// <summary> Linux. </summary>
        public static SapOSType Linux { get; } = new SapOSType(LinuxValue);
        /// <summary> Windows. </summary>
        public static SapOSType Windows { get; } = new SapOSType(WindowsValue);
        /// <summary> Determines if two <see cref="SapOSType"/> values are the same. </summary>
        public static bool operator ==(SapOSType left, SapOSType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SapOSType"/> values are not the same. </summary>
        public static bool operator !=(SapOSType left, SapOSType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SapOSType"/>. </summary>
        public static implicit operator SapOSType(string value) => new SapOSType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SapOSType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SapOSType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
