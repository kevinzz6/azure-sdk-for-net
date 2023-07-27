// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Orbital.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Orbital
{
    /// <summary>
    /// A class representing the OrbitalContact data model.
    /// Customer creates a contact resource for a spacecraft resource.
    /// </summary>
    public partial class OrbitalContactData : ResourceData
    {
        /// <summary> Initializes a new instance of OrbitalContactData. </summary>
        public OrbitalContactData()
        {
        }

        /// <summary> Initializes a new instance of OrbitalContactData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="provisioningState"> The current state of the resource's creation, deletion, or modification. </param>
        /// <param name="status"> Status of a contact. </param>
        /// <param name="reservationStartOn"> Reservation start time of a contact (ISO 8601 UTC standard). </param>
        /// <param name="reservationEndOn"> Reservation end time of a contact (ISO 8601 UTC standard). </param>
        /// <param name="rxStartOn"> Receive start time of a contact (ISO 8601 UTC standard). </param>
        /// <param name="rxEndOn"> Receive end time of a contact (ISO 8601 UTC standard). </param>
        /// <param name="txStartOn"> Transmit start time of a contact (ISO 8601 UTC standard). </param>
        /// <param name="txEndOn"> Transmit end time of a contact (ISO 8601 UTC standard). </param>
        /// <param name="errorMessage"> Any error message while scheduling a contact. </param>
        /// <param name="maximumElevationDegrees"> Maximum elevation of the antenna during the contact in decimal degrees. </param>
        /// <param name="startAzimuthDegrees"> Azimuth of the antenna at the start of the contact in decimal degrees. </param>
        /// <param name="endAzimuthDegrees"> Azimuth of the antenna at the end of the contact in decimal degrees. </param>
        /// <param name="groundStationName"> Azure Ground Station name. </param>
        /// <param name="startElevationDegrees"> Spacecraft elevation above the horizon at contact start. </param>
        /// <param name="endElevationDegrees"> Spacecraft elevation above the horizon at contact end. </param>
        /// <param name="antennaConfiguration"> The configuration associated with the allocated antenna. </param>
        /// <param name="contactProfile"> The reference to the contact profile resource. </param>
        internal OrbitalContactData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ETag? etag, OrbitalProvisioningState? provisioningState, OrbitalContactStatus? status, DateTimeOffset? reservationStartOn, DateTimeOffset? reservationEndOn, DateTimeOffset? rxStartOn, DateTimeOffset? rxEndOn, DateTimeOffset? txStartOn, DateTimeOffset? txEndOn, string errorMessage, float? maximumElevationDegrees, float? startAzimuthDegrees, float? endAzimuthDegrees, string groundStationName, float? startElevationDegrees, float? endElevationDegrees, OrbitalContactAntennaConfiguration antennaConfiguration, WritableSubResource contactProfile) : base(id, name, resourceType, systemData)
        {
            ETag = etag;
            ProvisioningState = provisioningState;
            Status = status;
            ReservationStartOn = reservationStartOn;
            ReservationEndOn = reservationEndOn;
            RxStartOn = rxStartOn;
            RxEndOn = rxEndOn;
            TxStartOn = txStartOn;
            TxEndOn = txEndOn;
            ErrorMessage = errorMessage;
            MaximumElevationDegrees = maximumElevationDegrees;
            StartAzimuthDegrees = startAzimuthDegrees;
            EndAzimuthDegrees = endAzimuthDegrees;
            GroundStationName = groundStationName;
            StartElevationDegrees = startElevationDegrees;
            EndElevationDegrees = endElevationDegrees;
            AntennaConfiguration = antennaConfiguration;
            ContactProfile = contactProfile;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The current state of the resource's creation, deletion, or modification. </summary>
        public OrbitalProvisioningState? ProvisioningState { get; set; }
        /// <summary> Status of a contact. </summary>
        public OrbitalContactStatus? Status { get; }
        /// <summary> Reservation start time of a contact (ISO 8601 UTC standard). </summary>
        public DateTimeOffset? ReservationStartOn { get; set; }
        /// <summary> Reservation end time of a contact (ISO 8601 UTC standard). </summary>
        public DateTimeOffset? ReservationEndOn { get; set; }
        /// <summary> Receive start time of a contact (ISO 8601 UTC standard). </summary>
        public DateTimeOffset? RxStartOn { get; }
        /// <summary> Receive end time of a contact (ISO 8601 UTC standard). </summary>
        public DateTimeOffset? RxEndOn { get; }
        /// <summary> Transmit start time of a contact (ISO 8601 UTC standard). </summary>
        public DateTimeOffset? TxStartOn { get; }
        /// <summary> Transmit end time of a contact (ISO 8601 UTC standard). </summary>
        public DateTimeOffset? TxEndOn { get; }
        /// <summary> Any error message while scheduling a contact. </summary>
        public string ErrorMessage { get; }
        /// <summary> Maximum elevation of the antenna during the contact in decimal degrees. </summary>
        public float? MaximumElevationDegrees { get; }
        /// <summary> Azimuth of the antenna at the start of the contact in decimal degrees. </summary>
        public float? StartAzimuthDegrees { get; }
        /// <summary> Azimuth of the antenna at the end of the contact in decimal degrees. </summary>
        public float? EndAzimuthDegrees { get; }
        /// <summary> Azure Ground Station name. </summary>
        public string GroundStationName { get; set; }
        /// <summary> Spacecraft elevation above the horizon at contact start. </summary>
        public float? StartElevationDegrees { get; }
        /// <summary> Spacecraft elevation above the horizon at contact end. </summary>
        public float? EndElevationDegrees { get; }
        /// <summary> The configuration associated with the allocated antenna. </summary>
        public OrbitalContactAntennaConfiguration AntennaConfiguration { get; }
        /// <summary> The reference to the contact profile resource. </summary>
        internal WritableSubResource ContactProfile { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier ContactProfileId
        {
            get => ContactProfile is null ? default : ContactProfile.Id;
            set
            {
                if (ContactProfile is null)
                    ContactProfile = new WritableSubResource();
                ContactProfile.Id = value;
            }
        }
    }
}
