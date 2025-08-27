namespace Assets.Scripts.Models.Profile;

public class MapEventSaveData
{
	public int triggerCount; //Field offset: 0x10
	public Dictionary<String, MapEventTriggerSaveData> triggerSaveData; //Field offset: 0x18
	public Dictionary<String, MapEventActionSaveData> actionSaveData; //Field offset: 0x20

	public MapEventSaveData() { }

}

