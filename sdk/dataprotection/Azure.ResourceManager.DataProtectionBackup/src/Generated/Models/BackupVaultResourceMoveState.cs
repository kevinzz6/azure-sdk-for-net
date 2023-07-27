// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Resource move state for backup vault. </summary>
    public readonly partial struct BackupVaultResourceMoveState : IEquatable<BackupVaultResourceMoveState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BackupVaultResourceMoveState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BackupVaultResourceMoveState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string InProgressValue = "InProgress";
        private const string PrepareFailedValue = "PrepareFailed";
        private const string CommitFailedValue = "CommitFailed";
        private const string FailedValue = "Failed";
        private const string PrepareTimedOutValue = "PrepareTimedout";
        private const string CommitTimedOutValue = "CommitTimedout";
        private const string CriticalFailureValue = "CriticalFailure";
        private const string PartialSuccessValue = "PartialSuccess";
        private const string MoveSucceededValue = "MoveSucceeded";

        /// <summary> Unknown. </summary>
        public static BackupVaultResourceMoveState Unknown { get; } = new BackupVaultResourceMoveState(UnknownValue);
        /// <summary> InProgress. </summary>
        public static BackupVaultResourceMoveState InProgress { get; } = new BackupVaultResourceMoveState(InProgressValue);
        /// <summary> PrepareFailed. </summary>
        public static BackupVaultResourceMoveState PrepareFailed { get; } = new BackupVaultResourceMoveState(PrepareFailedValue);
        /// <summary> CommitFailed. </summary>
        public static BackupVaultResourceMoveState CommitFailed { get; } = new BackupVaultResourceMoveState(CommitFailedValue);
        /// <summary> Failed. </summary>
        public static BackupVaultResourceMoveState Failed { get; } = new BackupVaultResourceMoveState(FailedValue);
        /// <summary> PrepareTimedout. </summary>
        public static BackupVaultResourceMoveState PrepareTimedOut { get; } = new BackupVaultResourceMoveState(PrepareTimedOutValue);
        /// <summary> CommitTimedout. </summary>
        public static BackupVaultResourceMoveState CommitTimedOut { get; } = new BackupVaultResourceMoveState(CommitTimedOutValue);
        /// <summary> CriticalFailure. </summary>
        public static BackupVaultResourceMoveState CriticalFailure { get; } = new BackupVaultResourceMoveState(CriticalFailureValue);
        /// <summary> PartialSuccess. </summary>
        public static BackupVaultResourceMoveState PartialSuccess { get; } = new BackupVaultResourceMoveState(PartialSuccessValue);
        /// <summary> MoveSucceeded. </summary>
        public static BackupVaultResourceMoveState MoveSucceeded { get; } = new BackupVaultResourceMoveState(MoveSucceededValue);
        /// <summary> Determines if two <see cref="BackupVaultResourceMoveState"/> values are the same. </summary>
        public static bool operator ==(BackupVaultResourceMoveState left, BackupVaultResourceMoveState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BackupVaultResourceMoveState"/> values are not the same. </summary>
        public static bool operator !=(BackupVaultResourceMoveState left, BackupVaultResourceMoveState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BackupVaultResourceMoveState"/>. </summary>
        public static implicit operator BackupVaultResourceMoveState(string value) => new BackupVaultResourceMoveState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BackupVaultResourceMoveState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BackupVaultResourceMoveState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
