// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a PacketCapture along with the instance operations that can be performed on it. </summary>
    public class PacketCapture : PacketCaptureOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "PacketCapture"/> class for mocking. </summary>
        protected PacketCapture() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "PacketCapture"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal PacketCapture(OperationsBase options, PacketCaptureData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the PacketCaptureData. </summary>
        public virtual PacketCaptureData Data { get; private set; }
    }
}
