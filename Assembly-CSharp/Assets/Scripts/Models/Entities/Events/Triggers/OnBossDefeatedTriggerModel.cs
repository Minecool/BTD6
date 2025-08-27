namespace Assets.Scripts.Models.Entities.Events.Triggers;

[Implementation(typeof(OnBossDefeatedTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OnBossDefeatedTriggerModel : EntityTriggerModel
{
	public int tier; //Field offset: 0x38

	public OnBossDefeatedTriggerModel(string name, int tier) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

