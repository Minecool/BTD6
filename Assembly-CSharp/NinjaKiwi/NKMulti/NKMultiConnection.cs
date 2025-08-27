namespace NinjaKiwi.NKMulti;

public class NKMultiConnection : IDisposable
{
	public readonly Queue<Message> SendQueue; //Field offset: 0x10
	public readonly Queue<Message> ReceiveQueue; //Field offset: 0x18
	private readonly Socket Socket; //Field offset: 0x20
	private readonly NetworkStream NetworkStream; //Field offset: 0x28
	private readonly MessageReader Reader; //Field offset: 0x30
	private readonly MessageWriter Writer; //Field offset: 0x38
	private readonly int PlayerNumber; //Field offset: 0x40
	private readonly Dictionary<Int32, MultipartMessageBuffer> multipartBuffers; //Field offset: 0x48

	public NKMultiConnection(Socket socket, int playerNumber) { }

	public override void Dispose() { }

	public void Receive() { }

	public void Send() { }

}

