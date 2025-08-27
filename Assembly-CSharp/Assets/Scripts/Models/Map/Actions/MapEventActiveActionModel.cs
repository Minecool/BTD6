namespace Assets.Scripts.Models.Map.Actions;

[Implementation(typeof(MapEventActiveAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MapEventActiveActionModel : MapActionModel
{
	public bool setToActive; //Field offset: 0x38
	public string mapEventName; //Field offset: 0x40

	public MapEventActiveActionModel(string name, string mapEventName, bool setToActive) { }

}

