namespace NinjaKiwi.LiNK.Client.Files;

public class MemoryStreamStorage : IStorage
{
	[CompilerGenerated]
	private sealed class <GetAllReadStreams>d__10 : IEnumerable<Stream>, IEnumerable, IEnumerator<Stream>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Stream <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public MemoryStreamStorage <>4__this; //Field offset: 0x28

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
		public <GetAllReadStreams>d__10(int <>1__state) { }

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

	private class ReusableMemoryStream : MemoryStream
	{
		private readonly Action<MemoryStream> disposeAction; //Field offset: 0x50
		private int writeCount; //Field offset: 0x58
		private int disposeCount; //Field offset: 0x5C

		public ReusableMemoryStream(Action<MemoryStream> disposeAction, int initialCapacity = 0) { }

		protected virtual void Dispose(bool disposing) { }

		public void IncrementWriteCount() { }

	}

	[CompilerGenerated]
	private Action<MemoryStream> SaveEvent; //Field offset: 0x10
	private readonly ReusableMemoryStream reusableMemoryStream; //Field offset: 0x18
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x20

	public event Action<MemoryStream> SaveEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public override string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public MemoryStreamStorage(string name) { }

	public MemoryStreamStorage(string name, Byte[] bytes) { }

	public MemoryStreamStorage(string name, Stream sourceStream) { }

	[CompilerGenerated]
	private void <.ctor>b__4_0(MemoryStream s) { }

	[CompilerGenerated]
	private void <.ctor>b__5_0(MemoryStream s) { }

	[CompilerGenerated]
	private void <.ctor>b__6_0(MemoryStream s) { }

	[CompilerGenerated]
	public void add_SaveEvent(Action<MemoryStream> value) { }

	public override void DeleteWriteStream(Stream _) { }

	[CompilerGenerated]
	public override string get_Name() { }

	[IteratorStateMachine(typeof(<GetAllReadStreams>d__10))]
	public override IEnumerable<Stream> GetAllReadStreams() { }

	public override Stream GetWriteStream() { }

	[CompilerGenerated]
	public void remove_SaveEvent(Action<MemoryStream> value) { }

	public override void Wipe() { }

}

