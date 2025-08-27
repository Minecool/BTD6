namespace Assets.Scripts.Models.Map.Actions;

[Implementation(typeof(PathActiveAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PathActiveActionModel : MapActionModel
{
	public bool setActiveToo; //Field offset: 0x38
	public string pathName; //Field offset: 0x40

	public PathActiveActionModel(string name, bool setActiveToo, string pathName) { }

}

