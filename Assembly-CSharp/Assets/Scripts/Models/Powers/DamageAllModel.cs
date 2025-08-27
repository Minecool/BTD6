namespace Assets.Scripts.Models.Powers;

[Implementation(typeof(DamageAll), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DamageAllModel : PowerBehaviorModel
{
	public float amount; //Field offset: 0x30

	public DamageAllModel(string name, float amount) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

