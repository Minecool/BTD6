namespace Assets.Scripts.Utils;

[Extension]
public static class Helpers
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public string baseHeroId; //Field offset: 0x10

		public <>c__DisplayClass26_0() { }

		internal bool <GetHeroMmCost>b__0(HeroDetailsModel e) { }

		internal bool <GetHeroMmCost>b__1(HeroSaleEvent x) { }

	}

	[CompilerGenerated]
	private struct <CheckInternetStatus>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public Nullable<TimeSpan> timeoutOverride; //Field offset: 0x20
		public bool isCoopCheck; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static readonly Dictionary<String, Object> GlobalExpressionParameters; //Field offset: 0x0
	private static List<ValueTuple`3<Int32, CoopDivision, CoopDivision>> DivisionsSameWhenPlayerCountIsOrGreaterThan; //Field offset: 0x8
	public static HashSet<String> samplePrefabsTo; //Field offset: 0x10

	private static Helpers() { }

	public static void AddInstaMonkeySet(string monkeyType, int maxTier = 5) { }

	[AsyncStateMachine(typeof(<CheckInternetStatus>d__27))]
	public static Task<Boolean> CheckInternetStatus(bool isCoopCheck, Nullable<TimeSpan> timeoutOverride = null) { }

	public static Vector2 ClampPointWithinMap(Vector2 point, float border = 0) { }

	public static string ConvertTimeToStr(DateTime time) { }

	private static string GetAudioClipGuid(AudioClip clip) { }

	public static AudioClipReference GetAudioClipReference(AudioClip clip) { }

	private static string GetGameObjectGuid(GameObject obj) { }

	public static ValueTuple<KonFuze, KonFuze, KonFuze, Boolean, Boolean> GetHeroMmCost(string baseHeroId, string skinName = null) { }

	public static List<TowerModel> GetLockedTowerListForTowerType(TowerSet towerset) { }

	public static PrefabReference GetPrefabReference(GameObject obj) { }

	public static Int32[] GetRandomTowerTiers(int mainTier) { }

	public static SpriteReference GetSpriteReference(GameObject obj) { }

	public static List<TowerModel> GetTowerListForTowerType(TowerSet towerset) { }

	[Extension]
	public static bool IsNullOrEmpty(ICollection<T> value) { }

	public static bool IsPointWithinMap(Vector2 point, float border = 0) { }

	private static bool IsValidNameChar(char v, Char[] allowedSymbols) { }

	public static CoopDivision IterateCoopDivisionEnum(CoopDivision curr, int iteration, string mapName, int numPlayers) { }

	public static void PostToInfoDump(string output) { }

	public static void ShowOkPopup(string bodyLocKey, ReturnCallback onOkCancelCallback = null) { }

	public static void ShowPopup(string titleLocKey, string bodyLocKey, bool showBackground, ReturnCallback onOkCallback = null) { }

	private static int SubTier(int mainTier) { }

	public static string ToEventTimeRemainingDisplay(TimeSpan timeRemaining, bool ignoreHeader = false) { }

	public static string ToGameCompletionTimeDisplay(int milliSeconds) { }

	public static string ToGameCompletionTimeDisplay(double milliSeconds) { }

	public static string ToGameCompletionTimeDisplay(TimeSpan timeSpan) { }

	public static string ValidateString(string text, int maxLength, Char[] allowedSymbols = null) { }

	public static List<String> ValidBaseTowerNames() { }

	public static int WrapToPathIndex(int index) { }

}

