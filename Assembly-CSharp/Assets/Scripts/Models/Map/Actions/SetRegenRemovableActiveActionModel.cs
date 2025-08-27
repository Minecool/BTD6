namespace Assets.Scripts.Models.Map.Actions;

[Implementation(typeof(SetRegenRemovableActiveAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SetRegenRemovableActiveActionModel : MapActionModel
{
	public RegenRemovableModel regenRemovable; //Field offset: 0x38
	public bool isActive; //Field offset: 0x40

	public SetRegenRemovableActiveActionModel(string name, RegenRemovableModel regenRemovable, bool isActive) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

