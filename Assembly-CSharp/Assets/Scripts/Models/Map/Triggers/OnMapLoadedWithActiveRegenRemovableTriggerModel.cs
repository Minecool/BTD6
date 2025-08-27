namespace Assets.Scripts.Models.Map.Triggers;

[Implementation(typeof(OnMapLoadedWithActiveRegenRemovableTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OnMapLoadedWithActiveRegenRemovableTriggerModel : MapTriggerModel
{
	public bool applyActionsWhenInactiveOnLoad; //Field offset: 0x38

	public OnMapLoadedWithActiveRegenRemovableTriggerModel(string name, bool applyActionsWhenInactiveOnLoad) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

