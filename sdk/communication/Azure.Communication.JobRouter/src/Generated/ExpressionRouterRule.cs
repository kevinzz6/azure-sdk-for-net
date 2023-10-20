// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    /// <summary> A rule providing inline expression rules. </summary>
    public partial class ExpressionRouterRule : RouterRule
    {
        /// <summary> Initializes a new instance of ExpressionRouterRule. </summary>
        /// <param name="kind"> Discriminator. </param>
        /// <param name="language"> The expression language to compile to and execute. </param>
        /// <param name="expression">
        /// The string containing the expression to evaluate. Should contain return
        /// statement with calculated values.
        /// </param>
        internal ExpressionRouterRule(string kind, string language, string expression) : base(kind)
        {
            Language = language;
            Expression = expression;
        }
        /// <summary>
        /// The string containing the expression to evaluate. Should contain return
        /// statement with calculated values.
        /// </summary>
        public string Expression { get; }
    }
}
