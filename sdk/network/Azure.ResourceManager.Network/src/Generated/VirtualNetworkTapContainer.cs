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
    /// <summary> A class representing collection of VirtualNetworkTap and their operations over a ResourceGroup. </summary>
    public partial class VirtualNetworkTapContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, VirtualNetworkTap, VirtualNetworkTapData>
    {
        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkTapContainer"/> class for mocking. </summary>
        protected VirtualNetworkTapContainer()
        {
        }

        /// <summary> Initializes a new instance of VirtualNetworkTapContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualNetworkTapContainer(OperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private VirtualNetworkTapsRestOperations _restClient => new VirtualNetworkTapsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates a Virtual Network Tap. </summary>
        /// <param name="tapName"> The name of the virtual network tap. </param>
        /// <param name="parameters"> Parameters supplied to the create or update virtual network tap operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tapName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<VirtualNetworkTap> CreateOrUpdate(string tapName, VirtualNetworkTapData parameters, CancellationToken cancellationToken = default)
        {
            if (tapName == null)
            {
                throw new ArgumentNullException(nameof(tapName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(tapName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a Virtual Network Tap. </summary>
        /// <param name="tapName"> The name of the virtual network tap. </param>
        /// <param name="parameters"> Parameters supplied to the create or update virtual network tap operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tapName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<VirtualNetworkTap>> CreateOrUpdateAsync(string tapName, VirtualNetworkTapData parameters, CancellationToken cancellationToken = default)
        {
            if (tapName == null)
            {
                throw new ArgumentNullException(nameof(tapName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(tapName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a Virtual Network Tap. </summary>
        /// <param name="tapName"> The name of the virtual network tap. </param>
        /// <param name="parameters"> Parameters supplied to the create or update virtual network tap operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tapName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual VirtualNetworkTapsCreateOrUpdateOperation StartCreateOrUpdate(string tapName, VirtualNetworkTapData parameters, CancellationToken cancellationToken = default)
        {
            if (tapName == null)
            {
                throw new ArgumentNullException(nameof(tapName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, tapName, parameters, cancellationToken);
                return new VirtualNetworkTapsCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, tapName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a Virtual Network Tap. </summary>
        /// <param name="tapName"> The name of the virtual network tap. </param>
        /// <param name="parameters"> Parameters supplied to the create or update virtual network tap operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tapName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<VirtualNetworkTapsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string tapName, VirtualNetworkTapData parameters, CancellationToken cancellationToken = default)
        {
            if (tapName == null)
            {
                throw new ArgumentNullException(nameof(tapName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, tapName, parameters, cancellationToken).ConfigureAwait(false);
                return new VirtualNetworkTapsCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, tapName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="tapName"> The name of virtual network tap. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<VirtualNetworkTap> Get(string tapName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.Get");
            scope.Start();
            try
            {
                if (tapName == null)
                {
                    throw new ArgumentNullException(nameof(tapName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, tapName, cancellationToken: cancellationToken);
                return Response.FromValue(new VirtualNetworkTap(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="tapName"> The name of virtual network tap. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<VirtualNetworkTap>> GetAsync(string tapName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.Get");
            scope.Start();
            try
            {
                if (tapName == null)
                {
                    throw new ArgumentNullException(nameof(tapName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, tapName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new VirtualNetworkTap(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tapName"> The name of virtual network tap. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual VirtualNetworkTap TryGet(string tapName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.TryGet");
            scope.Start();
            try
            {
                if (tapName == null)
                {
                    throw new ArgumentNullException(nameof(tapName));
                }

                return Get(tapName, cancellationToken: cancellationToken).Value;
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
        /// <param name="tapName"> The name of virtual network tap. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<VirtualNetworkTap> TryGetAsync(string tapName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.TryGet");
            scope.Start();
            try
            {
                if (tapName == null)
                {
                    throw new ArgumentNullException(nameof(tapName));
                }

                return await GetAsync(tapName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <param name="tapName"> The name of virtual network tap. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool DoesExist(string tapName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.DoesExist");
            scope.Start();
            try
            {
                if (tapName == null)
                {
                    throw new ArgumentNullException(nameof(tapName));
                }

                return TryGet(tapName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tapName"> The name of virtual network tap. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> DoesExistAsync(string tapName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.DoesExist");
            scope.Start();
            try
            {
                if (tapName == null)
                {
                    throw new ArgumentNullException(nameof(tapName));
                }

                return await TryGetAsync(tapName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the VirtualNetworkTaps in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualNetworkTap" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<VirtualNetworkTap> List(CancellationToken cancellationToken = default)
        {
            Page<VirtualNetworkTap> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = _restClient.ListByResourceGroup(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkTap(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualNetworkTap> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = _restClient.ListByResourceGroupNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkTap(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the VirtualNetworkTaps in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualNetworkTap" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<VirtualNetworkTap> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualNetworkTap>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await _restClient.ListByResourceGroupAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkTap(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualNetworkTap>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await _restClient.ListByResourceGroupNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualNetworkTap(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="VirtualNetworkTap" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualNetworkTapOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="VirtualNetworkTap" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualNetworkTapContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualNetworkTapOperations.ResourceType);
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
        // public ArmBuilder<ResourceGroupResourceIdentifier, VirtualNetworkTap, VirtualNetworkTapData> Construct() { }
    }
}
