namespace Assets.Scripts.Unity.UI_New.Callouts.CalloutTypes.CalloutLinked;

public class CalloutPopCount : CalloutPairs
{

	public CalloutPopCount(float weightHigh, float weightLow, double highMinValue, double lowMinValue, double exclusionRange = -1, List<String> difficultiesAwardedIn = null) { }

	protected virtual double DataToGet(AnalyticsGameSessionInfo data) { }

}

