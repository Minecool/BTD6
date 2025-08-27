namespace NinjaKiwi.LiNK.Client.Files;

public class PlayerPrefsStorage : IStorage
{
	[CompilerGenerated]
	private sealed class <GetAllReadStreams>d__6 : IEnumerable<Stream>, IEnumerable, IEnumerator<Stream>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Stream <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public PlayerPrefsStorage <>4__this; //Field offset: 0x28

		private override Stream System.Collections.Generic.IEnumerator<System.IO.Stream>.Current
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
		public <GetAllReadStreams>d__6(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Stream> System.Collections.Generic.IEnumerable<System.IO.Stream>.GetEnumerator() { }

		[DebuggerHidden]
		private override Stream System.Collections.Generic.IEnumerator<System.IO.Stream>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private const int DEFAULT_BUFFER_SIZE = 512; //Field offset: 0x0
	private readonly int bufferSize; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x18

	public override string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public PlayerPrefsStorage(string playerPrefsKey, int bufferSize = 512) { }

	public override void DeleteWriteStream(Stream stream) { }

	[CompilerGenerated]
	public override string get_Name() { }

	[IteratorStateMachine(typeof(<GetAllReadStreams>d__6))]
	public override IEnumerable<Stream> GetAllReadStreams() { }

	public override Stream GetWriteStream() { }

	public override void Wipe() { }

}

