namespace NinjaKiwi.Common.IO;

public class DefaultFileIO : IFileIO
{
	[CompilerGenerated]
	private sealed class <NinjaKiwi-Common-IO-IFileIO-FilesInDirectory>d__6 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public DefaultFileIO <>4__this; //Field offset: 0x28
		private string path; //Field offset: 0x30
		public string <>3__path; //Field offset: 0x38
		private bool recursive; //Field offset: 0x40
		public bool <>3__recursive; //Field offset: 0x41
		private string <directoryPath>5__2; //Field offset: 0x48
		private FileInfo[] <>7__wrap2; //Field offset: 0x50
		private int <>7__wrap3; //Field offset: 0x58

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
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
		public <NinjaKiwi-Common-IO-IFileIO-FilesInDirectory>d__6(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <NinjaKiwi-Common-IO-IFileIO-ReadAllBytesAsync>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Byte[]> <>t__builder; //Field offset: 0x8
		public DefaultFileIO <>4__this; //Field offset: 0x20
		public string path; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private FileStream <fileStream>5__2; //Field offset: 0x38
		private Byte[] <fileContents>5__3; //Field offset: 0x40
		private int <numBytesToRead>5__4; //Field offset: 0x48
		private int <numBytesRead>5__5; //Field offset: 0x4C
		private object <>7__wrap5; //Field offset: 0x50
		private int <>7__wrap6; //Field offset: 0x58
		private Byte[] <>7__wrap7; //Field offset: 0x60
		private TaskAwaiter<Int32> <>u__1; //Field offset: 0x68
		private ValueTaskAwaiter <>u__2; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly string rootFolder; //Field offset: 0x10

	public DefaultFileIO(string rootFolder) { }

	private override void NinjaKiwi.Common.IO.IFileIO.CleanDirectory(string path) { }

	private override void NinjaKiwi.Common.IO.IFileIO.CreateDirectory(string path) { }

	private override bool NinjaKiwi.Common.IO.IFileIO.DirectoryExists(string path) { }

	private override void NinjaKiwi.Common.IO.IFileIO.FileDelete(string path) { }

	private override bool NinjaKiwi.Common.IO.IFileIO.FileExists(string path) { }

	[IteratorStateMachine(typeof(<NinjaKiwi-Common-IO-IFileIO-FilesInDirectory>d__6))]
	private override IEnumerable<String> NinjaKiwi.Common.IO.IFileIO.FilesInDirectory(string path, bool recursive) { }

	private override DateTime NinjaKiwi.Common.IO.IFileIO.GetCreationTime(string path) { }

	private override long NinjaKiwi.Common.IO.IFileIO.GetFileSize(string path) { }

	private override DateTime NinjaKiwi.Common.IO.IFileIO.GetLastAccessTime(string path) { }

	private override DateTime NinjaKiwi.Common.IO.IFileIO.GetLastWriteTime(string path) { }

	private override Byte[] NinjaKiwi.Common.IO.IFileIO.ReadAllBytes(string path) { }

	[AsyncStateMachine(typeof(<NinjaKiwi-Common-IO-IFileIO-ReadAllBytesAsync>d__15))]
	private override Task<Byte[]> NinjaKiwi.Common.IO.IFileIO.ReadAllBytesAsync(string path, CancellationToken cancellationToken) { }

	private override void NinjaKiwi.Common.IO.IFileIO.SetLastAccessTime(string path, DateTime time) { }

	private override void NinjaKiwi.Common.IO.IFileIO.WriteAllBytes(string path, Byte[] bytes) { }

	private override Task NinjaKiwi.Common.IO.IFileIO.WriteAllBytesAsync(string path, Byte[] bytes, CancellationToken cancellationToken) { }

	private string ResolvePath(string path) { }

}

