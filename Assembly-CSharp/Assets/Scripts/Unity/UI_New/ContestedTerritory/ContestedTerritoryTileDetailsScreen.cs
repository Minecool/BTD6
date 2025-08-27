namespace Assets.Scripts.Unity.UI_New.ContestedTerritory;

public class ContestedTerritoryTileDetailsScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<TeamStoreRelic, Boolean> <>9__90_0; //Field offset: 0x8
		public static Func<ContestedTerritoryRelicType, Boolean> <>9__90_3; //Field offset: 0x10
		public static Func<CTRelicSelectable, ContestedTerritoryRelicType> <>9__97_0; //Field offset: 0x18
		public static Func<TowerData, Boolean> <>9__103_0; //Field offset: 0x20
		public static Func<TowerData, Boolean> <>9__103_1; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal bool <DisplayTowers>b__103_0(TowerData x) { }

		internal bool <DisplayTowers>b__103_1(TowerData x) { }

		internal ContestedTerritoryRelicType <StartNewGame>b__97_0(CTRelicSelectable x) { }

		internal bool <UpdateRelicsAsync>b__90_0(TeamStoreRelic x) { }

		internal bool <UpdateRelicsAsync>b__90_3(ContestedTerritoryRelicType x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass90_0
	{
		public ContestedTerritoryTileDetailsScreen <>4__this; //Field offset: 0x10
		public List<ContestedTerritoryRelicType> selectedRelics; //Field offset: 0x18
		public Func<ContestedTerritoryRelicType, Boolean> <>9__4; //Field offset: 0x20

		public <>c__DisplayClass90_0() { }

		internal bool <UpdateRelicsAsync>b__4(ContestedTerritoryRelicType x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass90_1
	{
		public CTRelicSelectable relicUI; //Field offset: 0x10
		public <>c__DisplayClass90_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass90_1() { }

		internal void <UpdateRelicsAsync>b__1(BaseEventData _) { }

		internal void <UpdateRelicsAsync>b__2(BaseEventData _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass90_2
	{
		public CTRelicSelectable relicUI; //Field offset: 0x10
		public <>c__DisplayClass90_0 CS$<>8__locals2; //Field offset: 0x18

		public <>c__DisplayClass90_2() { }

		internal void <UpdateRelicsAsync>b__5(BaseEventData _) { }

		internal void <UpdateRelicsAsync>b__6(BaseEventData _) { }

	}

	[CompilerGenerated]
	private struct <ClaimGuildTicketClicked>d__99 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryTileDetailsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<CtApiFunctionResult`1<TicketResponse>> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ContinueClicked>d__98 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryTileDetailsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<StartTileGameResponse> <>u__1; //Field offset: 0x30
		private TaskAwaiter<CtApiActionResult> <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Open>d__75 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public object data; //Field offset: 0x28
		public ContestedTerritoryTileDetailsScreen <>4__this; //Field offset: 0x30
		private TaskAwaiter<CtApiActionResult> <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PlayClicked>d__96 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryTileDetailsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<StartTileGameResponse> <>u__1; //Field offset: 0x30
		private TaskAwaiter<CtApiActionResult> <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PurchaseTicketAsync>d__101 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryTileDetailsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<CtApiFunctionResult`1<TicketResponse>> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowTeamCosmeticsAsync>d__105 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryTileDetailsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<GuildModel> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateLootAsync>d__77 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryTileDetailsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<LootSet> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateMapTileVisualsAsync>d__85 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryTileDetailsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateRelicsAsync>d__90 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryTileDetailsScreen <>4__this; //Field offset: 0x20
		private <>c__DisplayClass90_0 <>8__1; //Field offset: 0x28
		private CTEventData <ctEventData>5__2; //Field offset: 0x30
		private List<TeamStoreRelic> <guildRelics>5__3; //Field offset: 0x38
		private List<TeamStoreRelic> <>7__wrap3; //Field offset: 0x40
		private List<TeamStoreRelic> <>7__wrap4; //Field offset: 0x48
		private TaskAwaiter<TeamStoreRelic> <>u__1; //Field offset: 0x50
		private TaskAwaiter<TeamStoreRelic[]> <>u__2; //Field offset: 0x58
		private TaskAwaiter<IReadOnlyCollection`1<ContestedTerritoryRelicType>> <>u__3; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateRelicsOnClosePopupAsync>d__112 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryTileDetailsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateTileStatusAsync>d__78 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryIslandTile tile; //Field offset: 0x28
		public ContestedTerritoryTileDetailsScreen <>4__this; //Field offset: 0x30
		private TaskAwaiter<CtApiActionResult> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateTileStatusAsync>d__87 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryTileDetailsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<CtApiActionResult> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int purchaseTicketCost = 200; //Field offset: 0x0
	public Button fullScreenBackBtn; //Field offset: 0x48
	public TMP_Text difficultyTxt; //Field offset: 0x50
	public TMP_Text gameTypeTxt; //Field offset: 0x58
	public Image gameTypeImg; //Field offset: 0x60
	public Button gameTypeInfoBtn; //Field offset: 0x68
	public Sprite raceSpr; //Field offset: 0x70
	public Sprite bossSpr; //Field offset: 0x78
	public Sprite leastCashSpr; //Field offset: 0x80
	public Sprite leastTiersSpr; //Field offset: 0x88
	public TMP_Text tileIDTxt; //Field offset: 0x90
	public GameObject uncapturedObject; //Field offset: 0x98
	public GameObject capturedObject; //Field offset: 0xA0
	public Image bannerImg; //Field offset: 0xA8
	public Image teamIconImg; //Field offset: 0xB0
	public Image teamFrameImg; //Field offset: 0xB8
	public Image teamBannerImg; //Field offset: 0xC0
	public Button teamInfoBtn; //Field offset: 0xC8
	public TMP_Text ownerTxt; //Field offset: 0xD0
	public TMP_Text capturingPlayerTxt; //Field offset: 0xD8
	public TMP_Text scoreTxt; //Field offset: 0xE0
	public TMP_Text rateTxt; //Field offset: 0xE8
	public NK_TextMeshProUGUI ctPointsRateTxt; //Field offset: 0xF0
	public GameObject ctPointsRateObj; //Field offset: 0xF8
	public TMP_Text nextDegradeInTxt; //Field offset: 0x100
	public TMP_Text neutralInTxt; //Field offset: 0x108
	public NK_TextMeshProUGUI neutralInTitleTxt; //Field offset: 0x110
	public Image mapImage; //Field offset: 0x118
	public TMP_Text roundNumbersTxt; //Field offset: 0x120
	public GameObject maxTowerObject; //Field offset: 0x128
	public TMP_Text maxTowerTxt; //Field offset: 0x130
	public Transform towerContainer; //Field offset: 0x138
	public GameObject towerPrefab; //Field offset: 0x140
	public GameObject anyHeroPrefab; //Field offset: 0x148
	public Button rulesBtn; //Field offset: 0x150
	public LootPanel lootPanel; //Field offset: 0x158
	public GameObject relicTileObj; //Field offset: 0x160
	public GameObject bannerTileObj; //Field offset: 0x168
	public GameObject relicTilePopupObj; //Field offset: 0x170
	public TMP_Text relicTilePopupText; //Field offset: 0x178
	public Image relicIcon; //Field offset: 0x180
	public TMP_Text relicNameTxt; //Field offset: 0x188
	public GameObject fullRelicPanel; //Field offset: 0x190
	public TMP_Text relicCountTxt; //Field offset: 0x198
	public Transform eventRelicParent; //Field offset: 0x1A0
	public Transform heldRelicParent; //Field offset: 0x1A8
	public CTRelicSelectable heldRelicPrefab; //Field offset: 0x1B0
	public GameObject relicPopupObj; //Field offset: 0x1B8
	public GameObject relicPopupArrowObj; //Field offset: 0x1C0
	public TMP_Text relicPopupTitleTxt; //Field offset: 0x1C8
	public TMP_Text relicPopupDecriptionTxt; //Field offset: 0x1D0
	public GameObject relicPopupLockedObj; //Field offset: 0x1D8
	public Button relicManagerButton; //Field offset: 0x1E0
	public CTRelicManagerPopupScreen relicManagerPopupScreen; //Field offset: 0x1E8
	private readonly List<CTRelicSelectable> teamRelicList; //Field offset: 0x1F0
	private readonly List<CTRelicSelectable> heldRelicSelectedOrder; //Field offset: 0x1F8
	public Button continueBtn; //Field offset: 0x200
	public Button playBtn; //Field offset: 0x208
	public TMP_Text ticketCountTxt; //Field offset: 0x210
	public Button claimGuildTicketBtn; //Field offset: 0x218
	public TMP_Text guildTicketCountTxt; //Field offset: 0x220
	public Button buyTicketBtn; //Field offset: 0x228
	public TMP_Text ticketCostTxt; //Field offset: 0x230
	public GameObject noTicketsObj; //Field offset: 0x238
	public TMP_Text nextTicketsTimer; //Field offset: 0x240
	public GameObject loadingObject; //Field offset: 0x248
	public AudioClip clickSound; //Field offset: 0x250
	public AudioClip backSound; //Field offset: 0x258
	public GameObject cantPlayCompetitive; //Field offset: 0x260
	private ContestedTerritoryIslandTile tile; //Field offset: 0x268
	private MapSaveDataModel mapSave; //Field offset: 0x270
	private readonly List<GameObject> towerDisplayList; //Field offset: 0x278
	private TicketStatus tickets; //Field offset: 0x280
	private GuildModel guildModel; //Field offset: 0x2D8
	private bool invokedclose; //Field offset: 0x2E0
	private float timer; //Field offset: 0x2E4
	private bool updatingTileStatus; //Field offset: 0x2E8

	public ContestedTerritoryTileDetailsScreen() { }

	[CompilerGenerated]
	private void <BuyTicketClicked>b__100_0() { }

	[CompilerGenerated]
	private void <PlayClicked>b__96_0() { }

	protected virtual void Awake() { }

	private void ButtonsInteractable(bool interactable) { }

	public void BuyTicketClicked() { }

	[AsyncStateMachine(typeof(<ClaimGuildTicketClicked>d__99))]
	public void ClaimGuildTicketClicked() { }

	private void CloseMenu() { }

	[AsyncStateMachine(typeof(<ContinueClicked>d__98))]
	public void ContinueClicked() { }

	private void DisplayTowers() { }

	private void DoAnalytics() { }

	private ValueTuple<String, String> GetNeutralInTxt() { }

	private string GetNextDegradeInTxt() { }

	private bool HasTowerCountsToShow(List<TowerData> towers) { }

	private void HeldRelicMouseDown(CTRelicSelectable clickedItem) { }

	private void HeldRelicMouseUp(CTRelicSelectable clickedItem) { }

	private void OnDestroy() { }

	[AsyncStateMachine(typeof(<Open>d__75))]
	public virtual void Open(object data) { }

	private void OpenRelicManagerPopup() { }

	public virtual bool OverrideClose() { }

	[AsyncStateMachine(typeof(<PlayClicked>d__96))]
	public void PlayClicked() { }

	[AsyncStateMachine(typeof(<PurchaseTicketAsync>d__101))]
	public void PurchaseTicketAsync() { }

	private void RelicTileObjectDown(BaseEventData eventData) { }

	private void RelicTileObjectUp(BaseEventData eventData) { }

	private void SetMap(string mapId) { }

	private void ShowChallengeRules() { }

	private void ShowCorrectTicketBtn() { }

	private void ShowGameTypeInfoPanel() { }

	[AsyncStateMachine(typeof(<ShowTeamCosmeticsAsync>d__105))]
	public void ShowTeamCosmeticsAsync() { }

	public void StartNewGame() { }

	private void TeamInfoClicked() { }

	private void Update() { }

	private void UpdateCapturedVisuals() { }

	[AsyncStateMachine(typeof(<UpdateLootAsync>d__77))]
	private void UpdateLootAsync() { }

	[AsyncStateMachine(typeof(<UpdateMapTileVisualsAsync>d__85))]
	private void UpdateMapTileVisualsAsync() { }

	[AsyncStateMachine(typeof(<UpdateRelicsAsync>d__90))]
	private Task UpdateRelicsAsync() { }

	[AsyncStateMachine(typeof(<UpdateRelicsOnClosePopupAsync>d__112))]
	public void UpdateRelicsOnClosePopupAsync() { }

	[AsyncStateMachine(typeof(<UpdateTileStatusAsync>d__78))]
	private void UpdateTileStatusAsync(ContestedTerritoryIslandTile tile) { }

	[AsyncStateMachine(typeof(<UpdateTileStatusAsync>d__87))]
	private void UpdateTileStatusAsync() { }

}

