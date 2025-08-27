namespace Assets.Scripts.Unity.UI_New.Main.EventPanel;

public class MainMenuEventPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"task", "priority"}])]
		public static Func<ValueTuple`2<Func`1<Task>, Int32>, Int32> <>9__19_0; //Field offset: 0x8
		public static Func<SweepstakesEvent, DateTime> <>9__26_1; //Field offset: 0x10
		public static Func<SweepstakesEvent, DateTime> <>9__35_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal DateTime <CreateSweepStakesIcon>b__26_1(SweepstakesEvent x) { }

		internal int <RunTasksByPriority>b__19_0(ValueTuple<Func`1<Task>, Int32> x) { }

		internal DateTime <SweepstakesEndedClickedAsync>b__35_0(SweepstakesEvent x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		private struct <<CreateBossRushIcon>g__HasAvailableTickets|0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass25_0 <>4__this; //Field offset: 0x20
			private BossRushSettings <bossRushSettings>5__2; //Field offset: 0x28
			private TaskAwaiter<BossRushSettings> <>u__1; //Field offset: 0x30
			private TaskAwaiter<OnlineProfileModel> <>u__2; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public BossRushEvent bossRushEvent; //Field offset: 0x10

		public <>c__DisplayClass25_0() { }

		internal bool <CreateBossRushIcon>b__1(BossRushSaveData x) { }

		[AsyncStateMachine(typeof(<<CreateBossRushIcon>g__HasAvailableTickets|0>d))]
		internal Task<Boolean> <CreateBossRushIcon>g__HasAvailableTickets|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		private struct <<CreateSweepStakesIcon>g__HasAvailableTickets|0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass26_0 <>4__this; //Field offset: 0x20
			private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0x28
			private TaskAwaiter<SweepstakesStatusResponse> <>u__2; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public MainMenuEventPanel <>4__this; //Field offset: 0x10
		public SweepstakesEvent sweepStakesEvent; //Field offset: 0x18

		public <>c__DisplayClass26_0() { }

		[AsyncStateMachine(typeof(<<CreateSweepStakesIcon>g__HasAvailableTickets|0>d))]
		internal Task<Boolean> <CreateSweepStakesIcon>g__HasAvailableTickets|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public MainMenuEventPanel <>4__this; //Field offset: 0x10
		public UnityAction onClick; //Field offset: 0x18
		public DateTime endTime; //Field offset: 0x20

		public <>c__DisplayClass29_0() { }

		internal void <CreateClickableIcon>b__0(AsyncOperationHandle<GameObject> handle) { }

	}

	[CompilerGenerated]
	private struct <BossPanelClickedAsync>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuEventPanel <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateBossIcon>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuEventPanel <>4__this; //Field offset: 0x20
		private BossEvent <bossEvent>5__2; //Field offset: 0x28
		private TaskAwaiter<BossDataModel> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateBossRushIcon>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuEventPanel <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateCollectionIcon>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuEventPanel <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateCtIcon>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuEventPanel <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateEventIcons>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuEventPanel <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateMaintenanceIcon>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuEventPanel <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateOdysseyIcon>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuEventPanel <>4__this; //Field offset: 0x20
		private OdysseyEvent <odysseyEvent>5__2; //Field offset: 0x28
		private TaskAwaiter<OdysseyData> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateRaceIcon>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuEventPanel <>4__this; //Field offset: 0x20
		private RaceEvent <raceEvent>5__2; //Field offset: 0x28
		private TaskAwaiter<Race> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateSweepStakesIcon>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuEventPanel <>4__this; //Field offset: 0x20
		private <>c__DisplayClass26_0 <>8__1; //Field offset: 0x28
		private bool <isShowingCurrentEvent>5__2; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EnablePipAsync>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Task<Boolean> canShowPipTask; //Field offset: 0x28
		public MainMenuEventPanel <>4__this; //Field offset: 0x30
		public ButtonWithPip ctBtn; //Field offset: 0x38
		private bool <canShowPip>5__2; //Field offset: 0x40
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OpenBossEventScreenAsync>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuEventPanel <>4__this; //Field offset: 0x20
		private BossEvent <bossEvent>5__2; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OpenCTEventScreenAsync>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuEventPanel <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OpenRaceEventScreenAsync>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuEventPanel <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunTasksByPriority>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"task", "priority"}])]
		public ValueTuple<Func`1<Task>, Int32>[] unsortedTasks; //Field offset: 0x20
		public MainMenuEventPanel <>4__this; //Field offset: 0x28
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"task", "priority"}])]
		private IEnumerator<ValueTuple`2<Func`1<Task>, Int32>> <>7__wrap1; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SweepStakesClickedAsync>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuEventPanel <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SweepstakesEndedClickedAsync>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuEventPanel <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TeamEventPanelClicked>d__40 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public MainMenuEventPanel <>4__this; //Field offset: 0x28
		private bool <isPlayerFlagged>5__2; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class EventIcon
	{
		public readonly GameObject gameObject; //Field offset: 0x10
		public readonly DateTime endTime; //Field offset: 0x18

		public EventIcon(GameObject gameObject, DateTime endTime) { }

	}

	public MainMenu mainMenu; //Field offset: 0x20
	public Transform iconContainer; //Field offset: 0x28
	public GameObject racePrefab; //Field offset: 0x30
	public GameObject odysseyPrefab; //Field offset: 0x38
	public GameObject ctPrefab; //Field offset: 0x40
	public GameObject bossRushPrefab; //Field offset: 0x48
	public GameObject serverMaintenancePrefab; //Field offset: 0x50
	public GameObject sweepStakesPrefab; //Field offset: 0x58
	public GameObject[] collectionEventPrefabs; //Field offset: 0x60
	[SerializeField]
	private Vector2 NetflixButtonsOffset; //Field offset: 0x68
	private readonly List<EventIcon> eventIcons; //Field offset: 0x70

	private static LocalizationManager Locs
	{
		private get { } //Length: 48
	}

	private static MainMenuPriority SortOrderSettings
	{
		private get { } //Length: 147
	}

	public MainMenuEventPanel() { }

	protected void Awake() { }

	[AsyncStateMachine(typeof(<BossPanelClickedAsync>d__33))]
	private void BossPanelClickedAsync() { }

	[AsyncStateMachine(typeof(<CreateBossIcon>d__23))]
	private Task CreateBossIcon() { }

	[AsyncStateMachine(typeof(<CreateBossRushIcon>d__25))]
	private Task CreateBossRushIcon() { }

	private GameObject CreateClickableIcon(GameObject prefab, DateTime endTime, UnityAction onClick) { }

	private AsyncOperationHandle<GameObject> CreateClickableIcon(PrefabReference prefab, DateTime endTime, UnityAction onClick) { }

	[AsyncStateMachine(typeof(<CreateCollectionIcon>d__27))]
	private Task CreateCollectionIcon() { }

	[AsyncStateMachine(typeof(<CreateCtIcon>d__24))]
	private Task CreateCtIcon() { }

	[AsyncStateMachine(typeof(<CreateEventIcons>d__18))]
	private Task CreateEventIcons() { }

	[AsyncStateMachine(typeof(<CreateMaintenanceIcon>d__20))]
	private Task CreateMaintenanceIcon() { }

	[AsyncStateMachine(typeof(<CreateOdysseyIcon>d__22))]
	private Task CreateOdysseyIcon() { }

	[AsyncStateMachine(typeof(<CreateRaceIcon>d__21))]
	private Task CreateRaceIcon() { }

	[AsyncStateMachine(typeof(<CreateSweepStakesIcon>d__26))]
	private Task CreateSweepStakesIcon() { }

	[AsyncStateMachine(typeof(<EnablePipAsync>d__30))]
	private void EnablePipAsync(ButtonWithPip ctBtn, Task<Boolean> canShowPipTask) { }

	private static LocalizationManager get_Locs() { }

	private static MainMenuPriority get_SortOrderSettings() { }

	private void OpenBossEventScreen() { }

	[AsyncStateMachine(typeof(<OpenBossEventScreenAsync>d__37))]
	private Task OpenBossEventScreenAsync() { }

	private void OpenCollectionEventScreen() { }

	[AsyncStateMachine(typeof(<OpenCTEventScreenAsync>d__42))]
	private Task OpenCTEventScreenAsync() { }

	private void OpenOdysseyEventScreen() { }

	public void OpenRaceEventScreen() { }

	[AsyncStateMachine(typeof(<OpenRaceEventScreenAsync>d__32))]
	private Task OpenRaceEventScreenAsync() { }

	private void OpenTeamEventScreen() { }

	public void Refresh() { }

	[AsyncStateMachine(typeof(<RunTasksByPriority>d__19))]
	private Task RunTasksByPriority(ValueTuple<Func`1<Task>, Int32>[] unsortedTasks) { }

	[AsyncStateMachine(typeof(<SweepStakesClickedAsync>d__34))]
	private void SweepStakesClickedAsync() { }

	[AsyncStateMachine(typeof(<SweepstakesEndedClickedAsync>d__35))]
	private void SweepstakesEndedClickedAsync() { }

	[AsyncStateMachine(typeof(<TeamEventPanelClicked>d__40))]
	private void TeamEventPanelClicked() { }

	private void Update() { }

}

