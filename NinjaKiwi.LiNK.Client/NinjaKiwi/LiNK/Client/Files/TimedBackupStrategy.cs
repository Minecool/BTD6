namespace NinjaKiwi.LiNK.Client.Files;

internal sealed class TimedBackupStrategy : FileSystemStorage
{
	[CompilerGenerated]
	private struct <CreateBackup>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TimedBackupStrategy <>4__this; //Field offset: 0x28
		private object <id>5__2; //Field offset: 0x30
		private DateTime <endOfDelay>5__3; //Field offset: 0x38
		private YieldAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <GetAllReadStreams>d__7 : IEnumerable<Stream>, IEnumerable, IEnumerator<Stream>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Stream <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public TimedBackupStrategy <>4__this; //Field offset: 0x28

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
		public <GetAllReadStreams>d__7(int <>1__state) { }

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

	public static TimeSpan backupDelay; //Field offset: 0x0
	private readonly string tempPath; //Field offset: 0x20
	private readonly string backupPath; //Field offset: 0x28
	private bool mainFileIsKnowToBeCorrupt; //Field offset: 0x30
	private bool tempFileIsKnowToBeCorrupt; //Field offset: 0x31
	private object backupTimerID; //Field offset: 0x38

	private static TimedBackupStrategy() { }

	public TimedBackupStrategy(string path) { }

	[AsyncStateMachine(typeof(<CreateBackup>d__9))]
	private void CreateBackup() { }

	public virtual void DeleteWriteStream(Stream stream) { }

	[IteratorStateMachine(typeof(<GetAllReadStreams>d__7))]
	public virtual IEnumerable<Stream> GetAllReadStreams() { }

	public virtual Stream GetWriteStream() { }

	private static void Rename(string existingPath, string newPath) { }

	private static bool TryRename(string existingPath, string newPath) { }

	public virtual void Wipe() { }

}

