namespace Assets.Scripts.Models.Map.Actions;

[Implementation(typeof(SuspendTowersOnAreaAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SuspendTowersOnAreaActionModel : MapActionModel
{
	public string areaName; //Field offset: 0x38
	public bool isUnsuspendAction; //Field offset: 0x40

	public SuspendTowersOnAreaActionModel(string name, string areaName, bool isUnsuspendAction) { }

}

