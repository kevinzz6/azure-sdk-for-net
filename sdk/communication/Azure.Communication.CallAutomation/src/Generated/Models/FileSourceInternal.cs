// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The FileSource. </summary>
    internal partial class FileSourceInternal
    {
        /// <summary> Initializes a new instance of FileSourceInternal. </summary>
        /// <param name="uri"> Uri for the audio file to be played. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        public FileSourceInternal(string uri)
        {
            Argument.AssertNotNull(uri, nameof(uri));

            Uri = uri;
        }

        /// <summary> Uri for the audio file to be played. </summary>
        public string Uri { get; }
    }
}
