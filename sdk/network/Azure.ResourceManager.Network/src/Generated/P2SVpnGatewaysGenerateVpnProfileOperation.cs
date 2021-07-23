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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> Generates VPN profile for P2S client of the P2SVpnGateway in the specified resource group. </summary>
    public partial class P2SVpnGatewaysGenerateVpnProfileOperation : Operation<VpnProfileResponse>, IOperationSource<VpnProfileResponse>
    {
        private readonly OperationInternals<VpnProfileResponse> _operation;

        /// <summary> Initializes a new instance of P2SVpnGatewaysGenerateVpnProfileOperation for mocking. </summary>
        protected P2SVpnGatewaysGenerateVpnProfileOperation()
        {
        }

        internal P2SVpnGatewaysGenerateVpnProfileOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<VpnProfileResponse>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "P2SVpnGatewaysGenerateVpnProfileOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override VpnProfileResponse Value => _operation.Value;

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
        public override ValueTask<Response<VpnProfileResponse>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VpnProfileResponse>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        VpnProfileResponse IOperationSource<VpnProfileResponse>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return VpnProfileResponse.DeserializeVpnProfileResponse(document.RootElement);
        }

        async ValueTask<VpnProfileResponse> IOperationSource<VpnProfileResponse>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return VpnProfileResponse.DeserializeVpnProfileResponse(document.RootElement);
        }
    }
}
