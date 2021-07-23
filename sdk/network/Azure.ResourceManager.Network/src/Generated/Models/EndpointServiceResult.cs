// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Endpoint service. </summary>
    public partial class EndpointServiceResult : WritableSubResource<ResourceIdentifier>
    {
        /// <summary> Initializes a new instance of EndpointServiceResult. </summary>
        public EndpointServiceResult()
        {
        }

        /// <summary> Initializes a new instance of EndpointServiceResult. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> Name of the endpoint service. </param>
        /// <param name="type"> Type of the endpoint service. </param>
        internal EndpointServiceResult(string id, string name, string type) : base(id)
        {
            Name = name;
            Type = type;
        }

        /// <summary> Name of the endpoint service. </summary>
        public string Name { get; }
        /// <summary> Type of the endpoint service. </summary>
        public string Type { get; }
    }
}
