namespace NinjaKiwi.GUTS.Utils;

public static class EncodedStorage
{
	[CompilerGenerated]
	private struct <Decode>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public Byte[] encryptedData; //Field offset: 0x20
		private Aes <aes>5__2; //Field offset: 0x28
		private MemoryStream <memoryStream>5__3; //Field offset: 0x30
		private CryptoStream <cryptoStream>5__4; //Field offset: 0x38
		private DeflateStream <deflateStream>5__5; //Field offset: 0x40
		private StreamReader <streamReader>5__6; //Field offset: 0x48
		private TaskAwaiter<String> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DecodeFromFile>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public string filePath; //Field offset: 0x20
		private Aes <aes>5__2; //Field offset: 0x28
		private FileStream <fileStream>5__3; //Field offset: 0x30
		private CryptoStream <cryptoStream>5__4; //Field offset: 0x38
		private DeflateStream <deflateStream>5__5; //Field offset: 0x40
		private StreamReader <streamReader>5__6; //Field offset: 0x48
		private TaskAwaiter<String> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Encode>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Byte[]> <>t__builder; //Field offset: 0x8
		public string value; //Field offset: 0x20
		private Aes <aes>5__2; //Field offset: 0x28
		private MemoryStream <memoryStream>5__3; //Field offset: 0x30
		private CryptoStream <cryptoStream>5__4; //Field offset: 0x38
		private DeflateStream <deflateStream>5__5; //Field offset: 0x40
		private StreamWriter <streamWriter>5__6; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EncodeToFile>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string filePath; //Field offset: 0x20
		public string data; //Field offset: 0x28
		private Aes <aes>5__2; //Field offset: 0x30
		private FileStream <fileStream>5__3; //Field offset: 0x38
		private CryptoStream <cryptoStream>5__4; //Field offset: 0x40
		private DeflateStream <deflateStream>5__5; //Field offset: 0x48
		private StreamWriter <streamWriter>5__6; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	private static Aes CreateAes() { }

	private static void CreateRootDirectory(string filePath) { }

	[AsyncStateMachine(typeof(<Decode>d__3))]
	public static Task<String> Decode(Byte[] encryptedData) { }

	[AsyncStateMachine(typeof(<DecodeFromFile>d__1))]
	public static Task<String> DecodeFromFile(string filePath) { }

	[AsyncStateMachine(typeof(<Encode>d__2))]
	public static Task<Byte[]> Encode(string value) { }

	[AsyncStateMachine(typeof(<EncodeToFile>d__0))]
	public static Task EncodeToFile(string filePath, string data) { }

}

