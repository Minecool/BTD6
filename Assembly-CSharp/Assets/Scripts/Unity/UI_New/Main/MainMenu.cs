namespace Assets.Scripts.Unity.UI_New.Main;

public class MainMenu : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction <>9__28_0; //Field offset: 0x8
		public static UnityAction <>9__28_1; //Field offset: 0x10
		public static UnityAction <>9__28_2; //Field offset: 0x18
		public static UnityAction <>9__28_3; //Field offset: 0x20
		public static UnityAction <>9__28_4; //Field offset: 0x28
		public static UnityAction <>9__28_5; //Field offset: 0x30
		public static UnityAction <>9__28_6; //Field offset: 0x38
		public static UnityAction <>9__28_7; //Field offset: 0x40
		public static UnityAction <>9__28_8; //Field offset: 0x48
		public static UnityAction <>9__28_9; //Field offset: 0x50
		public static UnityAction <>9__28_10; //Field offset: 0x58
		public static Func<IapEvent, Boolean> <>9__41_0; //Field offset: 0x60

		private static <>c() { }

		public <>c() { }

		internal bool <RefreshStorePip>b__41_0(IapEvent iapEvent) { }

		internal void <Start>b__28_0() { }

		internal void <Start>b__28_1() { }

		internal void <Start>b__28_10() { }

		internal void <Start>b__28_2() { }

		internal void <Start>b__28_3() { }

		internal void <Start>b__28_4() { }

		internal void <Start>b__28_5() { }

		internal void <Start>b__28_6() { }

		internal void <Start>b__28_7() { }

		internal void <Start>b__28_8() { }

		internal void <Start>b__28_9() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass55_0
	{
		public PlaySessionConflict conflict; //Field offset: 0x10

		public <>c__DisplayClass55_0() { }

		internal void <ShowPlaySessionPopup>b__0() { }

		internal void <ShowPlaySessionPopup>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_0
	{
		public HashSet<String> receivedGiftEventIds; //Field offset: 0x10

		public <>c__DisplayClass57_0() { }

		internal bool <ShowGiftEventPopup>b__0(GiftEvent x) { }

	}

	[CompilerGenerated]
	private struct <CanOpenPendingDeepLink>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"canOpen", "playerContent"}])]
		private TaskAwaiter<ValueTuple`2<Boolean, PlayerContent>> <>u__1; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CheckAndRejoinCoopGame>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public MainMenu <>4__this; //Field offset: 0x20
		private Btd6Player <player>5__2; //Field offset: 0x28
		private CoopGameDetails <coopGameDetails>5__3; //Field offset: 0x30
		private int <canRejoin>5__4; //Field offset: 0x38
		private CancellationTokenSource <>7__wrap4; //Field offset: 0x40
		private TaskAwaiter<Int32> <>u__1; //Field offset: 0x48
		private BossEvent <bossEvent>5__6; //Field offset: 0x50
		private TaskAwaiter<BossDataModel> <>u__2; //Field offset: 0x58
		private TaskAwaiter<Boolean> <>u__3; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CheckBlockedNkServers>d__64 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private bool <updateSave>5__2; //Field offset: 0x20
		private List<String> <blockedHostnames>5__3; //Field offset: 0x28
		private TimeSpan <timeout>5__4; //Field offset: 0x30
		private AnalyticsManager <analyticsManager>5__5; //Field offset: 0x38
		private List<String> <>7__wrap5; //Field offset: 0x40
		private TaskAwaiter<List`1<String>> <>u__1; //Field offset: 0x48
		private string <analyticsHostname>5__7; //Field offset: 0x50
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x58
		private AnalyticsManager <>7__wrap7; //Field offset: 0x60
		private TaskAwaiter<String> <>u__3; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CheckForCompletedLeaderboardRewards>d__63 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public MainMenu <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28
		private TaskAwaiter<RaceEvent> <>u__2; //Field offset: 0x30
		private TaskAwaiter<BossEvent> <>u__3; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <QueuePopupsAsync>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenu <>4__this; //Field offset: 0x28
		private Btd6Player <player>5__2; //Field offset: 0x30
		private bool <hasRejoinedCoopGame>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RaiseExceptionsAsync>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Task task; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshServerTimeAndSKUData>d__52 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenu <>4__this; //Field offset: 0x28
		private TaskAwaiter<DateTime> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private static bool <HasBeenLoaded>k__BackingField; //Field offset: 0x0
	private static bool requiresPopupQueue; //Field offset: 0x1
	public static bool canShowLoginPopup; //Field offset: 0x2
	public Button monkeysBtn; //Field offset: 0x48
	public Button heroesBtn; //Field offset: 0x50
	public Button legendsBtn; //Field offset: 0x58
	public Button playBtn; //Field offset: 0x60
	public Button coopBtn; //Field offset: 0x68
	public Button powersBtn; //Field offset: 0x70
	public Button knowledgeBtn; //Field offset: 0x78
	public Button playerInfoBtn; //Field offset: 0x80
	public Button settingsBtn; //Field offset: 0x88
	public Button achievementsBtn; //Field offset: 0x90
	public Button storeBtn; //Field offset: 0x98
	public Button saveButton; //Field offset: 0xA0
	public Button trophyStoreBtn; //Field offset: 0xA8
	public Button exitBtn; //Field offset: 0xB0
	public Image heroButtonHeroImg; //Field offset: 0xB8
	public GameObject settingsBtnNotify; //Field offset: 0xC0
	private CancellationTokenSource rejoinCanceller; //Field offset: 0xC8
	public GameObject trophyStoreLimitedTimeObj; //Field offset: 0xD0
	[SerializeField]
	private GameObject mrBeastEventStoreObj; //Field offset: 0xD8
	[SerializeField]
	private GameObject[] disabledByServerMaintenance; //Field offset: 0xE0
	private bool isUnderMaintenance; //Field offset: 0xE8
	[SerializeField]
	private GameObject storePip; //Field offset: 0xF0
	[SerializeField]
	private GameObject legendsBtnContainer; //Field offset: 0xF8
	[SerializeField]
	private MainMenuMailboxPanel mainMenuMailboxPanel; //Field offset: 0x100
	private bool hasPendingSaveWarning; //Field offset: 0x108

	public static bool HasBeenLoaded
	{
		[CompilerGenerated]
		 get { } //Length: 54
		[CompilerGenerated]
		 set { } //Length: 59
	}

	public MainMenu() { }

	[AsyncStateMachine(typeof(<CanOpenPendingDeepLink>d__36))]
	private Task<Boolean> CanOpenPendingDeepLink() { }

	[AsyncStateMachine(typeof(<CheckAndRejoinCoopGame>d__39))]
	private Task<Boolean> CheckAndRejoinCoopGame() { }

	[AsyncStateMachine(typeof(<CheckBlockedNkServers>d__64))]
	private static Task CheckBlockedNkServers() { }

	[AsyncStateMachine(typeof(<CheckForCompletedLeaderboardRewards>d__63))]
	private Task<Boolean> CheckForCompletedLeaderboardRewards() { }

	public void CheckGiftbox() { }

	public void CheckNotifications() { }

	public void CheckRankUp() { }

	public virtual void Close() { }

	[CompilerGenerated]
	public static bool get_HasBeenLoaded() { }

	private void HideNetflixAccessButton() { }

	private void OnApplicationFocus(bool focus) { }

	private void OnDestroy() { }

	private void OnShowRate() { }

	private void OnShowRateAfterUpdate() { }

	private void OnShowRateAfterUpdateCancel() { }

	public virtual void Open(object data) { }

	private void OpenLegendsSelect() { }

	public virtual bool OverrideClose() { }

	[AsyncStateMachine(typeof(<QueuePopupsAsync>d__38))]
	private void QueuePopupsAsync() { }

	[AsyncStateMachine(typeof(<RaiseExceptionsAsync>d__30))]
	private void RaiseExceptionsAsync(Task task) { }

	private void RecheckNetflixAuth() { }

	[AsyncStateMachine(typeof(<RefreshServerTimeAndSKUData>d__52))]
	private void RefreshServerTimeAndSKUData() { }

	private void RefreshSKURelatedUI() { }

	private void RefreshStorePip() { }

	public virtual void ReOpen(object data) { }

	[CompilerGenerated]
	public static void set_HasBeenLoaded(bool value) { }

	private void SetRichPresence() { }

	public void SetSelectedHeroImage() { }

	private void ShowGiftEventPopup() { }

	private void ShowNetflixAccessButton() { }

	public void ShowPlayerStats() { }

	private void ShowPlaySessionPopup(PlaySessionConflict conflict) { }

	private void ShowRateMePopup() { }

	public void ShowUnseenStoreLoot() { }

	private void Start() { }

	private void Update() { }

	public void UpdateNavigation() { }

}

