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
    /// <summary> A class representing the operations that can be performed over a specific ConnectionMonitor. </summary>
    public partial class ConnectionMonitorOperations : ResourceOperationsBase<ResourceGroupResourceIdentifier, ConnectionMonitor>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private ConnectionMonitorsRestOperations _restClient { get; }

        /// <summary> Initializes a new instance of the <see cref="ConnectionMonitorOperations"/> class for mocking. </summary>
        protected ConnectionMonitorOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ConnectionMonitorOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal ConnectionMonitorOperations(OperationsBase options, ResourceGroupResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new ConnectionMonitorsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/networkWatchers/connectionMonitors";
        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <inheritdoc />
        public async override Task<Response<ConnectionMonitor>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorOperations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ConnectionMonitor(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <inheritdoc />
        public override Response<ConnectionMonitor> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorOperations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new ConnectionMonitor(this, response.Value), response.GetRawResponse());
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

        /// <summary> Deletes the specified connection monitor. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorOperations.Delete");
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

        /// <summary> Deletes the specified connection monitor. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorOperations.Delete");
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

        /// <summary> Deletes the specified connection monitor. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ConnectionMonitorsDeleteOperation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorOperations.StartDelete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return new ConnectionMonitorsDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified connection monitor. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ConnectionMonitorsDeleteOperation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorOperations.StartDelete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return new ConnectionMonitorsDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Update tags of the specified connection monitor. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ConnectionMonitorData>> UpdateTagsAsync(IDictionary<string, string> tags = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorOperations.UpdateTags");
            scope.Start();
            try
            {
                var response = await _restClient.UpdateTagsAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, tags, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update tags of the specified connection monitor. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ConnectionMonitorData> UpdateTags(IDictionary<string, string> tags = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorOperations.UpdateTags");
            scope.Start();
            try
            {
                var response = _restClient.UpdateTags(Id.ResourceGroupName, Id.Parent.Name, Id.Name, tags, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops the specified connection monitor. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> StopAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorOperations.Stop");
            scope.Start();
            try
            {
                var operation = await StartStopAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops the specified connection monitor. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Stop(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorOperations.Stop");
            scope.Start();
            try
            {
                var operation = StartStop(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops the specified connection monitor. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ConnectionMonitorsStopOperation> StartStopAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorOperations.StartStop");
            scope.Start();
            try
            {
                var response = await _restClient.StopAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return new ConnectionMonitorsStopOperation(_clientDiagnostics, Pipeline, _restClient.CreateStopRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops the specified connection monitor. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ConnectionMonitorsStopOperation StartStop(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorOperations.StartStop");
            scope.Start();
            try
            {
                var response = _restClient.Stop(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return new ConnectionMonitorsStopOperation(_clientDiagnostics, Pipeline, _restClient.CreateStopRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts the specified connection monitor. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> StartAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorOperations.Start");
            scope.Start();
            try
            {
                var operation = await StartStartAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts the specified connection monitor. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Start(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorOperations.Start");
            scope.Start();
            try
            {
                var operation = StartStart(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts the specified connection monitor. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ConnectionMonitorsStartOperation> StartStartAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorOperations.StartStart");
            scope.Start();
            try
            {
                var response = await _restClient.StartAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return new ConnectionMonitorsStartOperation(_clientDiagnostics, Pipeline, _restClient.CreateStartRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts the specified connection monitor. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ConnectionMonitorsStartOperation StartStart(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorOperations.StartStart");
            scope.Start();
            try
            {
                var response = _restClient.Start(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return new ConnectionMonitorsStartOperation(_clientDiagnostics, Pipeline, _restClient.CreateStartRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Query a snapshot of the most recent connection states. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ConnectionMonitorQueryResult>> QueryAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorOperations.Query");
            scope.Start();
            try
            {
                var operation = await StartQueryAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Query a snapshot of the most recent connection states. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ConnectionMonitorQueryResult> Query(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorOperations.Query");
            scope.Start();
            try
            {
                var operation = StartQuery(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Query a snapshot of the most recent connection states. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ConnectionMonitorsQueryOperation> StartQueryAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorOperations.StartQuery");
            scope.Start();
            try
            {
                var response = await _restClient.QueryAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return new ConnectionMonitorsQueryOperation(_clientDiagnostics, Pipeline, _restClient.CreateQueryRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Query a snapshot of the most recent connection states. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ConnectionMonitorsQueryOperation StartQuery(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConnectionMonitorOperations.StartQuery");
            scope.Start();
            try
            {
                var response = _restClient.Query(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return new ConnectionMonitorsQueryOperation(_clientDiagnostics, Pipeline, _restClient.CreateQueryRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
