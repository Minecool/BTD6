namespace Assets.Scripts.Unity.UI_New.Callouts.CalloutTypes;

public class CalloutType
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<PlayerData> <>9__9_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <AssignCalloutToPlayer>b__9_0(PlayerData a, PlayerData b) { }

	}

	protected float weight; //Field offset: 0x10
	protected double exclusionRange; //Field offset: 0x18
	protected double minThresholdValue; //Field offset: 0x20
	protected List<String> difficultiesAwardedIn; //Field offset: 0x28
	protected List<PlayerData> playersSortedData; //Field offset: 0x30
	protected PlayerCalloutTypes callout; //Field offset: 0x38

	protected PlayerData HighScoreData
	{
		 get { } //Length: 111
	}

	public CalloutType(float weight, double minThresholdValue, double exclusionRange = -1, List<String> difficultiesAwardedIn = null) { }

	public override bool AssignCalloutToPlayer(CalloutManager calloutManager) { }

	protected override double DataToGet(AnalyticsGameSessionInfo data) { }

	protected PlayerData get_HighScoreData() { }

	protected override PlayerCalloutTypes GetPairedCallout() { }

	public bool IsAvailable(string difficulty) { }

	protected bool IsHighScoreValid(PlayerData player) { }

	protected bool IsScoreUnique(PlayerData playerData) { }

	protected bool TestCheckMinThreshold(double value) { }

	protected bool TestExclusionRange() { }

}

