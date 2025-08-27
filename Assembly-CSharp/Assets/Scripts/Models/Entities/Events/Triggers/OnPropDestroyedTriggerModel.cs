namespace Assets.Scripts.Models.Entities.Events.Triggers;

[Implementation(typeof(OnPropDestroyedTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OnPropDestroyedTriggerModel : EntityTriggerModel
{
	public String[] propIds; //Field offset: 0x38

	public OnPropDestroyedTriggerModel(string name, String[] propIds) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

