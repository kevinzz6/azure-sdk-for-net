// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The kind of the entity. </summary>
    public readonly partial struct SecurityInsightsEntityKind : IEquatable<SecurityInsightsEntityKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsEntityKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityInsightsEntityKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AccountValue = "Account";
        private const string HostValue = "Host";
        private const string FileValue = "File";
        private const string AzureResourceValue = "AzureResource";
        private const string CloudApplicationValue = "CloudApplication";
        private const string DnsResolutionValue = "DnsResolution";
        private const string FileHashValue = "FileHash";
        private const string IPValue = "Ip";
        private const string MalwareValue = "Malware";
        private const string ProcessValue = "Process";
        private const string RegistryKeyValue = "RegistryKey";
        private const string RegistryValueValue = "RegistryValue";
        private const string SecurityGroupValue = "SecurityGroup";
        private const string UriValue = "Url";
        private const string IotDeviceValue = "IoTDevice";
        private const string SecurityAlertValue = "SecurityAlert";
        private const string BookmarkValue = "Bookmark";
        private const string MailClusterValue = "MailCluster";
        private const string MailMessageValue = "MailMessage";
        private const string MailboxValue = "Mailbox";
        private const string SubmissionMailValue = "SubmissionMail";

        /// <summary> Entity represents account in the system. </summary>
        public static SecurityInsightsEntityKind Account { get; } = new SecurityInsightsEntityKind(AccountValue);
        /// <summary> Entity represents host in the system. </summary>
        public static SecurityInsightsEntityKind Host { get; } = new SecurityInsightsEntityKind(HostValue);
        /// <summary> Entity represents file in the system. </summary>
        public static SecurityInsightsEntityKind File { get; } = new SecurityInsightsEntityKind(FileValue);
        /// <summary> Entity represents azure resource in the system. </summary>
        public static SecurityInsightsEntityKind AzureResource { get; } = new SecurityInsightsEntityKind(AzureResourceValue);
        /// <summary> Entity represents cloud application in the system. </summary>
        public static SecurityInsightsEntityKind CloudApplication { get; } = new SecurityInsightsEntityKind(CloudApplicationValue);
        /// <summary> Entity represents dns resolution in the system. </summary>
        public static SecurityInsightsEntityKind DnsResolution { get; } = new SecurityInsightsEntityKind(DnsResolutionValue);
        /// <summary> Entity represents file hash in the system. </summary>
        public static SecurityInsightsEntityKind FileHash { get; } = new SecurityInsightsEntityKind(FileHashValue);
        /// <summary> Entity represents ip in the system. </summary>
        public static SecurityInsightsEntityKind IP { get; } = new SecurityInsightsEntityKind(IPValue);
        /// <summary> Entity represents malware in the system. </summary>
        public static SecurityInsightsEntityKind Malware { get; } = new SecurityInsightsEntityKind(MalwareValue);
        /// <summary> Entity represents process in the system. </summary>
        public static SecurityInsightsEntityKind Process { get; } = new SecurityInsightsEntityKind(ProcessValue);
        /// <summary> Entity represents registry key in the system. </summary>
        public static SecurityInsightsEntityKind RegistryKey { get; } = new SecurityInsightsEntityKind(RegistryKeyValue);
        /// <summary> Entity represents registry value in the system. </summary>
        public static SecurityInsightsEntityKind RegistryValue { get; } = new SecurityInsightsEntityKind(RegistryValueValue);
        /// <summary> Entity represents security group in the system. </summary>
        public static SecurityInsightsEntityKind SecurityGroup { get; } = new SecurityInsightsEntityKind(SecurityGroupValue);
        /// <summary> Entity represents url in the system. </summary>
        public static SecurityInsightsEntityKind Uri { get; } = new SecurityInsightsEntityKind(UriValue);
        /// <summary> Entity represents IoT device in the system. </summary>
        public static SecurityInsightsEntityKind IotDevice { get; } = new SecurityInsightsEntityKind(IotDeviceValue);
        /// <summary> Entity represents security alert in the system. </summary>
        public static SecurityInsightsEntityKind SecurityAlert { get; } = new SecurityInsightsEntityKind(SecurityAlertValue);
        /// <summary> Entity represents bookmark in the system. </summary>
        public static SecurityInsightsEntityKind Bookmark { get; } = new SecurityInsightsEntityKind(BookmarkValue);
        /// <summary> Entity represents mail cluster in the system. </summary>
        public static SecurityInsightsEntityKind MailCluster { get; } = new SecurityInsightsEntityKind(MailClusterValue);
        /// <summary> Entity represents mail message in the system. </summary>
        public static SecurityInsightsEntityKind MailMessage { get; } = new SecurityInsightsEntityKind(MailMessageValue);
        /// <summary> Entity represents mailbox in the system. </summary>
        public static SecurityInsightsEntityKind Mailbox { get; } = new SecurityInsightsEntityKind(MailboxValue);
        /// <summary> Entity represents submission mail in the system. </summary>
        public static SecurityInsightsEntityKind SubmissionMail { get; } = new SecurityInsightsEntityKind(SubmissionMailValue);
        /// <summary> Determines if two <see cref="SecurityInsightsEntityKind"/> values are the same. </summary>
        public static bool operator ==(SecurityInsightsEntityKind left, SecurityInsightsEntityKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityInsightsEntityKind"/> values are not the same. </summary>
        public static bool operator !=(SecurityInsightsEntityKind left, SecurityInsightsEntityKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecurityInsightsEntityKind"/>. </summary>
        public static implicit operator SecurityInsightsEntityKind(string value) => new SecurityInsightsEntityKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityInsightsEntityKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityInsightsEntityKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
