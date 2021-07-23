// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    internal partial class DdosCustomPoliciesRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of DdosCustomPoliciesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public DdosCustomPoliciesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2021-02-01")
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            endpoint ??= new Uri("https://management.azure.com");
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.subscriptionId = subscriptionId;
            this.endpoint = endpoint;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateDeleteRequest(string resourceGroupName, string ddosCustomPolicyName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/ddosCustomPolicies/", false);
            uri.AppendPath(ddosCustomPolicyName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Deletes the specified DDoS custom policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="ddosCustomPolicyName"/> is null. </exception>
        public async Task<Response> DeleteAsync(string resourceGroupName, string ddosCustomPolicyName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (ddosCustomPolicyName == null)
            {
                throw new ArgumentNullException(nameof(ddosCustomPolicyName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, ddosCustomPolicyName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Deletes the specified DDoS custom policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="ddosCustomPolicyName"/> is null. </exception>
        public Response Delete(string resourceGroupName, string ddosCustomPolicyName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (ddosCustomPolicyName == null)
            {
                throw new ArgumentNullException(nameof(ddosCustomPolicyName));
            }

            using var message = CreateDeleteRequest(resourceGroupName, ddosCustomPolicyName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string ddosCustomPolicyName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/ddosCustomPolicies/", false);
            uri.AppendPath(ddosCustomPolicyName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Gets information about the specified DDoS custom policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="ddosCustomPolicyName"/> is null. </exception>
        public async Task<Response<DdosCustomPolicyData>> GetAsync(string resourceGroupName, string ddosCustomPolicyName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (ddosCustomPolicyName == null)
            {
                throw new ArgumentNullException(nameof(ddosCustomPolicyName));
            }

            using var message = CreateGetRequest(resourceGroupName, ddosCustomPolicyName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DdosCustomPolicyData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DdosCustomPolicyData.DeserializeDdosCustomPolicyData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Gets information about the specified DDoS custom policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="ddosCustomPolicyName"/> is null. </exception>
        public Response<DdosCustomPolicyData> Get(string resourceGroupName, string ddosCustomPolicyName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (ddosCustomPolicyName == null)
            {
                throw new ArgumentNullException(nameof(ddosCustomPolicyName));
            }

            using var message = CreateGetRequest(resourceGroupName, ddosCustomPolicyName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DdosCustomPolicyData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DdosCustomPolicyData.DeserializeDdosCustomPolicyData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string ddosCustomPolicyName, DdosCustomPolicyData parameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/ddosCustomPolicies/", false);
            uri.AppendPath(ddosCustomPolicyName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            return message;
        }

        /// <summary> Creates or updates a DDoS custom policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="parameters"> Parameters supplied to the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="ddosCustomPolicyName"/>, or <paramref name="parameters"/> is null. </exception>
        public async Task<Response> CreateOrUpdateAsync(string resourceGroupName, string ddosCustomPolicyName, DdosCustomPolicyData parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (ddosCustomPolicyName == null)
            {
                throw new ArgumentNullException(nameof(ddosCustomPolicyName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, ddosCustomPolicyName, parameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Creates or updates a DDoS custom policy. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="parameters"> Parameters supplied to the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="ddosCustomPolicyName"/>, or <paramref name="parameters"/> is null. </exception>
        public Response CreateOrUpdate(string resourceGroupName, string ddosCustomPolicyName, DdosCustomPolicyData parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (ddosCustomPolicyName == null)
            {
                throw new ArgumentNullException(nameof(ddosCustomPolicyName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, ddosCustomPolicyName, parameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateTagsRequest(string resourceGroupName, string ddosCustomPolicyName, IDictionary<string, string> tags)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/ddosCustomPolicies/", false);
            uri.AppendPath(ddosCustomPolicyName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            TagsObject tagsObject = new TagsObject();
            if (tags != null)
            {
                foreach (var value in tags)
                {
                    tagsObject.Tags.Add(value);
                }
            }
            var model = tagsObject;
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Update a DDoS custom policy tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="ddosCustomPolicyName"/> is null. </exception>
        public async Task<Response<DdosCustomPolicyData>> UpdateTagsAsync(string resourceGroupName, string ddosCustomPolicyName, IDictionary<string, string> tags = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (ddosCustomPolicyName == null)
            {
                throw new ArgumentNullException(nameof(ddosCustomPolicyName));
            }

            using var message = CreateUpdateTagsRequest(resourceGroupName, ddosCustomPolicyName, tags);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DdosCustomPolicyData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = DdosCustomPolicyData.DeserializeDdosCustomPolicyData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Update a DDoS custom policy tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="ddosCustomPolicyName"> The name of the DDoS custom policy. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="ddosCustomPolicyName"/> is null. </exception>
        public Response<DdosCustomPolicyData> UpdateTags(string resourceGroupName, string ddosCustomPolicyName, IDictionary<string, string> tags = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (ddosCustomPolicyName == null)
            {
                throw new ArgumentNullException(nameof(ddosCustomPolicyName));
            }

            using var message = CreateUpdateTagsRequest(resourceGroupName, ddosCustomPolicyName, tags);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        DdosCustomPolicyData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = DdosCustomPolicyData.DeserializeDdosCustomPolicyData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
