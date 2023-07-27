// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.Rooms
{
    /// <summary> Model factory for models. </summary>
    public static partial class RoomsModelFactory
    {
        /// <summary> Initializes a new instance of CommunicationRoom. </summary>
        /// <param name="id"> Unique identifier of a room. This id is server generated. </param>
        /// <param name="createdAt"> The timestamp when the room was created at the server. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <param name="validFrom"> The timestamp from when the room is open for joining. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <param name="validUntil"> The timestamp from when the room can no longer be joined. The timestamp is in RFC3339 format: `yyyy-MM-ddTHH:mm:ssZ`. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        /// <returns> A new <see cref="Rooms.CommunicationRoom"/> instance for mocking. </returns>
        public static CommunicationRoom CommunicationRoom(string id = null, DateTimeOffset createdAt = default, DateTimeOffset validFrom = default, DateTimeOffset validUntil = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return new CommunicationRoom(id, createdAt, validFrom, validUntil);
        }
    }
}
