namespace Assets.Scripts.Models.ServerEvents;

public class Races : EnableFlag
{
	[CompilerGenerated]
	private struct <GetAllRewards>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<LeaderboardReward[][]> <>t__builder; //Field offset: 0x8
		public Races <>4__this; //Field offset: 0x20
		public RaceEvent raceEvent; //Field offset: 0x28
		private LeaderboardReward[] <>7__wrap1; //Field offset: 0x30
		private TaskAwaiter<LeaderboardReward[]> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetRewards>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<LeaderboardReward[]> <>t__builder; //Field offset: 0x8
		public RaceEvent raceEvent; //Field offset: 0x20
		public bool forMiniRace; //Field offset: 0x28
		public Races <>4__this; //Field offset: 0x30
		private TaskAwaiter<Race> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Dictionary<String, LeaderboardReward[]> rewards; //Field offset: 0x18
	public Dictionary<String, LeaderboardReward[]> miniRewards; //Field offset: 0x20
	public RaceSettings settings; //Field offset: 0x28

	public Races() { }

	[AsyncStateMachine(typeof(<GetAllRewards>d__4))]
	public Task<LeaderboardReward[][]> GetAllRewards(RaceEvent raceEvent) { }

	[AsyncStateMachine(typeof(<GetRewards>d__3))]
	public Task<LeaderboardReward[]> GetRewards(RaceEvent raceEvent, bool forMiniRace) { }

}

