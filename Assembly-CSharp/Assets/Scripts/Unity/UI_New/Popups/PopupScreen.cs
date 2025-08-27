namespace Assets.Scripts.Unity.UI_New.Popups;

public class PopupScreen : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static ReturnCallback <>9__83_0; //Field offset: 0x8
		public static ReturnCallback <>9__87_1; //Field offset: 0x10
		public static ReturnCallback <>9__113_1; //Field offset: 0x18
		public static Action<GameObject> <>9__126_0; //Field offset: 0x20
		public static Func<AsyncOperationHandle`1<GameObject>, Boolean> <>9__147_0; //Field offset: 0x28
		public static Func<AsyncOperationHandle`1<GameObject>, Popup> <>9__147_1; //Field offset: 0x30
		public static Action<AsyncOperationHandle`1<GameObject>> <>9__163_0; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal bool <HideAllPopups>b__147_0(AsyncOperationHandle<GameObject> h) { }

		internal Popup <HideAllPopups>b__147_1(AsyncOperationHandle<GameObject> h) { }

		internal void <InstantiateCoopInvitePopup>b__163_0(AsyncOperationHandle<GameObject> _) { }

		internal void <ShowEpicAccount>b__87_1() { }

		internal void <ShowMapDifficultyUnlockPopup>b__113_1() { }

		internal void <ShowModderPopup>b__126_0(GameObject _) { }

		internal void <ShowMonkeyMonkeyPopup>b__83_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass104_0
	{
		public string bg; //Field offset: 0x10
		public IEnumerable<Task`1<Int32>> countdown; //Field offset: 0x18
		public byte culpritPlayerNumber; //Field offset: 0x20
		public string playerName; //Field offset: 0x28
		public PopupScreen <>4__this; //Field offset: 0x30

		public <>c__DisplayClass104_0() { }

		internal void <ShowCoopSyncingPopup>b__0(GameObject pop) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass108_0
	{
		public Action<Int32> okCallback; //Field offset: 0x10
		public int defaultValue; //Field offset: 0x18
		public PopupScreen <>4__this; //Field offset: 0x20
		public string title; //Field offset: 0x28
		public string description; //Field offset: 0x30
		public Action<String> <>9__1; //Field offset: 0x38

		public <>c__DisplayClass108_0() { }

		internal void <ShowSetValuePopup>b__0(GameObject pop) { }

		internal void <ShowSetValuePopup>b__1(string stringValue) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass109_0
	{
		public Action<String> okCallback; //Field offset: 0x10
		public string defaultValue; //Field offset: 0x18
		public PopupScreen <>4__this; //Field offset: 0x20
		public string title; //Field offset: 0x28
		public string description; //Field offset: 0x30

		public <>c__DisplayClass109_0() { }

		internal void <ShowSetNamePopup>b__0(GameObject pop) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass110_0
	{
		public ReturnCallback returnCallback; //Field offset: 0x10
		public PopupScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass110_0() { }

		internal void <ShowApopalypseWarningPopup>b__0(GameObject pop) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass111_0
	{
		public ReturnCallback returnCallback; //Field offset: 0x10
		public PopupScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass111_0() { }

		internal void <ShowThankYouPopup>b__0(GameObject pop) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass112_0
	{
		public MapDifficulty difficulty; //Field offset: 0x10
		public int required; //Field offset: 0x14
		public int completed; //Field offset: 0x18
		public PopupScreen <>4__this; //Field offset: 0x20

		public <>c__DisplayClass112_0() { }

		internal void <ShowMapDifficultyLockPopup>b__0(GameObject pop) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass113_0
	{
		public MapDifficulty difficulty; //Field offset: 0x10
		public int completed; //Field offset: 0x14
		public int required; //Field offset: 0x18
		public PopupScreen <>4__this; //Field offset: 0x20

		public <>c__DisplayClass113_0() { }

		internal void <ShowMapDifficultyUnlockPopup>b__0(GameObject pop) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass114_0
	{
		public ReturnCallback okCallback; //Field offset: 0x10
		public ReturnCallback cancelCallback; //Field offset: 0x18
		public PopupScreen <>4__this; //Field offset: 0x20
		public string title; //Field offset: 0x28
		public string okString; //Field offset: 0x30
		public string body; //Field offset: 0x38
		public string cancelString; //Field offset: 0x40

		public <>c__DisplayClass114_0() { }

		internal void <ShowTrophyStorePopup>b__0(GameObject pop) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass115_0
	{
		public StoreItem storeItem; //Field offset: 0x10
		public ReturnCallback purchaseCompleteCallback; //Field offset: 0x18
		public PopupScreen <>4__this; //Field offset: 0x20

		public <>c__DisplayClass115_0() { }

		internal void <ShowStorePopup>b__0(GameObject pop) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass117_0
	{
		public ReturnCallback purchaseCompleteCallback; //Field offset: 0x10
		public PopupScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass117_0() { }

		internal void <ShowRacePassPopup>b__0(GameObject pop) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass118_0
	{
		public PopupScreen <>4__this; //Field offset: 0x0
		public T serverEvent; //Field offset: 0x0
		public bool isDebug; //Field offset: 0x0

		public <>c__DisplayClass118_0`1() { }

		internal void <ShowLeaderboardEventEndedPopup>b__0(GameObject pop) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass121_0
	{
		public BossRushEvent bossRushEvent; //Field offset: 0x10
		public int defeatedBossIndex; //Field offset: 0x18
		public BossRushSaveData bossRushSaveData; //Field offset: 0x20
		public bool isDebug; //Field offset: 0x28
		public PopupScreen <>4__this; //Field offset: 0x30

		public <>c__DisplayClass121_0() { }

		internal void <ShowBossRushEventEndedPopup>b__0(GameObject pop) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass123_0
	{
		public TaskCompletionSource<Boolean> tcs; //Field offset: 0x10

		public <>c__DisplayClass123_0() { }

		internal void <ShowCancelOrTryAgainPopup>b__0() { }

		internal void <ShowCancelOrTryAgainPopup>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass124_0
	{
		private struct <<ShowArcadeDataConsentPopup>g___giveConsent|1>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass124_0 <>4__this; //Field offset: 0x28
			public bool givesConsent; //Field offset: 0x30
			private <>c__DisplayClass124_1 <>8__1; //Field offset: 0x38
			private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x40

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public PopupScreen <>4__this; //Field offset: 0x10
		public LocalizationManager locs; //Field offset: 0x18
		public TaskCompletionSource<Boolean> tcs; //Field offset: 0x20
		public ReturnCallback <>9__2; //Field offset: 0x28
		public ReturnCallback <>9__3; //Field offset: 0x30

		public <>c__DisplayClass124_0() { }

		internal void <ShowArcadeDataConsentPopup>b__0(GameObject pop) { }

		internal void <ShowArcadeDataConsentPopup>b__2() { }

		internal void <ShowArcadeDataConsentPopup>b__3() { }

		[AsyncStateMachine(typeof(<<ShowArcadeDataConsentPopup>g___giveConsent|1>d))]
		internal void <ShowArcadeDataConsentPopup>g___giveConsent|1(bool givesConsent) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass124_1
	{
		public bool givesConsent; //Field offset: 0x10
		public <>c__DisplayClass124_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass124_1() { }

		internal void <ShowArcadeDataConsentPopup>b__4(Popup _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass125_0
	{
		private struct <<ShowDataConsentPopup>g___giveConsent|2>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass125_0 <>4__this; //Field offset: 0x28
			public bool givesConsent; //Field offset: 0x30
			private <>c__DisplayClass125_1 <>8__1; //Field offset: 0x38
			private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x40

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public LocalizationManager locs; //Field offset: 0x10
		public TaskCompletionSource<Boolean> tcs; //Field offset: 0x18

		public <>c__DisplayClass125_0() { }

		internal void <ShowDataConsentPopup>b__0() { }

		internal void <ShowDataConsentPopup>b__1() { }

		[AsyncStateMachine(typeof(<<ShowDataConsentPopup>g___giveConsent|2>d))]
		internal void <ShowDataConsentPopup>g___giveConsent|2(bool givesConsent) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass125_1
	{
		public bool givesConsent; //Field offset: 0x10
		public <>c__DisplayClass125_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass125_1() { }

		internal void <ShowDataConsentPopup>b__3(Popup _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass126_0
	{
		public GameObject popupGameObj; //Field offset: 0x10

		public <>c__DisplayClass126_0() { }

		internal bool <ShowModderPopup>b__1(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass128_0
	{
		public ReturnCallback onClaimClicked; //Field offset: 0x10
		public PopupScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass128_0() { }

		internal void <ShowPrimeDropPopup>b__0(GameObject pop) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass129_0
	{
		public ReturnCallback onClaimClicked; //Field offset: 0x10
		public PopupScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass129_0() { }

		internal void <ShowPhatMojoGiftPopup>b__0(GameObject pop) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass130_0
	{
		public Action onRestartClicked; //Field offset: 0x10
		public TaskCompletionSource<Boolean> playerInputCompletion; //Field offset: 0x18

		public <>c__DisplayClass130_0() { }

		internal void <ShowInvalidSessionPopup>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass134_0
	{
		public Action<Double> okCallback; //Field offset: 0x10
		public Action cancelCallback; //Field offset: 0x18
		public int currentCash; //Field offset: 0x20
		public int maxCash; //Field offset: 0x24
		public int upgradeCost; //Field offset: 0x28
		public BackGround background; //Field offset: 0x2C
		public TransitionAnim transition; //Field offset: 0x30
		public PopupScreen <>4__this; //Field offset: 0x38
		public Placement placement; //Field offset: 0x40
		public string title; //Field offset: 0x48
		public string body; //Field offset: 0x50
		public string okString; //Field offset: 0x58
		public string cancelString; //Field offset: 0x60

		public <>c__DisplayClass134_0() { }

		internal void <CreateParagonConfirmationPopup>b__0(GameObject pop) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass140_0
	{
		public AssetType assetType; //Field offset: 0x10
		public TaskCompletionSource<Entry<BTD6AssetFlags>> tcs; //Field offset: 0x18
		public PopupScreen <>4__this; //Field offset: 0x20
		public ReturnCallback <>9__2; //Field offset: 0x28

		public <>c__DisplayClass140_0() { }

		internal void <PickFromAssetLibrary>b__0(GameObject pop) { }

		internal void <PickFromAssetLibrary>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass140_1
	{
		public AssetLibraryPopup popup; //Field offset: 0x10
		public <>c__DisplayClass140_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass140_1() { }

		internal void <PickFromAssetLibrary>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass150_0
	{
		public Popup p; //Field offset: 0x10
		public PopupScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass150_0() { }

		internal bool <OnPopupEnd>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass150_1
	{
		public BackGround background; //Field offset: 0x10
		public <>c__DisplayClass150_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass150_1() { }

		internal void <OnPopupEnd>b__1(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass161_0
	{
		public Action<GameObject> OnLoaded; //Field offset: 0x10
		public PopupScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass161_0() { }

		internal void <InstantiateHintPanel>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass56_0
	{
		public Action<GameObject> OnLoaded; //Field offset: 0x10
		public PopupScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass56_0() { }

		internal void <InstantiatePopup>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_0
	{
		public ReturnCallback okCallback; //Field offset: 0x10
		public ReturnCallback cancelCallback; //Field offset: 0x18
		public BackGround background; //Field offset: 0x20
		public TransitionAnim transition; //Field offset: 0x24
		public bool instantClose; //Field offset: 0x28
		public bool closeIfTowersAreSuspended; //Field offset: 0x29
		public PopupScreen <>4__this; //Field offset: 0x30
		public Placement placement; //Field offset: 0x38
		public string title; //Field offset: 0x40
		public string body; //Field offset: 0x48
		public string okString; //Field offset: 0x50
		public string cancelString; //Field offset: 0x58
		public int cash; //Field offset: 0x60

		public <>c__DisplayClass57_0() { }

		internal void <CreateCommonPopup>b__0(GameObject pop) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass58_0
	{
		public Task asyncOkCallback; //Field offset: 0x10
		public Task asyncCancelCallback; //Field offset: 0x18
		public BackGround background; //Field offset: 0x20
		public TransitionAnim transition; //Field offset: 0x24
		public bool instantClose; //Field offset: 0x28
		public PopupScreen <>4__this; //Field offset: 0x30
		public Placement placement; //Field offset: 0x38
		public string title; //Field offset: 0x40
		public string body; //Field offset: 0x48
		public string okString; //Field offset: 0x50
		public string cancelString; //Field offset: 0x58
		public int cash; //Field offset: 0x60

		public <>c__DisplayClass58_0() { }

		internal void <CreateAwaitAsyncTasksPopup>b__0(GameObject pop) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass59_0
	{
		public ReturnCallback cancelCallback; //Field offset: 0x10
		public ReturnCallback okCallback; //Field offset: 0x18
		public PopupScreen <>4__this; //Field offset: 0x20
		public ReturnCallback onRewardScreenClosedCallback; //Field offset: 0x28
		public RogueLootData rogueLootData; //Field offset: 0x30

		public <>c__DisplayClass59_0() { }

		internal void <CreateRogueLootPopup>b__0(GameObject pop) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass60_0
	{
		public ReturnCallback okCallback; //Field offset: 0x10
		public PopupScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass60_0() { }

		internal void <CreateRogueArtifactPopup>b__0(GameObject pop) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass61_0
	{
		public ReturnCallback okCallback; //Field offset: 0x10
		public PopupScreen <>4__this; //Field offset: 0x18
		public RogueLoot loot; //Field offset: 0x20
		public bool closeAfterDelay; //Field offset: 0x28
		public int stackCount; //Field offset: 0x2C

		public <>c__DisplayClass61_0() { }

		internal void <CreateRogueRewardPopup>b__0(GameObject pop) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass62_0
	{
		public ReturnCallback okCallback; //Field offset: 0x10
		public ReturnCallback cancelCallback; //Field offset: 0x18
		public BackGround background; //Field offset: 0x20
		public TransitionAnim transition; //Field offset: 0x24
		public bool instantClose; //Field offset: 0x28
		public bool closeIfTowersAreSuspended; //Field offset: 0x29
		public PopupScreen <>4__this; //Field offset: 0x30
		public Placement placement; //Field offset: 0x38
		public string title; //Field offset: 0x40
		public string body; //Field offset: 0x48
		public string okString; //Field offset: 0x50
		public string cancelString; //Field offset: 0x58
		public int cash; //Field offset: 0x60

		public <>c__DisplayClass62_0() { }

		internal void <CreateLogoutPopup>b__0(GameObject pop) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass63_0
	{
		public ReturnCallback cancelCallback; //Field offset: 0x10
		public PopupScreen <>4__this; //Field offset: 0x18
		public PlayerContentInfo playerContentInfo; //Field offset: 0x20
		public PurchaseSuccessCallback purchaseSuccessCallback; //Field offset: 0x28
		public string playerName; //Field offset: 0x30
		public bool canUseNexus; //Field offset: 0x38

		public <>c__DisplayClass63_0() { }

		internal void <CreateAccoladesStorePopup>b__0(GameObject popupGameObject) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass64_0
	{
		public AsyncReturnCallback asyncReturnOkCallback; //Field offset: 0x10
		public AsyncReturnCallback asyncReturnCancelCallback; //Field offset: 0x18
		public BackGround background; //Field offset: 0x20
		public TransitionAnim transition; //Field offset: 0x24
		public bool instantClose; //Field offset: 0x28
		public PopupScreen <>4__this; //Field offset: 0x30
		public Placement placement; //Field offset: 0x38
		public string title; //Field offset: 0x40
		public string body; //Field offset: 0x48
		public string okString; //Field offset: 0x50
		public string cancelString; //Field offset: 0x58
		public int cash; //Field offset: 0x60

		public <>c__DisplayClass64_0() { }

		internal void <CreateAwaitAsyncTasksPopup>b__0(GameObject pop) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass67_0
	{
		public PopupScreen <>4__this; //Field offset: 0x10
		public BackGround background; //Field offset: 0x18

		public <>c__DisplayClass67_0() { }

		internal void <CreateBackground>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass75_0
	{
		public GiftEvent giftEvent; //Field offset: 0x10
		public PopupScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass75_0() { }

		internal void <ShowGiftEventPopup>b__0(GameObject pop) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass84_0
	{
		public ReturnCallback returnCallback; //Field offset: 0x10
		public BackGround background; //Field offset: 0x18
		public TransitionAnim transition; //Field offset: 0x1C
		public PopupScreen <>4__this; //Field offset: 0x20
		public Placement placement; //Field offset: 0x28
		public string title; //Field offset: 0x30
		public string body; //Field offset: 0x38
		public string okstring; //Field offset: 0x40
		public int monkeyMoney; //Field offset: 0x48

		public <>c__DisplayClass84_0() { }

		internal void <ShowVictoryTutorialPopup>b__0(GameObject pop) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass85_0
	{
		public ReturnCallback okCallback; //Field offset: 0x10
		public ReturnCallback cancelCallback; //Field offset: 0x18
		public BackGround background; //Field offset: 0x20
		public TransitionAnim transition; //Field offset: 0x24
		public PopupScreen <>4__this; //Field offset: 0x28
		public Placement placement; //Field offset: 0x30
		public string title; //Field offset: 0x38
		public string body; //Field offset: 0x40
		public Sprite useThisImage; //Field offset: 0x48
		public int imageIndex; //Field offset: 0x50
		public string okString; //Field offset: 0x58
		public string cancelString; //Field offset: 0x60

		public <>c__DisplayClass85_0() { }

		internal void <ShowEventPopup>b__0(GameObject pop) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass86_0
	{
		public ReturnCallback okCallback; //Field offset: 0x10
		public ReturnCallback cancelCallback; //Field offset: 0x18
		public BackGround background; //Field offset: 0x20
		public TransitionAnim transition; //Field offset: 0x24
		public PopupScreen <>4__this; //Field offset: 0x28
		public Placement placement; //Field offset: 0x30
		public string title; //Field offset: 0x38
		public string okString; //Field offset: 0x40
		public string cancelString; //Field offset: 0x48

		public <>c__DisplayClass86_0() { }

		internal void <ShowWelcomePopup>b__0(GameObject pop) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass87_0
	{
		public Action createdAccountCallback; //Field offset: 0x10
		public PopupScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass87_0() { }

		internal void <ShowEpicAccount>b__0(GameObject pop) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass96_0
	{
		public ReturnCallback onOkClicked; //Field offset: 0x10

		public <>c__DisplayClass96_0() { }

		internal void <ShowLoginReminder>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass97_0
	{
		public Func<CancellationToken, Task> rejoinFunc; //Field offset: 0x10
		public ReturnCallback quitAction; //Field offset: 0x18
		public string lobbyId; //Field offset: 0x20
		public string fromMenu; //Field offset: 0x28
		public ReturnCallback afterRejoinAction; //Field offset: 0x30
		public PopupScreen <>4__this; //Field offset: 0x38

		public <>c__DisplayClass97_0() { }

		internal void <ShowCoopDisconnectedPopup>b__0(GameObject pop) { }

	}

	[CompilerGenerated]
	private sealed class <AllActivePopups>d__106 : IEnumerable<Popup>, IEnumerable, IEnumerator<Popup>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Popup <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public PopupScreen <>4__this; //Field offset: 0x28
		private Enumerator<AsyncOperationHandle<GameObject>> <>7__wrap1; //Field offset: 0x30

		private override Popup System.Collections.Generic.IEnumerator<Assets.Scripts.Unity.UI_New.Popups.Popup>.Current
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
		public <AllActivePopups>d__106(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Popup> System.Collections.Generic.IEnumerable<Assets.Scripts.Unity.UI_New.Popups.Popup>.GetEnumerator() { }

		[DebuggerHidden]
		private override Popup System.Collections.Generic.IEnumerator<Assets.Scripts.Unity.UI_New.Popups.Popup>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <AutoDismissHint>d__156 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public int lifeTime; //Field offset: 0x20
		public PopupScreen <>4__this; //Field offset: 0x28
		public int hintId; //Field offset: 0x30
		public ReturnCallback autoDismissCallback; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PickFromAssetLibrary>d__140 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Entry<BTD6AssetFlags>> <>t__builder; //Field offset: 0x8
		public AssetType assetType; //Field offset: 0x20
		public PopupScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<Entry<BTD6AssetFlags>> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowInvalidSessionPopup>d__130 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Action onRestartClicked; //Field offset: 0x20
		public PopupScreen <>4__this; //Field offset: 0x28
		private <>c__DisplayClass130_0 <>8__1; //Field offset: 0x30
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x38
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowModderPopup>d__126 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ModdingPopupChoice> <>t__builder; //Field offset: 0x8
		public PopupScreen <>4__this; //Field offset: 0x20
		private <>c__DisplayClass126_0 <>8__1; //Field offset: 0x28
		private AsyncOperationHandle<GameObject> <popupHandle>5__2; //Field offset: 0x30
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x48
		private TaskAwaiter<ModdingPopupChoice> <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <YieldWhileActive>d__71 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private YieldAwaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class AsyncReturnCallback : MulticastDelegate
	{

		public AsyncReturnCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override Task EndInvoke(IAsyncResult result) { }

		public override Task Invoke() { }

	}

	internal enum BackGround
	{
		Grey = 0,
		Clear = 1,
		GreyNonDismissable = 2,
		ClearNonDismissable = 3,
	}

	internal struct HintData
	{
		public int hintId; //Field offset: 0x0
		public string text; //Field offset: 0x8
		public int imageIndex; //Field offset: 0x10
		public bool repositionFor4x3; //Field offset: 0x14

		public HintData(int hintId, string text, int imageIndex, bool repositionFor4x3) { }

	}

	internal enum Placement
	{
		inGameCenter = 0,
		inGameBottom = 1,
		menuCenter = 2,
		menuBottom = 3,
	}

	internal sealed class ReturnCallback : MulticastDelegate
	{

		public ReturnCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	public static PopupScreen instance; //Field offset: 0x0
	[SerializeField]
	private Transform popupLayer; //Field offset: 0x20
	public PrefabReference backgroundPR; //Field offset: 0x28
	public PrefabReference commonPopupPR; //Field offset: 0x30
	public PrefabReference tutorialVictoryPopupPR; //Field offset: 0x38
	public PrefabReference welcomePopupPR; //Field offset: 0x40
	public PrefabReference coopDisconnectedPopup; //Field offset: 0x48
	public PrefabReference coopSyncingPopup; //Field offset: 0x50
	public PrefabReference coopRejoiningPopup; //Field offset: 0x58
	public PrefabReference eventPopupPR; //Field offset: 0x60
	public PrefabReference setValuePopup; //Field offset: 0x68
	public PrefabReference setNamePopup; //Field offset: 0x70
	public PrefabReference apopalypseWarningPopup; //Field offset: 0x78
	public PrefabReference trophyStorePopup; //Field offset: 0x80
	public PrefabReference storePopup; //Field offset: 0x88
	public PrefabReference racePassStorePopup; //Field offset: 0x90
	public PrefabReference raceEndedPopup; //Field offset: 0x98
	public PrefabReference primeDropPopup; //Field offset: 0xA0
	public PrefabReference phatMojoGiftPopup; //Field offset: 0xA8
	public PrefabReference bossEndedPopup; //Field offset: 0xB0
	public PrefabReference ctEndedPopup; //Field offset: 0xB8
	public PrefabReference epicAccountPopup; //Field offset: 0xC0
	public PrefabReference nexusSettingsPopup; //Field offset: 0xC8
	public PrefabReference logoutPopup; //Field offset: 0xD0
	public PrefabReference paragonConfirmationPopup; //Field offset: 0xD8
	public PrefabReference unlockMapEditorPopup; //Field offset: 0xE0
	public PrefabReference unlockMapEditorThankYouPopup; //Field offset: 0xE8
	public PrefabReference arcadeDataConsentPopup; //Field offset: 0xF0
	public PrefabReference accoladesStorePopup; //Field offset: 0xF8
	public PrefabReference giftCodeRedemptionPopup; //Field offset: 0x100
	public PrefabReference giftEventPopup; //Field offset: 0x108
	public PrefabReference bossRushEndedPopup; //Field offset: 0x110
	public PrefabReference moddingPopup; //Field offset: 0x118
	public PrefabReference mapDifficultyLockPopup; //Field offset: 0x120
	public PrefabReference mapDifficultyUnlockPopup; //Field offset: 0x128
	public PrefabReference assetLibraryPopup; //Field offset: 0x130
	public PrefabReference rogueLootPopup; //Field offset: 0x138
	public PrefabReference rogueArtifactPopup; //Field offset: 0x140
	public PrefabReference rogueRewardPopup; //Field offset: 0x148
	public SpriteReference[] popupImagesSR; //Field offset: 0x150
	public PrefabReference hintPanelPrefab; //Field offset: 0x158
	public Transform hintPanelLayer; //Field offset: 0x160
	public Transform hintPanelLayer43; //Field offset: 0x168
	public Transform invitePanelLayer; //Field offset: 0x170
	public PrefabReference invitePanelPrefab; //Field offset: 0x178
	private readonly List<AsyncOperationHandle`1<GameObject>> activePopupHandles; //Field offset: 0x180
	[SerializeField]
	private RectTransform[] popupPositions_4_3; //Field offset: 0x188
	[SerializeField]
	private RectTransform[] popupPositions_16_9; //Field offset: 0x190
	private RectTransform[] popupPositions; //Field offset: 0x198
	private bool waitFrame; //Field offset: 0x1A0
	private AsyncOperationHandle<GameObject> backgroundHandle; //Field offset: 0x1A8
	private int backgroundOwner; //Field offset: 0x1C0
	public bool hasPendingDesyncPopup; //Field offset: 0x1C4
	private readonly List<HintData> hints; //Field offset: 0x1C8
	private GameObject activeHintPanel; //Field offset: 0x1D0
	private AsyncOperationHandle<GameObject> activeHintPanelOpHandle; //Field offset: 0x1D8
	private bool makingHintPanel; //Field offset: 0x1F0
	private float origHintPanelY; //Field offset: 0x1F4

	public PopupScreen() { }

	[CompilerGenerated]
	private void <ShowCoopRejoiningPopup>b__105_0(GameObject pop) { }

	[CompilerGenerated]
	private void <ShowGiftCodeRedemptionPopup>b__135_0(GameObject pop) { }

	[CompilerGenerated]
	private void <ShowMapEditorUnlockPopup>b__116_0(GameObject pop) { }

	[CompilerGenerated]
	private void <ShowNexusSettingsPopup>b__92_0(GameObject pop) { }

	[CompilerGenerated]
	private void <UpdateHints>b__159_0(GameObject hintPanel) { }

	[IteratorStateMachine(typeof(<AllActivePopups>d__106))]
	private IEnumerable<Popup> AllActivePopups() { }

	[AsyncStateMachine(typeof(<AutoDismissHint>d__156))]
	private Task AutoDismissHint(int hintId, int lifeTime, ReturnCallback autoDismissCallback = null) { }

	public void Awake() { }

	public void BackgroundClicked() { }

	public bool CanActivePopupBeDismissed() { }

	private void CreateAccoladesStorePopup(ReturnCallback cancelCallback, PlayerContentInfo playerContentInfo, PurchaseSuccessCallback purchaseSuccessCallback, string playerName, bool canUseNexus) { }

	private AsyncOperationHandle<GameObject> CreateAwaitAsyncTasksPopup(Placement placement, string title, string body, AsyncReturnCallback asyncReturnOkCallback, string okString, AsyncReturnCallback asyncReturnCancelCallback, string cancelString, TransitionAnim transition, BackGround background, bool instantClose, int cash = -1) { }

	private AsyncOperationHandle<GameObject> CreateAwaitAsyncTasksPopup(Placement placement, string title, string body, Task asyncOkCallback, string okString, Task asyncCancelCallback, string cancelString, TransitionAnim transition, BackGround background, bool instantClose, int cash = -1) { }

	private bool CreateBackground(Popup popup, BackGround background) { }

	private AsyncOperationHandle<GameObject> CreateCommonPopup(Placement placement, string title, string body, ReturnCallback okCallback, string okString, ReturnCallback cancelCallback, string cancelString, TransitionAnim transition, BackGround background, bool instantClose, bool closeIfTowersAreSuspended, int cash = -1) { }

	private AsyncOperationHandle<GameObject> CreateLogoutPopup(Placement placement, string title, string body, ReturnCallback okCallback, string okString, ReturnCallback cancelCallback, string cancelString, TransitionAnim transition, BackGround background, bool instantClose, bool closeIfTowersAreSuspended, int cash = -1) { }

	private AsyncOperationHandle<GameObject> CreateParagonConfirmationPopup(Placement placement, string title, string body, Action<Double> okCallback, string okString, Action cancelCallback, string cancelString, TransitionAnim transition, BackGround background, int currentCash, int maxCash, int upgradeCost) { }

	private AsyncOperationHandle<GameObject> CreateRogueArtifactPopup(ReturnCallback okCallback) { }

	private AsyncOperationHandle<GameObject> CreateRogueLootPopup(ReturnCallback okCallback, RogueLootData rogueLootData, ReturnCallback onRewardScreenClosedCallback = null, ReturnCallback cancelCallback = null) { }

	private AsyncOperationHandle<GameObject> CreateRogueRewardPopup(ReturnCallback okCallback, RogueLoot loot, bool closeAfterDelay, int stackCount) { }

	public void DismissAllHints() { }

	public void DismissHint(int hintId) { }

	private string GetErrorMessage(Exception exception) { }

	private PrefabReference GetEventEndedPrefab(T serverEvent) { }

	private LeaderboardEventEndPopup GetEventEndPopup(GameObject pop, T serverEvent) { }

	private Popup GetFirstActivePopup() { }

	public bool HiddenPopupActive() { }

	public void HideActivePopup() { }

	public void HideAllPopups() { }

	public void HideCoopSyncingPopups() { }

	public bool HotKeysDisabled() { }

	public AsyncOperationHandle<GameObject> InstantiateCoopInvitePopup() { }

	private void InstantiateHintPanel(Action<GameObject> OnLoaded) { }

	private AsyncOperationHandle<GameObject> InstantiatePopup(PrefabReference pr, Action<GameObject> OnLoaded) { }

	public bool IsPopupActive() { }

	private void OnDestroy() { }

	private void OnPopupEnd(Popup p) { }

	private void OnPopupHide(Popup p) { }

	public Task<Entry<BTD6AssetFlags>> PickAudioClipFromAssetLibrary() { }

	[AsyncStateMachine(typeof(<PickFromAssetLibrary>d__140))]
	private Task<Entry<BTD6AssetFlags>> PickFromAssetLibrary(AssetType assetType) { }

	public Task<Entry<BTD6AssetFlags>> PickPrefabFromAssetLibrary() { }

	public Task<Entry<BTD6AssetFlags>> PickSpriteFromAssetLibrary() { }

	public void QueueHint(int hintId, string text, int imageIndex, bool repositionFor4x3 = true, bool autoDismiss = false, int lifetime = 2, ReturnCallback autoDismissCallback = null) { }

	private void ResetBackgroundColour(AsyncOperationHandle<GameObject> handle, BackGround background) { }

	private void SetBackgroundAlpha(AsyncOperationHandle<GameObject> handle, float a) { }

	public void ShowAccoladesStorePopup(ReturnCallback cancelCallback, PlayerContentInfo playerContentInfo, PurchaseSuccessCallback purchaseSuccessCallback, string playerName, bool canUseNexus) { }

	public void ShowApopalypseWarningPopup(ReturnCallback returnCallback) { }

	public Task<Boolean> ShowArcadeDataConsentPopup() { }

	public AsyncOperationHandle<GameObject> ShowAsyncReturnCallbackPopup(Placement placement, string title, string body, AsyncReturnCallback asyncReturnOkCallback, string okString, AsyncReturnCallback asyncReturnCancelCallback, string cancelString, TransitionAnim transition, BackGround background = 1, bool instantClose = false) { }

	public AsyncOperationHandle<GameObject> ShowAwaitAsyncTasksPopup(Placement placement, string title, string body, Task asyncOkCallback, string okString, Task asyncCancelCallback, string cancelString, TransitionAnim transition, BackGround background = 1, bool instantClose = false) { }

	public void ShowBossRushEventEndedPopup(BossRushEvent bossRushEvent, int defeatedBossIndex, BossRushSaveData bossRushSaveData, bool isDebug) { }

	public Task<Boolean> ShowCancelOrTryAgainPopup(string title, string body, string cancelString = null, Placement placement = 2, TransitionAnim transition = 1, BackGround background = 3) { }

	public void ShowCantPlayBossPopup(string bodyLocKey) { }

	public void ShowCompetitiveCtUnavailablePopup() { }

	public void ShowContestedTerritoryError(string errorCode, string message, string buttonText, ReturnCallback buttonCallback = null) { }

	public void ShowCoopDisconnectedPopup(string fromMenu, string lobbyId, Func<CancellationToken, Task> rejoinFunc, ReturnCallback afterRejoinAction, ReturnCallback quitAction) { }

	public void ShowCoopRejoiningPopup() { }

	private void ShowCoopSyncingPopup(string bg, IEnumerable<Task`1<Int32>> countdown, byte culpritPlayerNumber = 0, string playerName = null) { }

	public void ShowDarkBlueCoopSyncingPopup(IEnumerable<Task`1<Int32>> countdown, byte culpritPlayerNumber, string playerName) { }

	public static Task<Boolean> ShowDataConsentPopup() { }

	public void ShowEpicAccount(Action createdAccountCallback) { }

	public void ShowEventEndindSoonPopup() { }

	public void ShowEventPopup(Placement placement, string title, string body, string okString, ReturnCallback okCallback, string cancelString, ReturnCallback cancelCallback, TransitionAnim transition, int imageIndex, BackGround background = 1, Sprite useThisImage = null) { }

	public void ShowGiftCodeRedemptionPopup() { }

	public void ShowGiftEventPopup(GiftEvent giftEvent) { }

	public void ShowGreenCoopSyncingPopup(IEnumerable<Task`1<Int32>> countdown) { }

	public void ShowInternetPopup(string errorCode) { }

	public void ShowInternetPopup(Exception exception) { }

	public void ShowInternetPopup(int code) { }

	[AsyncStateMachine(typeof(<ShowInvalidSessionPopup>d__130))]
	public Task ShowInvalidSessionPopup(Action onRestartClicked) { }

	public void ShowLeaderboardEventEndedPopup(T serverEvent, bool isDebug = false) { }

	public void ShowLightBlueCoopSyncingPopup(IEnumerable<Task`1<Int32>> countdown, byte culpritPlayerNumber, string playerName) { }

	public void ShowLoginReminder(ReturnCallback onOkClicked = null, ReturnCallback onCancelClicked = null) { }

	public void ShowLoginRequiredPopup() { }

	public AsyncOperationHandle<GameObject> ShowLogoutPopup(Placement placement, string title, string body, ReturnCallback okCallback, string okString, ReturnCallback cancelCallback, string cancelString, TransitionAnim transition, BackGround background = 1, bool instantClose = false, bool closeIfTowersAreSuspended = false) { }

	public void ShowMapDifficultyLockPopup(MapDifficulty difficulty, int completed, int required) { }

	public void ShowMapDifficultyUnlockPopup(MapDifficulty difficulty, int completed, int required) { }

	public AsyncOperationHandle<GameObject> ShowMapEditorUnlockPopup() { }

	[AsyncStateMachine(typeof(<ShowModderPopup>d__126))]
	public Task<ModdingPopupChoice> ShowModderPopup() { }

	public AsyncOperationHandle<GameObject> ShowMonkeyMonkeyPopup(ReturnCallback onOK = null, ReturnCallback onCancel = null) { }

	public void ShowNexusSettingsPopup() { }

	public AsyncOperationHandle<GameObject> ShowOkPopup(string localizedBody, ReturnCallback onOkCancelCallback = null) { }

	public AsyncOperationHandle<GameObject> ShowParagonConfirmationPopup(Placement placement, string title, string body, Action<Double> okCallback, string okString, Action cancelCallback, string cancelString, TransitionAnim transition, int currentCash, int maxValue, int upgradeCost) { }

	public AsyncOperationHandle<GameObject> ShowPaymentPopup(Placement placement, string title, string body, int cash, ReturnCallback okCallback, string okString, ReturnCallback cancelCallback, string cancelString, TransitionAnim transition, BackGround background = 1, bool instantClose = false) { }

	public void ShowPhatMojoGiftPopup(ReturnCallback onClaimClicked) { }

	public AsyncOperationHandle<GameObject> ShowPopup(Placement placement, string title, string body, ReturnCallback okCallback, string okString, ReturnCallback cancelCallback, string cancelString, TransitionAnim transition, BackGround background = 1, bool instantClose = false, bool closeIfTowersAreSuspended = false) { }

	public void ShowPrimeDropPopup(ReturnCallback onClaimClicked) { }

	public AsyncOperationHandle<GameObject> ShowRacePassPopup(ReturnCallback purchaseCompleteCallback) { }

	public void ShowRogueArtifactsPopup(ReturnCallback okCallback) { }

	public void ShowRogueLootPopup(ReturnCallback okCallback, RogueLootData rogueLootType, ReturnCallback onRewardScreenClosedCallback = null, ReturnCallback cancelCallback = null) { }

	public void ShowRogueRewardPopup(ReturnCallback okCallback, RogueLoot loot, bool closeAfterDelay, int stackCount = 1) { }

	public static void ShowSaveWarningPopup() { }

	public void ShowServerMaintenancePopup() { }

	public void ShowSetNamePopup(string title, string description, Action<String> okCallback, string defaultValue) { }

	public void ShowSetValuePopup(string title, string description, Action<Int32> okCallback, int defaultValue) { }

	public AsyncOperationHandle<GameObject> ShowStorePopup(StoreItem storeItem, ReturnCallback purchaseCompleteCallback) { }

	public void ShowThankYouPopup(ReturnCallback returnCallback) { }

	public AsyncOperationHandle<GameObject> ShowThemedPaymentPopup(Placement placement, string title, string body, int cash, ReturnCallback okCallback, string okString, ReturnCallback cancelCallback, string cancelString, TransitionAnim transition, BackGround background = 1, bool instantClose = false) { }

	public AsyncOperationHandle<GameObject> ShowTrophyStorePopup(string title, string body, ReturnCallback okCallback, string okString, ReturnCallback cancelCallback, string cancelString) { }

	public void ShowUnrecoverableErrorPopup(ReturnCallback okCallback) { }

	public void ShowVictoryTutorialPopup(Placement placement, string title, string body, int monkeyMoney, string okstring, ReturnCallback returnCallback, TransitionAnim transition, BackGround background = 1) { }

	public void ShowWelcomePopup(Placement placement, string title, ReturnCallback okCallback, string okString, ReturnCallback cancelCallback, string cancelString, TransitionAnim transition, BackGround background = 1) { }

	private static string StripHtml(string input) { }

	public void ToggleBackground(bool isOn) { }

	private void Update() { }

	public void UpdateHints() { }

	[AsyncStateMachine(typeof(<YieldWhileActive>d__71))]
	public static Task YieldWhileActive() { }

}

