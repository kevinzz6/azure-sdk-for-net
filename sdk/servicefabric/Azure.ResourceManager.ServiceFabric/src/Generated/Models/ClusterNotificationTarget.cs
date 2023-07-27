// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> Describes the notification target properties. </summary>
    public partial class ClusterNotificationTarget
    {
        /// <summary> Initializes a new instance of ClusterNotificationTarget. </summary>
        /// <param name="notificationChannel"> The notification channel indicates the type of receivers subscribed to the notification, either user or subscription. </param>
        /// <param name="receivers"> List of targets that subscribe to the notification. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="receivers"/> is null. </exception>
        public ClusterNotificationTarget(ClusterNotificationChannel notificationChannel, IEnumerable<string> receivers)
        {
            Argument.AssertNotNull(receivers, nameof(receivers));

            NotificationChannel = notificationChannel;
            Receivers = receivers.ToList();
        }

        /// <summary> Initializes a new instance of ClusterNotificationTarget. </summary>
        /// <param name="notificationChannel"> The notification channel indicates the type of receivers subscribed to the notification, either user or subscription. </param>
        /// <param name="receivers"> List of targets that subscribe to the notification. </param>
        internal ClusterNotificationTarget(ClusterNotificationChannel notificationChannel, IList<string> receivers)
        {
            NotificationChannel = notificationChannel;
            Receivers = receivers;
        }

        /// <summary> The notification channel indicates the type of receivers subscribed to the notification, either user or subscription. </summary>
        public ClusterNotificationChannel NotificationChannel { get; set; }
        /// <summary> List of targets that subscribe to the notification. </summary>
        public IList<string> Receivers { get; }
    }
}
