// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Confluent.Models
{
    /// <summary> Subscriber detail. </summary>
    public partial class ConfluentUserDetail
    {
        /// <summary> Initializes a new instance of ConfluentUserDetail. </summary>
        /// <param name="emailAddress"> Email address. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="emailAddress"/> is null. </exception>
        public ConfluentUserDetail(string emailAddress)
        {
            Argument.AssertNotNull(emailAddress, nameof(emailAddress));

            EmailAddress = emailAddress;
        }

        /// <summary> Initializes a new instance of ConfluentUserDetail. </summary>
        /// <param name="firstName"> First name. </param>
        /// <param name="lastName"> Last name. </param>
        /// <param name="emailAddress"> Email address. </param>
        internal ConfluentUserDetail(string firstName, string lastName, string emailAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
        }

        /// <summary> First name. </summary>
        public string FirstName { get; set; }
        /// <summary> Last name. </summary>
        public string LastName { get; set; }
        /// <summary> Email address. </summary>
        public string EmailAddress { get; set; }
    }
}
