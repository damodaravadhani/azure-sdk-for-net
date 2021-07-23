// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A Class representing a DdosCustomPolicy along with the instance operations that can be performed on it. </summary>
    public class DdosCustomPolicy : DdosCustomPolicyOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "DdosCustomPolicy"/> class for mocking. </summary>
        protected DdosCustomPolicy() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DdosCustomPolicy"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal DdosCustomPolicy(OperationsBase options, DdosCustomPolicyData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the DdosCustomPolicyData. </summary>
        public virtual DdosCustomPolicyData Data { get; private set; }
    }
}
