namespace Assets.Scripts.Utils.Leaderboards;

public struct LeaderboardScoreData : IComparable<LeaderboardScoreData>
{
	public const ScoreComponent kRaceComponents = 5; //Field offset: 0x0
	public const ScoreComponent kBossTimeComponents = 69; //Field offset: 0x0
	public const ScoreComponent kBossTiersComponents = 90; //Field offset: 0x0
	public const ScoreComponent kBossCashComponents = 104; //Field offset: 0x0
	public static readonly ScoreComponent[] AllScoreComponents; //Field offset: 0x0
	private const byte kMaxBitOffset = 53; //Field offset: 0x0
	private static readonly ulong kMaxBossTierValue; //Field offset: 0x8
	private readonly ScoreComponent componentMask; //Field offset: 0x0
	private ulong rawScore; //Field offset: 0x8

	private static LeaderboardScoreData() { }

	public LeaderboardScoreData(ScoreComponent componentMask) { }

	public LeaderboardScoreData(ScoreComponent componentMask, long rawScore) { }

	public override int CompareTo(LeaderboardScoreData other) { }

	public bool Equals(LeaderboardScoreData other) { }

	public virtual bool Equals(object obj) { }

	[IsReadOnly]
	private byte GetComponentBitShift(ScoreComponent scoreComponent) { }

	public virtual int GetHashCode() { }

	[IsReadOnly]
	public ulong GetScore(ScoreComponent scoreComponent) { }

	[IsReadOnly]
	public TimeSpan GetTimeScore(ScoreComponent scoreComponent) { }

	public static bool op_Equality(LeaderboardScoreData l, LeaderboardScoreData r) { }

	public static bool op_GreaterThan(LeaderboardScoreData l, LeaderboardScoreData r) { }

	public static ulong op_Implicit(LeaderboardScoreData d) { }

	public static long op_Implicit(LeaderboardScoreData d) { }

	public static bool op_Inequality(LeaderboardScoreData l, LeaderboardScoreData r) { }

	public static bool op_LessThan(LeaderboardScoreData l, LeaderboardScoreData r) { }

	public void SetScore(ScoreComponent scoreComponent, uint score) { }

	public void SetScore(ScoreComponent scoreComponent, ulong score) { }

	public void SetScore(ScoreComponent scoreComponent, int score) { }

	public void SetTimeScore(ScoreComponent scoreComponent, TimeSpan time) { }

	private static void ThrowIfIncompatible(ScoreComponent componentMask) { }

}

