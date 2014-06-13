﻿using System;
using System.Collections.Generic;

namespace Abc.Zebus.Directory.Storage
{
    public interface IPeerRepository
    {
        PeerDescriptor Get(PeerId peerId);
        IEnumerable<PeerDescriptor> GetPeers();

        void AddOrUpdatePeer(PeerDescriptor peerDescriptor);
        void RemovePeer(PeerId peerId);
        void SetPeerResponding(PeerId peerId, bool isResponding);

        void AddDynamicSubscriptions(PeerId peerId, DateTime timestampUtc, Subscription[] subscriptions);
        void RemoveDynamicSubscriptions(PeerId peerId, DateTime timestampUtc, Subscription[] subscriptions);
    }
}