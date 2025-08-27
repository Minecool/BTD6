namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(TriggerEventHooksAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TriggerEventHooksActionModel : EntityActionModel
{
	public String[] eventHookIds; //Field offset: 0x38
	public ToggleModdifier toggleEventHooks; //Field offset: 0x40

	public TriggerEventHooksActionModel(string name, String[] eventHookIds, ToggleModdifier toggleEventHooks) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

