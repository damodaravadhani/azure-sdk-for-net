// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a P2SVpnGateway along with the instance operations that can be performed on it. </summary>
    public class P2SVpnGateway : P2SVpnGatewayOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "P2SVpnGateway"/> class for mocking. </summary>
        protected P2SVpnGateway() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "P2SVpnGateway"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal P2SVpnGateway(OperationsBase options, P2SVpnGatewayData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the P2SVpnGatewayData. </summary>
        public virtual P2SVpnGatewayData Data { get; private set; }
    }
}
