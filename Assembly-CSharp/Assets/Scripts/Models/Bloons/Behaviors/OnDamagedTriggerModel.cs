namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(OnDamagedTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OnDamagedTriggerModel : BloonBehaviorTriggerModel
{
	public String[] actionIds; //Field offset: 0x30
	public float cooldown; //Field offset: 0x38
	public float chance; //Field offset: 0x3C

	public OnDamagedTriggerModel(string name, String[] actionIds, float cooldown, float chance) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

