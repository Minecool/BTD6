namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(BigSqueezeFortifiedEffect), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BigSqueezeFortifiedEffectModel : ProjectileBehaviorModel
{
	public bool randomRotation; //Field offset: 0x38
	public EffectModel effectModel; //Field offset: 0x40

	public BigSqueezeFortifiedEffectModel(string name, bool randomRotation, EffectModel effectModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

