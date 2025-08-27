namespace Assets.Scripts.Unity.UI_New.Popups;

public class RaceEndedPopup : LeaderboardEventEndPopup
{
	[CompilerGenerated]
	private struct <LoadResults>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public RaceEndedPopup <>4__this; //Field offset: 0x28
		public BaseServerEvent serverEvent; //Field offset: 0x30
		private RaceEvent <raceEvent>5__2; //Field offset: 0x38
		private Races <raceSku>5__3; //Field offset: 0x40
		private LeaderboardReward[] <rewards>5__4; //Field offset: 0x48
		private LeaderboardReward[] <rewardsMini>5__5; //Field offset: 0x50
		private bool <canClaimRewards>5__6; //Field offset: 0x58
		private TaskAwaiter <>u__1; //Field offset: 0x60
		private TaskAwaiter<LeaderboardReward[]> <>u__2; //Field offset: 0x68
		private TaskAwaiter<List`1<LeaderboardData>> <>u__3; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public RaceEndedPopup() { }

	[AsyncStateMachine(typeof(<LoadResults>d__0))]
	public virtual void LoadResults(BaseServerEvent serverEvent, bool isDebug) { }

}

