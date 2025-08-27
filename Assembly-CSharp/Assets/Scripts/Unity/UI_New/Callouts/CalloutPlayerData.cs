namespace Assets.Scripts.Unity.UI_New.Callouts;

public class CalloutPlayerData
{
	public AnalyticsGameSessionInfo playerData; //Field offset: 0x10
	public CalloutData assignedCallout; //Field offset: 0x18
	public CalloutData assignedLowCallout; //Field offset: 0x20
	public List<CalloutData> callouts; //Field offset: 0x28
	public List<CalloutData> calloutsLow; //Field offset: 0x30

	public CalloutPlayerData() { }

}

