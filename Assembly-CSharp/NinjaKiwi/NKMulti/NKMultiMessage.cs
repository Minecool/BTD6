namespace NinjaKiwi.NKMulti;

public class NKMultiMessage : Message
{
	public const string CODE = "GE"; //Field offset: 0x0

	public NKMultiMessage(Byte[] data) { }

	public NKMultiMessage(Writable content) { }

	private static Byte[] CreateBytes(Writable content) { }

}

