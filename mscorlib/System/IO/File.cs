namespace System.IO;

public static class File
{
	[CompilerGenerated]
	private struct <InternalWriteAllBytesAsync>d__74 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string path; //Field offset: 0x20
		public Byte[] bytes; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private FileStream <fs>5__2; //Field offset: 0x38
		private ConfiguredValueTaskAwaiter <>u__1; //Field offset: 0x40
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public static void Copy(string sourceFileName, string destFileName, bool overwrite) { }

	public static FileStream Create(string path) { }

	public static FileStream Create(string path, int bufferSize) { }

	public static void Delete(string path) { }

	public static bool Exists(string path) { }

	public static FileAttributes GetAttributes(string path) { }

	public static DateTime GetCreationTime(string path) { }

	public static DateTime GetLastAccessTime(string path) { }

	public static DateTime GetLastWriteTime(string path) { }

	private static string InternalReadAllText(string path, Encoding encoding) { }

	private static void InternalWriteAllBytes(string path, Byte[] bytes) { }

	[AsyncStateMachine(typeof(<InternalWriteAllBytesAsync>d__74))]
	private static Task InternalWriteAllBytesAsync(string path, Byte[] bytes, CancellationToken cancellationToken) { }

	public static void Move(string sourceFileName, string destFileName) { }

	public static FileStream Open(string path, FileMode mode) { }

	public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share) { }

	public static FileStream OpenRead(string path) { }

	public static StreamReader OpenText(string path) { }

	public static FileStream OpenWrite(string path) { }

	public static Byte[] ReadAllBytes(string path) { }

	private static Byte[] ReadAllBytesUnknownLength(FileStream fs) { }

	public static string ReadAllText(string path) { }

	public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName) { }

	public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors) { }

	public static void SetLastAccessTime(string path, DateTime lastAccessTime) { }

	public static void WriteAllBytes(string path, Byte[] bytes) { }

	public static Task WriteAllBytesAsync(string path, Byte[] bytes, CancellationToken cancellationToken = null) { }

	public static void WriteAllText(string path, string contents) { }

}

