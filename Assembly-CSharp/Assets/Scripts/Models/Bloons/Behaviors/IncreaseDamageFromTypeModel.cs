namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(IncreaseDamageFromType), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class IncreaseDamageFromTypeModel : BloonBehaviorModel
{
	public float amount; //Field offset: 0x30
	public String[] damageTypes; //Field offset: 0x38
	public bool useOriginalType; //Field offset: 0x40

	public IncreaseDamageFromTypeModel(string name, float amount, String[] damageTypes, bool useOriginalType) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

