// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Peering optionA properties. </summary>
    public partial class NetworkFabricOptionAProperties : NetworkFabricLayer3IPPrefixProperties
    {
        /// <summary> Initializes a new instance of NetworkFabricOptionAProperties. </summary>
        public NetworkFabricOptionAProperties()
        {
        }

        /// <summary> Initializes a new instance of NetworkFabricOptionAProperties. </summary>
        /// <param name="primaryIPv4Prefix"> IPv4 Address Prefix of CE-PE interconnect links. Example: 172.31.0.0/31. The values can be specified at the time of creation or can be updated afterwards. Any update to the values post-provisioning may disrupt traffic. The 1st and 3rd IPs are to be configured on CE1 and CE2 for Option B interfaces. The 2nd and 4th IPs are to be configured on PE1 and PE2 for Option B interfaces. </param>
        /// <param name="primaryIPv6Prefix"> IPv6 Address Prefix of CE-PE interconnect links. Example: 3FFE:FFFF:0:CD30::a0/126. The values can be specified at the time of creation or can be updated afterwards. Any update to the values post-provisioning may disrupt traffic. The 1st and 3rd IPs are to be configured on CE1 and CE2 for Option B interfaces. The 2nd and 4th IPs are to be configured on PE1 and PE2 for Option B interfaces. </param>
        /// <param name="secondaryIPv4Prefix"> Secondary IPv4 Address Prefix of CE-PE interconnect links. Example: 172.31.0.20/31. The values can be specified at the time of creation or can be updated afterwards. Any update to the values post-provisioning may disrupt traffic. The 1st and 3rd IPs are to be configured on CE1 and CE2 for Option B interfaces. The 2nd and 4th IPs are to be configured on PE1 and PE2 for Option B interfaces. </param>
        /// <param name="secondaryIPv6Prefix"> Secondary IPv6 Address Prefix of CE-PE interconnect links. Example: 3FFE:FFFF:0:CD30::a4/126. The values can be specified at the time of creation or can be updated afterwards. Any update to the values post-provisioning may disrupt traffic. The 1st and 3rd IPs are to be configured on CE1 and CE2 for Option B interfaces. The 2nd and 4th IPs are to be configured on PE1 and PE2 for Option B interfaces. </param>
        /// <param name="mtu"> MTU to use for option A peering. </param>
        /// <param name="vlanId"> Vlan identifier. Example : 501. </param>
        /// <param name="peerASN"> Peer ASN number.Example : 28. </param>
        /// <param name="bfdConfiguration"> BFD Configuration properties. </param>
        internal NetworkFabricOptionAProperties(string primaryIPv4Prefix, string primaryIPv6Prefix, string secondaryIPv4Prefix, string secondaryIPv6Prefix, int? mtu, int? vlanId, int? peerASN, FabricBfdConfiguration bfdConfiguration) : base(primaryIPv4Prefix, primaryIPv6Prefix, secondaryIPv4Prefix, secondaryIPv6Prefix)
        {
            Mtu = mtu;
            VlanId = vlanId;
            PeerASN = peerASN;
            BfdConfiguration = bfdConfiguration;
        }

        /// <summary> MTU to use for option A peering. </summary>
        public int? Mtu { get; set; }
        /// <summary> Vlan identifier. Example : 501. </summary>
        public int? VlanId { get; set; }
        /// <summary> Peer ASN number.Example : 28. </summary>
        public int? PeerASN { get; set; }
        /// <summary> BFD Configuration properties. </summary>
        public FabricBfdConfiguration BfdConfiguration { get; set; }
    }
}
