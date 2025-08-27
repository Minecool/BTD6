namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class RogueMapScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <<RunAsync>g__RunRoutine|67_0>d : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public IEnumerator routine; //Field offset: 0x20
		public Action onComplete; //Field offset: 0x28

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
		public <<RunAsync>g__RunRoutine|67_0>d(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<GameObject, Boolean> <>9__59_0; //Field offset: 0x8
		public static Func<GameObject, Boolean> <>9__60_0; //Field offset: 0x10
		public static Func<RogueInstaMonkey, Boolean> <>9__76_0; //Field offset: 0x18
		public static Func<ArtifactLoot, Boolean> <>9__76_1; //Field offset: 0x20
		public static Func<RogueModeGenericRules, Boolean> <>9__97_0; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal bool <CheckInventoryLimits>b__76_0(RogueInstaMonkey x) { }

		internal bool <CheckInventoryLimits>b__76_1(ArtifactLoot x) { }

		internal bool <GetTotalCashForTile>b__97_0(RogueModeGenericRules x) { }

		internal bool <LivesAddedAnim>b__59_0(GameObject x) { }

		internal bool <LivesRemovedAnim>b__60_0(GameObject x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass67_0
	{
		public bool running; //Field offset: 0x10

		public <>c__DisplayClass67_0() { }

		internal void <RunAsync>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass88_0
	{
		public RogueMapScreen <>4__this; //Field offset: 0x10
		public bool canAutoMove; //Field offset: 0x18

		public <>c__DisplayClass88_0() { }

		internal void <ClaimLoot>b__0() { }

		internal void <ClaimLoot>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass90_0
	{
		public RogueMapScreen <>4__this; //Field offset: 0x10
		public RogueTile tile; //Field offset: 0x18

		public <>c__DisplayClass90_0() { }

		internal void <PlayTile>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass94_0
	{
		public RogueTile tile; //Field offset: 0x10

		public <>c__DisplayClass94_0() { }

		internal bool <GenerateDCM>b__0(RogueModeGenericRules x) { }

	}

	[CompilerGenerated]
	private struct <ActionTileComplete>d__75 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueMapScreen <>4__this; //Field offset: 0x28
		public RogueTile actionTile; //Field offset: 0x30
		public int healAmount; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <LoadingScreen>d__66 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18

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
		public <LoadingScreen>d__66(int <>1__state) { }

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

	[CompilerGenerated]
	private struct <Open>d__51 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueMapScreen <>4__this; //Field offset: 0x28
		public object data; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PlayTile>d__90 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueMapScreen <>4__this; //Field offset: 0x28
		public RogueTile tile; //Field offset: 0x30
		private <>c__DisplayClass90_0 <>8__1; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Refresh>d__69 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueMapScreen <>4__this; //Field offset: 0x20
		public bool regenerateTiles; //Field offset: 0x28
		public bool canAutoMove; //Field offset: 0x29
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <RegenerateTiles>d__64 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RogueMapScreen <>4__this; //Field offset: 0x20
		private Task <generateMapTask>5__2; //Field offset: 0x28
		private Task <animTask>5__3; //Field offset: 0x30

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
		public <RegenerateTiles>d__64(int <>1__state) { }

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

	[CompilerGenerated]
	private struct <RetryMinigame>d__91 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueMapScreen <>4__this; //Field offset: 0x28
		public RogueTile tile; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReturnToMainMenuScreen>d__74 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueMapScreen <>4__this; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunAsync>d__67 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IEnumerator routine; //Field offset: 0x20
		private <>c__DisplayClass67_0 <>8__1; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SkipTile>d__70 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueMapScreen <>4__this; //Field offset: 0x28
		public RogueTile tile; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class OnActionPanelClosed : MulticastDelegate
	{

		public OnActionPanelClosed(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(RogueTile campfireTileToReopen, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(RogueTile campfireTileToReopen = null) { }

	}

	internal sealed class OnActionTileComplete : MulticastDelegate
	{

		public OnActionTileComplete(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(RogueTile tile, int health, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(RogueTile tile, int health = 0) { }

	}

	internal sealed class OnRogueMapPanelOpen : MulticastDelegate
	{

		public OnRogueMapPanelOpen(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[SerializeField]
	private NK_TextMeshProUGUI stageText; //Field offset: 0x48
	[SerializeField]
	private Button resetRunBtn; //Field offset: 0x50
	[SerializeField]
	private Button showArtifactsBtn; //Field offset: 0x58
	[SerializeField]
	private Button showPartyBtn; //Field offset: 0x60
	[SerializeField]
	private Button resetViewBtn; //Field offset: 0x68
	[SerializeField]
	private Button curseInfoBtn; //Field offset: 0x70
	[SerializeField]
	private GameObject heartPrefab; //Field offset: 0x78
	[SerializeField]
	private GameObject heartsContainer; //Field offset: 0x80
	[SerializeField]
	private GameObject chimpsObj; //Field offset: 0x88
	[HideInInspector]
	public RogueTileInfoPanel tileInfoPanel; //Field offset: 0x90
	[SerializeField]
	private RogueCampfirePanel campfirePanel; //Field offset: 0x98
	public UpgradeArtifactsPanel enhanceArtifactPanel; //Field offset: 0xA0
	public RogueMentorPanel mentorPanel; //Field offset: 0xA8
	public RogueLootDisplay instasDisplay; //Field offset: 0xB0
	[SerializeField]
	private DisplayArtifactsPanel artifactDisplay; //Field offset: 0xB8
	[SerializeField]
	private RoguePartyPanel partyDisplay; //Field offset: 0xC0
	[SerializeField]
	private RogueMerchantPanel merchantPanel; //Field offset: 0xC8
	[SerializeField]
	private Button infoBtn; //Field offset: 0xD0
	[SerializeField]
	private GameObject infoPanel; //Field offset: 0xD8
	[SerializeField]
	private RogueCurseInfoPanel curseInfoPanel; //Field offset: 0xE0
	[SerializeField]
	private Lightbox infoPanelClose; //Field offset: 0xE8
	[SerializeField]
	private Button infoPanelOk; //Field offset: 0xF0
	[SerializeField]
	private float initialLoadAnimationDelaySecs; //Field offset: 0xF8
	[SerializeField]
	private float uiAnimDelay; //Field offset: 0xFC
	[SerializeField]
	private Animator blackBarsAnim; //Field offset: 0x100
	[SerializeField]
	private Animator rogueXpBannerEarnAnim; //Field offset: 0x108
	[SerializeField]
	private NK_TextMeshProUGUI rogueXpBannerEarnTxt; //Field offset: 0x110
	[SerializeField]
	private NK_TextMeshProUGUI rogueXpBannerTotalTxt; //Field offset: 0x118
	public RogueExtractionPanel extractionPanel; //Field offset: 0x120
	public RogueCampaignSummaryScreen summaryScreen; //Field offset: 0x128
	private bool isLootChestOpen; //Field offset: 0x130
	private List<GameObject> activeHeartObjs; //Field offset: 0x138
	public bool isSubPanelOpen; //Field offset: 0x140
	public RogueMap rogueMap; //Field offset: 0x148
	private bool isRefreshingTiles; //Field offset: 0x150
	private bool isRefreshing; //Field offset: 0x151

	private int ArtifactInventorySize
	{
		private get { } //Length: 85
	}

	private int InventorySize
	{
		private get { } //Length: 127
	}

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	private RogueData RogueData
	{
		private get { } //Length: 71
	}

	private RogueGameSaveData RogueSaveData
	{
		private get { } //Length: 211
	}

	private RogueGameModeRules Rules
	{
		private get { } //Length: 83
	}

	public RogueMapScreen() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__0(object data) { }

	[CompilerGenerated]
	private void <CheckInventoryLimits>b__76_2() { }

	[CompilerGenerated]
	private void <ResetRogue>b__71_0() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(<<RunAsync>g__RunRoutine|67_0>d))]
	internal static IEnumerator <RunAsync>g__RunRoutine|67_0(IEnumerator routine, Action onComplete) { }

	private void ActionPanelClosed(RogueTile reopenCampfireTile) { }

	private void ActionPanelOpened() { }

	[AsyncStateMachine(typeof(<ActionTileComplete>d__75))]
	public void ActionTileComplete(RogueTile actionTile, int healAmount = 0) { }

	protected virtual void Awake() { }

	public BossRushGameData BossRushData(RogueTile tile) { }

	public void CheckForLoot(bool canAutoMove) { }

	private void CheckForXpReward() { }

	private void CheckInventoryLimits() { }

	private void CinematicEvent(int phase) { }

	private void ClaimLoot(bool canAutoMove) { }

	public virtual void Close() { }

	public void CloseAnim() { }

	private void CloseInfoPanel() { }

	public void ContinueGame(RogueTile tile) { }

	private void CreateHearts() { }

	public void DisplayArtifactsInventory() { }

	public void DisplayRogueParty() { }

	public void ExtractionClosed() { }

	public DailyChallengeModel GenerateDCM(RogueTile tile) { }

	private int get_ArtifactInventorySize() { }

	private int get_InventorySize() { }

	private LegendsDataModel get_LegendsData() { }

	private RogueData get_RogueData() { }

	private RogueGameSaveData get_RogueSaveData() { }

	private RogueGameModeRules get_Rules() { }

	private float GetBossHealthForStage(int stage, RogueFinalBossInfo rogueFinalBossInfo) { }

	private float GetBossHealthMultiplier(RogueFinalBossInfo rogueFinalBossInfo) { }

	public int GetTotalCashForTile() { }

	private void KillAllSoundLoops() { }

	private void LivesAddedAnim(int livesAdded) { }

	public void LivesRemovedAnim() { }

	[IteratorStateMachine(typeof(<LoadingScreen>d__66))]
	private IEnumerator LoadingScreen() { }

	private void OnDestroy() { }

	[AsyncStateMachine(typeof(<Open>d__51))]
	public virtual void Open(object data) { }

	private void OpenCurseInfo() { }

	private void OpenInfoPanel() { }

	public virtual bool OverrideClose() { }

	[AsyncStateMachine(typeof(<PlayTile>d__90))]
	public void PlayTile(RogueTile tile) { }

	private void PlayXpEarnedAnim(int amount) { }

	public virtual void ReClose() { }

	[AsyncStateMachine(typeof(<Refresh>d__69))]
	private Task Refresh(bool regenerateTiles = false, bool canAutoMove = false) { }

	public void RefreshAsync(bool regenerateTiles = false, bool canAutoMove = false) { }

	public void RefreshHud() { }

	public void RefreshWithLoadingScreen() { }

	public void RefreshXpAmountTxt() { }

	[IteratorStateMachine(typeof(<RegenerateTiles>d__64))]
	private IEnumerator<Object> RegenerateTiles() { }

	public virtual void ReOpen(object data) { }

	private void ResetRogue() { }

	private void ResetView() { }

	[AsyncStateMachine(typeof(<RetryMinigame>d__91))]
	public void RetryMinigame(RogueTile tile) { }

	[AsyncStateMachine(typeof(<ReturnToMainMenuScreen>d__74))]
	private Task ReturnToMainMenuScreen() { }

	public void ReturnToMenu() { }

	[AsyncStateMachine(typeof(<RunAsync>d__67))]
	private static Task RunAsync(IEnumerator routine) { }

	public void SendRestartAnalyticsAndDelete() { }

	[AsyncStateMachine(typeof(<SkipTile>d__70))]
	public void SkipTile(RogueTile tile) { }

	public void TileSelected(RogueTile tile) { }

	private void UpdateHearts() { }

}

