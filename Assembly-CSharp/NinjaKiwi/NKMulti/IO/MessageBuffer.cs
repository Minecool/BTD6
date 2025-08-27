namespace NinjaKiwi.NKMulti.IO;

public class MessageBuffer : IDisposable
{
	public static int DEFAULT_BUFFER_SIZE; //Field offset: 0x0
	public readonly Byte[] ByteArray; //Field offset: 0x10
	private readonly MemoryStream byteStream; //Field offset: 0x18
	private readonly BinaryReader byteReader; //Field offset: 0x20

	public int Capacity
	{
		 get { } //Length: 42
	}

	private static MessageBuffer() { }

	public MessageBuffer() { }

	public MessageBuffer(int bufferSize) { }

	public override void Dispose() { }

	public int get_Capacity() { }

	public Head ReadHead() { }

	public Message ReadMessage(int length) { }

	public Tail ReadTail() { }

}

