namespace Assets.Scripts.Unity.Map.Triggers;

public class MapEvent : MonoBehaviour
{
	public bool oneTimeEvent; //Field offset: 0x20
	public bool allTriggersRequired; //Field offset: 0x21
	public bool inactiveByDefault; //Field offset: 0x22
	public bool trackArrowsOnTrigger; //Field offset: 0x23
	public float trackArrowDistanceOverride; //Field offset: 0x24
	public int trackArrowAmountOverride; //Field offset: 0x28
	public List<MapTrigger> triggers; //Field offset: 0x30
	public List<MapAction> actions; //Field offset: 0x38
	public List<MapUnityAction> unityActions; //Field offset: 0x40
	private MapEventModel def; //Field offset: 0x48

	public MapEventModel Def
	{
		 get { } //Length: 539
	}

	public MapEvent() { }

	public MapEventModel get_Def() { }

}

