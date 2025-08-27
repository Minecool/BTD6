namespace NinjaKiwi.NKMulti;

public class JoinSessionMessage : Message
{
	public const string CODE = "JSM"; //Field offset: 0x0
	public readonly string MatchID; //Field offset: 0x20
	public readonly int PeerID; //Field offset: 0x28
	public readonly string PlayerGlobalID; //Field offset: 0x30

	public JoinSessionMessage(Byte[] data) { }

	public JoinSessionMessage(int peerID, string matchID, string globalID) { }

	private static Byte[] CreateBytes(int peerID, string matchID, string globalID) { }

}

