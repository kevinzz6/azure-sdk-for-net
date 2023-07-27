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
    /// <summary> Model that represents a discrete action. </summary>
    public partial class DiscreteAction : Action
    {
        /// <summary> Initializes a new instance of DiscreteAction. </summary>
        /// <param name="name"> String that represents a Capability URN. </param>
        /// <param name="parameters"> List of key value pairs. </param>
        /// <param name="selectorId"> String that represents a selector. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="parameters"/> or <paramref name="selectorId"/> is null. </exception>
        public DiscreteAction(string name, IEnumerable<KeyValuePair> parameters, string selectorId) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(parameters, nameof(parameters));
            Argument.AssertNotNull(selectorId, nameof(selectorId));

            Parameters = parameters.ToList();
            SelectorId = selectorId;
            ActionType = "discrete";
        }

        /// <summary> Initializes a new instance of DiscreteAction. </summary>
        /// <param name="actionType"> Enum that discriminates between action models. </param>
        /// <param name="name"> String that represents a Capability URN. </param>
        /// <param name="parameters"> List of key value pairs. </param>
        /// <param name="selectorId"> String that represents a selector. </param>
        internal DiscreteAction(string actionType, string name, IList<KeyValuePair> parameters, string selectorId) : base(actionType, name)
        {
            Parameters = parameters;
            SelectorId = selectorId;
            ActionType = actionType ?? "discrete";
        }

        /// <summary> List of key value pairs. </summary>
        public IList<KeyValuePair> Parameters { get; }
        /// <summary> String that represents a selector. </summary>
        public string SelectorId { get; set; }
    }
}
