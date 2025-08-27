namespace NinjaKiwi.NKMulti;

public class PeerDisconnectedMessage : Message
{
	public const string CODE = "DC"; //Field offset: 0x0
	public readonly int PeerID; //Field offset: 0x20
	public readonly List<Byte> ConnectedPlayers; //Field offset: 0x28

	public PeerDisconnectedMessage(Byte[] data) { }

	public PeerDisconnectedMessage(int peerID, List<Byte> connectedPlayers) { }

	protected virtual Byte[] CreateBytes() { }

}

