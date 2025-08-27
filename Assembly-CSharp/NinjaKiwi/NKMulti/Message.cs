namespace NinjaKiwi.NKMulti;

public abstract class Message
{
	public const int MAX_LENGTH = 32767; //Field offset: 0x0
	public readonly string code; //Field offset: 0x10
	public readonly Byte[] bytes; //Field offset: 0x18

	public int LengthWhenSerialised
	{
		 get { } //Length: 41
	}

	public Message(string code, Byte[] bytes) { }

	public int get_LengthWhenSerialised() { }

	protected static int GetMessageHeaderLength(string code) { }

}

