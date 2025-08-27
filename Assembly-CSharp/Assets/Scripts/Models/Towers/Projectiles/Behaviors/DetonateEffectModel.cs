namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(DetonateEffect), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DetonateEffectModel : ProjectileBehaviorModel
{
	public string effectMutationIds; //Field offset: 0x38
	public float damagePerSecondRemaining; //Field offset: 0x40

	public DetonateEffectModel(string name, string tags, float damagePerSecondRemaining) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

