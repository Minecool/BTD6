namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(WinGameAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class WinGameActionModel : EntityActionModel
{
	public float amount; //Field offset: 0x38

	public WinGameActionModel(string name, float amount) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

