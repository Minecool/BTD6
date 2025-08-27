namespace Assets.Scripts.Unity.UI_New.Callouts.CalloutTypes;

public class CalloutPairs : CalloutType
{
	protected float weightCalloutLow; //Field offset: 0x40
	protected double lowMinValue; //Field offset: 0x48
	protected PlayerCalloutTypes calloutLow; //Field offset: 0x50

	private PlayerData LowScoreData
	{
		private get { } //Length: 131
	}

	public CalloutPairs(float weightCalloutHigh, float weightCalloutLow, double highMinValue, double lowMinValue, double exclusionRange = -1, List<String> difficultiesAwardedIn = null) { }

	public virtual bool AssignCalloutToPlayer(CalloutManager calloutManger) { }

	private PlayerData get_LowScoreData() { }

	protected virtual PlayerCalloutTypes GetPairedCallout() { }

	private bool TestCanAssignLowCallout() { }

}

