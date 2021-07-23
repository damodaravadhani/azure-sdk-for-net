// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the operations that can be performed over a specific ExpressRouteGateway. </summary>
    public partial class ExpressRouteGatewayOperations : ResourceOperationsBase<ResourceGroupResourceIdentifier, ExpressRouteGateway>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private ExpressRouteGatewaysRestOperations _restClient { get; }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteGatewayOperations"/> class for mocking. </summary>
        protected ExpressRouteGatewayOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteGatewayOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal ExpressRouteGatewayOperations(OperationsBase options, ResourceGroupResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new ExpressRouteGatewaysRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/expressRouteGateways";
        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public async override Task<Response<ExpressRouteGateway>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewayOperations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ExpressRouteGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public override Response<ExpressRouteGateway> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewayOperations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new ExpressRouteGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<Location>> ListAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> ListAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Deletes the specified ExpressRoute gateway in a resource group. An ExpressRoute gateway resource can only be deleted when there are no connection subresources. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewayOperations.Delete");
            scope.Start();
            try
            {
                var operation = await StartDeleteAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified ExpressRoute gateway in a resource group. An ExpressRoute gateway resource can only be deleted when there are no connection subresources. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewayOperations.Delete");
            scope.Start();
            try
            {
                var operation = StartDelete(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified ExpressRoute gateway in a resource group. An ExpressRoute gateway resource can only be deleted when there are no connection subresources. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ExpressRouteGatewaysDeleteOperation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewayOperations.StartDelete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return new ExpressRouteGatewaysDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified ExpressRoute gateway in a resource group. An ExpressRoute gateway resource can only be deleted when there are no connection subresources. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ExpressRouteGatewaysDeleteOperation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewayOperations.StartDelete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.ResourceGroupName, Id.Name, cancellationToken);
                return new ExpressRouteGatewaysDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates express route gateway tags. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ExpressRouteGateway>> UpdateTagsAsync(IDictionary<string, string> tags = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewayOperations.UpdateTags");
            scope.Start();
            try
            {
                var operation = await StartUpdateTagsAsync(tags, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates express route gateway tags. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRouteGateway> UpdateTags(IDictionary<string, string> tags = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewayOperations.UpdateTags");
            scope.Start();
            try
            {
                var operation = StartUpdateTags(tags, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates express route gateway tags. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ExpressRouteGatewaysUpdateTagsOperation> StartUpdateTagsAsync(IDictionary<string, string> tags = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewayOperations.StartUpdateTags");
            scope.Start();
            try
            {
                var response = await _restClient.UpdateTagsAsync(Id.ResourceGroupName, Id.Name, tags, cancellationToken).ConfigureAwait(false);
                return new ExpressRouteGatewaysUpdateTagsOperation(this, _clientDiagnostics, Pipeline, _restClient.CreateUpdateTagsRequest(Id.ResourceGroupName, Id.Name, tags).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates express route gateway tags. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ExpressRouteGatewaysUpdateTagsOperation StartUpdateTags(IDictionary<string, string> tags = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewayOperations.StartUpdateTags");
            scope.Start();
            try
            {
                var response = _restClient.UpdateTags(Id.ResourceGroupName, Id.Name, tags, cancellationToken);
                return new ExpressRouteGatewaysUpdateTagsOperation(this, _clientDiagnostics, Pipeline, _restClient.CreateUpdateTagsRequest(Id.ResourceGroupName, Id.Name, tags).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of ExpressRouteConnections in the ExpressRouteGateway. </summary>
        /// <returns> An object representing collection of ExpressRouteConnections and their operations over a ExpressRouteGateway. </returns>
        public ExpressRouteConnectionContainer GetExpressRouteConnections()
        {
            return new ExpressRouteConnectionContainer(this);
        }
    }
}
