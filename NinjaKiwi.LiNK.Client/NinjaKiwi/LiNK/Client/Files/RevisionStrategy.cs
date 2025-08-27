namespace NinjaKiwi.LiNK.Client.Files;

internal class RevisionStrategy : FileSystemStorage
{
	[CompilerGenerated]
	private sealed class <GetAllReadStreams>d__2 : IEnumerable<Stream>, IEnumerable, IEnumerator<Stream>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Stream <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public RevisionStrategy <>4__this; //Field offset: 0x28

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
		public <GetAllReadStreams>d__2(int <>1__state) { }

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

	private static readonly string REVISION_SUFFIX; //Field offset: 0x0
	private static readonly string REVISION_REGEX; //Field offset: 0x8
	private readonly string directoryPath; //Field offset: 0x20

	private static RevisionStrategy() { }

	public RevisionStrategy(string path) { }

	public virtual void DeleteWriteStream(Stream stream) { }

	[IteratorStateMachine(typeof(<GetAllReadStreams>d__2))]
	public virtual IEnumerable<Stream> GetAllReadStreams() { }

	private int GetMaximumFileVersion(bool allowEmptyFiles) { }

	public virtual Stream GetWriteStream() { }

	private void RemoveRevisionsBelow(int maxVersion) { }

	public virtual void Wipe() { }

}

