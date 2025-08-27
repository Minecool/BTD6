namespace NinjaKiwi.NKMulti;

public class MultipartMessage : Message
{
	[CompilerGenerated]
	private sealed class <Create>d__9 : IEnumerable<MultipartMessage>, IEnumerable, IEnumerator<MultipartMessage>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private MultipartMessage <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private Message baseMessage; //Field offset: 0x28
		public Message <>3__baseMessage; //Field offset: 0x30
		private int playerNumber; //Field offset: 0x38
		public int <>3__playerNumber; //Field offset: 0x3C
		private int <bytesWritten>5__2; //Field offset: 0x40
		private List<Int32> <lengths>5__3; //Field offset: 0x48
		private int <i>5__4; //Field offset: 0x50
		private int <thisMessageLength>5__5; //Field offset: 0x54

		private override MultipartMessage System.Collections.Generic.IEnumerator<NinjaKiwi.NKMulti.MultipartMessage>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <Create>d__9(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<MultipartMessage> System.Collections.Generic.IEnumerable<NinjaKiwi.NKMulti.MultipartMessage>.GetEnumerator() { }

		[DebuggerHidden]
		private override MultipartMessage System.Collections.Generic.IEnumerator<NinjaKiwi.NKMulti.MultipartMessage>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public const string CODE = "MPM"; //Field offset: 0x0
	public readonly int playerNumber; //Field offset: 0x20
	public readonly string baseMessageCode; //Field offset: 0x28
	public readonly int partNumber; //Field offset: 0x30
	public readonly int totalParts; //Field offset: 0x34
	public readonly Byte[] partBytes; //Field offset: 0x38

	public MultipartMessage(int playerNumber, string baseMessageCode, int partNumber, int totalParts, Byte[] baseMessageContent, int startIndex, int length) { }

	public MultipartMessage(Byte[] data) { }

	[IteratorStateMachine(typeof(<Create>d__9))]
	public static IEnumerable<MultipartMessage> Create(int playerNumber, Message baseMessage) { }

	private static Byte[] GetBytes(int playerNumber, string baseMessageCode, int partNumber, int totalParts, Byte[] baseMessageContent, int startIndex, int length) { }

	private static int GetOwnHeaderLength(string baseMessageCode) { }

}

