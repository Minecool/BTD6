namespace NinjaKiwi.LiNK.MatchMaking;

public class MatchMakingParameters
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<List`1<String>, Boolean> <>9__28_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__28_0(List<String> _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public string parameterName; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal bool <MustMatch>b__0(MatchMakingRule rule) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public string parameterName; //Field offset: 0x10

		public <>c__DisplayClass22_0() { }

		internal bool <MustNotMatch>b__0(MatchMakingRule rule) { }

	}

	internal class NotCompatibleException : Exception
	{

		public NotCompatibleException(string message) { }

	}

	[CompilerGenerated]
	private string <Bucket>k__BackingField; //Field offset: 0x10
	public TimeSpan expiresIn; //Field offset: 0x18
	public bool unique; //Field offset: 0x20
	public bool prettyName; //Field offset: 0x21
	public bool onMobileData; //Field offset: 0x22
	public readonly Dictionary<String, String> lobbyParameters; //Field offset: 0x28
	public int maxPlayers; //Field offset: 0x30
	public bool enforceCreatedMaxPlayers; //Field offset: 0x34
	public int maxAttempts; //Field offset: 0x38
	public TimeSpan retryDelay; //Field offset: 0x40
	public readonly List<String> searchBuckets; //Field offset: 0x48
	public Func<List`1<String>, Boolean> expandSearchBuckets; //Field offset: 0x50
	public readonly List<MatchMakingRule> searchRules; //Field offset: 0x58
	public readonly List<String> excludeLobbyIDs; //Field offset: 0x60
	public TimeSpan canBePurgedAfter; //Field offset: 0x68
	public bool alsoJoinMatchmakingGroup; //Field offset: 0x70

	public private string Bucket
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public MatchMakingParameters() { }

	public MatchMakingParameters AddSearchBuckets(IEnumerable<String> values) { }

	public MatchMakingParameters AddSearchBuckets(String[] values) { }

	protected override string CheckCompatible(LobbyModel lobbyModel) { }

	[CompilerGenerated]
	public string get_Bucket() { }

	public MatchMakingParameters MustMatch(string parameterName, String[] values) { }

	public MatchMakingParameters MustNotMatch(string parameterName, String[] values) { }

	[CompilerGenerated]
	private void set_Bucket(string value) { }

	public MatchMakingParameters SetBucket(string bucket) { }

	public MatchMakingParameters SetParameter(string parameterName, string value) { }

	public void ThrowIfNotCompatible(LobbyModel lobbyModel) { }

}

