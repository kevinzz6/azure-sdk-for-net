// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Resource location data properties. </summary>
    public partial class ResourceLocationDataContract
    {
        /// <summary> Initializes a new instance of ResourceLocationDataContract. </summary>
        /// <param name="name"> A canonical name for the geographic or physical location. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ResourceLocationDataContract(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of ResourceLocationDataContract. </summary>
        /// <param name="name"> A canonical name for the geographic or physical location. </param>
        /// <param name="city"> The city or locality where the resource is located. </param>
        /// <param name="district"> The district, state, or province where the resource is located. </param>
        /// <param name="countryOrRegion"> The country or region where the resource is located. </param>
        internal ResourceLocationDataContract(string name, string city, string district, string countryOrRegion)
        {
            Name = name;
            City = city;
            District = district;
            CountryOrRegion = countryOrRegion;
        }

        /// <summary> A canonical name for the geographic or physical location. </summary>
        public string Name { get; set; }
        /// <summary> The city or locality where the resource is located. </summary>
        public string City { get; set; }
        /// <summary> The district, state, or province where the resource is located. </summary>
        public string District { get; set; }
        /// <summary> The country or region where the resource is located. </summary>
        public string CountryOrRegion { get; set; }
    }
}
