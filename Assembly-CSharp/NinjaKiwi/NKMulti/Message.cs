namespace NinjaKiwi.NKMulti;

public class Message
{
	public readonly string Code; //Field offset: 0x10
	protected Byte[] bytes; //Field offset: 0x18

	protected Message(string code) { }

	public Message(string code, Byte[] data) { }

	protected override Byte[] CreateBytes() { }

	public Byte[] GetBytes() { }

}

