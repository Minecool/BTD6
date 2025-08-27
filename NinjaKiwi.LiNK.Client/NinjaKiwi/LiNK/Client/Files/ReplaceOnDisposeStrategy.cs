namespace NinjaKiwi.LiNK.Client.Files;

internal class ReplaceOnDisposeStrategy : FileSystemStorage
{
	[CompilerGenerated]
	private sealed class <GetAllReadStreams>d__1 : IEnumerable<Stream>, IEnumerable, IEnumerator<Stream>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Stream <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public ReplaceOnDisposeStrategy <>4__this; //Field offset: 0x28

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
		public <GetAllReadStreams>d__1(int <>1__state) { }

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

	private class ReplaceOnDisposeFileStream : FileStream
	{
		private readonly string tempPath; //Field offset: 0x70
		private readonly string finalPath; //Field offset: 0x78
		private bool isDisposed; //Field offset: 0x80

		public ReplaceOnDisposeFileStream(string finalPath, string tempPath, FileMode mode, FileAccess access, FileShare share) { }

		public void Delete() { }

		protected virtual void Dispose(bool disposing) { }

	}


	public ReplaceOnDisposeStrategy(string path) { }

	public virtual void DeleteWriteStream(Stream stream) { }

	[IteratorStateMachine(typeof(<GetAllReadStreams>d__1))]
	public virtual IEnumerable<Stream> GetAllReadStreams() { }

	public virtual Stream GetWriteStream() { }

	public virtual void Wipe() { }

}

