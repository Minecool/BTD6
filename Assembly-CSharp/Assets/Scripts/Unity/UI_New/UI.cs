namespace Assets.Scripts.Unity.UI_New;

public class UI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<CoopPlayerInfo, PlayerCosmeticInfo> <>9__7_5; //Field offset: 0x8
		public static Func<PlayerCosmeticInfo, Boolean> <>9__7_6; //Field offset: 0x10
		public static Func<Int32, Char, Int32> <>9__7_2; //Field offset: 0x18
		public static Func<Boolean> <>9__7_3; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal int <LoadGameEnumerator>b__7_2(int prod, char next) { }

		internal bool <LoadGameEnumerator>b__7_3() { }

		internal PlayerCosmeticInfo <LoadGameEnumerator>b__7_5(CoopPlayerInfo coopPlayerInfo) { }

		internal bool <LoadGameEnumerator>b__7_6(PlayerCosmeticInfo cosmeticInfo) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public Btd6CoopGame coopGame; //Field offset: 0x10
		public bool isCoop; //Field offset: 0x18
		public PlayerCosmeticInfo cosmetics; //Field offset: 0x20
		public bool loadingComplete; //Field offset: 0x28

		public <>c__DisplayClass7_0() { }

		internal bool <LoadGameEnumerator>b__0(CoopPlayerInfo p) { }

		internal bool <LoadGameEnumerator>b__1() { }

		internal void <LoadGameEnumerator>b__8() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_1
	{
		public BossRushGameData bossRushDataIngame; //Field offset: 0x10

		public <>c__DisplayClass7_1() { }

		internal bool <LoadGameEnumerator>b__4(BossRushScriptable x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_2
	{
		public Task<BossDataModel> bossDataTask; //Field offset: 0x10

		public <>c__DisplayClass7_2() { }

		internal bool <LoadGameEnumerator>b__7() { }

	}

	[CompilerGenerated]
	private sealed class <LoadGameEnumerator>d__7 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Btd6CoopGame coopGame; //Field offset: 0x20
		public UI <>4__this; //Field offset: 0x28
		public MapSaveDataModel mapSaveData; //Field offset: 0x30
		private <>c__DisplayClass7_0 <>8__1; //Field offset: 0x38
		public Replay replay; //Field offset: 0x40
		private <>c__DisplayClass7_2 <>8__2; //Field offset: 0x48
		public bool isRejoining; //Field offset: 0x50
		public bool requiresReplayRecording; //Field offset: 0x51
		public bool wasSaveOverwritten; //Field offset: 0x52
		private GameModel <gameModelOrig>5__2; //Field offset: 0x58
		private List<String> <activeMods>5__3; //Field offset: 0x60
		private Btd6Player <btd6Player>5__4; //Field offset: 0x68
		private ModModel <dcmModModel>5__5; //Field offset: 0x70
		private GameModel <moddedGameModel>5__6; //Field offset: 0x78
		private UnityToSimulation <bridge>5__7; //Field offset: 0x80
		private DateTime <whenToStopWaiting>5__8; //Field offset: 0x88

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
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
		public <LoadGameEnumerator>d__7(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal sealed class OnUiLoadGameCompleteEvent : MulticastDelegate
	{

		public OnUiLoadGameCompleteEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	public static UI instance; //Field offset: 0x0
	public MapLoader mapLoader; //Field offset: 0x20
	private bool isLoadingGame; //Field offset: 0x28

	public UI() { }

	public static void ApplyExtraNotInSimModelSettings(UnityToSimulation uts, GameModel model) { }

	public static void ApplyFastTrack(Btd6CoopGame coopGame, GameModel moddedGameModel) { }

	public static void ApplyRogueHeroXp(GameModel moddedGameModel) { }

	public void Awake() { }

	public void DestroyAndUnloadMapScene() { }

	private String[] GetBannedHeros() { }

	public static string GetImageQualityForDevice() { }

	public void LoadGame(Btd6CoopGame coopGame = null, Replay replay = null, MapSaveDataModel mapSaveData = null, bool requiresReplayRecording = false, bool wasSaveOverwritten = false) { }

	[IteratorStateMachine(typeof(<LoadGameEnumerator>d__7))]
	public IEnumerator LoadGameEnumerator(Btd6CoopGame coopGame = null, Replay replay = null, MapSaveDataModel mapSaveData = null, bool isRejoining = false, bool requiresReplayRecording = false, bool wasSaveOverwritten = false) { }

	private void OnDestroy() { }

	public void ResetMap() { }

	private bool ShouldRecord(GameType gameType, bool isCoop) { }

	public void UpdateRoundForMap(int round, bool isSet) { }

}

