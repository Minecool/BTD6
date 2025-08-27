namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(HealthPercentTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class HealthPercentTriggerModel : BloonBehaviorTriggerModel
{
	public bool repeatFirst; //Field offset: 0x30
	public bool preventFallthrough; //Field offset: 0x31
	public Single[] percentageValues; //Field offset: 0x38
	public String[] actionIds; //Field offset: 0x40

	public HealthPercentTriggerModel(string name) { }

	public HealthPercentTriggerModel(string name, bool repeatFirst, Single[] percentageValues, String[] actionIds, bool preventFallthrough) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

