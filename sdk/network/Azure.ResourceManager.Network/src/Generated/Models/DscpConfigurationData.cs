// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> A class representing the DscpConfiguration data model. </summary>
    public partial class DscpConfigurationData : Resource
    {
        /// <summary> Initializes a new instance of DscpConfigurationData. </summary>
        public DscpConfigurationData()
        {
            Markings = new ChangeTrackingList<int>();
            SourceIpRanges = new ChangeTrackingList<QosIpRange>();
            DestinationIpRanges = new ChangeTrackingList<QosIpRange>();
            SourcePortRanges = new ChangeTrackingList<QosPortRange>();
            DestinationPortRanges = new ChangeTrackingList<QosPortRange>();
            AssociatedNetworkInterfaces = new ChangeTrackingList<NetworkInterfaceData>();
        }

        /// <summary> Initializes a new instance of DscpConfigurationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="markings"> List of markings to be used in the configuration. </param>
        /// <param name="sourceIpRanges"> Source IP ranges. </param>
        /// <param name="destinationIpRanges"> Destination IP ranges. </param>
        /// <param name="sourcePortRanges"> Sources port ranges. </param>
        /// <param name="destinationPortRanges"> Destination port ranges. </param>
        /// <param name="protocol"> RNM supported protocol types. </param>
        /// <param name="qosCollectionId"> Qos Collection ID generated by RNM. </param>
        /// <param name="associatedNetworkInterfaces"> Associated Network Interfaces to the DSCP Configuration. </param>
        /// <param name="resourceGuid"> The resource GUID property of the DSCP Configuration resource. </param>
        /// <param name="provisioningState"> The provisioning state of the DSCP Configuration resource. </param>
        internal DscpConfigurationData(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, IList<int> markings, IList<QosIpRange> sourceIpRanges, IList<QosIpRange> destinationIpRanges, IList<QosPortRange> sourcePortRanges, IList<QosPortRange> destinationPortRanges, ProtocolType? protocol, string qosCollectionId, IReadOnlyList<NetworkInterfaceData> associatedNetworkInterfaces, string resourceGuid, ProvisioningState? provisioningState) : base(id, name, type, location, tags)
        {
            Etag = etag;
            Markings = markings;
            SourceIpRanges = sourceIpRanges;
            DestinationIpRanges = destinationIpRanges;
            SourcePortRanges = sourcePortRanges;
            DestinationPortRanges = destinationPortRanges;
            Protocol = protocol;
            QosCollectionId = qosCollectionId;
            AssociatedNetworkInterfaces = associatedNetworkInterfaces;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> List of markings to be used in the configuration. </summary>
        public IList<int> Markings { get; }
        /// <summary> Source IP ranges. </summary>
        public IList<QosIpRange> SourceIpRanges { get; }
        /// <summary> Destination IP ranges. </summary>
        public IList<QosIpRange> DestinationIpRanges { get; }
        /// <summary> Sources port ranges. </summary>
        public IList<QosPortRange> SourcePortRanges { get; }
        /// <summary> Destination port ranges. </summary>
        public IList<QosPortRange> DestinationPortRanges { get; }
        /// <summary> RNM supported protocol types. </summary>
        public ProtocolType? Protocol { get; set; }
        /// <summary> Qos Collection ID generated by RNM. </summary>
        public string QosCollectionId { get; }
        /// <summary> Associated Network Interfaces to the DSCP Configuration. </summary>
        public IReadOnlyList<NetworkInterfaceData> AssociatedNetworkInterfaces { get; }
        /// <summary> The resource GUID property of the DSCP Configuration resource. </summary>
        public string ResourceGuid { get; }
        /// <summary> The provisioning state of the DSCP Configuration resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
