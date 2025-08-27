namespace Assets.Scripts.Unity.UI_New.Callouts;

public class CalloutManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<CalloutData> <>9__6_0; //Field offset: 0x8
		public static Comparison<CalloutData> <>9__6_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <.ctor>b__6_0(CalloutData a, CalloutData b) { }

		internal int <.ctor>b__6_1(CalloutData a, CalloutData b) { }

	}

	private const int CHANCE_TO_ASSIGN_LOW_CALLOUT = 50; //Field offset: 0x0
	private readonly List<CalloutType> listCalloutTypes; //Field offset: 0x10
	private readonly List<CalloutType> singlePlayerCalloutTypes; //Field offset: 0x18
	private readonly Btd6CoopGame coopGame; //Field offset: 0x20
	private Dictionary<Int32, CalloutPlayerData> playerCallouts; //Field offset: 0x28
	private Random seededRandom; //Field offset: 0x30

	public CalloutManager(Btd6CoopGame coopGame = null) { }

	public void AddPlayerCalloutData(CalloutData data, PlayerData player) { }

	private List<CalloutType> GetAvailableCallouts() { }

	private List<CalloutType> GetAvailableSinglePlayerCallouts() { }

	public CalloutData GetCalloutForPlayer(int playerId) { }

	public Dictionary<Int32, AnalyticsGameSessionInfo> GetPlayersAnalyticsData() { }

	private int NextRandom(CalloutPlayerData playerData) { }

	private void TryAssignLowCallouts() { }

}

