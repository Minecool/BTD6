namespace Assets.Scripts.Unity.UI_New.Callouts.CalloutTypes.CalloutNeutral;

public class CalloutFumigator : CalloutType
{

	public CalloutFumigator(float weight, double minValue, double exclusionRange = -1, List<String> difficultiesAwardedIn = null) { }

	protected virtual double DataToGet(AnalyticsGameSessionInfo data) { }

}

