namespace Assets.Scripts.Unity.Bridge;

public class UpdatePeerState : IBtd6MessageType
{
	internal struct PeerState
	{
		public byte playerNumber; //Field offset: 0x0
		public bool rejoining; //Field offset: 0x1
		public bool autoPlay; //Field offset: 0x2
		public bool quit; //Field offset: 0x3

	}

	public readonly List<PeerState> peerStates; //Field offset: 0x10

	[JsonConstructor]
	public UpdatePeerState(List<PeerState> peerStates) { }

	public UpdatePeerState(Peers peers) { }

	public static UpdatePeerState Decode(BinaryReader reader) { }

	public static void Encode(BinaryWriter writer, UpdatePeerState message) { }

}

