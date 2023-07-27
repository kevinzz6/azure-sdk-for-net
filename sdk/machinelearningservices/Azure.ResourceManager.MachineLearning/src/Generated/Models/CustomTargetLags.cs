// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The CustomTargetLags. </summary>
    public partial class CustomTargetLags : TargetLags
    {
        /// <summary> Initializes a new instance of CustomTargetLags. </summary>
        /// <param name="values"> [Required] Set target lags values. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="values"/> is null. </exception>
        public CustomTargetLags(IEnumerable<int> values)
        {
            Argument.AssertNotNull(values, nameof(values));

            Values = values.ToList();
            Mode = TargetLagsMode.Custom;
        }

        /// <summary> Initializes a new instance of CustomTargetLags. </summary>
        /// <param name="mode"> [Required] Set target lags mode - Auto/Custom. </param>
        /// <param name="values"> [Required] Set target lags values. </param>
        internal CustomTargetLags(TargetLagsMode mode, IList<int> values) : base(mode)
        {
            Values = values;
            Mode = mode;
        }

        /// <summary> [Required] Set target lags values. </summary>
        public IList<int> Values { get; }
    }
}
