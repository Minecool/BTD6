namespace NinjaKiwi.LiNK.Client.Caching;

public class LocalStorageBackedHttpDataLoader : IHttpDataLoader, IDataLoader
{
	[CompilerGenerated]
	private struct <Get>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<DataAndEtag> <>t__builder; //Field offset: 0x8
		public LocalStorageBackedHttpDataLoader <>4__this; //Field offset: 0x20
		public string dataKey; //Field offset: 0x28
		public DataAndEtag existing; //Field offset: 0x30
		private DataAndEtag <localData>5__2; //Field offset: 0x38
		private TaskAwaiter<DataAndEtag> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly HttpDataLoader httpDataLoader; //Field offset: 0x10
	private readonly ILocalKeyValueStorage keyValueStorage; //Field offset: 0x18
	private readonly JsonSerializerSettings jsonSettings; //Field offset: 0x20

	public LocalStorageBackedHttpDataLoader(string url, ILocalKeyValueStorage storage) { }

	public LocalStorageBackedHttpDataLoader(string url, string storageRootPath) { }

	[AsyncStateMachine(typeof(<Get>d__6))]
	public override Task<DataAndEtag> Get(string dataKey, DataAndEtag existing) { }

	public override void SetUp(ContentEncoding requestEncoding = 0, ContentEncoding responseEncoding = 0, bool responseCompression = true, TimeSpan timeout = null) { }

}

