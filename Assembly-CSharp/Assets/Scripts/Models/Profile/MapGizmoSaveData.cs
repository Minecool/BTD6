namespace Assets.Scripts.Models.Profile;

public class MapGizmoSaveData
{
	public string name; //Field offset: 0x10
	public List<MapGizmoBehaviorSaveData> data; //Field offset: 0x18

	public MapGizmoSaveData(string name, List<MapGizmoBehaviorSaveData> data) { }

}

