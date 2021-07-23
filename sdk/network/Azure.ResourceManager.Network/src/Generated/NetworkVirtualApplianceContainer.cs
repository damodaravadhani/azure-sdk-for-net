// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of NetworkVirtualAppliance and their operations over a ResourceGroup. </summary>
    public partial class NetworkVirtualApplianceContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, NetworkVirtualAppliance, NetworkVirtualApplianceData>
    {
        /// <summary> Initializes a new instance of the <see cref="NetworkVirtualApplianceContainer"/> class for mocking. </summary>
        protected NetworkVirtualApplianceContainer()
        {
        }

        /// <summary> Initializes a new instance of NetworkVirtualApplianceContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal NetworkVirtualApplianceContainer(OperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private NetworkVirtualAppliancesRestOperations _restClient => new NetworkVirtualAppliancesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates the specified Network Virtual Appliance. </summary>
        /// <param name="networkVirtualApplianceName"> The name of Network Virtual Appliance. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Network Virtual Appliance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkVirtualApplianceName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<NetworkVirtualAppliance> CreateOrUpdate(string networkVirtualApplianceName, NetworkVirtualApplianceData parameters, CancellationToken cancellationToken = default)
        {
            if (networkVirtualApplianceName == null)
            {
                throw new ArgumentNullException(nameof(networkVirtualApplianceName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualApplianceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(networkVirtualApplianceName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified Network Virtual Appliance. </summary>
        /// <param name="networkVirtualApplianceName"> The name of Network Virtual Appliance. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Network Virtual Appliance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkVirtualApplianceName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<NetworkVirtualAppliance>> CreateOrUpdateAsync(string networkVirtualApplianceName, NetworkVirtualApplianceData parameters, CancellationToken cancellationToken = default)
        {
            if (networkVirtualApplianceName == null)
            {
                throw new ArgumentNullException(nameof(networkVirtualApplianceName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualApplianceContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(networkVirtualApplianceName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified Network Virtual Appliance. </summary>
        /// <param name="networkVirtualApplianceName"> The name of Network Virtual Appliance. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Network Virtual Appliance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkVirtualApplianceName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual NetworkVirtualAppliancesCreateOrUpdateOperation StartCreateOrUpdate(string networkVirtualApplianceName, NetworkVirtualApplianceData parameters, CancellationToken cancellationToken = default)
        {
            if (networkVirtualApplianceName == null)
            {
                throw new ArgumentNullException(nameof(networkVirtualApplianceName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualApplianceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, networkVirtualApplianceName, parameters, cancellationToken);
                return new NetworkVirtualAppliancesCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, networkVirtualApplianceName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified Network Virtual Appliance. </summary>
        /// <param name="networkVirtualApplianceName"> The name of Network Virtual Appliance. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Network Virtual Appliance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkVirtualApplianceName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<NetworkVirtualAppliancesCreateOrUpdateOperation> StartCreateOrUpdateAsync(string networkVirtualApplianceName, NetworkVirtualApplianceData parameters, CancellationToken cancellationToken = default)
        {
            if (networkVirtualApplianceName == null)
            {
                throw new ArgumentNullException(nameof(networkVirtualApplianceName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualApplianceContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, networkVirtualApplianceName, parameters, cancellationToken).ConfigureAwait(false);
                return new NetworkVirtualAppliancesCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, networkVirtualApplianceName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="networkVirtualApplianceName"> The name of Network Virtual Appliance. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<NetworkVirtualAppliance> Get(string networkVirtualApplianceName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualApplianceContainer.Get");
            scope.Start();
            try
            {
                if (networkVirtualApplianceName == null)
                {
                    throw new ArgumentNullException(nameof(networkVirtualApplianceName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, networkVirtualApplianceName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(new NetworkVirtualAppliance(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="networkVirtualApplianceName"> The name of Network Virtual Appliance. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<NetworkVirtualAppliance>> GetAsync(string networkVirtualApplianceName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualApplianceContainer.Get");
            scope.Start();
            try
            {
                if (networkVirtualApplianceName == null)
                {
                    throw new ArgumentNullException(nameof(networkVirtualApplianceName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, networkVirtualApplianceName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new NetworkVirtualAppliance(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="networkVirtualApplianceName"> The name of Network Virtual Appliance. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual NetworkVirtualAppliance TryGet(string networkVirtualApplianceName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualApplianceContainer.TryGet");
            scope.Start();
            try
            {
                if (networkVirtualApplianceName == null)
                {
                    throw new ArgumentNullException(nameof(networkVirtualApplianceName));
                }

                return Get(networkVirtualApplianceName, expand, cancellationToken: cancellationToken).Value;
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="networkVirtualApplianceName"> The name of Network Virtual Appliance. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<NetworkVirtualAppliance> TryGetAsync(string networkVirtualApplianceName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualApplianceContainer.TryGet");
            scope.Start();
            try
            {
                if (networkVirtualApplianceName == null)
                {
                    throw new ArgumentNullException(nameof(networkVirtualApplianceName));
                }

                return await GetAsync(networkVirtualApplianceName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="networkVirtualApplianceName"> The name of Network Virtual Appliance. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool DoesExist(string networkVirtualApplianceName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualApplianceContainer.DoesExist");
            scope.Start();
            try
            {
                if (networkVirtualApplianceName == null)
                {
                    throw new ArgumentNullException(nameof(networkVirtualApplianceName));
                }

                return TryGet(networkVirtualApplianceName, expand, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="networkVirtualApplianceName"> The name of Network Virtual Appliance. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> DoesExistAsync(string networkVirtualApplianceName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualApplianceContainer.DoesExist");
            scope.Start();
            try
            {
                if (networkVirtualApplianceName == null)
                {
                    throw new ArgumentNullException(nameof(networkVirtualApplianceName));
                }

                return await TryGetAsync(networkVirtualApplianceName, expand, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all Network Virtual Appliances in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkVirtualAppliance" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<NetworkVirtualAppliance> List(CancellationToken cancellationToken = default)
        {
            Page<NetworkVirtualAppliance> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkVirtualApplianceContainer.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = _restClient.ListByResourceGroup(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkVirtualAppliance(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<NetworkVirtualAppliance> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkVirtualApplianceContainer.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = _restClient.ListByResourceGroupNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkVirtualAppliance(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all Network Virtual Appliances in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkVirtualAppliance" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<NetworkVirtualAppliance> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NetworkVirtualAppliance>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkVirtualApplianceContainer.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await _restClient.ListByResourceGroupAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkVirtualAppliance(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<NetworkVirtualAppliance>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NetworkVirtualApplianceContainer.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await _restClient.ListByResourceGroupNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NetworkVirtualAppliance(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="NetworkVirtualAppliance" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualApplianceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(NetworkVirtualApplianceOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="NetworkVirtualAppliance" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NetworkVirtualApplianceContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(NetworkVirtualApplianceOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceGroupResourceIdentifier, NetworkVirtualAppliance, NetworkVirtualApplianceData> Construct() { }
    }
}
