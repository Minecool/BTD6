namespace NinjaKiwi.NKMulti.IO;

public class MessageReader : IDisposable
{
	private enum Part
	{
		Head = 0,
		Message = 1,
		Tail = 2,
	}

	private readonly NetworkStream stream; //Field offset: 0x10
	private readonly MessageBuffer buffer; //Field offset: 0x18
	private RelayMessage currentRelayMessage; //Field offset: 0x20
	private Part currentPart; //Field offset: 0x28
	private int currentPartBytesNeeded; //Field offset: 0x2C
	private int currentPartBytesRead; //Field offset: 0x30

	public MessageReader(NetworkStream input) { }

	private int bytesNeeded() { }

	private void createPart() { }

	public override void Dispose() { }

	private void moveToNextPart() { }

	public Message Read() { }

}

