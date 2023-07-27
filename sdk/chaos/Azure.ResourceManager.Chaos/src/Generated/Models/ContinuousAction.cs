// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> Model that represents a continuous action. </summary>
    public partial class ContinuousAction : Action
    {
        /// <summary> Initializes a new instance of ContinuousAction. </summary>
        /// <param name="name"> String that represents a Capability URN. </param>
        /// <param name="duration"> ISO8601 formatted string that represents a duration. </param>
        /// <param name="parameters"> List of key value pairs. </param>
        /// <param name="selectorId"> String that represents a selector. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="parameters"/> or <paramref name="selectorId"/> is null. </exception>
        public ContinuousAction(string name, TimeSpan duration, IEnumerable<KeyValuePair> parameters, string selectorId) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(parameters, nameof(parameters));
            Argument.AssertNotNull(selectorId, nameof(selectorId));

            Duration = duration;
            Parameters = parameters.ToList();
            SelectorId = selectorId;
            ActionType = "continuous";
        }

        /// <summary> Initializes a new instance of ContinuousAction. </summary>
        /// <param name="actionType"> Enum that discriminates between action models. </param>
        /// <param name="name"> String that represents a Capability URN. </param>
        /// <param name="duration"> ISO8601 formatted string that represents a duration. </param>
        /// <param name="parameters"> List of key value pairs. </param>
        /// <param name="selectorId"> String that represents a selector. </param>
        internal ContinuousAction(string actionType, string name, TimeSpan duration, IList<KeyValuePair> parameters, string selectorId) : base(actionType, name)
        {
            Duration = duration;
            Parameters = parameters;
            SelectorId = selectorId;
            ActionType = actionType ?? "continuous";
        }

        /// <summary> ISO8601 formatted string that represents a duration. </summary>
        public TimeSpan Duration { get; set; }
        /// <summary> List of key value pairs. </summary>
        public IList<KeyValuePair> Parameters { get; }
        /// <summary> String that represents a selector. </summary>
        public string SelectorId { get; set; }
    }
}
