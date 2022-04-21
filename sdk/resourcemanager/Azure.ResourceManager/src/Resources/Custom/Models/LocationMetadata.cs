// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

[assembly: CodeGenSuppressType("LocationMetadata")]
namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Location metadata information. </summary>
    public partial class LocationMetadata
    {
        /// <summary> Initializes a new instance of LocationMetadata. </summary>
        internal LocationMetadata()
        {
            PairedRegions = new ChangeTrackingList<PairedRegion>();
        }

        /// <summary> Initializes a new instance of LocationMetadata. </summary>
        /// <param name="regionType"> The type of the region. </param>
        /// <param name="regionCategory"> The category of the region. </param>
        /// <param name="geographyGroup"> The geography group of the location. </param>
        /// <param name="longitude"> The longitude of the location. </param>
        /// <param name="latitude"> The latitude of the location. </param>
        /// <param name="physicalLocation"> The physical location of the Azure location. </param>
        /// <param name="pairedRegions"> The regions paired to this region. </param>
        /// <param name="homeLocation"> The home location of an edge zone. </param>
        internal LocationMetadata(RegionType? regionType, RegionCategory? regionCategory, string geographyGroup, double? longitude, double? latitude, string physicalLocation, IReadOnlyList<PairedRegion> pairedRegions, string homeLocation)
        {
            RegionType = regionType;
            RegionCategory = regionCategory;
            GeographyGroup = geographyGroup;
            Longitude = longitude;
            Latitude = latitude;
            PhysicalLocation = physicalLocation;
            PairedRegions = pairedRegions;
            HomeLocation = homeLocation;
        }

        /// <summary> The type of the region. </summary>
        public RegionType? RegionType { get; }
        /// <summary> The category of the region. </summary>
        public RegionCategory? RegionCategory { get; }
        /// <summary> The geography group of the location. </summary>
        public string GeographyGroup { get; }
        /// <summary> The longitude of the location. </summary>
        public double? Longitude { get; }
        /// <summary> The latitude of the location. </summary>
        public double? Latitude { get; }
        /// <summary> The physical location of the Azure location. </summary>
        public string PhysicalLocation { get; }
        /// <summary> The regions paired to this region. </summary>
        public IReadOnlyList<PairedRegion> PairedRegions { get; }
        /// <summary> The home location of an edge zone. </summary>
        public string HomeLocation { get; }
    }
}
