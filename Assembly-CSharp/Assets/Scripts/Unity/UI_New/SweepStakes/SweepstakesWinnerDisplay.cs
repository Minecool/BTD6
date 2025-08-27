namespace Assets.Scripts.Unity.UI_New.SweepStakes;

public class SweepstakesWinnerDisplay : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public SweepstakesWinnerDisplay <>4__this; //Field offset: 0x10
		public SweepstakesEventEndedScreen sweepstakesScreen; //Field offset: 0x18
		public Func<Task> <>9__1; //Field offset: 0x20

		public <>c__DisplayClass9_0() { }

		internal void <Init>b__0() { }

		internal Task <Init>b__1() { }

	}

	[CompilerGenerated]
	private struct <Bind>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SweepstakesWinnerDisplay <>4__this; //Field offset: 0x20
		public string playerId; //Field offset: 0x28
		public Task<Dictionary`2<String, String>> playerNamesTask; //Field offset: 0x30
		private TaskAwaiter<Btd6PlayerStats> <>u__1; //Field offset: 0x38
		private TaskAwaiter<String> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetPlayerName>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public Task<Dictionary`2<String, String>> playerNamesTask; //Field offset: 0x20
		public string playerId; //Field offset: 0x28
		private string <playerNameString>5__2; //Field offset: 0x30
		private TaskAwaiter<Dictionary`2<String, String>> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetPlayerStats>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Btd6PlayerStats> <>t__builder; //Field offset: 0x8
		public string playerId; //Field offset: 0x20
		private TaskAwaiter<Btd6PlayerStats> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Header("Winner Display Values")]
	[SerializeField]
	private Image playerBanner; //Field offset: 0x20
	[SerializeField]
	private Image playerIcon; //Field offset: 0x28
	[SerializeField]
	private NK_TextMeshProUGUI playerNameText; //Field offset: 0x30
	[SerializeField]
	private Button infoButton; //Field offset: 0x38
	[SerializeField]
	private GameObject loadingPlayerObj; //Field offset: 0x40
	[SerializeField]
	private GameObject playerDataObj; //Field offset: 0x48
	private string playerId; //Field offset: 0x50
	private bool canShowPlayerStats; //Field offset: 0x58

	public SweepstakesWinnerDisplay() { }

	private void Awake() { }

	[AsyncStateMachine(typeof(<Bind>d__10))]
	public Task Bind(string playerId, Task<Dictionary`2<String, String>> playerNamesTask) { }

	public void ButtonsInteractable(bool isInteractable) { }

	[AsyncStateMachine(typeof(<GetPlayerName>d__13))]
	private static Task<String> GetPlayerName(Task<Dictionary`2<String, String>> playerNamesTask, string playerId) { }

	[AsyncStateMachine(typeof(<GetPlayerStats>d__12))]
	private static Task<Btd6PlayerStats> GetPlayerStats(string playerId) { }

	public void Init(SweepstakesEventEndedScreen sweepstakesScreen) { }

}

