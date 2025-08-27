namespace Assets.Scripts.Models.Entities.Events.Triggers;

[Implementation(typeof(OnPowerActivatedTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OnPowerActivatedTriggerModel : EntityTriggerModel
{
	public String[] powerIds; //Field offset: 0x38

	public OnPowerActivatedTriggerModel(string name, String[] powerIds) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

