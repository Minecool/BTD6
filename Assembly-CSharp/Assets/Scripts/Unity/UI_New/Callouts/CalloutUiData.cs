namespace Assets.Scripts.Unity.UI_New.Callouts;

public class CalloutUiData : MonoBehaviour
{
	public Sprite sprite; //Field offset: 0x20
	public string headerLoc; //Field offset: 0x28
	public string subTextLoc; //Field offset: 0x30
	public PlayerCalloutTypes calloutId; //Field offset: 0x38

	public CalloutUiData() { }

}

