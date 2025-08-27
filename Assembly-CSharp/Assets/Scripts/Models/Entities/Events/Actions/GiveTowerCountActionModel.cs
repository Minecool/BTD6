namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(GiveTowerCountAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class GiveTowerCountActionModel : EntityActionModel
{
	public int amount; //Field offset: 0x38
	public string towerId; //Field offset: 0x40

	public GiveTowerCountActionModel(string name, int amount, string towerId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

