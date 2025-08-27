namespace Assets.Scripts.Unity.UI_New.Callouts.CalloutTypes.CalloutNeutral;

internal class CalloutDdtDestroyer : CalloutType
{

	public CalloutDdtDestroyer(float weight, double minValue, double exclusionRange = -1, List<String> difficultiesAwardedIn = null) { }

	protected virtual double DataToGet(AnalyticsGameSessionInfo data) { }

}

