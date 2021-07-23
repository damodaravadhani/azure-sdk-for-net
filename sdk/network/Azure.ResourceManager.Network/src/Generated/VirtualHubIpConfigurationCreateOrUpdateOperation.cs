// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> Creates a VirtualHubIpConfiguration resource if it doesn&apos;t exist else updates the existing VirtualHubIpConfiguration. </summary>
    public partial class VirtualHubIpConfigurationCreateOrUpdateOperation : Operation<HubIpConfiguration>, IOperationSource<HubIpConfiguration>
    {
        private readonly OperationInternals<HubIpConfiguration> _operation;

        private readonly OperationsBase _operationBase;

        /// <summary> Initializes a new instance of VirtualHubIpConfigurationCreateOrUpdateOperation for mocking. </summary>
        protected VirtualHubIpConfigurationCreateOrUpdateOperation()
        {
        }

        internal VirtualHubIpConfigurationCreateOrUpdateOperation(OperationsBase operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<HubIpConfiguration>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "VirtualHubIpConfigurationCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override HubIpConfiguration Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<HubIpConfiguration>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<HubIpConfiguration>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        HubIpConfiguration IOperationSource<HubIpConfiguration>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new HubIpConfiguration(_operationBase, HubIpConfigurationData.DeserializeHubIpConfigurationData(document.RootElement));
        }

        async ValueTask<HubIpConfiguration> IOperationSource<HubIpConfiguration>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new HubIpConfiguration(_operationBase, HubIpConfigurationData.DeserializeHubIpConfigurationData(document.RootElement));
        }
    }
}
