namespace NinjaKiwi.NKMulti;

public class LatencyTestMessage : Message
{
	public const string CODE = "ECHO"; //Field offset: 0x0
	public readonly int PeerID; //Field offset: 0x20
	public readonly long Timestamp; //Field offset: 0x28
	public readonly bool IsReply; //Field offset: 0x30

	public LatencyTestMessage(Byte[] data) { }

	public LatencyTestMessage(int peerID, long timestamp) { }

	private static Byte[] CreateBytes(long timestamp, int peerID) { }

}

