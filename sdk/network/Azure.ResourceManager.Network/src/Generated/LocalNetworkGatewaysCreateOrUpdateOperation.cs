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
    /// <summary> Creates or updates a local network gateway in the specified resource group. </summary>
    public partial class LocalNetworkGatewaysCreateOrUpdateOperation : Operation<LocalNetworkGateway>, IOperationSource<LocalNetworkGateway>
    {
        private readonly OperationInternals<LocalNetworkGateway> _operation;

        private readonly OperationsBase _operationBase;

        /// <summary> Initializes a new instance of LocalNetworkGatewaysCreateOrUpdateOperation for mocking. </summary>
        protected LocalNetworkGatewaysCreateOrUpdateOperation()
        {
        }

        internal LocalNetworkGatewaysCreateOrUpdateOperation(OperationsBase operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<LocalNetworkGateway>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "LocalNetworkGatewaysCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override LocalNetworkGateway Value => _operation.Value;

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
        public override ValueTask<Response<LocalNetworkGateway>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<LocalNetworkGateway>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        LocalNetworkGateway IOperationSource<LocalNetworkGateway>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new LocalNetworkGateway(_operationBase, LocalNetworkGatewayData.DeserializeLocalNetworkGatewayData(document.RootElement));
        }

        async ValueTask<LocalNetworkGateway> IOperationSource<LocalNetworkGateway>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new LocalNetworkGateway(_operationBase, LocalNetworkGatewayData.DeserializeLocalNetworkGatewayData(document.RootElement));
        }
    }
}
