// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Schedule for backup. </summary>
    public partial class DataProtectionBackupSchedule
    {
        /// <summary> Initializes a new instance of DataProtectionBackupSchedule. </summary>
        /// <param name="repeatingTimeIntervals"> ISO 8601 repeating time interval format. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="repeatingTimeIntervals"/> is null. </exception>
        public DataProtectionBackupSchedule(IEnumerable<string> repeatingTimeIntervals)
        {
            Argument.AssertNotNull(repeatingTimeIntervals, nameof(repeatingTimeIntervals));

            RepeatingTimeIntervals = repeatingTimeIntervals.ToList();
        }

        /// <summary> Initializes a new instance of DataProtectionBackupSchedule. </summary>
        /// <param name="repeatingTimeIntervals"> ISO 8601 repeating time interval format. </param>
        /// <param name="timeZone"> Time zone for a schedule. Example: Pacific Standard Time. </param>
        internal DataProtectionBackupSchedule(IList<string> repeatingTimeIntervals, string timeZone)
        {
            RepeatingTimeIntervals = repeatingTimeIntervals;
            TimeZone = timeZone;
        }

        /// <summary> ISO 8601 repeating time interval format. </summary>
        public IList<string> RepeatingTimeIntervals { get; }
        /// <summary> Time zone for a schedule. Example: Pacific Standard Time. </summary>
        public string TimeZone { get; set; }
    }
}
