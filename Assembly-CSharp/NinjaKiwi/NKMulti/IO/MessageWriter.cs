namespace NinjaKiwi.NKMulti.IO;

public class MessageWriter : IDisposable
{
	private const int streamBufferSize = 2048; //Field offset: 0x0
	private readonly Stream stream; //Field offset: 0x10
	private readonly BinaryWriter writer; //Field offset: 0x18
	private readonly BufferedStream buffer; //Field offset: 0x20
	private readonly RelayMessageFactory relayMessageFactory; //Field offset: 0x28

	public MessageWriter(Stream output) { }

	public override void Dispose() { }

	public void Flush() { }

	public void Write(Message message) { }

}

