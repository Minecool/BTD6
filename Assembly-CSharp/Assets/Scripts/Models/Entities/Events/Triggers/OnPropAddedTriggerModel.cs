namespace Assets.Scripts.Models.Entities.Events.Triggers;

[Implementation(typeof(OnPropAddedTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OnPropAddedTriggerModel : EntityTriggerModel
{
	public String[] propIds; //Field offset: 0x38

	public OnPropAddedTriggerModel(string name, String[] propIds) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

