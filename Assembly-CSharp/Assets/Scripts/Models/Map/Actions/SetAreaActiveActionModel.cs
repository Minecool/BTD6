namespace Assets.Scripts.Models.Map.Actions;

[Implementation(typeof(SetAreaActiveAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SetAreaActiveActionModel : MapActionModel
{
	public string areaName; //Field offset: 0x38
	public bool isActive; //Field offset: 0x40

	public SetAreaActiveActionModel(string name, string areaName, bool isActive) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

