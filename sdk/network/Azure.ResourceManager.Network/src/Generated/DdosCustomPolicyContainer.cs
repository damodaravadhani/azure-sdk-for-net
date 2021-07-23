// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of DdosCustomPolicy and their operations over a ResourceGroup. </summary>
    public partial class DdosCustomPolicyContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, DdosCustomPolicy, DdosCustomPolicyData>
    {
        /// <summary> Initializes a new instance of the <see cref="DdosCustomPolicyContainer"/> class for mocking. </summary>
        protected DdosCustomPolicyContainer()
        {
        }

        /// <summary> Initializes a new instance of DdosCustomPolicyContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DdosCustomPolicyContainer(OperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private DdosCustomPoliciesRestOperations _restClient => new DdosCustomPoliciesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates a DDoS custom policy. </summary>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="parameters"> Parameters supplied to the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosCustomPolicyName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<DdosCustomPolicy> CreateOrUpdate(string ddosCustomPolicyName, DdosCustomPolicyData parameters, CancellationToken cancellationToken = default)
        {
            if (ddosCustomPolicyName == null)
            {
                throw new ArgumentNullException(nameof(ddosCustomPolicyName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DdosCustomPolicyContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(ddosCustomPolicyName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a DDoS custom policy. </summary>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="parameters"> Parameters supplied to the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosCustomPolicyName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<DdosCustomPolicy>> CreateOrUpdateAsync(string ddosCustomPolicyName, DdosCustomPolicyData parameters, CancellationToken cancellationToken = default)
        {
            if (ddosCustomPolicyName == null)
            {
                throw new ArgumentNullException(nameof(ddosCustomPolicyName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DdosCustomPolicyContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(ddosCustomPolicyName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a DDoS custom policy. </summary>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="parameters"> Parameters supplied to the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosCustomPolicyName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual DdosCustomPoliciesCreateOrUpdateOperation StartCreateOrUpdate(string ddosCustomPolicyName, DdosCustomPolicyData parameters, CancellationToken cancellationToken = default)
        {
            if (ddosCustomPolicyName == null)
            {
                throw new ArgumentNullException(nameof(ddosCustomPolicyName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DdosCustomPolicyContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, ddosCustomPolicyName, parameters, cancellationToken);
                return new DdosCustomPoliciesCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, ddosCustomPolicyName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a DDoS custom policy. </summary>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="parameters"> Parameters supplied to the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ddosCustomPolicyName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<DdosCustomPoliciesCreateOrUpdateOperation> StartCreateOrUpdateAsync(string ddosCustomPolicyName, DdosCustomPolicyData parameters, CancellationToken cancellationToken = default)
        {
            if (ddosCustomPolicyName == null)
            {
                throw new ArgumentNullException(nameof(ddosCustomPolicyName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DdosCustomPolicyContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, ddosCustomPolicyName, parameters, cancellationToken).ConfigureAwait(false);
                return new DdosCustomPoliciesCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, ddosCustomPolicyName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<DdosCustomPolicy> Get(string ddosCustomPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DdosCustomPolicyContainer.Get");
            scope.Start();
            try
            {
                if (ddosCustomPolicyName == null)
                {
                    throw new ArgumentNullException(nameof(ddosCustomPolicyName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, ddosCustomPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(new DdosCustomPolicy(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<DdosCustomPolicy>> GetAsync(string ddosCustomPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DdosCustomPolicyContainer.Get");
            scope.Start();
            try
            {
                if (ddosCustomPolicyName == null)
                {
                    throw new ArgumentNullException(nameof(ddosCustomPolicyName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, ddosCustomPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DdosCustomPolicy(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual DdosCustomPolicy TryGet(string ddosCustomPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DdosCustomPolicyContainer.TryGet");
            scope.Start();
            try
            {
                if (ddosCustomPolicyName == null)
                {
                    throw new ArgumentNullException(nameof(ddosCustomPolicyName));
                }

                return Get(ddosCustomPolicyName, cancellationToken: cancellationToken).Value;
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
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<DdosCustomPolicy> TryGetAsync(string ddosCustomPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DdosCustomPolicyContainer.TryGet");
            scope.Start();
            try
            {
                if (ddosCustomPolicyName == null)
                {
                    throw new ArgumentNullException(nameof(ddosCustomPolicyName));
                }

                return await GetAsync(ddosCustomPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool DoesExist(string ddosCustomPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DdosCustomPolicyContainer.DoesExist");
            scope.Start();
            try
            {
                if (ddosCustomPolicyName == null)
                {
                    throw new ArgumentNullException(nameof(ddosCustomPolicyName));
                }

                return TryGet(ddosCustomPolicyName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> DoesExistAsync(string ddosCustomPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DdosCustomPolicyContainer.DoesExist");
            scope.Start();
            try
            {
                if (ddosCustomPolicyName == null)
                {
                    throw new ArgumentNullException(nameof(ddosCustomPolicyName));
                }

                return await TryGetAsync(ddosCustomPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="DdosCustomPolicy" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DdosCustomPolicyContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DdosCustomPolicyOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="DdosCustomPolicy" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DdosCustomPolicyContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(DdosCustomPolicyOperations.ResourceType);
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
        // public ArmBuilder<ResourceGroupResourceIdentifier, DdosCustomPolicy, DdosCustomPolicyData> Construct() { }
    }
}
