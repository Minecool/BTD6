namespace NinjaKiwi.NKMulti;

public class JoinSessionResponseMessage : Message
{
	public const string CODE = "JSRM"; //Field offset: 0x0
	public readonly bool Success; //Field offset: 0x20
	public readonly List<Byte> ConnectedPlayers; //Field offset: 0x28

	public JoinSessionResponseMessage(Byte[] data) { }

	public JoinSessionResponseMessage(bool success, List<Byte> players) { }

	protected virtual Byte[] CreateBytes() { }

}

