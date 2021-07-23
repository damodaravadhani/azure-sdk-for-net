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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the operations that can be performed over a specific VirtualNetworkGatewayConnection. </summary>
    public partial class VirtualNetworkGatewayConnectionOperations : ResourceOperationsBase<ResourceGroupResourceIdentifier, VirtualNetworkGatewayConnection>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private VirtualNetworkGatewayConnectionsRestOperations _restClient { get; }

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkGatewayConnectionOperations"/> class for mocking. </summary>
        protected VirtualNetworkGatewayConnectionOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkGatewayConnectionOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal VirtualNetworkGatewayConnectionOperations(OperationsBase options, ResourceGroupResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new VirtualNetworkGatewayConnectionsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/connections";
        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public async override Task<Response<VirtualNetworkGatewayConnection>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new VirtualNetworkGatewayConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public override Response<VirtualNetworkGatewayConnection> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new VirtualNetworkGatewayConnection(this, response.Value), response.GetRawResponse());
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

        /// <summary> Deletes the specified virtual network Gateway connection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.Delete");
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

        /// <summary> Deletes the specified virtual network Gateway connection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.Delete");
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

        /// <summary> Deletes the specified virtual network Gateway connection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VirtualNetworkGatewayConnectionsDeleteOperation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.StartDelete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return new VirtualNetworkGatewayConnectionsDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified virtual network Gateway connection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualNetworkGatewayConnectionsDeleteOperation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.StartDelete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.ResourceGroupName, Id.Name, cancellationToken);
                return new VirtualNetworkGatewayConnectionsDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> The Get VirtualNetworkGatewayConnectionSharedKey operation retrieves information about the specified virtual network gateway connection shared key through Network resource provider. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ConnectionSharedKey>> GetSharedKeyAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.GetSharedKey");
            scope.Start();
            try
            {
                var response = await _restClient.GetSharedKeyAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The Get VirtualNetworkGatewayConnectionSharedKey operation retrieves information about the specified virtual network gateway connection shared key through Network resource provider. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ConnectionSharedKey> GetSharedKey(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.GetSharedKey");
            scope.Start();
            try
            {
                var response = _restClient.GetSharedKey(Id.ResourceGroupName, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a virtual network gateway connection tags. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<VirtualNetworkGatewayConnection>> UpdateTagsAsync(IDictionary<string, string> tags = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.UpdateTags");
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

        /// <summary> Updates a virtual network gateway connection tags. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VirtualNetworkGatewayConnection> UpdateTags(IDictionary<string, string> tags = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.UpdateTags");
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

        /// <summary> Updates a virtual network gateway connection tags. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VirtualNetworkGatewayConnectionsUpdateTagsOperation> StartUpdateTagsAsync(IDictionary<string, string> tags = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.StartUpdateTags");
            scope.Start();
            try
            {
                var response = await _restClient.UpdateTagsAsync(Id.ResourceGroupName, Id.Name, tags, cancellationToken).ConfigureAwait(false);
                return new VirtualNetworkGatewayConnectionsUpdateTagsOperation(this, _clientDiagnostics, Pipeline, _restClient.CreateUpdateTagsRequest(Id.ResourceGroupName, Id.Name, tags).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates a virtual network gateway connection tags. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualNetworkGatewayConnectionsUpdateTagsOperation StartUpdateTags(IDictionary<string, string> tags = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.StartUpdateTags");
            scope.Start();
            try
            {
                var response = _restClient.UpdateTags(Id.ResourceGroupName, Id.Name, tags, cancellationToken);
                return new VirtualNetworkGatewayConnectionsUpdateTagsOperation(this, _clientDiagnostics, Pipeline, _restClient.CreateUpdateTagsRequest(Id.ResourceGroupName, Id.Name, tags).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The Put VirtualNetworkGatewayConnectionSharedKey operation sets the virtual network gateway connection shared key for passed virtual network gateway connection in the specified resource group through Network resource provider. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ConnectionSharedKey>> SetSharedKeyAsync(string id = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.SetSharedKey");
            scope.Start();
            try
            {
                var operation = await StartSetSharedKeyAsync(id, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The Put VirtualNetworkGatewayConnectionSharedKey operation sets the virtual network gateway connection shared key for passed virtual network gateway connection in the specified resource group through Network resource provider. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ConnectionSharedKey> SetSharedKey(string id = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.SetSharedKey");
            scope.Start();
            try
            {
                var operation = StartSetSharedKey(id, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The Put VirtualNetworkGatewayConnectionSharedKey operation sets the virtual network gateway connection shared key for passed virtual network gateway connection in the specified resource group through Network resource provider. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VirtualNetworkGatewayConnectionsSetSharedKeyOperation> StartSetSharedKeyAsync(string id = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.StartSetSharedKey");
            scope.Start();
            try
            {
                var response = await _restClient.SetSharedKeyAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, id, cancellationToken).ConfigureAwait(false);
                return new VirtualNetworkGatewayConnectionsSetSharedKeyOperation(_clientDiagnostics, Pipeline, _restClient.CreateSetSharedKeyRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, id).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The Put VirtualNetworkGatewayConnectionSharedKey operation sets the virtual network gateway connection shared key for passed virtual network gateway connection in the specified resource group through Network resource provider. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualNetworkGatewayConnectionsSetSharedKeyOperation StartSetSharedKey(string id = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.StartSetSharedKey");
            scope.Start();
            try
            {
                var response = _restClient.SetSharedKey(Id.ResourceGroupName, Id.Parent.Name, Id.Name, id, cancellationToken);
                return new VirtualNetworkGatewayConnectionsSetSharedKeyOperation(_clientDiagnostics, Pipeline, _restClient.CreateSetSharedKeyRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, id).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The VirtualNetworkGatewayConnectionResetSharedKey operation resets the virtual network gateway connection shared key for passed virtual network gateway connection in the specified resource group through Network resource provider. </summary>
        /// <param name="keyLength"> The virtual network connection reset shared key length, should between 1 and 128. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ConnectionResetSharedKey>> ResetSharedKeyAsync(int keyLength, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.ResetSharedKey");
            scope.Start();
            try
            {
                var operation = await StartResetSharedKeyAsync(keyLength, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The VirtualNetworkGatewayConnectionResetSharedKey operation resets the virtual network gateway connection shared key for passed virtual network gateway connection in the specified resource group through Network resource provider. </summary>
        /// <param name="keyLength"> The virtual network connection reset shared key length, should between 1 and 128. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ConnectionResetSharedKey> ResetSharedKey(int keyLength, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.ResetSharedKey");
            scope.Start();
            try
            {
                var operation = StartResetSharedKey(keyLength, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The VirtualNetworkGatewayConnectionResetSharedKey operation resets the virtual network gateway connection shared key for passed virtual network gateway connection in the specified resource group through Network resource provider. </summary>
        /// <param name="keyLength"> The virtual network connection reset shared key length, should between 1 and 128. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VirtualNetworkGatewayConnectionsResetSharedKeyOperation> StartResetSharedKeyAsync(int keyLength, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.StartResetSharedKey");
            scope.Start();
            try
            {
                var response = await _restClient.ResetSharedKeyAsync(Id.ResourceGroupName, Id.Name, keyLength, cancellationToken).ConfigureAwait(false);
                return new VirtualNetworkGatewayConnectionsResetSharedKeyOperation(_clientDiagnostics, Pipeline, _restClient.CreateResetSharedKeyRequest(Id.ResourceGroupName, Id.Name, keyLength).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The VirtualNetworkGatewayConnectionResetSharedKey operation resets the virtual network gateway connection shared key for passed virtual network gateway connection in the specified resource group through Network resource provider. </summary>
        /// <param name="keyLength"> The virtual network connection reset shared key length, should between 1 and 128. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualNetworkGatewayConnectionsResetSharedKeyOperation StartResetSharedKey(int keyLength, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.StartResetSharedKey");
            scope.Start();
            try
            {
                var response = _restClient.ResetSharedKey(Id.ResourceGroupName, Id.Name, keyLength, cancellationToken);
                return new VirtualNetworkGatewayConnectionsResetSharedKeyOperation(_clientDiagnostics, Pipeline, _restClient.CreateResetSharedKeyRequest(Id.ResourceGroupName, Id.Name, keyLength).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts packet capture on virtual network gateway connection in the specified resource group. </summary>
        /// <param name="filterData"> Start Packet capture parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<string>> StartPacketCaptureAsync(string filterData = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.StartPacketCapture");
            scope.Start();
            try
            {
                var operation = await StartStartPacketCaptureAsync(filterData, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts packet capture on virtual network gateway connection in the specified resource group. </summary>
        /// <param name="filterData"> Start Packet capture parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<string> StartPacketCapture(string filterData = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.StartPacketCapture");
            scope.Start();
            try
            {
                var operation = StartStartPacketCapture(filterData, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts packet capture on virtual network gateway connection in the specified resource group. </summary>
        /// <param name="filterData"> Start Packet capture parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VirtualNetworkGatewayConnectionsStartPacketCaptureOperation> StartStartPacketCaptureAsync(string filterData = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.StartStartPacketCapture");
            scope.Start();
            try
            {
                var response = await _restClient.StartPacketCaptureAsync(Id.ResourceGroupName, Id.Name, filterData, cancellationToken).ConfigureAwait(false);
                return new VirtualNetworkGatewayConnectionsStartPacketCaptureOperation(_clientDiagnostics, Pipeline, _restClient.CreateStartPacketCaptureRequest(Id.ResourceGroupName, Id.Name, filterData).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts packet capture on virtual network gateway connection in the specified resource group. </summary>
        /// <param name="filterData"> Start Packet capture parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualNetworkGatewayConnectionsStartPacketCaptureOperation StartStartPacketCapture(string filterData = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.StartStartPacketCapture");
            scope.Start();
            try
            {
                var response = _restClient.StartPacketCapture(Id.ResourceGroupName, Id.Name, filterData, cancellationToken);
                return new VirtualNetworkGatewayConnectionsStartPacketCaptureOperation(_clientDiagnostics, Pipeline, _restClient.CreateStartPacketCaptureRequest(Id.ResourceGroupName, Id.Name, filterData).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops packet capture on virtual network gateway connection in the specified resource group. </summary>
        /// <param name="sasUrl"> SAS url for packet capture on virtual network gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<string>> StopPacketCaptureAsync(string sasUrl = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.StopPacketCapture");
            scope.Start();
            try
            {
                var operation = await StartStopPacketCaptureAsync(sasUrl, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops packet capture on virtual network gateway connection in the specified resource group. </summary>
        /// <param name="sasUrl"> SAS url for packet capture on virtual network gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<string> StopPacketCapture(string sasUrl = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.StopPacketCapture");
            scope.Start();
            try
            {
                var operation = StartStopPacketCapture(sasUrl, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops packet capture on virtual network gateway connection in the specified resource group. </summary>
        /// <param name="sasUrl"> SAS url for packet capture on virtual network gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VirtualNetworkGatewayConnectionsStopPacketCaptureOperation> StartStopPacketCaptureAsync(string sasUrl = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.StartStopPacketCapture");
            scope.Start();
            try
            {
                var response = await _restClient.StopPacketCaptureAsync(Id.ResourceGroupName, Id.Name, sasUrl, cancellationToken).ConfigureAwait(false);
                return new VirtualNetworkGatewayConnectionsStopPacketCaptureOperation(_clientDiagnostics, Pipeline, _restClient.CreateStopPacketCaptureRequest(Id.ResourceGroupName, Id.Name, sasUrl).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops packet capture on virtual network gateway connection in the specified resource group. </summary>
        /// <param name="sasUrl"> SAS url for packet capture on virtual network gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualNetworkGatewayConnectionsStopPacketCaptureOperation StartStopPacketCapture(string sasUrl = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.StartStopPacketCapture");
            scope.Start();
            try
            {
                var response = _restClient.StopPacketCapture(Id.ResourceGroupName, Id.Name, sasUrl, cancellationToken);
                return new VirtualNetworkGatewayConnectionsStopPacketCaptureOperation(_clientDiagnostics, Pipeline, _restClient.CreateStopPacketCaptureRequest(Id.ResourceGroupName, Id.Name, sasUrl).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists IKE Security Associations for the virtual network gateway connection in the specified resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<string>> GetIkeSasAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.GetIkeSas");
            scope.Start();
            try
            {
                var operation = await StartGetIkeSasAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists IKE Security Associations for the virtual network gateway connection in the specified resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<string> GetIkeSas(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.GetIkeSas");
            scope.Start();
            try
            {
                var operation = StartGetIkeSas(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists IKE Security Associations for the virtual network gateway connection in the specified resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VirtualNetworkGatewayConnectionsGetIkeSasOperation> StartGetIkeSasAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.StartGetIkeSas");
            scope.Start();
            try
            {
                var response = await _restClient.GetIkeSasAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return new VirtualNetworkGatewayConnectionsGetIkeSasOperation(_clientDiagnostics, Pipeline, _restClient.CreateGetIkeSasRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists IKE Security Associations for the virtual network gateway connection in the specified resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualNetworkGatewayConnectionsGetIkeSasOperation StartGetIkeSas(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.StartGetIkeSas");
            scope.Start();
            try
            {
                var response = _restClient.GetIkeSas(Id.ResourceGroupName, Id.Name, cancellationToken);
                return new VirtualNetworkGatewayConnectionsGetIkeSasOperation(_clientDiagnostics, Pipeline, _restClient.CreateGetIkeSasRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resets the virtual network gateway connection specified. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> ResetConnectionAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.ResetConnection");
            scope.Start();
            try
            {
                var operation = await StartResetConnectionAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resets the virtual network gateway connection specified. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response ResetConnection(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.ResetConnection");
            scope.Start();
            try
            {
                var operation = StartResetConnection(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resets the virtual network gateway connection specified. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VirtualNetworkGatewayConnectionsResetConnectionOperation> StartResetConnectionAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.StartResetConnection");
            scope.Start();
            try
            {
                var response = await _restClient.ResetConnectionAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return new VirtualNetworkGatewayConnectionsResetConnectionOperation(_clientDiagnostics, Pipeline, _restClient.CreateResetConnectionRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Resets the virtual network gateway connection specified. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualNetworkGatewayConnectionsResetConnectionOperation StartResetConnection(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkGatewayConnectionOperations.StartResetConnection");
            scope.Start();
            try
            {
                var response = _restClient.ResetConnection(Id.ResourceGroupName, Id.Name, cancellationToken);
                return new VirtualNetworkGatewayConnectionsResetConnectionOperation(_clientDiagnostics, Pipeline, _restClient.CreateResetConnectionRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
