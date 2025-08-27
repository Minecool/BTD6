namespace Assets.Scripts.Unity.Network;

public class Btd6MatchMakingParameters : MatchMakingParameters
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public BucketName value; //Field offset: 0x10
		public Btd6MatchMakingParameters <>4__this; //Field offset: 0x18

		public <>c__DisplayClass15_0() { }

		internal string <set_BucketName>b__0(string compatibleSpec) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_1
	{
		public Queue<String> compatibleBucketsQueue; //Field offset: 0x10
		public <>c__DisplayClass15_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass15_1() { }

		internal bool <set_BucketName>b__1(List<String> _) { }

	}

	public static int DefaultMaxPlayers; //Field offset: 0x0
	public const string kXr = "Xr"; //Field offset: 0x0
	private const string kClientVersion = "clientVersion"; //Field offset: 0x0
	private const string isPublicKey = "IsPublic"; //Field offset: 0x0
	private BucketName _bucket; //Field offset: 0x78

	public BucketName BucketName
	{
		 get { } //Length: 4
		 set { } //Length: 1173
	}

	public string FullBucketString
	{
		 get { } //Length: 5
	}

	private static Btd6MatchMakingParameters() { }

	public Btd6MatchMakingParameters(bool isFlagged) { }

	private static string AddBucketPrefix(string bucketType) { }

	private static string AddDeviceSpecSuffix(string bucketName, string deviceSpec) { }

	protected virtual string CheckCompatible(LobbyModel lobbyModel) { }

	private static string CheckLobbyCompatibility(JObject lobbyMetadata) { }

	public BucketName get_BucketName() { }

	public string get_FullBucketString() { }

	private static string GetDeviceSpec() { }

	private static string GetVersionBucket() { }

	public static bool IsCompatible(JObject lobbyMetadata) { }

	public static bool IsPublic(JObject lobbyMetadata) { }

	public void set_BucketName(BucketName value) { }

	public static Task SetPublic(Btd6Player player, string lobbyID, bool isPublic) { }

}

