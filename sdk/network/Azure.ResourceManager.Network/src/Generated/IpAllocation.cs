// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a IpAllocation along with the instance operations that can be performed on it. </summary>
    public class IpAllocation : IpAllocationOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "IpAllocation"/> class for mocking. </summary>
        protected IpAllocation() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "IpAllocation"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal IpAllocation(OperationsBase options, IpAllocationData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the IpAllocationData. </summary>
        public virtual IpAllocationData Data { get; private set; }
    }
}
