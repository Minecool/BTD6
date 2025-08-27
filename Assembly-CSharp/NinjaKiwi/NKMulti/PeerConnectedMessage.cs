namespace NinjaKiwi.NKMulti;

public class PeerConnectedMessage : Message
{
	public const string CODE = "PCM"; //Field offset: 0x0
	public readonly int PeerID; //Field offset: 0x20
	public readonly List<Byte> ConnectedPlayers; //Field offset: 0x28

	public PeerConnectedMessage(Byte[] data) { }

	public PeerConnectedMessage(int peerID, List<Byte> connectedPlayers) { }

	protected virtual Byte[] CreateBytes() { }

}

