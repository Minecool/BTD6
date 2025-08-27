namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(DestroyTowersAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DestroyTowersActionModel : EntityActionModel
{
	public float range; //Field offset: 0x38
	public string towerId; //Field offset: 0x40
	public bool triggerEffect; //Field offset: 0x48
	public EffectModel effectOnTrigger; //Field offset: 0x50

	public DestroyTowersActionModel(string name, float range, string towerId, bool triggerEffect, EffectModel effectOnTrigger) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

