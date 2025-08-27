namespace Assets.Scripts.Models.Entities.Events.Triggers;

[Implementation(typeof(OnBossHealedTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OnBossHealedTriggerModel : EntityTriggerModel
{
	public String[] towerIds; //Field offset: 0x38

	public OnBossHealedTriggerModel(string name) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

