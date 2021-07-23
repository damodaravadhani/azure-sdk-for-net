// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> ExtendedLocation complex type. </summary>
    public partial class ExtendedLocation
    {
        /// <summary> Initializes a new instance of ExtendedLocation. </summary>
        public ExtendedLocation()
        {
        }

        /// <summary> Initializes a new instance of ExtendedLocation. </summary>
        /// <param name="name"> The name of the extended location. </param>
        /// <param name="type"> The type of the extended location. </param>
        internal ExtendedLocation(string name, ExtendedLocationTypes? type)
        {
            Name = name;
            Type = type;
        }

        /// <summary> The name of the extended location. </summary>
        public string Name { get; set; }
        /// <summary> The type of the extended location. </summary>
        public ExtendedLocationTypes? Type { get; set; }
    }
}
