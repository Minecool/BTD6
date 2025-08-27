namespace Assets.Scripts.Unity.UI_New.Callouts;

public class CalloutData
{
	public PlayerCalloutTypes callout; //Field offset: 0x10
	public double data; //Field offset: 0x18
	public float weight; //Field offset: 0x20
	public bool isPairedCallout; //Field offset: 0x24
	public bool isHighPairedCallout; //Field offset: 0x25
	public PlayerCalloutTypes pairedCallout; //Field offset: 0x28

	public CalloutData() { }

}

