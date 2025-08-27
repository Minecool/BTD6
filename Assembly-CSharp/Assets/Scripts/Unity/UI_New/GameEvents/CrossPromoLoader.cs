namespace Assets.Scripts.Unity.UI_New.GameEvents;

public static class CrossPromoLoader
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<NkCrossPromo, DateTime> <>9__5_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal DateTime <GetCrossPromoInfo>b__5_0(NkCrossPromo x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public DateTime now; //Field offset: 0x10
		public string gamePromoTag; //Field offset: 0x18
		public string storeTag; //Field offset: 0x20

		public <>c__DisplayClass5_0() { }

		internal bool <GetCrossPromoInfo>b__1(NkCrossPromo x) { }

		internal bool <GetCrossPromoInfo>b__2(GamePromoInfo x) { }

	}

	[CompilerGenerated]
	private struct <GetCrossPromoInfo>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<CrossPromoInfo> <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x20
		private <>c__DisplayClass5_0 <>8__1; //Field offset: 0x28
		private NkCrossPromo[] <appCrossPromos>5__2; //Field offset: 0x30
		private int <promotedGameId>5__3; //Field offset: 0x38
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public class GamePromo
	{
		[JsonProperty("assets")]
		public GamePromoInfo[] gamePromoInfos; //Field offset: 0x10
		public Dictionary<String, String> links; //Field offset: 0x18

		public GamePromo() { }

	}

	public class GamePromoInfo
	{
		public string name; //Field offset: 0x10
		[JsonProperty("url")]
		public string imageUrl; //Field offset: 0x18
		public String[] tags; //Field offset: 0x20

		public GamePromoInfo() { }

	}

	public class NkCrossPromo
	{
		public int appid; //Field offset: 0x10
		[JsonConverter(typeof(UnixDateTimeConverter))]
		public DateTime startTime; //Field offset: 0x18

		public NkCrossPromo() { }

	}

	public class NkCrossPromos
	{
		public Dictionary<String, NkCrossPromo[]> promotions; //Field offset: 0x10

		public NkCrossPromos() { }

	}

	private static readonly CrossPromoInfo InvalidCrossPromo; //Field offset: 0x0

	private static string AppId
	{
		private get { } //Length: 29
	}

	private static Environments Environment
	{
		private get { } //Length: 77
	}

	private static CrossPromoLoader() { }

	private static string get_AppId() { }

	private static Environments get_Environment() { }

	[AsyncStateMachine(typeof(<GetCrossPromoInfo>d__5))]
	public static Task<CrossPromoInfo> GetCrossPromoInfo(CancellationToken cancellationToken) { }

	private static string GetStoreTag() { }

	private static Task<Byte[]> LoadFromCacheOrDownload(Uri uri) { }

	private static bool TryGetStoreUrl(Dictionary<String, String> links, out string storeUrl) { }

}

