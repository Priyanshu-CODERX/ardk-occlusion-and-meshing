// Copyright 2022 Niantic, Inc. All Rights Reserved.

using Niantic.ARDK.Utilities;

namespace Niantic.Experimental.ARDK.SharedAR
{
  /// @note This is an experimental feature. Experimental features should not be used in
  /// production products as they are subject to breaking changes, not officially supported, and
  /// may be deprecated without notice
  public struct ColocalizationStateUpdatedArgs:
    IArdkEventArgs
  {
    public ColocalizationStateUpdatedArgs(IPeerID peer, ColocalizationState state):
      this()
    {
      Peer = peer;
      State = state;
    }
    
    public IPeerID Peer { get; private set; }
    public ColocalizationState State { get; private set; }
  }
}
