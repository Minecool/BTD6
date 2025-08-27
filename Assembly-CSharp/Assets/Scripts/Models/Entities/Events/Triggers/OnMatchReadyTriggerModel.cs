namespace Assets.Scripts.Models.Entities.Events.Triggers;

[Implementation(typeof(OnMatchReadyTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OnMatchReadyTriggerModel : EntityTriggerModel
{
	public bool triggerOnLoadedSave; //Field offset: 0x38

	public OnMatchReadyTriggerModel(bool triggerOnLoadedSave = false) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

