// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a PrivateLinkService along with the instance operations that can be performed on it. </summary>
    public class PrivateLinkService : PrivateLinkServiceOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "PrivateLinkService"/> class for mocking. </summary>
        protected PrivateLinkService() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "PrivateLinkService"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal PrivateLinkService(OperationsBase options, PrivateLinkServiceData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the PrivateLinkServiceData. </summary>
        public virtual PrivateLinkServiceData Data { get; private set; }
    }
}
