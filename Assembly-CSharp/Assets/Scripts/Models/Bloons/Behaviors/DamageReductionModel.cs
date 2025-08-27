namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(DamageReduction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DamageReductionModel : BloonBehaviorModel
{
	public float amount; //Field offset: 0x30

	public DamageReductionModel(string name, float amount) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

