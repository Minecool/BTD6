namespace NinjaKiwi.GUTS.Models.BCS;

[Nullable(0)]
[NullableContext(1)]
public class BossRewards
{
	[CompilerGenerated]
	private sealed class <>c
	{
		[Nullable(0)]
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(0)]
		public static Func<WalletLeaderboardReward, Int32> <>9__8_0; //Field offset: 0x8
		[Nullable(0)]
		public static Func<WalletLeaderboardReward, Single> <>9__8_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		[NullableContext(0)]
		internal int <GetSortedFinalRewards>b__8_0(WalletLeaderboardReward x) { }

		[NullableContext(0)]
		internal float <GetSortedFinalRewards>b__8_1(WalletLeaderboardReward x) { }

	}

	[CompilerGenerated]
	private sealed class <GetLeaderboardRewards>d__9 : IEnumerable<WalletRewardGroup>, IEnumerable, IEnumerator<WalletRewardGroup>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private WalletRewardGroup <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private int playerRank; //Field offset: 0x24
		public int <>3__playerRank; //Field offset: 0x28
		private int totalPlayers; //Field offset: 0x2C
		public int <>3__totalPlayers; //Field offset: 0x30
		[Nullable(0)]
		public BossRewards <>4__this; //Field offset: 0x38
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		private IEnumerator<WalletLeaderboardReward> <>7__wrap1; //Field offset: 0x40
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		private WalletRewardGroup[] <>7__wrap2; //Field offset: 0x48
		private int <>7__wrap3; //Field offset: 0x50

		private override WalletRewardGroup System.Collections.Generic.IEnumerator<NinjaKiwi.GUTS.Models.WalletRewardGroup>.Current
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
		public <GetLeaderboardRewards>d__9(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<WalletRewardGroup> System.Collections.Generic.IEnumerable<NinjaKiwi.GUTS.Models.WalletRewardGroup>.GetEnumerator() { }

		[DebuggerHidden]
		private override WalletRewardGroup System.Collections.Generic.IEnumerator<NinjaKiwi.GUTS.Models.WalletRewardGroup>.get_Current() { }

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
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1}])]
	private Dictionary<Int32, WalletRewardGroup[]> <StageIdRewards>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private WalletLeaderboardReward[] <FinalRewards>k__BackingField; //Field offset: 0x18

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public WalletLeaderboardReward[] FinalRewards
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1, 1}])]
	public Dictionary<Int32, WalletRewardGroup[]> StageIdRewards
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public BossRewards() { }

	[CompilerGenerated]
	public WalletLeaderboardReward[] get_FinalRewards() { }

	[CompilerGenerated]
	public Dictionary<Int32, WalletRewardGroup[]> get_StageIdRewards() { }

	[IteratorStateMachine(typeof(<GetLeaderboardRewards>d__9))]
	public IEnumerable<WalletRewardGroup> GetLeaderboardRewards(int playerRank, int totalPlayers) { }

	public IEnumerable<WalletLeaderboardReward> GetSortedFinalRewards() { }

	public static Dictionary<String, Dictionary`2<String, Int32>> ParseBossRewards(WalletRewardGroup[] bossRewards) { }

	[CompilerGenerated]
	public void set_FinalRewards(WalletLeaderboardReward[] value) { }

	[CompilerGenerated]
	public void set_StageIdRewards(Dictionary<Int32, WalletRewardGroup[]> value) { }

}

