namespace Assets.Scripts.Models.ServerEvents;

public class DailyChallenges
{
	[CompilerGenerated]
	private struct <GetChallengeFromRotation>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<DailyChallengeModel> <>t__builder; //Field offset: 0x8
		public ChallengeType challengeType; //Field offset: 0x20
		public DateTime challengeDate; //Field offset: 0x28
		private ChallengeFileInfo <challengeFileInfo>5__2; //Field offset: 0x30
		private TaskAwaiter<DailyChallengeModel> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetChallengeWithId>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<DailyChallengeModel> <>t__builder; //Field offset: 0x8
		public ChallengeType challengeType; //Field offset: 0x20
		public string dataId; //Field offset: 0x28
		private TaskAwaiter<DailyChallengeModel> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetDailyChallenge>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<DailyChallengeModel> <>t__builder; //Field offset: 0x8
		public string specificId; //Field offset: 0x20
		public ChallengeType challengeType; //Field offset: 0x28
		public DateTime startDate; //Field offset: 0x30
		public DateTime endDate; //Field offset: 0x38
		private DailyChallengeModel <challenge>5__2; //Field offset: 0x40
		private TaskAwaiter<DailyChallengeModel> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal struct ChallengeFileInfo
	{
		public string dataFolder; //Field offset: 0x0
		public int fileName; //Field offset: 0x8

	}

	internal class IdRotationCache
	{
		private int firstId; //Field offset: 0x10
		private int lastId; //Field offset: 0x14
		private Int32[] excludedIds; //Field offset: 0x18
		[CompilerGenerated]
		private List<Int32> <ValidIds>k__BackingField; //Field offset: 0x20

		public private List<Int32> ValidIds
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 5
		}

		public IdRotationCache() { }

		[CompilerGenerated]
		public List<Int32> get_ValidIds() { }

		public bool IsExpired(RotationInfo rotationInfo) { }

		[CompilerGenerated]
		private void set_ValidIds(List<Int32> value) { }

		public void Update(RotationInfo rotationInfo, List<Int32> validIds) { }

	}

	internal class LoopInfo
	{
		public bool isEnabled; //Field offset: 0x10
		public int lastId; //Field offset: 0x14
		public Int32[] excludedIds; //Field offset: 0x18

		public LoopInfo() { }

	}

	internal class RotationInfo
	{
		[JsonConverter(typeof(StringDateConverter))]
		[JsonProperty("firstDate")]
		public DateTime firstDate; //Field offset: 0x10
		public LoopInfo looping; //Field offset: 0x18
		public int firstId; //Field offset: 0x20

		public RotationInfo() { }

	}

	public const string IdPrefixRegular = "rot"; //Field offset: 0x0
	public const string IdPrefixAdvanced = "adv"; //Field offset: 0x0
	private static readonly IdRotationCache idRotationCache; //Field offset: 0x0
	private static readonly IdRotationCache idRotationCacheAdvanced; //Field offset: 0x8
	public RotationInfo standard; //Field offset: 0x10
	public RotationInfo advanced; //Field offset: 0x18
	public int availableOffline; //Field offset: 0x20

	private static DailyChallenges() { }

	public DailyChallenges() { }

	public static ChallengeFileInfo GetChallengeFileInfo(ChallengeType challengeType, DateTime challengeDate) { }

	[AsyncStateMachine(typeof(<GetChallengeFromRotation>d__11))]
	private static Task<DailyChallengeModel> GetChallengeFromRotation(ChallengeType challengeType, DateTime challengeDate) { }

	public static DateTime GetChallengeStartDate(ChallengeType challengeType, string challengeId) { }

	[AsyncStateMachine(typeof(<GetChallengeWithId>d__9))]
	private static Task<DailyChallengeModel> GetChallengeWithId(ChallengeType challengeType, string dataId) { }

	[AsyncStateMachine(typeof(<GetDailyChallenge>d__5))]
	public Task<DailyChallengeModel> GetDailyChallenge(ChallengeType challengeType, string specificId = null, DateTime startDate = null, DateTime endDate = null) { }

	private static string GetDataFolder(ChallengeType challengeType) { }

	public static string GetDataId(string dcId) { }

	private static int GetIdFromRotation(IdRotationCache idRotationCache, RotationInfo rotationInfo, int daysSinceFirstChallenge) { }

	private static IdRotationCache GetIdRotationCache(ChallengeType challengeType) { }

	private static List<Int32> GetIdsFromRotation(RotationInfo rotationInfo) { }

	private RotationInfo GetRotationInfo(ChallengeType challengeType) { }

	private static RotationInfo GetRotationInfoStatic(ChallengeType challengeType) { }

}

