// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The type used for authentication. Type: string. </summary>
    public readonly partial struct SqlServerAuthenticationType : IEquatable<SqlServerAuthenticationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SqlServerAuthenticationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SqlServerAuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SQLValue = "SQL";
        private const string WindowsValue = "Windows";
        private const string UserAssignedManagedIdentityValue = "UserAssignedManagedIdentity";

        /// <summary> SQL. </summary>
        public static SqlServerAuthenticationType SQL { get; } = new SqlServerAuthenticationType(SQLValue);
        /// <summary> Windows. </summary>
        public static SqlServerAuthenticationType Windows { get; } = new SqlServerAuthenticationType(WindowsValue);
        /// <summary> UserAssignedManagedIdentity. </summary>
        public static SqlServerAuthenticationType UserAssignedManagedIdentity { get; } = new SqlServerAuthenticationType(UserAssignedManagedIdentityValue);
        /// <summary> Determines if two <see cref="SqlServerAuthenticationType"/> values are the same. </summary>
        public static bool operator ==(SqlServerAuthenticationType left, SqlServerAuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SqlServerAuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(SqlServerAuthenticationType left, SqlServerAuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SqlServerAuthenticationType"/>. </summary>
        public static implicit operator SqlServerAuthenticationType(string value) => new SqlServerAuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SqlServerAuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SqlServerAuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
