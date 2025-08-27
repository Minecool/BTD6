namespace NinjaKiwi.NKMulti;

public class PeerTargetedMessage : Message
{
	public const string CODE = "TRG"; //Field offset: 0x0
	public readonly int PeerID; //Field offset: 0x20
	public readonly Message Message; //Field offset: 0x28

	public PeerTargetedMessage(Byte[] data) { }

	public PeerTargetedMessage(int peerID, Message message) { }

	protected virtual Byte[] CreateBytes() { }

}

