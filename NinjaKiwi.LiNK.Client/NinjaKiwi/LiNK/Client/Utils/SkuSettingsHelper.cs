namespace NinjaKiwi.LiNK.Client.Utils;

public class SkuSettingsHelper
{
	[CompilerGenerated]
	private struct <Retrieve>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public SkuSettingsHelper <>4__this; //Field offset: 0x20
		public string fileName; //Field offset: 0x28
		public float minutesToCache; //Field offset: 0x30
		public bool returnNullIfUnchanged; //Field offset: 0x34
		public bool checkSig; //Field offset: 0x35
		private TaskAwaiter<CacheEntry> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RetrieveByBuild>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public SkuSettingsHelper <>4__this; //Field offset: 0x20
		public bool checkSig; //Field offset: 0x28
		public String[] buildNames; //Field offset: 0x30
		public float minutesToCache; //Field offset: 0x38
		public bool returnNullIfUnchanged; //Field offset: 0x3C
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x40
		private TaskAwaiter<String> <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string START = "{"settings":{"; //Field offset: 0x0
	private const string END = "}}"; //Field offset: 0x0
	internal readonly int appID; //Field offset: 0x10
	internal readonly int skuID; //Field offset: 0x14
	internal readonly Environments environment; //Field offset: 0x18
	private readonly string skuSignature; //Field offset: 0x20
	private readonly JsonSerializerSettings jsonSettings; //Field offset: 0x28
	private readonly TimeSpan timeout; //Field offset: 0x30
	private readonly ICache cache; //Field offset: 0x38
	private readonly bool useFileCache; //Field offset: 0x40
	private string previousEtag; //Field offset: 0x48
	private bool firstTime; //Field offset: 0x50

	public SkuSettingsHelper(int appID, int skuID, string skuSignature, Environments environment, JsonSerializerSettings jsonSettings = null, TimeSpan timeout = null, bool useFileCache = true) { }

	internal string DeserialiseResponseAndCheckSignature(string rawResponse, bool checkSig) { }

	private IHttpDataLoader GetDataLoader(string url) { }

	internal string GetFileNameFromBranchesInfo(string json, int appID, int skuID, String[] buildNames) { }

	[AsyncStateMachine(typeof(<Retrieve>d__13))]
	public Task<String> Retrieve(string fileName, float minutesToCache, bool checkSig = true, bool returnNullIfUnchanged = true) { }

	public Task<String> RetrieveByBuild(string buildName, float minutesToCache, bool checkSig = true, bool returnNullIfUnchanged = true) { }

	[AsyncStateMachine(typeof(<RetrieveByBuild>d__12))]
	public Task<String> RetrieveByBuild(String[] buildNames, float minutesToCache, bool checkSig = true, bool returnNullIfUnchanged = true) { }

	internal string StripSettingsTag(string input) { }

}

