﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using System;
using System.Threading;
using Azure.Core;

namespace Azure.Storage.DataMovement
{
    /// <summary>
    /// Event Argument for Failed Single Blob Upload Transfers
    /// </summary>
    public class TransferFailedEventArgs : StorageTransferEventArgs
    {
        /// <summary>
        /// Gets the <see cref="StorageResourceSingle"/> that was the source resource for the transfer.
        /// </summary>
        public StorageResourceSingle SourceResource { get; }

        /// <summary>
        /// Gets the <see cref="StorageResourceSingle"/> that was the destination resource for the transfer.
        /// </summary>
        public StorageResourceSingle DestinationResource { get; }

        /// <summary>
        /// Gets the <see cref="Exception"/> that was thrown during the job.
        /// </summary>
        public Exception Exception { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferFailedEventArgs"/>.
        /// </summary>
        /// <param name="transferId"></param>
        /// <param name="sourceResource"></param>
        /// <param name="destinationResource"></param>
        /// <param name="exception"></param>
        /// <param name="isRunningSynchronously">
        /// A value indicating whether the event handler was invoked
        /// synchronously or asynchronously.  Please see
        /// <see cref="Azure.Core.SyncAsyncEventHandler{T}"/> for more details.
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token related to the original operation that raised
        /// the event.  It's important for your handler to pass this token
        /// along to any asynchronous or long-running synchronous operations
        /// that take a token so cancellation will correctly propagate.  The
        /// default value is <see cref="CancellationToken.None"/>.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Trhown if <paramref name="transferId"/> is empty or null.
        /// Thrown if <paramref name="sourceResource"/> is empty or null.
        /// Thrown if <paramref name="destinationResource"/> is empty or null.
        /// </exception>
        public TransferFailedEventArgs(
            string transferId,
            StorageResourceSingle sourceResource,
            StorageResourceSingle destinationResource,
            Exception exception,
            bool isRunningSynchronously,
            CancellationToken cancellationToken)
            : base(transferId, isRunningSynchronously, cancellationToken)
        {
            Argument.AssertNotNull(sourceResource, nameof(sourceResource));
            Argument.AssertNotNull(destinationResource, nameof(destinationResource));
            Argument.AssertNotNull(exception, nameof(exception));
            SourceResource = sourceResource;
            DestinationResource = destinationResource;
            Exception = exception;
        }
    }
}
