namespace Assets.Scripts.Models.Map.Actions;

[Implementation(typeof(RemovableActiveAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RemovableActiveActionModel : MapActionModel
{
	public bool setActiveToo; //Field offset: 0x38
	public string removeableName; //Field offset: 0x40

	public RemovableActiveActionModel(string name, bool setActiveToo, string removeableName) { }

}

