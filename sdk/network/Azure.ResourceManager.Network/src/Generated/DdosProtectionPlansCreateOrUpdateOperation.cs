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
    /// <summary> Creates or updates a DDoS protection plan. </summary>
    public partial class DdosProtectionPlansCreateOrUpdateOperation : Operation<DdosProtectionPlan>, IOperationSource<DdosProtectionPlan>
    {
        private readonly OperationInternals<DdosProtectionPlan> _operation;

        private readonly OperationsBase _operationBase;

        /// <summary> Initializes a new instance of DdosProtectionPlansCreateOrUpdateOperation for mocking. </summary>
        protected DdosProtectionPlansCreateOrUpdateOperation()
        {
        }

        internal DdosProtectionPlansCreateOrUpdateOperation(OperationsBase operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<DdosProtectionPlan>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "DdosProtectionPlansCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override DdosProtectionPlan Value => _operation.Value;

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
        public override ValueTask<Response<DdosProtectionPlan>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<DdosProtectionPlan>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        DdosProtectionPlan IOperationSource<DdosProtectionPlan>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new DdosProtectionPlan(_operationBase, DdosProtectionPlanData.DeserializeDdosProtectionPlanData(document.RootElement));
        }

        async ValueTask<DdosProtectionPlan> IOperationSource<DdosProtectionPlan>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new DdosProtectionPlan(_operationBase, DdosProtectionPlanData.DeserializeDdosProtectionPlanData(document.RootElement));
        }
    }
}
